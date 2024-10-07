using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace inventario
{
    public partial class agregar : Form
    {
        public agregar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string connectionString = "server=localhost;database=logins;uid=root;pwd=1234;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Consulta SQL de inserción
                    string query = "INSERT INTO product (id_pro, producto, cantidad, precio) VALUES (@id_pro, @producto, @cantidad, @precio)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Parámetros para evitar inyecciones SQL
                        cmd.Parameters.AddWithValue("@id_pro", textBoxid.Text);
                        cmd.Parameters.AddWithValue("@producto", textBoxpro.Text);
                        cmd.Parameters.AddWithValue("@cantidad", textBoxcant.Text);
                        cmd.Parameters.AddWithValue("@precio", textBoxpre.Text);

                        // Ejecutar el comando
                        int result = cmd.ExecuteNonQuery();

                        // Verificar si la inserción fue exitosa
                        if (result > 0)
                        {
                            MessageBox.Show("Producto agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el producto.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxpro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxcant_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxpre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
