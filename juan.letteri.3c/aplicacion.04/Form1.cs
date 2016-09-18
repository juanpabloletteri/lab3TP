using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir?","Saliendo...",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int num = 0;
            try
            {
                num = Convert.ToInt32(txtNumero.Text);
                lstNumeros.Items.Add(num);
                txtNumero.Text = "";
                txtNumero.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                txtNumero.Text = "";
                txtNumero.Focus();
            }
        }
        private int OrdenarAscendente(int num1, int num2)
        {
            if (num1<num2)
            {
                return -1;
            }
            else if (num1>num2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private int OrdenarDescendente(int num1, int num2)
        {
            return -(OrdenarAscendente(num1,num2));
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            List<int> lista = new List<int>();

            foreach (int item in lstNumeros.Items)
            {
                lista.Add(item);
            }

            if (rbtAscendente.Checked)//==true)
            {
                lista.Sort(OrdenarAscendente);
            }
            else
            {
                lista.Sort(OrdenarDescendente);
            }

            lstNumeros.Items.Clear();
            foreach (int item in lista)
            {
                lstNumeros.Items.Add(item);
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                btnAgregar_Click(sender,e);
            }
        }
    }
}
