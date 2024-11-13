namespace inventario
{
    partial class pago
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
            this.txtntarjeta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcvc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnpagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtntarjeta
            // 
            this.txtntarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtntarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtntarjeta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtntarjeta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtntarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtntarjeta.ForeColor = System.Drawing.Color.White;
            this.txtntarjeta.Location = new System.Drawing.Point(63, 241);
            this.txtntarjeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtntarjeta.Name = "txtntarjeta";
            this.txtntarjeta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtntarjeta.Size = new System.Drawing.Size(429, 28);
            this.txtntarjeta.TabIndex = 32;
            this.txtntarjeta.Text = "Numero de Tarjeta";
            this.txtntarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtntarjeta.TextChanged += new System.EventHandler(this.txtntarjeta_TextChanged);
            this.txtntarjeta.Enter += new System.EventHandler(this.txtntarjeta_Enter);
            this.txtntarjeta.Leave += new System.EventHandler(this.txtntarjeta_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "_______________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "Agregar Targeta de Credito/Debito";
            // 
            // txtfecha
            // 
            this.txtfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.ForeColor = System.Drawing.Color.White;
            this.txtfecha.Location = new System.Drawing.Point(62, 336);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtfecha.Size = new System.Drawing.Size(429, 28);
            this.txtfecha.TabIndex = 35;
            this.txtfecha.Text = "Fecha Expedicion";
            this.txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfecha.Enter += new System.EventHandler(this.txtfecha_Enter);
            this.txtfecha.Leave += new System.EventHandler(this.txtfecha_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "_______________________________________________";
            // 
            // txtcvc
            // 
            this.txtcvc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtcvc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtcvc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcvc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcvc.ForeColor = System.Drawing.Color.White;
            this.txtcvc.Location = new System.Drawing.Point(63, 416);
            this.txtcvc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcvc.Name = "txtcvc";
            this.txtcvc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcvc.Size = new System.Drawing.Size(429, 28);
            this.txtcvc.TabIndex = 37;
            this.txtcvc.Text = "Pin";
            this.txtcvc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcvc.Enter += new System.EventHandler(this.txtcvc_Enter);
            this.txtcvc.Leave += new System.EventHandler(this.txtcvc_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 438);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(432, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "_______________________________________________";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtdireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.ForeColor = System.Drawing.Color.White;
            this.txtdireccion.Location = new System.Drawing.Point(537, 416);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtdireccion.Size = new System.Drawing.Size(429, 28);
            this.txtdireccion.TabIndex = 39;
            this.txtdireccion.Text = "Direccion(obligatorio)";
            this.txtdireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdireccion.Enter += new System.EventHandler(this.txtdireccion_Enter);
            this.txtdireccion.Leave += new System.EventHandler(this.txtdireccion_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(533, 438);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(432, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "_______________________________________________";
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.White;
            this.txtnombre.Location = new System.Drawing.Point(537, 241);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtnombre.Size = new System.Drawing.Size(429, 28);
            this.txtnombre.TabIndex = 41;
            this.txtnombre.Text = "Nombre del Titular";
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnombre.Enter += new System.EventHandler(this.txtnombre_Enter);
            this.txtnombre.Leave += new System.EventHandler(this.txtnombre_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(533, 263);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(432, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "_______________________________________________";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtcodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.White;
            this.txtcodigo.Location = new System.Drawing.Point(535, 336);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcodigo.Size = new System.Drawing.Size(429, 28);
            this.txtcodigo.TabIndex = 43;
            this.txtcodigo.Text = "Codigo Postal";
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcodigo.Enter += new System.EventHandler(this.txtcodigo_Enter);
            this.txtcodigo.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(531, 358);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(432, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "_______________________________________________";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(112, 575);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(240, 46);
            this.btncancelar.TabIndex = 45;
            this.btncancelar.Text = "Cancelar Pago";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnpagar
            // 
            this.btnpagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnpagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpagar.FlatAppearance.BorderSize = 0;
            this.btnpagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagar.ForeColor = System.Drawing.Color.White;
            this.btnpagar.Location = new System.Drawing.Point(658, 575);
            this.btnpagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(240, 46);
            this.btnpagar.TabIndex = 46;
            this.btnpagar.Text = "Pagar";
            this.btnpagar.UseVisualStyleBackColor = false;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(997, 675);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcvc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtntarjeta);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pago";
            this.Load += new System.EventHandler(this.pago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtntarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcvc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnpagar;
    }
}