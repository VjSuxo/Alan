using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A6
{
    public partial class Form1 : Form
    {
        string jugadorX = "";
        string jugadorO = "";
        bool cambio = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnOffBtn(false);
        }

        public void OnOffBtn(bool onoff) {

            a1.Enabled = onoff;
            a2.Enabled = onoff;
            a3.Enabled = onoff;
            b1.Enabled = onoff;
            b2.Enabled = onoff;
            b3.Enabled = onoff;
            c1.Enabled = onoff;
            c2.Enabled = onoff;
            c3.Enabled = onoff;
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";

        }

        private void Btn_Click(object sender, EventArgs e)
        {


            PlayGame();
            
        }

       

        public void PlayGame() {



            OnOffBtn(true);
        }

        private void ButtonsClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (cambio)
            {
                b.Text = "X";
            }
            else {
                b.Text = "O";
            }
            cambio = !cambio;
            b.Enabled = false;
            partida();
        }
        public void partida() {


            if ((a1.Text == a2.Text) & (a2.Text == a3.Text) && (!a1.Enabled))
            {
                MessageBox.Show("Ganador " + a1.Text);
            }
            else if ((b1.Text == b2.Text) & (b2.Text == b3.Text) && (!b1.Enabled))
            {
                MessageBox.Show("Ganador " + b1.Text);
            }
            else if ((c1.Text == c2.Text) & (c2.Text == c3.Text) && (!c1.Enabled))
            {
                MessageBox.Show("Ganador " + c1.Text);
            }

            else if ((a1.Text == b1.Text) & (b1.Text == c1.Text) && (!c1.Enabled))
            {
                MessageBox.Show("Ganador " + b1.Text);
            }
            else if ((a2.Text == b2.Text) & (b2.Text == c2.Text) && (!c2.Enabled))
            {
                MessageBox.Show("Ganador " + b2.Text);
            }
            else if ((a3.Text == b3.Text) & (b3.Text == c3.Text) && (!c3.Enabled))
            {
                MessageBox.Show("Ganador " + b1.Text);
            }

            else if ((a1.Text == b2.Text) & (b2.Text == c3.Text) && (!c3.Enabled))
            {
                MessageBox.Show("Ganador " + b2.Text);
            }
            else if ((a3.Text == b2.Text) & (b2.Text == c1.Text) && (!c1.Enabled))
            {
                MessageBox.Show("Ganador " + b2.Text);
            }
            
        }
    }
}
