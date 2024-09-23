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
        private void ActivateButton(object btnsander)
        {
            if (btnsander != null)
            {
                if (currentButton != (Button)btnsander)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsander;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    paneltitlebar.BackColor = color;
                    panellogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0, 3);
                }
            }
        }


        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(224, 224, 224);
            public static Color color2 = Color.FromArgb(224, 224, 224);
            public static Color color3 = Color.FromArgb(224, 224, 224);
            public static Color color4 = Color.FromArgb(224, 224, 224);
            public static Color color5 = Color.FromArgb(224, 224, 224);
            public static Color color6 = Color.FromArgb(224, 224, 224);
            public static Color color7 = Color.FromArgb(224, 224, 224);
            public static Color color8 = Color.FromArgb(224, 224, 224);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //boton normal
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(64, 64, 64);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                iconcorrentForm.IconChar = currentBtn.IconChar;
                iconcorrentForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelcatalogosubmenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(64, 64, 64);
                    previousBtn.ForeColor = Color.DimGray;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                if (currentBtn != null)
                {
                    currentBtn.BackColor = Color.FromArgb(15, 15, 15);
                    currentBtn.ForeColor = Color.White;
                    currentBtn.IconColor = Color.White;
                }
            }

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
