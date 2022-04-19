namespace A5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panelJuego = new System.Windows.Forms.Panel();
            this.buttonReinicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.puntos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panelJuego
            // 
            this.panelJuego.Location = new System.Drawing.Point(12, 12);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(624, 559);
            this.panelJuego.TabIndex = 0;
            // 
            // buttonReinicio
            // 
            this.buttonReinicio.Location = new System.Drawing.Point(668, 285);
            this.buttonReinicio.Name = "buttonReinicio";
            this.buttonReinicio.Size = new System.Drawing.Size(123, 23);
            this.buttonReinicio.TabIndex = 1;
            this.buttonReinicio.Text = "Reinicio de Juego";
            this.buttonReinicio.UseVisualStyleBackColor = true;
            this.buttonReinicio.Click += new System.EventHandler(this.ButtonReinicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Record: ";
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.Location = new System.Drawing.Point(719, 47);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(13, 13);
            this.puntos.TabIndex = 3;
            this.puntos.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 616);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReinicio);
            this.Controls.Add(this.panelJuego);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelJuego;
        private System.Windows.Forms.Button buttonReinicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label puntos;
        private System.Windows.Forms.Timer timer1;
    }
}

