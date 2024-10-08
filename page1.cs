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
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;

namespace inventario
{
    public partial class page1 : Form
    {
        
        private Random random;
        private int tempIndex;
        private IconButton currentBtn;
        public page1()
        {
            InitializeComponent();
         
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form MsgBox = new MsgBox();
            MsgBox.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUser_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new usuario());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inventario());
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelpadre.Controls.Count > 0)
                this.panelpadre.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelpadre.Controls.Add(fh);
            this.panelpadre.Tag = fh;
            fh.Show();

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inicio());
        }
    }
}
