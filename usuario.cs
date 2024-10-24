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
    public partial class usuario : Form
    {
        public usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form MsgBox = new MsgBox();
            MsgBox.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void txtreuser_Enter(object sender, EventArgs e)
        {
            if (txtreuser.Text == "CAMBIAR NOMBRE DE USUARIO")
            {
                txtreuser.Text = "";
                txtreuser.ForeColor = Color.White;
            }
        }

        private void txtreuser_Leave(object sender, EventArgs e)
        {
            if (txtreuser.Text == "")
            {
                txtreuser.Text = "CAMBIAR NOMBRE DE USUARIO";
                txtreuser.ForeColor = Color.White;
            }
        }

        private void txtrpass_Enter(object sender, EventArgs e)
        {
            if (txtrpass.Text == "CAMBIAR CONTRASEÑA")
            {
                txtrpass.Text = "";
                txtrpass.ForeColor = Color.White;
            }
        }

        private void txtrpass_Leave(object sender, EventArgs e)
        {
            if (txtrpass.Text == "")
            {
                txtrpass.Text = "CAMBIAR CONTRASEÑA";
                txtrpass.ForeColor = Color.White;
            }
        }
    }
}
