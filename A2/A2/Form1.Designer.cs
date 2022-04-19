namespace A2
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
            this.NumU = new System.Windows.Forms.TextBox();
            this.NumD = new System.Windows.Forms.TextBox();
            this.NumT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ptj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumU
            // 
            this.NumU.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumU.Location = new System.Drawing.Point(34, 43);
            this.NumU.Name = "NumU";
            this.NumU.Size = new System.Drawing.Size(41, 62);
            this.NumU.TabIndex = 0;
            this.NumU.Text = "5";
            // 
            // NumD
            // 
            this.NumD.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumD.Location = new System.Drawing.Point(81, 43);
            this.NumD.Name = "NumD";
            this.NumD.Size = new System.Drawing.Size(41, 62);
            this.NumD.TabIndex = 1;
            this.NumD.Text = "5";
            // 
            // NumT
            // 
            this.NumT.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumT.Location = new System.Drawing.Point(128, 43);
            this.NumT.Name = "NumT";
            this.NumT.Size = new System.Drawing.Size(41, 62);
            this.NumT.TabIndex = 2;
            this.NumT.Text = "5";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "JUGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Puntaje :";
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(194, 89);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(0, 16);
            this.res.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Iniciar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ptj
            // 
            this.ptj.AutoSize = true;
            this.ptj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptj.Location = new System.Drawing.Point(194, 59);
            this.ptj.Name = "ptj";
            this.ptj.Size = new System.Drawing.Size(0, 16);
            this.ptj.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 235);
            this.Controls.Add(this.ptj);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.res);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumT);
            this.Controls.Add(this.NumD);
            this.Controls.Add(this.NumU);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumU;
        private System.Windows.Forms.TextBox NumD;
        private System.Windows.Forms.TextBox NumT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ptj;
    }
}

