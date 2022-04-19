namespace A3
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
            this.fichas = new System.Windows.Forms.FlowLayoutPanel();
            this.palabra = new System.Windows.Forms.FlowLayoutPanel();
            this.mensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.PictureBox();
            this.picAhorcado = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // fichas
            // 
            this.fichas.Location = new System.Drawing.Point(12, 115);
            this.fichas.Name = "fichas";
            this.fichas.Size = new System.Drawing.Size(445, 283);
            this.fichas.TabIndex = 1;
            // 
            // palabra
            // 
            this.palabra.Location = new System.Drawing.Point(121, 400);
            this.palabra.Name = "palabra";
            this.palabra.Size = new System.Drawing.Size(608, 88);
            this.palabra.TabIndex = 3;
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje.ForeColor = System.Drawing.Color.DarkRed;
            this.mensaje.Location = new System.Drawing.Point(471, 24);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(262, 55);
            this.mensaje.TabIndex = 5;
            this.mensaje.Text = "Lo mataste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(68, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adivina la palabra o muere";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Image = global::A3.Properties.Resources.boton42;
            this.btnIniciar.Location = new System.Drawing.Point(12, 7);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(445, 71);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.TabStop = false;
            this.btnIniciar.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // picAhorcado
            // 
            this.picAhorcado.Location = new System.Drawing.Point(481, 115);
            this.picAhorcado.Name = "picAhorcado";
            this.picAhorcado.Size = new System.Drawing.Size(250, 283);
            this.picAhorcado.TabIndex = 2;
            this.picAhorcado.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "ayuda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.palabra);
            this.Controls.Add(this.picAhorcado);
            this.Controls.Add(this.fichas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fichas;
        private System.Windows.Forms.PictureBox picAhorcado;
        private System.Windows.Forms.FlowLayoutPanel palabra;
        private System.Windows.Forms.Label mensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnIniciar;
        private System.Windows.Forms.Button button1;
    }
}

