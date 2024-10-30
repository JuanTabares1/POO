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
    public partial class usuario : Form
    {
        public usuario()
        {
            InitializeComponent();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string conexion = "Server=127.0.0.1;Database=logins;Uid=root;Pwd=1234;";
            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE users SET pass = @pass WHERE user = @user";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@user", txtreuser.Text);
                        cmd.Parameters.AddWithValue("@pass", txtrpass.Text);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Usuario actualizado exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró el usuario con el Nombre proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error: " + ex.Message);
                }
            }
        }
    }
}
