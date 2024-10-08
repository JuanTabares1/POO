using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace inventario
{
    public partial class editar : Form
    {
        private int id_pro;

        public editar(int id_pro, string producto, int cantidad, decimal precio)
        {
            InitializeComponent();
            this.id_pro = id_pro;
            textBox1.Text = id_pro.ToString(); 
            textBoxpro.Text = producto;    
            textBoxcant.Text = cantidad.ToString(); 
            textBoxpre.Text = precio.ToString("F2"); 
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

                    string query = "UPDATE product SET producto = @producto, cantidad = @cantidad, precio = @precio WHERE id_pro = @id_pro";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_pro", id_pro);
                        cmd.Parameters.AddWithValue("@producto", textBoxpro.Text);
                        cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(textBoxcant.Text));
                        cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(textBoxpre.Text));

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Producto editado correctamente.");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error al editar el producto.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
