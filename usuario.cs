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

        private void button2_Click(object sender, EventArgs e)
        {
            Form MsgBox = new MsgBox();
            MsgBox.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form page1 = new page1();
            page1.Show();
        }
    }
}
