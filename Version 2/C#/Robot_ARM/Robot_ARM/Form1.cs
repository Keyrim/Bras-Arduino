using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot_ARM
{
    public partial class Form1 : Form
    {
        //Orders for the motors 
        List<NumericUpDown> numericUpDowns_stepper_order = new List<NumericUpDown>();
        //Set the max speed for the motors
        List<NumericUpDown> numericUpDowns_stepper_max_speed = new List<NumericUpDown>();
        //Reduction ratio to convert degrees in steps acording to the axe 
        List<float> degrees_to_steps = new List<float>();
        
        public Form1()
        {
            InitializeComponent();
            button_open_port.BackColor = Color.Orange;
            //Stepper order initalisation 
            for (int i =0; i < 4; i ++)
            {
                numericUpDowns_stepper_order.Add(new NumericUpDown());
                this.Controls.Add(numericUpDowns_stepper_order[i]);
                numericUpDowns_stepper_order[i].Value = 90;
                numericUpDowns_stepper_order[i].Minimum = 0;
                numericUpDowns_stepper_order[i].Maximum = 380;
                numericUpDowns_stepper_order[i].Width = 45;
                numericUpDowns_stepper_order[i].Location = new Point(15, 50 + 20 * i);
                numericUpDowns_stepper_order[i].ValueChanged += NumericUpDown_order_value_changed;

            }

            //Stepper max speed initialisation, we also initialize the degrees_to_step values
            for (int i = 0; i < 4; i++)
            {
                degrees_to_steps.Add(new float());
                numericUpDowns_stepper_max_speed.Add(new NumericUpDown());
                numericUpDowns_stepper_max_speed[i].Value = 90;
                numericUpDowns_stepper_max_speed[i].Maximum = 120;
                numericUpDowns_stepper_max_speed[i].Minimum = 1;
                numericUpDowns_stepper_max_speed[i].Width = 45;
                numericUpDowns_stepper_max_speed[i].Location = new Point(15, 150 + 20 * i);
                numericUpDowns_stepper_max_speed[i].ValueChanged += NumericUpDown_max_speed_value_changed;
                this.Controls.Add(numericUpDowns_stepper_max_speed[i]);

            }
            degrees_to_steps[0] = 9.259259f;
            degrees_to_steps[1] = 17.7777f;
            degrees_to_steps[2] = 17.7777f;
            degrees_to_steps[3] = 1f;


        }

        private void NumericUpDown_max_speed_value_changed(object sender, EventArgs e)
        {
            for(int i = 0; i < 4; i++)
            {
                double value = (double)numericUpDowns_stepper_max_speed[i].Value * degrees_to_steps[i];

                Send_data(4 + i, (int)(1000000/value));
            }
        }

        private void NumericUpDown_order_value_changed(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i ++)
            {
                int value = (int)((double)numericUpDowns_stepper_order[i].Value * (double)degrees_to_steps[i]);
                Send_data(i, value);
            }
        }

        bool Start_comunication()
        {
            try
            {
                arduino_mega.Open();
                return true;
            }
            catch
            {
                return false;
            }
                
        }

        private void Button_open_port_Click(object sender, EventArgs e)
        {
            if (Start_comunication()) button_open_port.BackColor = Color.LightGreen;
            else button_open_port.BackColor = Color.Red;
        }

        bool Send_data(int indice, int data)
        {
            if (arduino_mega.IsOpen)
            {
                data = data << 4;
                data += indice;
                arduino_mega.WriteLine(data.ToString());
                return true;
            }
            else return false;
        }

    }
}
