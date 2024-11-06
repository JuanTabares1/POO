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

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No hay productos en el carrito.");
                        }

                        gridCarrito.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el carrito: " + ex.Message);
                }
            }
        }
    }
}
