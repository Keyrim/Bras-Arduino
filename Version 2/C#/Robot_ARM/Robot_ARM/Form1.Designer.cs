namespace Robot_ARM
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
            this.arduino_mega = new System.IO.Ports.SerialPort(this.components);
            this.button_open_port = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arduino_mega
            // 
            this.arduino_mega.PortName = "COM7";
            // 
            // button_open_port
            // 
            this.button_open_port.BackColor = System.Drawing.Color.Green;
            this.button_open_port.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_open_port.FlatAppearance.BorderSize = 0;
            this.button_open_port.Location = new System.Drawing.Point(22, 12);
            this.button_open_port.Name = "button_open_port";
            this.button_open_port.Size = new System.Drawing.Size(75, 23);
            this.button_open_port.TabIndex = 1;
            this.button_open_port.Text = "Open port 6";
            this.button_open_port.UseVisualStyleBackColor = false;
            this.button_open_port.Click += new System.EventHandler(this.Button_open_port_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_open_port);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort arduino_mega;
        private System.Windows.Forms.Button button_open_port;
    }
}

