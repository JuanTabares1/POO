using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace inventario
{
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();

            txtSearch.TextChanged += txtSearch_TextChanged;

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

        private void LoadDataToGrid()
        {
            string connectionString = "server=localhost;database=logins;uid=root;pwd=1234;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id_pro, producto, cantidad, precio FROM product";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
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

        private void inventario_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form MsgBox = new MsgBox();
            MsgBox.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
   
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form agregar = new agregar();
            agregar.Show();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (gridProducts.SelectedRows.Count > 0)
            {
                int id_pro = Convert.ToInt32(gridProducts.SelectedRows[0].Cells["id_pro"].Value);
                string producto = gridProducts.SelectedRows[0].Cells["producto"].Value.ToString();
                int cantidad = Convert.ToInt32(gridProducts.SelectedRows[0].Cells["cantidad"].Value);
                decimal precio = Convert.ToDecimal(gridProducts.SelectedRows[0].Cells["precio"].Value);

                // Abrir el formulario de edición y pasar los datos
                editar editForm = new editar(id_pro, producto, cantidad, precio);
                editForm.ShowDialog();
                LoadDataToGrid(); // Recargar datos después de cerrar el formulario de edición
            }
            else
            {
                MessageBox.Show("Selecciona un producto para editar.");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (gridProducts.SelectedRows.Count > 0)
            {
                int id_pro = Convert.ToInt32(gridProducts.SelectedRows[0].Cells["id_pro"].Value);

                string connectionString = "server=localhost;database=logins;uid=root;pwd=1234;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string query = "DELETE FROM product WHERE id_pro = @id_pro";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id_pro", id_pro);

                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Producto eliminado correctamente.");
                                LoadDataToGrid();
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar el producto.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar.");
            }
        }

        private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Filtrar los datos en el DataGridView según el texto del txtSearch
            string filter = txtSearch.Text.ToLower();
            string connectionString = "server=localhost;database=logins;uid=root;pwd=1234;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Consulta SQL para obtener los datos de la tabla 'product'
                    string query = "SELECT id_pro, producto, cantidad, precio FROM product WHERE LOWER(producto) LIKE @filter";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Asignar el DataTable como fuente de datos del DataGridView
                            gridProducts.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar productos: " + ex.Message);
                }
            }
        }
    }
}
