namespace Reconocimiento_Visión
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CamaraBox = new Emgu.CV.UI.ImageBox();
            this.LabeL_Name = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextNSS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextMedico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextSangre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextEdad = new System.Windows.Forms.TextBox();
            this.buttonAgendar = new System.Windows.Forms.Button();
            this.buttonHistorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CamaraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CamaraBox
            // 
            this.CamaraBox.Location = new System.Drawing.Point(24, 286);
            this.CamaraBox.Name = "CamaraBox";
            this.CamaraBox.Size = new System.Drawing.Size(304, 259);
            this.CamaraBox.TabIndex = 2;
            this.CamaraBox.TabStop = false;
            // 
            // LabeL_Name
            // 
            this.LabeL_Name.AutoSize = true;
            this.LabeL_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabeL_Name.Location = new System.Drawing.Point(388, 148);
            this.LabeL_Name.Name = "LabeL_Name";
            this.LabeL_Name.Size = new System.Drawing.Size(47, 13);
            this.LabeL_Name.TabIndex = 4;
            this.LabeL_Name.Text = "Nombre:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(24, 551);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(52, 30);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(443, 145);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(266, 20);
            this.TextName.TabIndex = 6;
            // 
            // TextApellidos
            // 
            this.TextApellidos.Location = new System.Drawing.Point(443, 187);
            this.TextApellidos.Name = "TextApellidos";
            this.TextApellidos.Size = new System.Drawing.Size(266, 20);
            this.TextApellidos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(383, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Apellidos:";
            // 
            // TextDireccion
            // 
            this.TextDireccion.Location = new System.Drawing.Point(443, 231);
            this.TextDireccion.Name = "TextDireccion";
            this.TextDireccion.Size = new System.Drawing.Size(266, 20);
            this.TextDireccion.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(380, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(380, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Teléfono:";
            // 
            // TextTelefono
            // 
            this.TextTelefono.Location = new System.Drawing.Point(443, 286);
            this.TextTelefono.Name = "TextTelefono";
            this.TextTelefono.Size = new System.Drawing.Size(266, 20);
            this.TextTelefono.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(400, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "NSS:";
            // 
            // TextNSS
            // 
            this.TextNSS.Location = new System.Drawing.Point(443, 373);
            this.TextNSS.Name = "TextNSS";
            this.TextNSS.Size = new System.Drawing.Size(266, 20);
            this.TextNSS.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(387, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Médico:";
            // 
            // TextMedico
            // 
            this.TextMedico.Location = new System.Drawing.Point(443, 428);
            this.TextMedico.Name = "TextMedico";
            this.TextMedico.Size = new System.Drawing.Size(266, 20);
            this.TextMedico.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(349, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tipo de Sangre:";
            // 
            // TextSangre
            // 
            this.TextSangre.Location = new System.Drawing.Point(443, 332);
            this.TextSangre.Name = "TextSangre";
            this.TextSangre.Size = new System.Drawing.Size(94, 20);
            this.TextSangre.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(580, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Edad:";
            // 
            // TextEdad
            // 
            this.TextEdad.Location = new System.Drawing.Point(637, 335);
            this.TextEdad.Name = "TextEdad";
            this.TextEdad.Size = new System.Drawing.Size(72, 20);
            this.TextEdad.TabIndex = 19;
            // 
            // buttonAgendar
            // 
            this.buttonAgendar.Location = new System.Drawing.Point(443, 498);
            this.buttonAgendar.Name = "buttonAgendar";
            this.buttonAgendar.Size = new System.Drawing.Size(110, 47);
            this.buttonAgendar.TabIndex = 21;
            this.buttonAgendar.Text = "Agendar Cita Médica";
            this.buttonAgendar.UseVisualStyleBackColor = true;
            this.buttonAgendar.Click += new System.EventHandler(this.buttonAgendar_Click);
            // 
            // buttonHistorial
            // 
            this.buttonHistorial.Location = new System.Drawing.Point(599, 498);
            this.buttonHistorial.Name = "buttonHistorial";
            this.buttonHistorial.Size = new System.Drawing.Size(110, 47);
            this.buttonHistorial.TabIndex = 22;
            this.buttonHistorial.Text = "Ver Historia Clínica";
            this.buttonHistorial.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(730, 603);
            this.Controls.Add(this.buttonHistorial);
            this.Controls.Add(this.buttonAgendar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextEdad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextSangre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextMedico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextNSS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextApellidos);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LabeL_Name);
            this.Controls.Add(this.CamaraBox);
            this.Name = "Form1";
            this.Text = "Reconocimiento de rostros";
            ((System.ComponentModel.ISupportInitialize)(this.CamaraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox CamaraBox;
        private System.Windows.Forms.Label LabeL_Name;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextNSS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextMedico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextSangre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextEdad;
        private System.Windows.Forms.Button buttonAgendar;
        private System.Windows.Forms.Button buttonHistorial;
    }
}

