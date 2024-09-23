using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventario
{
    public partial class registers : Form
    {
        public registers()
        {
            InitializeComponent();
        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            if (txtcorreo.Text == "")
            {
                txtcorreo.Text = "CORREO";
                txtcorreo.ForeColor = Color.DimGray;
            }
        }

        private void txtcorreo_Enter(object sender, EventArgs e)
        {
            if (txtcorreo.Text == "CORREO")
            {
                txtcorreo.Text = "";
                txtcorreo.ForeColor = Color.White;
            }
        }

        private void txtruser_Leave(object sender, EventArgs e)
        {
            if (txtruser.Text == "")
            {
                txtruser.Text = "USUARIO";
                txtruser.ForeColor = Color.DimGray;
            }
        }

        private void txtruser_Enter(object sender, EventArgs e)
        {
            if (txtruser.Text == "USUARIO")
            {
                txtruser.Text = "";
                txtruser.ForeColor = Color.White;
            }
        }

        private void txtrpass_Leave(object sender, EventArgs e)
        {
            if (txtrpass.Text == "")
            {
                txtrpass.Text = "CONTRASEÑA";
                txtrpass.ForeColor = Color.DimGray;
                txtrpass.UseSystemPasswordChar = false;
            }
        }

        private void txtrpass_Enter(object sender, EventArgs e)
        {
            if (txtrpass.Text == "CONTRASEÑA")
            {
                txtrpass.Text = "";
                txtrpass.ForeColor = Color.White;
                txtrpass.UseSystemPasswordChar = true;
            }
        }

        private void txtrpass2_Leave(object sender, EventArgs e)
        {
            if (txtrpass2.Text == "")
            {
                txtrpass2.Text = "CONFIRMAR CONTRASEÑA";
                txtrpass2.ForeColor = Color.DimGray;
                txtrpass2.UseSystemPasswordChar = false;
            }
        }

        private void txtrpass2_Enter(object sender, EventArgs e)
        {
            if (txtrpass2.Text == "CONFIRMAR CONTRASEÑA")
            {
                txtrpass2.Text = "";
                txtrpass2.ForeColor = Color.White;
                txtrpass2.UseSystemPasswordChar = true;

            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string correo = txtcorreo.Text;
            string username = txtruser.Text;
            string password = txtrpass.Text;
            string confirmPassword = txtrpass2.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            if (!IsValidEmail(correo))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return;
            }

            MessageBox.Show("Usuario registrado con éxito.");
            Form Form1 = new Form1();
            Form1.Show();
            this.Hide();

        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir?", "Esta apunto de salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                Form Form1 = new Form1();
                Form1.Show();
            }
        }
    }
}
