using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3
{
    public partial class Form1 : Form
    {
        char[] PalabrasAdivinandas; int Oportunidades = 0;
        char[] PalabraSaleccionada;
        char[] Alfabeto;
        string[] Palabras;
        int cont = 0;

        public Form1()
        {
         

            InitializeComponent();
            button1.Enabled = false;
            mensaje.Visible = false;
        }

        public void IniciarJuego() {

            fichas.Controls.Clear();
            fichas.Enabled = true;
            mensaje.Visible = false;
            picAhorcado.Image = null;
            Oportunidades = 0;
            btnIniciar.Image = Properties.Resources.Jugando;
            Palabras = new string[] {"Mario","Valorant","Dinero","Juego","Jazmin","Joel","Batman","Trigonometria" };

            Alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();


            Random random = new Random();
            int IndicePalabraSel = random.Next(0, Palabras.Length);
            PalabraSaleccionada = Palabras[IndicePalabraSel].ToUpper().ToCharArray();
            PalabrasAdivinandas = PalabraSaleccionada;


            foreach (char LetraAlfabeto in Alfabeto)
            {
                Button btnLetra = new Button();
                btnLetra.Tag = LetraAlfabeto.ToString();
                btnLetra.Text = LetraAlfabeto.ToString();
                btnLetra.Width = 60;
                btnLetra.Height = 40;

                btnLetra.Click += Compara;

                btnLetra.ForeColor = Color.White;
                btnLetra.Font = new Font(btnLetra.Font.Name, 15, FontStyle.Bold);
                btnLetra.BackgroundImageLayout = ImageLayout.Center;
                btnLetra.BackColor = Color.Black;
                btnLetra.Name = LetraAlfabeto.ToString();
                fichas.Controls.Add(btnLetra);

            }
           
           
            
            palabra.Controls.Clear();
            for (int INdiceValorLetra = 0; INdiceValorLetra < PalabraSaleccionada.Length; INdiceValorLetra++)
            {
                Button Letra = new Button();
                Letra.Tag = PalabraSaleccionada[INdiceValorLetra].ToString();
                Letra.Width = 46;
                Letra.Height = 80;
                Letra.ForeColor = Color.Purple;
              
                    Letra.Text = "-";

                
                Letra.Font = new Font(Letra.Font.Name, 32, FontStyle.Bold);
                Letra.BackgroundImageLayout = ImageLayout.Center;
                Letra.BackColor = Color.White;
                Letra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Letra.Name = "Adivinando" + INdiceValorLetra.ToString();
                palabra.Controls.Add(Letra);
            }

        }

        void Compara(object sender, EventArgs e)
        {
            bool encontrado = false;
            //btn descatuivado
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Enabled = false;

            for (int indiceRevisar = 0; indiceRevisar < PalabrasAdivinandas.Length; indiceRevisar++) {

                if (PalabrasAdivinandas[indiceRevisar] == char.Parse(btn.Text)) {

                    Button tbx = this.Controls.Find("Adivinando" + indiceRevisar, true).FirstOrDefault() as Button;
                    tbx.Text = PalabrasAdivinandas[indiceRevisar].ToString();
                    PalabrasAdivinandas[indiceRevisar] = '-';
                    encontrado = true;

                }

            }

            bool Ganaste = true;
            for (int indiceAnalizador = 0; indiceAnalizador < PalabrasAdivinandas.Length; indiceAnalizador++) {

                if (PalabrasAdivinandas[indiceAnalizador] != '-') {
                    Ganaste = false;
                }

            }

            if (Ganaste) { MessageBox.Show("Ganaste"); btnIniciar.Image = Properties.Resources.boton42; }

            if (!encontrado) {
                Oportunidades = Oportunidades + 1;
                picAhorcado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(Oportunidades.ToString());

                if (Oportunidades == 6) {

                    mensaje.Visible = true;
                    for (int IndiceValorLetra = 0; IndiceValorLetra < PalabraSaleccionada.Length; IndiceValorLetra++) {
                        Button btnLetra = this.Controls.Find("Adivinando" + IndiceValorLetra, true).FirstOrDefault() as Button;
                        btnLetra.Text = btnLetra.Tag.ToString();
                    }

                    fichas.Enabled = false;
                    btnIniciar.Image = Properties.Resources.boton42;

                }


            }

        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            IniciarJuego();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string x = "";
            int[] ayupos = new int[2];
            for (int i = 0; i < 3; i++)
            {
                int pos = random.Next(0, PalabraSaleccionada.Length);
                x += "-" + PalabraSaleccionada[pos];
            }
            MessageBox.Show("Letras Calve "+x);
            button1.Enabled = false;
        }
    }
}
