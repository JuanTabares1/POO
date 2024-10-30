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

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No se encontraron productos.");  
                            }

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
    }
}
