﻿namespace inventario
{
    partial class usuario
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtreuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventario.Properties.Resources.R;
            this.pictureBox1.Location = new System.Drawing.Point(313, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtreuser
            // 
            this.txtreuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtreuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtreuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtreuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreuser.ForeColor = System.Drawing.Color.White;
            this.txtreuser.Location = new System.Drawing.Point(192, 194);
            this.txtreuser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtreuser.Name = "txtreuser";
            this.txtreuser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtreuser.Size = new System.Drawing.Size(382, 17);
            this.txtreuser.TabIndex = 25;
            this.txtreuser.Text = "CAMBIAR NOMBRE DE USUARIO";
            this.txtreuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtreuser.Enter += new System.EventHandler(this.txtreuser_Enter);
            this.txtreuser.Leave += new System.EventHandler(this.txtreuser_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(277, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "______________________________";
            // 
            // txtrpass
            // 
            this.txtrpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtrpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtrpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrpass.ForeColor = System.Drawing.Color.White;
            this.txtrpass.Location = new System.Drawing.Point(161, 257);
            this.txtrpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtrpass.Name = "txtrpass";
            this.txtrpass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtrpass.Size = new System.Drawing.Size(429, 17);
            this.txtrpass.TabIndex = 33;
            this.txtrpass.Text = "CAMBIAR CONTRASEÑA";
            this.txtrpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrpass.Enter += new System.EventHandler(this.txtrpass_Enter);
            this.txtrpass.Leave += new System.EventHandler(this.txtrpass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(268, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "______________________________";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(280, 352);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(205, 51);
            this.btn_guardar.TabIndex = 35;
            this.btn_guardar.Text = "Guardar Cambios";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(909, 486);
            this.ControlBox = false;
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txtrpass);
            this.Controls.Add(this.txtreuser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "usuario";
            this.Load += new System.EventHandler(this.usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtreuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guardar;
    }
}