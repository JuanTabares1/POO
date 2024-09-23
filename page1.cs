using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Color = System.Drawing.Color;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Reflection;

namespace inventario
{
    public partial class page1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public page1()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            customizeDesing();
        }

        private Color SelectThemeColor()
        {

            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Form inventario = new inventario();
            inventario.Show();

            this.Hide();
        }
     

        
    }
}
