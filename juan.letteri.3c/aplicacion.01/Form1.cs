using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = 0;
            try
            {
                num = Convert.ToInt32(txtNumero.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                btnLimpiar_Click(sender,e);
            }

            for (int i = 1; i <= 10; i++)
            {
                lstTabla.Items.Add(num + " * " + i + " = " + (num * i));
            }

            btnCalcular.Enabled = false;
            btnLimpiar.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstTabla.Items.Clear();
            txtNumero.Clear();
            btnCalcular.Enabled = true;
            txtNumero.Focus();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                btnCalcular_Click("", e);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro desea salir?","Saliendo...",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
