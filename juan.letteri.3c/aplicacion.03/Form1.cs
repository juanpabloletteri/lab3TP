using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string Invertir(string cadena)
        {
            char[] arraychar = cadena.ToCharArray();
            Array.Reverse(arraychar);
            string st = new string(arraychar);
            return st;
            //return arraychar.ToString();
        }
        private string OrdenarAlfabeticamente(string cadena)
        {
            char[] arraychar = cadena.ToCharArray();
            Array.Sort(arraychar);
            string ordenado = new string(arraychar);
            return ordenado;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro desea salir?","Saliendo...",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string cadena = txtCadena.Text;
            txtInvertida.Text = Invertir(cadena);

            cadena = txtCadena.Text;
            txtAlfabetico.Text = OrdenarAlfabeticamente(cadena);

        }
    }
}
