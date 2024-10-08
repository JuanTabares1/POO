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
    public partial class editar : Form
    {
        public editar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form inventario = new inventario();
            inventario.Show();
            this.Close();
        }
    }
}
