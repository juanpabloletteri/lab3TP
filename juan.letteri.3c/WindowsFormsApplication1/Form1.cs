using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public enum eColores
        {
            rojo,
            azul,
            verde,
            amarillo,
            violeta
        }
        public Form1()
        {
            InitializeComponent();
            cmb.Items.Add("hola");
            cmb.Items.Add("chau");

            foreach (eColores item in Enum.GetValues(typeof(eColores )))
            {
                cmbColores.Items.Add(item);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            lblIndex.Text = cmb.SelectedIndex.ToString();
            lblText.Text = cmb.SelectedText.ToString();
            lblItem.Text= cmb.SelectedItem.ToString();
            /*try
            {
            lblValue.Text= cmb.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }*/

        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAceptar_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro desera salir?","Saliendo...", MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
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
