using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace inventario
{
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();
            this.Load += ventas_Load;
            ConfigurarGrid();

        }

        private void ConfigurarGrid()
        {
            gridProducts.AutoGenerateColumns = false;

            gridProducts.Columns.Add("id_pro", "ID Producto");
            gridProducts.Columns.Add("producto", "Producto");
            gridProducts.Columns.Add("cantidad", "Cantidad");
            gridProducts.Columns.Add("precio", "Precio");

            gridProducts.Columns["id_pro"].DataPropertyName = "id_pro";
            gridProducts.Columns["producto"].DataPropertyName = "producto";
            gridProducts.Columns["cantidad"].DataPropertyName = "cantidad";
            gridProducts.Columns["precio"].DataPropertyName = "precio";

            gridProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ventas_Load(object sender, EventArgs e)
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
                    string query = "SELECT id_pro, producto, cantidad, precio FROM product";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            gridProducts.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void btnagregarc_Click(object sender, EventArgs e)
        {
            if (gridProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridProducts.SelectedRows[0];
                int idProducto = Convert.ToInt32(selectedRow.Cells["id_pro"].Value);
                string producto = selectedRow.Cells["producto"].Value.ToString();
                int cantidad = Convert.ToInt32(selectedRow.Cells["cantidad"].Value);
                int precio = Convert.ToInt32(selectedRow.Cells["precio"].Value);

                if (cantidad > 0)
                {
                    AgregarProductoACompras(idProducto, producto, 1, precio);
                    ActualizarCantidadProducto(idProducto, cantidad - 1);
                    LoadDataToGrid(); 
                }
                else
                {
                    MessageBox.Show("No hay suficiente cantidad en el inventario.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para agregar al carrito.");
            }
        }

        private void AgregarProductoACompras(int idProducto, string producto, int cantidad, int precio)
        {
            string connectionString = "server=127.0.0.1;database=logins;uid=root;pwd=1234;";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO compras (id_pro, producto, cantidad, precio) VALUES (@id_pro, @producto, @cantidad, @precio)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_pro", idProducto);
                        cmd.Parameters.AddWithValue("@producto", producto);
                        cmd.Parameters.AddWithValue("@cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el producto al carrito: " + ex.Message);
                }
            }
        }

        private void ActualizarCantidadProducto(int idProducto, int nuevaCantidad)
        {
            string connectionString = "server=127.0.0.1;database=logins;uid=root;pwd=1234;";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE product SET cantidad = @cantidad WHERE id_pro = @id_pro";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", nuevaCantidad);
                        cmd.Parameters.AddWithValue("@id_pro", idProducto);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la cantidad del producto: " + ex.Message);
                }
            }
        }

        private void ventas_Load_1(object sender, EventArgs e)
        {

        }
    }
}
