using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            button1.Enabled = false;
        }

        public void Random()
        {

            var seed = Environment.TickCount;
            var random = new Random(seed);

            var value = random.Next(1, 3);
            NumU.Text = value.ToString();



             value = random.Next(1,3);
            NumD.Text = value.ToString();

             value = random.Next(1,3);
            NumT.Text = value.ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            

            Random();
            string un = NumU.Text;
            string dos = NumD.Text;
            string te = NumT.Text;
            string p = ptj.Text;

            int u = int.Parse(un);
            int d = int.Parse(dos);
            int t = int.Parse(te);
            int pu = int.Parse(p);

            if (u == d)
            {
                if (d == t)
                {
                    
                    pu =pu + 5;
                    
                }
                else {
                    pu++;
                    
                }
            }
            else
            {
                if (u==t)
                {
                    pu++;
                    
                }
                else
                {
                    pu -= 5;
                    
                }
            }
            

            if (pu > 0 ) {
                ptj.Text = pu.ToString();
            }


            if (pu <= 0)
            {
                res.Text = " Usted Perdio ";
                NumU.Text = "0";
                NumD.Text = "0";
                NumT.Text = "0";
                button1.Enabled = false;

            }
            if(pu >= 150){
                res.Text = " Usted Gano ";
                NumU.Text = "0";
                NumD.Text = "0";
                NumT.Text = "0";
                button1.Enabled = false;
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
                        
                res.Text = "";
            ptj.Text = "50";
            button1.Enabled = true;

        }
    }
}
