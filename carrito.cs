using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace inventario
{
    public partial class carrito : Form
    {
        public carrito()
        {
            InitializeComponent();
            this.Load += carrito_Load;
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            gridCarrito.AutoGenerateColumns = false;

            gridCarrito.Columns.Add("id_pro", "ID Producto");
            gridCarrito.Columns.Add("producto", "Producto");
            gridCarrito.Columns.Add("cantidad", "Cantidad");
            gridCarrito.Columns.Add("precio", "Precio");

            gridCarrito.Columns["id_pro"].DataPropertyName = "id_pro";
            gridCarrito.Columns["producto"].DataPropertyName = "producto";
            gridCarrito.Columns["cantidad"].DataPropertyName = "cantidad";
            gridCarrito.Columns["precio"].DataPropertyName = "precio";

            gridCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void carrito_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            string connectionString = "server=127.0.0.1;database=logins;uid=root;pwd=1234;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT id_pro, producto, cantidad, precio FROM compras";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        gridCarrito.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el carrito: " + ex.Message);
                }
            }
        }

        private void btnbuyall_Click(object sender, EventArgs e)
        {
            Form pago = new pago();
            pago.Show();

            string connectionString = "server=127.0.0.1;database=logins;uid=root;pwd=1234;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM compras";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    LoadDataToGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al comprar los productos del carrito: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gridCarrito.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(gridCarrito.SelectedRows[0].Cells["id_pro"].Value);

                string connectionString = "server=127.0.0.1;database=logins;uid=root;pwd=1234;";
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM compras WHERE id_pro = @id_pro"; 
                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id_pro", idProducto);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("El producto seleccionado ha sido eliminado del carrito.");
                        LoadDataToGrid();  
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el producto seleccionado del carrito: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
            }
        }
    }
}
