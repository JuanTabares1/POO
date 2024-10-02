using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.White;
            }
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.White;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.White;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.White;
                txtpass.UseSystemPasswordChar = true;

            }
        }
        private void lblErrorMessage_Click(object sender, EventArgs e)
        {

        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form MsgBox = new MsgBox();
            MsgBox.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string pass = txtpass.Text;
            MySqlConnection con = new MySqlConnection("server = 127.0.0.1; Database=logins; User Id = root; password=1234");
            try
            {
                con.Open();
            }
            catch (MySqlException ex) { MessageBox.Show("Error " + ex.ToString()); }
            String sql = "select user,pass from users where user ='" + username + "' AND pass ='" + pass + "'";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@username", username);
            comando.Parameters.AddWithValue("@password", pass);
            MySqlDataReader read = comando.ExecuteReader();
            if (read.Read())
            {
                Form page1 = new page1();
                page1.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }

            if (txtuser.Text != "USUARIO")
            {
                if (txtpass.Text != "CONTRASEÑA")
                {
                }
                else msgError("Porfavor ingrese la contraseña");
            }
            else msgError("Porfavor ingrese el usuario");
        }
        

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            Form registers = new registers();
            registers.Show();

            this.Hide();
        }

        private void muestra_CheckedChanged_1(object sender, EventArgs e)
        {
            if (muestra.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
