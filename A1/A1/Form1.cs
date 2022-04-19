using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1
{
    public partial class Form1 : Form
    {
        ArrayList vector;
        string[] lista ;
        string[] pp = new string[100];
        int j = 0;
        public Form1()
        {
            InitializeComponent();
            vector = new ArrayList();
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string a="";
            string x = textBox.Text.ToString();
            vector.Add(x);
            list.Clear();


            if (!x.Equals(""))
            {
                x = vector[0].ToString();
                char[] delimitador = { ',', ' ' };
                lista = x.Split(delimitador);
                for (int i = 0; i < lista.Length; i++)
                {

                    if (lista[i].Length > 5)
                    {
                        
                        pp[j] = lista[i];
                        list.Items.Add(pp[j]);

                        j++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese palabra a buscar");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string a = "";
            string x = textBox.Text.ToString();
            vector.Add(x);
            list.Clear();
            if (!x.Equals(""))
            {
                x = vector[0].ToString();
                char[] delimitador = { ',', ' ' };
                lista = x.Split(delimitador);
                for (int i = 0; i < lista.Length; i++)
                {

                    if (lista[i].Length < 6)
                    {
                        pp[j] = lista[i];
                        list.Items.Add(pp[j]);
                        j++;
                    }
                }

            }
            else
            {
                MessageBox.Show("Ingrese palabra a buscar");
            }


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            String a ;
            string x = textBox.Text.ToString();
            vector.Add(x);

            list.Clear();

            if (!x.Equals(""))
            {
                x = vector[0].ToString();
                char[] delimitador = { ',', ' ' };
                lista = x.Split(delimitador);
                for (int i = 0; i < lista.Length; i++)
                {
                    a = lista[i].Substring(lista[i].Length-1,1).ToLower();
                    if ((!a.Equals("a")) || (!a.Equals("e")) || (!a.Equals("i")) || (!a.Equals("o")) || (!a.Equals("u")))
                    {
                        pp[j] = lista[i];
                        list.Items.Add(pp[j]);
                        j++;
                    }
                }

            }
            else
            {
                MessageBox.Show("Ingrese palabra a buscar");
            }



        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string x = palabra.Text;
            if (!x.Equals("")) {
                
                for (int i = 0; i < lista.Length; i++)
                {
                    if (x.ToLower().Equals(lista[i].ToLower())) {
                        MessageBox.Show("La palabra se encuentra en la posicion "+i);
                        break;
                    }
                }
            }
            else {
                MessageBox.Show("Ingrese palabra a buscar");
            }
            list.Clear();
        }
    }
}
