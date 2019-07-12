using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vector3D;

namespace Bras_arduino
{
    public partial class Form1 : Form
    {

        // ------------------------- Varaibles Globales de notre programme ------------------------- 
        bool[] moteur_a_leur_place = new bool[4];                                                               //Permet de savoir si les moteurs sont aux bons endroit ou non
        Vector vector_consigne = new Vector();                                                                  //ce vecteur corespond à la consigne actuel de l'arduino
        bool en_mouvement = false;
        //---------------------------Gestion file d'attente--------------------------------------
        //variables
        const int longueur = 1000;
        int next_position = 0;
        int last_position = 0;
        double[,] tableau = new double[longueur, 3];
        //Fonctions
        public void ajout_ligne_vecteur(Vector vecteur)
        {
            tableau[last_position, 0] = vecteur.X;
            tableau[last_position, 1] = vecteur.Y;
            tableau[last_position, 2] = vecteur.Z;
            last_position++;
            if (last_position >= longueur) last_position = 0;
            if (!en_mouvement) etape_suivante();
        }
        public void ajout_ligne_xyz(double x, double y, double z)
        {
            tableau[last_position, 0] = x;
            tableau[last_position, 1] = y;
            tableau[last_position, 2] = z;
            last_position++;
            if (last_position >= longueur) last_position = 0;
            if (!en_mouvement) etape_suivante();
        }
        public void etape_suivante()
        {
            System.Diagnostics.Debug.Print("etape suivante "+ next_position.ToString() + "      " + last_position.ToString());
            if (next_position != last_position)
            {
                Vector consigne = new Vector
                {
                    X = tableau[next_position, 0],
                    Y = tableau[next_position, 1],
                    Z = tableau[next_position, 2]
                };
                compute_position(true, consigne);
                next_position++;
                if (next_position >= longueur) next_position = 0;
            }
            
        }



        // ------------------------- Focntions d'initialisation -------------------------
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Au debut tous les moteurs sont a leur place
            for (int i = 0; i < 4; i++) moteur_a_leur_place[i] = true;
            
            vector_consigne.X = (double)pos_x.Value;
            vector_consigne.Y = (double)pos_y.Value;
            vector_consigne.Z = (double)pos_z.Value;
        }


        // ------------------------- Fonctions Apellées par le formulaire / l'arduino ---------------------------
        //Fonctions communication avec l'arduino
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            arduino.PortName = textBox1.Text;
        }                                         //Simple mis a jour du port série si celui-ci est changé dans le formulaire
        private void tampon_button_Click(object sender, EventArgs e)
        {
            send_message(10, (int)valeur_tampon.Value);
        }                                          //Fonction qui prévient que les n données qui vont suivre doivent etre traitée ensemble
        private void Conexion_Click(object sender, EventArgs e)
        {
            try
            {
                arduino.Open();
                arduino.ReadExisting();
                Statut.Text = "Statu : Connécté";
            }
            catch
            {
                Statut.Text = "Statu : Echec conexion port " + arduino.PortName.ToString();
            }
        }                                               //Fonction qui essai d'ouvrir le port série sur le port indiqué        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            send_message(10, 3);
            send_message(0, 180);
            send_message(1, 220);
            send_message(2, 90);
            if (arduino.IsOpen) arduino.Close();
        }                                   //Fonction qui se lance a la fermeture du formulaire       
        private void arduino_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string data_received = arduino.ReadLine();
            //int nombre = 0; 
            /*try
            {*/
                int nombre = Convert.ToInt32(data_received);
                int indice = nombre & 15;
                nombre = (nombre - indice) >> 4;
            //arduino_input.Invoke((MethodInvoker)delegate { arduino_input.AppendText(Convert.ToString(nombre)+"\r\n"); });
            System.Diagnostics.Debug.WriteLine("ID : " + indice.ToString() + " Valeur : " + nombre.ToString() + "\r\n");
                //On traite la consigne de l'arduino
                if (indice == 0)
                {
                if (nombre == 0)
                    textBox_position_moteur0.Invoke((MethodInvoker)delegate { textBox_position_moteur0.BackColor = System.Drawing.Color.Green; });
                    else if (nombre == 1)
                        textBox_position_moteur1.Invoke((MethodInvoker)delegate { textBox_position_moteur1.BackColor = System.Drawing.Color.Green; });
                else if (nombre == 2)
                        textBox_position_moteur2.Invoke((MethodInvoker)delegate { textBox_position_moteur2.BackColor = System.Drawing.Color.Green; });
                
                else if (nombre == 3)
                        textBox_position_moteur3.Invoke((MethodInvoker)delegate { textBox_position_moteur3.BackColor = System.Drawing.Color.Green; });
                }

          /*  }
            catch
            {

            }*/

        }       //Fonction qui traite les données recu
        private void Label_moteurs_Click(object sender, EventArgs e)
        {
            if (textBox_auto_update.BackColor == System.Drawing.Color.Green)
                textBox_auto_update.BackColor = System.Drawing.Color.Red;
            else
                textBox_auto_update.BackColor = System.Drawing.Color.Green;
        }

        //Ces 4 fonctions sont apellées par un chagement de valeur des "numériques up down" consigne moteur
        private void haut_bas0_ValueChanged(object sender, EventArgs e)
        {
            if(textBox_auto_update.BackColor == System.Drawing.Color.Green)
                send_message(0, (int)haut_bas0.Value);
            textBox_position_moteur0.BackColor = System.Drawing.Color.Red;
        }
        private void haut_bas1_ValueChanged(object sender, EventArgs e)
        {
            if (textBox_auto_update.BackColor == System.Drawing.Color.Green)
                send_message(1, (int)haut_bas1.Value);
            textBox_position_moteur1.BackColor = System.Drawing.Color.Red;
        }
        private void haut_bas2_ValueChanged(object sender, EventArgs e)
        {
            if (textBox_auto_update.BackColor == System.Drawing.Color.Green)
                send_message(2, (int)haut_bas2.Value);
            textBox_position_moteur2.BackColor = System.Drawing.Color.Red;

        }
        private void haut_bas3_ValueChanged(object sender, EventArgs e)
        {
            if (textBox_auto_update.BackColor == System.Drawing.Color.Green)
                send_message(3, (int)haut_bas3.Value);
            textBox_position_moteur3.BackColor = System.Drawing.Color.Red;

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }             
        //Je sais pas pk t'es la toi
        //Ces 3 fonctions sont apellées lors d'un chagement de consigne et mettent à jour le vecteur consigne
        private void pos_x_ValueChanged(object sender, EventArgs e)
        {
            vector_consigne.X = (double)pos_x.Value;
        }
        private void pos_y_ValueChanged(object sender, EventArgs e)
        {
            vector_consigne.Y = (double)pos_y.Value;
        }
        private void pos_z_ValueChanged(object sender, EventArgs e)
        {
            vector_consigne.Z = (double)pos_z.Value;
        }
        private void Update_button_Click(object sender, EventArgs e)
        {
            ajout_ligne_vecteur(vector_consigne);
        }


        // ------------------------- Fonctions autres -------------------------
        private void label1_Click(object sender, EventArgs e)
        {
            //Je crois elle sert a rien masibon 

        } 
        private void Set_vitesse_max_Click(object sender, EventArgs e)
        {
            send_message(12, (int)Numeric_up_down_vmax0.Value);
            send_message(13, (int)Numeric_up_down_vmax1.Value);
            send_message(14, (int)Numeric_up_down_vmax2.Value);
            send_message(15, (int)Numeric_up_down_vmax3.Value);
        }
        void compute_position(bool envoyer, Vector consigne)
        {

            double produit_scalaire = 1 * consigne.X;
            double produit_normes = 1 * Math.Sqrt(Math.Pow(consigne.Y, 2) + Math.Pow(consigne.X, 2));
            double cosinus = 0;

            const double distance1 = 16;
            const double distance2 = 16.7; // 11.65;
            double distance3 = Vector.VectorNorm(consigne);
            double alpha = Math.Asin(consigne.Z / distance3);
            double beta = Math.Acos((Math.Pow(distance3, 2) + Math.Pow(distance1, 2) - Math.Pow(distance2, 2)) / (2 * distance3 * distance1));
            double theta1 = beta + alpha;
            double theta2 = Math.Acos((Math.Pow(distance2, 2) + Math.Pow(distance1, 2) - Math.Pow(distance3, 2)) / (2 * distance2 * distance1));
            theta1 *= 180 / Math.PI;
            theta2 *= 180 / Math.PI;


            if (distance3 < distance1 + distance2)
            {
                cosinus = produit_scalaire / produit_normes;
                //Calcul du determinant avec det = xy' - yx'
                if (produit_normes != 0) haut_bas0.Value = (int)(Math.Acos(cosinus) * 180 / Math.PI) * Math.Sign(consigne.Y) + 180;
                info.Text = "Distance 1 : " + distance1.ToString() + "\r\n" + "Distance 2 : " + distance2.ToString() + "\r\n" + "Distance 3 : " + distance3.ToString()
                    + "\r\n" + "Alpha : " + alpha.ToString() + "\r\n" + "Beta : " + beta.ToString();
                if (theta1 + 90 < (double)haut_bas1.Minimum) theta1 = (double)haut_bas1.Minimum-90;
                if (theta2  < (double)haut_bas2.Minimum) theta2 = (double)haut_bas2.Minimum;
                haut_bas1.Value = (int)theta1 + 90;
                haut_bas2.Value = (int)theta2;

                
                if (envoyer)
                {

                    send_message(10, (int)valeur_tampon.Value);
                    send_message(0, (int)haut_bas0.Value);
                    send_message(1, (int)haut_bas1.Value);
                    send_message(2, (int)haut_bas2.Value);
                }
                

            }
        }
        private void button_home_Click(object sender, EventArgs e)
        {
            send_message(10, 3);
            send_message(0, 180);
            send_message(1, 220);
            send_message(2, 90);
        }                   //Return Position de démarage

        // ------------------------- Foontions Autres -------------------------------------------
        //Fonctions communication arduino
        void send_message(int id, int valeur)
        {
            valeur = valeur << 4;
            valeur += id;
            if (arduino.IsOpen) arduino.Write(valeur.ToString() + "\n");
        }//Fonction qui code les donnée pour l'arduino 
        //Focntions déplacement


        //Fonctions dessins
        private void line(Vector debut, Vector fin)
        {
            double distance_enter_deux_points = 0.3;
            Vector line = Vector.VectorDiff(fin, debut);
            double norme = Vector.VectorNorm(line);
            int iteration = (int)Math.Ceiling(norme / distance_enter_deux_points);
            Vector vector_increment = Vector.VectorDiv(line, iteration);
            for( int i = 0; i < iteration; i++)
            {
                ajout_ligne_vecteur(Vector.VectorAdd(debut, Vector.VectorMul(i, vector_increment)));;
            }
            


        }
        private void draw_rectangle(int largeur, int hauteur)
        {
            //Première étape On baisse la vitesse des moteurs pour poasser en "mode dessin"
            send_message(12, 300);
            send_message(13, 600);
            send_message(14, 200);

            //On se relève un peu et on va aux bonne endroit pour démarer 
            pos_z.Value += 3;
            int mini_x = (int)pos_x.Value - (int)largeur / 2;
            int mini_y = (int)pos_y.Value - (int)hauteur / 2;

        }


        private void Back_color_changed(object sender, EventArgs e)
        {
            if (textBox_position_moteur0.BackColor == System.Drawing.Color.Red || textBox_position_moteur1.BackColor == System.Drawing.Color.Red || textBox_position_moteur2.BackColor == System.Drawing.Color.Red) en_mouvement = true;
            else en_mouvement = false;
            arduino_input.Invoke((MethodInvoker)delegate { arduino_input.AppendText(en_mouvement.ToString() + "\r\n"); });
            System.Diagnostics.Debug.Print("Etape suivante" + en_mouvement.ToString());
            if (en_mouvement == false) etape_suivante();


                
        }

        private void button_trace_ligne_Click(object sender, EventArgs e)
        {
            Vector debut = new Vector
            {
                X = (double)numericUpDown1.Value,
                Y = (double)numericUpDown2.Value,
                Z = (double)numericUpDown3.Value
            };
            Vector fin = new Vector
            {
                X = (double)numericUpDown4.Value,
                Y = (double)numericUpDown5.Value,
                Z = (double)numericUpDown6.Value
            };
            line(debut, fin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Print(en_mouvement.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            foreach (var nb in tableau)
                System.Diagnostics.Debug.Print(nb.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Print(next_position.ToString() + "      "+ last_position.ToString());
        }

        private void info_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
