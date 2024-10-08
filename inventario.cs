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
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();

            // Desactivar AutoGenerateColumns
            gridProducts.AutoGenerateColumns = false;

            // Definir manualmente las columnas
            gridProducts.Columns.Add("id_pro", "ID Producto");
            gridProducts.Columns.Add("producto", "Producto");
            gridProducts.Columns.Add("cantidad", "Cantidad");
            gridProducts.Columns.Add("precio", "Precio");

            // Asignar qué propiedad de los datos se enlaza a cada columna
            gridProducts.Columns["id_pro"].DataPropertyName = "id_pro";
            gridProducts.Columns["producto"].DataPropertyName = "producto";
            gridProducts.Columns["cantidad"].DataPropertyName = "cantidad";
            gridProducts.Columns["precio"].DataPropertyName = "precio";

            // Ajustar columnas para llenar todo el espacio del DataGridView
            gridProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Método para cargar datos en el DataGridView
        private void LoadDataToGrid()
        {
            string connectionString = "server=localhost;database=logins;uid=root;pwd=1234;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Consulta SQL para obtener los datos de la tabla 'product'
                    string query = "SELECT id_pro, producto, cantidad, precio FROM product";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
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
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        // Evento que se ejecuta cuando el formulario 'inventario' se carga
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
            this.Close();
            Form page1 = new page1();
            page1.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form agregar = new agregar();
            agregar.Show();
            this.Close();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            Form editar = new editar();
            editar.Show();
            this.Close();
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
    }
}
