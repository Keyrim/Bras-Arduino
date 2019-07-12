namespace Bras_arduino
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Conexion = new System.Windows.Forms.Button();
            this.Statut = new System.Windows.Forms.Label();
            this.arduino = new System.IO.Ports.SerialPort(this.components);
            this.state_stepper1 = new System.Windows.Forms.Label();
            this.input_data_label = new System.Windows.Forms.Label();
            this.state_stepper0 = new System.Windows.Forms.Label();
            this.haut_bas0 = new System.Windows.Forms.NumericUpDown();
            this.haut_bas1 = new System.Windows.Forms.NumericUpDown();
            this.haut_bas3 = new System.Windows.Forms.NumericUpDown();
            this.haut_bas2 = new System.Windows.Forms.NumericUpDown();
            this.test_moteur0 = new System.Windows.Forms.TextBox();
            this.text_moteur1 = new System.Windows.Forms.TextBox();
            this.text_moteur2 = new System.Windows.Forms.TextBox();
            this.text_moteur3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label_moteurs = new System.Windows.Forms.Label();
            this.label_pos_x = new System.Windows.Forms.Label();
            this.label_pos_y = new System.Windows.Forms.Label();
            this.label_pos_z = new System.Windows.Forms.Label();
            this.pos_x = new System.Windows.Forms.NumericUpDown();
            this.pos_y = new System.Windows.Forms.NumericUpDown();
            this.pos_z = new System.Windows.Forms.NumericUpDown();
            this.info = new System.Windows.Forms.TextBox();
            this.tampon_button = new System.Windows.Forms.Button();
            this.valeur_tampon = new System.Windows.Forms.NumericUpDown();
            this.Update_button = new System.Windows.Forms.Button();
            this.Set_vitesse_max = new System.Windows.Forms.Button();
            this.Numeric_up_down_vmax0 = new System.Windows.Forms.NumericUpDown();
            this.Numeric_up_down_vmax1 = new System.Windows.Forms.NumericUpDown();
            this.Numeric_up_down_vmax2 = new System.Windows.Forms.NumericUpDown();
            this.Numeric_up_down_vmax3 = new System.Windows.Forms.NumericUpDown();
            this.arduino_input = new System.Windows.Forms.TextBox();
            this.textBox_position_moteur0 = new System.Windows.Forms.TextBox();
            this.textBox_position_moteur1 = new System.Windows.Forms.TextBox();
            this.textBox_position_moteur2 = new System.Windows.Forms.TextBox();
            this.textBox_position_moteur3 = new System.Windows.Forms.TextBox();
            this.button_home = new System.Windows.Forms.Button();
            this.textBox_auto_update = new System.Windows.Forms.TextBox();
            this.textBox_ligne = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.button_trace_ligne = new System.Windows.Forms.Button();
            this.textBox_vecteur_depart = new System.Windows.Forms.TextBox();
            this.textBox_vecteur_arrive = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.haut_bas0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haut_bas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haut_bas3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haut_bas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valeur_tampon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_up_down_vmax0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_up_down_vmax1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_up_down_vmax2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_up_down_vmax3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // Conexion
            // 
            this.Conexion.Location = new System.Drawing.Point(34, 46);
            this.Conexion.Name = "Conexion";
            this.Conexion.Size = new System.Drawing.Size(75, 23);
            this.Conexion.TabIndex = 0;
            this.Conexion.Text = "Conexion";
            this.Conexion.UseVisualStyleBackColor = true;
            this.Conexion.Click += new System.EventHandler(this.Conexion_Click);
            // 
            // Statut
            // 
            this.Statut.AutoSize = true;
            this.Statut.Location = new System.Drawing.Point(31, 30);
            this.Statut.Name = "Statut";
            this.Statut.Size = new System.Drawing.Size(97, 13);
            this.Statut.TabIndex = 1;
            this.Statut.Text = "Etat : Non conécté";
            // 
            // arduino
            // 
            this.arduino.PortName = "COM6";
            this.arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.arduino_DataReceived);
            // 
            // state_stepper1
            // 
            this.state_stepper1.AutoSize = true;
            this.state_stepper1.Location = new System.Drawing.Point(312, 43);
            this.state_stepper1.Name = "state_stepper1";
            this.state_stepper1.Size = new System.Drawing.Size(0, 13);
            this.state_stepper1.TabIndex = 3;
            // 
            // input_data_label
            // 
            this.input_data_label.AutoSize = true;
            this.input_data_label.Location = new System.Drawing.Point(53, 144);
            this.input_data_label.Name = "input_data_label";
            this.input_data_label.Size = new System.Drawing.Size(0, 13);
            this.input_data_label.TabIndex = 4;
            // 
            // state_stepper0
            // 
            this.state_stepper0.AutoSize = true;
            this.state_stepper0.Location = new System.Drawing.Point(276, 43);
            this.state_stepper0.Name = "state_stepper0";
            this.state_stepper0.Size = new System.Drawing.Size(0, 13);
            this.state_stepper0.TabIndex = 6;
            // 
            // haut_bas0
            // 
            this.haut_bas0.Location = new System.Drawing.Point(204, 72);
            this.haut_bas0.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.haut_bas0.Name = "haut_bas0";
            this.haut_bas0.Size = new System.Drawing.Size(120, 20);
            this.haut_bas0.TabIndex = 7;
            this.haut_bas0.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.haut_bas0.ValueChanged += new System.EventHandler(this.haut_bas0_ValueChanged);
            // 
            // haut_bas1
            // 
            this.haut_bas1.Location = new System.Drawing.Point(204, 123);
            this.haut_bas1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.haut_bas1.Name = "haut_bas1";
            this.haut_bas1.Size = new System.Drawing.Size(120, 20);
            this.haut_bas1.TabIndex = 8;
            this.haut_bas1.Value = new decimal(new int[] {
            220,
            0,
            0,
            0});
            this.haut_bas1.ValueChanged += new System.EventHandler(this.haut_bas1_ValueChanged);
            // 
            // haut_bas3
            // 
            this.haut_bas3.Location = new System.Drawing.Point(204, 227);
            this.haut_bas3.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.haut_bas3.Name = "haut_bas3";
            this.haut_bas3.Size = new System.Drawing.Size(120, 20);
            this.haut_bas3.TabIndex = 9;
            this.haut_bas3.ValueChanged += new System.EventHandler(this.haut_bas3_ValueChanged);
            // 
            // haut_bas2
            // 
            this.haut_bas2.Location = new System.Drawing.Point(204, 175);
            this.haut_bas2.Maximum = new decimal(new int[] {
            305,
            0,
            0,
            0});
            this.haut_bas2.Minimum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.haut_bas2.Name = "haut_bas2";
            this.haut_bas2.Size = new System.Drawing.Size(120, 20);
            this.haut_bas2.TabIndex = 10;
            this.haut_bas2.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.haut_bas2.ValueChanged += new System.EventHandler(this.haut_bas2_ValueChanged);
            // 
            // test_moteur0
            // 
            this.test_moteur0.Location = new System.Drawing.Point(204, 46);
            this.test_moteur0.Name = "test_moteur0";
            this.test_moteur0.Size = new System.Drawing.Size(100, 20);
            this.test_moteur0.TabIndex = 0;
            this.test_moteur0.Text = "Moteur0";
            // 
            // text_moteur1
            // 
            this.text_moteur1.Location = new System.Drawing.Point(204, 98);
            this.text_moteur1.Name = "text_moteur1";
            this.text_moteur1.Size = new System.Drawing.Size(100, 20);
            this.text_moteur1.TabIndex = 11;
            this.text_moteur1.Text = "Moteur1";
            // 
            // text_moteur2
            // 
            this.text_moteur2.Location = new System.Drawing.Point(204, 149);
            this.text_moteur2.Name = "text_moteur2";
            this.text_moteur2.Size = new System.Drawing.Size(100, 20);
            this.text_moteur2.TabIndex = 12;
            this.text_moteur2.Text = "Moteur2";
            // 
            // text_moteur3
            // 
            this.text_moteur3.Location = new System.Drawing.Point(204, 201);
            this.text_moteur3.Name = "text_moteur3";
            this.text_moteur3.Size = new System.Drawing.Size(100, 20);
            this.text_moteur3.TabIndex = 13;
            this.text_moteur3.Text = "Moteur3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "COM7";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Label_moteurs
            // 
            this.Label_moteurs.AutoSize = true;
            this.Label_moteurs.Location = new System.Drawing.Point(201, 30);
            this.Label_moteurs.Name = "Label_moteurs";
            this.Label_moteurs.Size = new System.Drawing.Size(141, 13);
            this.Label_moteurs.TabIndex = 15;
            this.Label_moteurs.Text = "Envoi automatique consigne";
            this.Label_moteurs.Click += new System.EventHandler(this.Label_moteurs_Click);
            // 
            // label_pos_x
            // 
            this.label_pos_x.AutoSize = true;
            this.label_pos_x.Location = new System.Drawing.Point(31, 127);
            this.label_pos_x.Name = "label_pos_x";
            this.label_pos_x.Size = new System.Drawing.Size(69, 13);
            this.label_pos_x.TabIndex = 16;
            this.label_pos_x.Text = "Position en X";
            // 
            // label_pos_y
            // 
            this.label_pos_y.AutoSize = true;
            this.label_pos_y.Location = new System.Drawing.Point(31, 166);
            this.label_pos_y.Name = "label_pos_y";
            this.label_pos_y.Size = new System.Drawing.Size(69, 13);
            this.label_pos_y.TabIndex = 17;
            this.label_pos_y.Text = "Position en Y";
            // 
            // label_pos_z
            // 
            this.label_pos_z.AutoSize = true;
            this.label_pos_z.Location = new System.Drawing.Point(31, 205);
            this.label_pos_z.Name = "label_pos_z";
            this.label_pos_z.Size = new System.Drawing.Size(69, 13);
            this.label_pos_z.TabIndex = 18;
            this.label_pos_z.Text = "Position en Z";
            // 
            // pos_x
            // 
            this.pos_x.DecimalPlaces = 1;
            this.pos_x.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.pos_x.Location = new System.Drawing.Point(34, 143);
            this.pos_x.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.pos_x.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.pos_x.Name = "pos_x";
            this.pos_x.Size = new System.Drawing.Size(45, 20);
            this.pos_x.TabIndex = 19;
            this.pos_x.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pos_x.ValueChanged += new System.EventHandler(this.pos_x_ValueChanged);
            // 
            // pos_y
            // 
            this.pos_y.DecimalPlaces = 1;
            this.pos_y.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.pos_y.Location = new System.Drawing.Point(34, 182);
            this.pos_y.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.pos_y.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.pos_y.Name = "pos_y";
            this.pos_y.Size = new System.Drawing.Size(45, 20);
            this.pos_y.TabIndex = 20;
            this.pos_y.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pos_y.ValueChanged += new System.EventHandler(this.pos_y_ValueChanged);
            // 
            // pos_z
            // 
            this.pos_z.DecimalPlaces = 1;
            this.pos_z.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.pos_z.Location = new System.Drawing.Point(34, 221);
            this.pos_z.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.pos_z.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.pos_z.Name = "pos_z";
            this.pos_z.Size = new System.Drawing.Size(45, 20);
            this.pos_z.TabIndex = 21;
            this.pos_z.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.pos_z.ValueChanged += new System.EventHandler(this.pos_z_ValueChanged);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(28, 314);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(197, 99);
            this.info.TabIndex = 22;
            this.info.TextChanged += new System.EventHandler(this.info_TextChanged);
            // 
            // tampon_button
            // 
            this.tampon_button.Location = new System.Drawing.Point(388, 30);
            this.tampon_button.Name = "tampon_button";
            this.tampon_button.Size = new System.Drawing.Size(75, 23);
            this.tampon_button.TabIndex = 23;
            this.tampon_button.Text = "Tampon";
            this.tampon_button.UseVisualStyleBackColor = true;
            this.tampon_button.Click += new System.EventHandler(this.tampon_button_Click);
            // 
            // valeur_tampon
            // 
            this.valeur_tampon.Location = new System.Drawing.Point(388, 59);
            this.valeur_tampon.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.valeur_tampon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valeur_tampon.Name = "valeur_tampon";
            this.valeur_tampon.Size = new System.Drawing.Size(40, 20);
            this.valeur_tampon.TabIndex = 24;
            this.valeur_tampon.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(34, 247);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(94, 37);
            this.Update_button.TabIndex = 25;
            this.Update_button.Text = "Calculs angles et envoit arduino";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Set_vitesse_max
            // 
            this.Set_vitesse_max.Location = new System.Drawing.Point(388, 85);
            this.Set_vitesse_max.Name = "Set_vitesse_max";
            this.Set_vitesse_max.Size = new System.Drawing.Size(120, 23);
            this.Set_vitesse_max.TabIndex = 26;
            this.Set_vitesse_max.Text = "Set Vmax M0, ... ,M3";
            this.Set_vitesse_max.UseVisualStyleBackColor = true;
            this.Set_vitesse_max.Click += new System.EventHandler(this.Set_vitesse_max_Click);
            // 
            // Numeric_up_down_vmax0
            // 
            this.Numeric_up_down_vmax0.Location = new System.Drawing.Point(388, 114);
            this.Numeric_up_down_vmax0.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.Numeric_up_down_vmax0.Name = "Numeric_up_down_vmax0";
            this.Numeric_up_down_vmax0.Size = new System.Drawing.Size(120, 20);
            this.Numeric_up_down_vmax0.TabIndex = 27;
            this.Numeric_up_down_vmax0.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // Numeric_up_down_vmax1
            // 
            this.Numeric_up_down_vmax1.Location = new System.Drawing.Point(388, 140);
            this.Numeric_up_down_vmax1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Numeric_up_down_vmax1.Name = "Numeric_up_down_vmax1";
            this.Numeric_up_down_vmax1.Size = new System.Drawing.Size(120, 20);
            this.Numeric_up_down_vmax1.TabIndex = 28;
            this.Numeric_up_down_vmax1.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // Numeric_up_down_vmax2
            // 
            this.Numeric_up_down_vmax2.Location = new System.Drawing.Point(388, 166);
            this.Numeric_up_down_vmax2.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Numeric_up_down_vmax2.Name = "Numeric_up_down_vmax2";
            this.Numeric_up_down_vmax2.Size = new System.Drawing.Size(120, 20);
            this.Numeric_up_down_vmax2.TabIndex = 29;
            this.Numeric_up_down_vmax2.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // Numeric_up_down_vmax3
            // 
            this.Numeric_up_down_vmax3.Location = new System.Drawing.Point(388, 194);
            this.Numeric_up_down_vmax3.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Numeric_up_down_vmax3.Name = "Numeric_up_down_vmax3";
            this.Numeric_up_down_vmax3.Size = new System.Drawing.Size(120, 20);
            this.Numeric_up_down_vmax3.TabIndex = 30;
            this.Numeric_up_down_vmax3.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // arduino_input
            // 
            this.arduino_input.Location = new System.Drawing.Point(253, 314);
            this.arduino_input.Multiline = true;
            this.arduino_input.Name = "arduino_input";
            this.arduino_input.Size = new System.Drawing.Size(197, 99);
            this.arduino_input.TabIndex = 31;
            // 
            // textBox_position_moteur0
            // 
            this.textBox_position_moteur0.BackColor = System.Drawing.Color.Green;
            this.textBox_position_moteur0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_position_moteur0.Location = new System.Drawing.Point(178, 71);
            this.textBox_position_moteur0.Name = "textBox_position_moteur0";
            this.textBox_position_moteur0.ReadOnly = true;
            this.textBox_position_moteur0.Size = new System.Drawing.Size(20, 20);
            this.textBox_position_moteur0.TabIndex = 37;
            this.textBox_position_moteur0.BackColorChanged += new System.EventHandler(this.Back_color_changed);
            // 
            // textBox_position_moteur1
            // 
            this.textBox_position_moteur1.BackColor = System.Drawing.Color.Green;
            this.textBox_position_moteur1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_position_moteur1.Location = new System.Drawing.Point(178, 123);
            this.textBox_position_moteur1.Name = "textBox_position_moteur1";
            this.textBox_position_moteur1.ReadOnly = true;
            this.textBox_position_moteur1.Size = new System.Drawing.Size(20, 20);
            this.textBox_position_moteur1.TabIndex = 38;
            this.textBox_position_moteur1.BackColorChanged += new System.EventHandler(this.Back_color_changed);
            // 
            // textBox_position_moteur2
            // 
            this.textBox_position_moteur2.BackColor = System.Drawing.Color.Green;
            this.textBox_position_moteur2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_position_moteur2.Location = new System.Drawing.Point(178, 175);
            this.textBox_position_moteur2.Name = "textBox_position_moteur2";
            this.textBox_position_moteur2.ReadOnly = true;
            this.textBox_position_moteur2.Size = new System.Drawing.Size(20, 20);
            this.textBox_position_moteur2.TabIndex = 39;
            this.textBox_position_moteur2.BackColorChanged += new System.EventHandler(this.Back_color_changed);
            // 
            // textBox_position_moteur3
            // 
            this.textBox_position_moteur3.BackColor = System.Drawing.Color.Green;
            this.textBox_position_moteur3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_position_moteur3.Location = new System.Drawing.Point(178, 226);
            this.textBox_position_moteur3.Name = "textBox_position_moteur3";
            this.textBox_position_moteur3.ReadOnly = true;
            this.textBox_position_moteur3.Size = new System.Drawing.Size(20, 20);
            this.textBox_position_moteur3.TabIndex = 40;
            this.textBox_position_moteur3.BackColorChanged += new System.EventHandler(this.Back_color_changed);
            // 
            // button_home
            // 
            this.button_home.Location = new System.Drawing.Point(34, 101);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(75, 23);
            this.button_home.TabIndex = 41;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // textBox_auto_update
            // 
            this.textBox_auto_update.BackColor = System.Drawing.Color.Red;
            this.textBox_auto_update.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_auto_update.Location = new System.Drawing.Point(178, 30);
            this.textBox_auto_update.Name = "textBox_auto_update";
            this.textBox_auto_update.ReadOnly = true;
            this.textBox_auto_update.Size = new System.Drawing.Size(20, 20);
            this.textBox_auto_update.TabIndex = 42;
            // 
            // textBox_ligne
            // 
            this.textBox_ligne.Location = new System.Drawing.Point(570, 40);
            this.textBox_ligne.Name = "textBox_ligne";
            this.textBox_ligne.Size = new System.Drawing.Size(117, 20);
            this.textBox_ligne.TabIndex = 43;
            this.textBox_ligne.Text = "Déplacement linéaire";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(570, 95);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 44;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 1;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(570, 123);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown2.TabIndex = 45;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 1;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown3.Location = new System.Drawing.Point(570, 149);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown3.TabIndex = 46;
            this.numericUpDown3.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 1;
            this.numericUpDown4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown4.Location = new System.Drawing.Point(570, 200);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown4.TabIndex = 47;
            this.numericUpDown4.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 1;
            this.numericUpDown5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown5.Location = new System.Drawing.Point(570, 226);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown5.TabIndex = 48;
            this.numericUpDown5.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DecimalPlaces = 1;
            this.numericUpDown6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown6.Location = new System.Drawing.Point(570, 252);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown6.TabIndex = 49;
            this.numericUpDown6.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_trace_ligne
            // 
            this.button_trace_ligne.Location = new System.Drawing.Point(570, 279);
            this.button_trace_ligne.Name = "button_trace_ligne";
            this.button_trace_ligne.Size = new System.Drawing.Size(144, 23);
            this.button_trace_ligne.TabIndex = 50;
            this.button_trace_ligne.Text = "Ligne entre les vecteurs";
            this.button_trace_ligne.UseVisualStyleBackColor = true;
            this.button_trace_ligne.Click += new System.EventHandler(this.button_trace_ligne_Click);
            // 
            // textBox_vecteur_depart
            // 
            this.textBox_vecteur_depart.Location = new System.Drawing.Point(570, 66);
            this.textBox_vecteur_depart.Name = "textBox_vecteur_depart";
            this.textBox_vecteur_depart.Size = new System.Drawing.Size(83, 20);
            this.textBox_vecteur_depart.TabIndex = 51;
            this.textBox_vecteur_depart.Text = "Vecteur Départ";
            // 
            // textBox_vecteur_arrive
            // 
            this.textBox_vecteur_arrive.Location = new System.Drawing.Point(570, 174);
            this.textBox_vecteur_arrive.Name = "textBox_vecteur_arrive";
            this.textBox_vecteur_arrive.Size = new System.Drawing.Size(83, 20);
            this.textBox_vecteur_arrive.TabIndex = 52;
            this.textBox_vecteur_arrive.Text = "Vecteur Arrivée";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "True/False";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 54;
            this.button2.Text = "Tableau";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(620, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 55;
            this.button3.Text = "Next last position";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_vecteur_arrive);
            this.Controls.Add(this.textBox_vecteur_depart);
            this.Controls.Add(this.button_trace_ligne);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox_ligne);
            this.Controls.Add(this.textBox_auto_update);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.textBox_position_moteur3);
            this.Controls.Add(this.textBox_position_moteur2);
            this.Controls.Add(this.textBox_position_moteur1);
            this.Controls.Add(this.textBox_position_moteur0);
            this.Controls.Add(this.arduino_input);
            this.Controls.Add(this.Numeric_up_down_vmax3);
            this.Controls.Add(this.Numeric_up_down_vmax2);
            this.Controls.Add(this.Numeric_up_down_vmax1);
            this.Controls.Add(this.Numeric_up_down_vmax0);
            this.Controls.Add(this.Set_vitesse_max);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.valeur_tampon);
            this.Controls.Add(this.tampon_button);
            this.Controls.Add(this.info);
            this.Controls.Add(this.pos_z);
            this.Controls.Add(this.pos_y);
            this.Controls.Add(this.pos_x);
            this.Controls.Add(this.label_pos_z);
            this.Controls.Add(this.label_pos_y);
            this.Controls.Add(this.label_pos_x);
            this.Controls.Add(this.Label_moteurs);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.text_moteur3);
            this.Controls.Add(this.text_moteur2);
            this.Controls.Add(this.text_moteur1);
            this.Controls.Add(this.test_moteur0);
            this.Controls.Add(this.haut_bas2);
            this.Controls.Add(this.haut_bas3);
            this.Controls.Add(this.haut_bas1);
            this.Controls.Add(this.haut_bas0);
            this.Controls.Add(this.state_stepper0);
            this.Controls.Add(this.input_data_label);
            this.Controls.Add(this.state_stepper1);
            this.Controls.Add(this.Statut);
            this.Controls.Add(this.Conexion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.haut_bas0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haut_bas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haut_bas3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haut_bas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valeur_tampon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_up_down_vmax0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_up_down_vmax1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_up_down_vmax2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_up_down_vmax3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Conexion;
        private System.Windows.Forms.Label Statut;
        private System.IO.Ports.SerialPort arduino;
        private System.Windows.Forms.Label state_stepper1;
        private System.Windows.Forms.Label input_data_label;
        private System.Windows.Forms.Label state_stepper0;
        private System.Windows.Forms.NumericUpDown haut_bas0;
        private System.Windows.Forms.NumericUpDown haut_bas1;
        private System.Windows.Forms.NumericUpDown haut_bas3;
        private System.Windows.Forms.NumericUpDown haut_bas2;
        private System.Windows.Forms.TextBox test_moteur0;
        private System.Windows.Forms.TextBox text_moteur1;
        private System.Windows.Forms.TextBox text_moteur2;
        private System.Windows.Forms.TextBox text_moteur3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Label_moteurs;
        private System.Windows.Forms.Label label_pos_x;
        private System.Windows.Forms.Label label_pos_y;
        private System.Windows.Forms.Label label_pos_z;
        private System.Windows.Forms.NumericUpDown pos_x;
        private System.Windows.Forms.NumericUpDown pos_y;
        private System.Windows.Forms.NumericUpDown pos_z;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Button tampon_button;
        private System.Windows.Forms.NumericUpDown valeur_tampon;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Set_vitesse_max;
        private System.Windows.Forms.NumericUpDown Numeric_up_down_vmax0;
        private System.Windows.Forms.NumericUpDown Numeric_up_down_vmax1;
        private System.Windows.Forms.NumericUpDown Numeric_up_down_vmax2;
        private System.Windows.Forms.NumericUpDown Numeric_up_down_vmax3;
        private System.Windows.Forms.TextBox arduino_input;
        private System.Windows.Forms.TextBox textBox_position_moteur0;
        private System.Windows.Forms.TextBox textBox_position_moteur1;
        private System.Windows.Forms.TextBox textBox_position_moteur2;
        private System.Windows.Forms.TextBox textBox_position_moteur3;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.TextBox textBox_auto_update;
        private System.Windows.Forms.TextBox textBox_ligne;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Button button_trace_ligne;
        private System.Windows.Forms.TextBox textBox_vecteur_depart;
        private System.Windows.Forms.TextBox textBox_vecteur_arrive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

