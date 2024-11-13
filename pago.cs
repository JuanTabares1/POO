using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventario
{
    public partial class pago : Form
    {
        public pago()
        {
            InitializeComponent();
        }

        private void pago_Load(object sender, EventArgs e)
        {

        }

        private void txtntarjeta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtntarjeta_Enter(object sender, EventArgs e)
        {
            if (txtntarjeta.Text == "Numero de Tarjeta")
            {
                txtntarjeta.Text = "";
                txtntarjeta.ForeColor = Color.White;
            }
        }

        private void txtntarjeta_Leave(object sender, EventArgs e)
        {
            if (txtntarjeta.Text == "")
            {
                txtntarjeta.Text = "Numero de Tarjeta";
                txtntarjeta.ForeColor = Color.White;
            }
        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            if (txtnombre.Text == "Nombre del Titular")
            {
                txtnombre.Text = "";
                txtnombre.ForeColor = Color.White;
            }
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {

            if (txtnombre.Text == "")
            {
                txtnombre.Text = "Nombre del Titular";
                txtnombre.ForeColor = Color.White;
            }
        }

        private void txtfecha_Enter(object sender, EventArgs e)
        {
            if (txtfecha.Text == "Fecha Expedicion")
            {
                txtfecha.Text = "";
                txtfecha.ForeColor = Color.White;
            }
        }

        private void txtfecha_Leave(object sender, EventArgs e)
        {

            if (txtfecha.Text == "")
            {
                txtfecha.Text = "Fecha Expedicion";
                txtfecha.ForeColor = Color.White;
            }
        }

        private void txtcodigo_Enter(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "Codigo Postal")
            {
                txtcodigo.Text = "";
                txtcodigo.ForeColor = Color.White;
            }
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                txtcodigo.Text = "Codigo Postal";
                txtcodigo.ForeColor = Color.White;
            }
        }

        private void txtcvc_Enter(object sender, EventArgs e)
        {
            if (txtcvc.Text == "Pin")
            {
                txtcvc.Text = "";
                txtcvc.ForeColor = Color.White;
            }
        }

        private void txtcvc_Leave(object sender, EventArgs e)
        {
            if (txtcvc.Text == "")
            {
                txtcvc.Text = "Pin";
                txtcvc.ForeColor = Color.White;
            }
        }

        private void txtdireccion_Enter(object sender, EventArgs e)
        {
            if (txtdireccion.Text == "Direccion(obligatorio)")
            {
                txtdireccion.Text = "";
                txtdireccion.ForeColor = Color.White;
            }
        }

        private void txtdireccion_Leave(object sender, EventArgs e)
        {
            if (txtdireccion.Text == "")
            {
                txtdireccion.Text = "Direccion(obligatorio)";
                txtdireccion.ForeColor = Color.White;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {

        }
    }
}
