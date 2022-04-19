using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A5
{
    public partial class Form1 : Form
    {
        int TemanioColumnasFilas = 4;
        int Movimientos = 0;
        int CantidadDeCartasVolteadas = 0;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionadas;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        int CartaActual=0;
        public Form1()
        {
            InitializeComponent();
            iniciarJuego();
        }

        public void iniciarJuego() {

            timer1.Enabled = false;
            timer1.Stop();
            puntos.Text = "0";
            CantidadDeCartasVolteadas = 0;
            Movimientos = 0;
            panelJuego.Controls.Clear();
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();
            for (int i = 0; i < 8; i++) {

                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());

            }
            var NumeroAleatorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item=> NumeroAleatorio.Next());
            foreach (string valorCarta in Resultado) {
                CartasRevueltas.Add(valorCarta);
            }
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = TemanioColumnasFilas;
            tablaPanel.ColumnCount = TemanioColumnasFilas;
            for (int i =0;i<TemanioColumnasFilas;i++) {

                var Porcentaje = 150f / (float)TemanioColumnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));


            }

            int contadorFichas = 1;

            for(var i =0; i < TemanioColumnasFilas; i++) {

                for (var j = 0; j < TemanioColumnasFilas; j++) {

                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = string.Format("{0}", contadorFichas);
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = Properties.Resources.fondo1;
                    CartasJuego.Click += ButtonCarta_Click;
                    CartasJuego.Cursor = Cursors.Hand;
                    tablaPanel.Controls.Add(CartasJuego, j, i);
                    contadorFichas++;
                }

            }

            tablaPanel.Dock = DockStyle.Fill;
            panelJuego.Controls.Add(tablaPanel);
        }

        private void ButtonReinicio_Click(object sender, EventArgs e)
        {
             
        }

        private void ButtonCarta_Click(object sender, EventArgs e)
        {

            Movimientos++;
            puntos.Text = Convert.ToString(Movimientos);
            var CartasSleccionadasUsuario = (PictureBox)sender;

            CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSleccionadasUsuario.Name)-1]);
            CartasSleccionadasUsuario.Image = RecuperarImagen(CartaActual);
            CartasSeleccionadas.Add(CartasSleccionadasUsuario);
        }


        public Bitmap RecuperarImagen(int CartaActual) {

            Bitmap TmoImg = new Bitmap(200, 100);
            switch (CartaActual) {


                case 0: TmoImg = Properties.Resources._1;
                    break;
                default: TmoImg = (Bitmap)Properties.Resources.ResourceManager.GetObject(CartaActual.ToString());
                    break;


            }

            return TmoImg;
        }

    }
}
