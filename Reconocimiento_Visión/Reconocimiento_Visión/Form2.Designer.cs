namespace Reconocimiento_Visión
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComboArea = new System.Windows.Forms.ComboBox();
            this.TextMotivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboArea
            // 
            this.ComboArea.FormattingEnabled = true;
            this.ComboArea.Items.AddRange(new object[] {
            "Emergencias",
            "Consulta General",
            "Especialidad"});
            this.ComboArea.Location = new System.Drawing.Point(80, 37);
            this.ComboArea.Name = "ComboArea";
            this.ComboArea.Size = new System.Drawing.Size(195, 21);
            this.ComboArea.TabIndex = 0;
            this.ComboArea.Text = "Seleccione área...";
            // 
            // TextMotivo
            // 
            this.TextMotivo.Location = new System.Drawing.Point(80, 95);
            this.TextMotivo.Name = "TextMotivo";
            this.TextMotivo.Size = new System.Drawing.Size(195, 20);
            this.TextMotivo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Area:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Motivo:";
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(80, 151);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(142, 33);
            this.Aceptar.TabIndex = 4;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(303, 209);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextMotivo);
            this.Controls.Add(this.ComboArea);
            this.Name = "Form2";
            this.Text = "Motivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboArea;
        private System.Windows.Forms.TextBox TextMotivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Aceptar;
    }
}