namespace inventario
{
    partial class page1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(page1));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btninicio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelpadre = new System.Windows.Forms.Panel();
            this.btncarrito = new System.Windows.Forms.PictureBox();
            this.btnventas = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(0, 634);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(81, 80);
            this.btnCerrar.TabIndex = 38;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btninicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 74);
            this.panel1.TabIndex = 39;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btninicio
            // 
            this.btninicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninicio.Dock = System.Windows.Forms.DockStyle.Right;
            this.btninicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicio.ForeColor = System.Drawing.Color.White;
            this.btninicio.Location = new System.Drawing.Point(1137, 0);
            this.btninicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(165, 74);
            this.btninicio.TabIndex = 4;
            this.btninicio.Text = "Home";
            this.btninicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.btncarrito);
            this.panel2.Controls.Add(this.btnventas);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnUser);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 714);
            this.panel2.TabIndex = 40;
            // 
            // panelpadre
            // 
            this.panelpadre.BackgroundImage = global::inventario.Properties.Resources._81_811946_fondos_de_pantalla_para_pc_8k;
            this.panelpadre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelpadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelpadre.Location = new System.Drawing.Point(81, 74);
            this.panelpadre.Name = "panelpadre";
            this.panelpadre.Size = new System.Drawing.Size(1221, 714);
            this.panelpadre.TabIndex = 41;
            // 
            // btncarrito
            // 
            this.btncarrito.Image = global::inventario.Properties.Resources.pngegg;
            this.btncarrito.Location = new System.Drawing.Point(0, 130);
            this.btncarrito.Name = "btncarrito";
            this.btncarrito.Size = new System.Drawing.Size(81, 60);
            this.btncarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncarrito.TabIndex = 42;
            this.btncarrito.TabStop = false;
            this.btncarrito.Click += new System.EventHandler(this.btncarrito_Click);
            // 
            // btnventas
            // 
            this.btnventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnventas.Image = global::inventario.Properties.Resources._3301793f04334afbd270693ae85dd0dc;
            this.btnventas.Location = new System.Drawing.Point(0, 0);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(81, 60);
            this.btnventas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnventas.TabIndex = 41;
            this.btnventas.TabStop = false;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::inventario.Properties.Resources._2906274;
            this.pictureBox2.Location = new System.Drawing.Point(0, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.Location = new System.Drawing.Point(0, 196);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(81, 54);
            this.btnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUser.TabIndex = 39;
            this.btnUser.TabStop = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventario.Properties.Resources.Default_A_stylized_logo_for_Game_Store_a_fusion_of_modern_gami_1_d832442e_1296_4ba8_8fba_a160bd71a3d3_0;
            this.pictureBox1.Location = new System.Drawing.Point(0, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1302, 788);
            this.Controls.Add(this.panelpadre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "page1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btninicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelpadre;
        private System.Windows.Forms.PictureBox btnventas;
        private System.Windows.Forms.PictureBox btncarrito;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}