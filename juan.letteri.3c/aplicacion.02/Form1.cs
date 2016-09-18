using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion._02
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = 0;
            try
            {
                num=Convert.ToInt32(txtMonto.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error;" + ex.Message);
            }

            if (num<0)
            {
                MessageBox.Show("Por favor ingrese un numero mayor q cero", "Error numero negativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLimpiar_Click(sender, e);
            }
            else if (num>=0 && num<30)
            {
                txtDescuento.Text = "0";
                txtPagar.Text = num.ToString();
            }
            else if (num>=30 && num<=50)
            {
                txtDescuento.Text = (num * 0.10).ToString();
                txtPagar.Text = (num * 0.90).ToString();
            }
            else
            {
                txtDescuento.Text = (num * 0.20).ToString();
                txtPagar.Text = (num * 0.80).ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescuento.Text = "";
            txtPagar.Text = "";
            txtMonto.Text = "";
            txtMonto.Focus();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCalcular_Click(sender,e);
            }
        }
    }
}
