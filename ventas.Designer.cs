namespace inventario
{
    partial class ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.btncomprar = new System.Windows.Forms.Button();
            this.btnagregarc = new System.Windows.Forms.Button();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AllowUserToResizeColumns = false;
            this.gridProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.gridProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.gridProducts.BackgroundColor = System.Drawing.Color.White;
            this.gridProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.gridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProducts.DefaultCellStyle = dataGridViewCellStyle18;
            this.gridProducts.EnableHeadersVisualStyles = false;
            this.gridProducts.GridColor = System.Drawing.Color.WhiteSmoke;
            this.gridProducts.Location = new System.Drawing.Point(54, 166);
            this.gridProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridProducts.MultiSelect = false;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.gridProducts.RowHeadersVisible = false;
            this.gridProducts.RowHeadersWidth = 25;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridProducts.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.gridProducts.RowTemplate.Height = 25;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Size = new System.Drawing.Size(902, 465);
            this.gridProducts.TabIndex = 15;
            // 
            // btncomprar
            // 
            this.btncomprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btncomprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncomprar.FlatAppearance.BorderSize = 0;
            this.btncomprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomprar.ForeColor = System.Drawing.Color.White;
            this.btncomprar.Location = new System.Drawing.Point(1026, 248);
            this.btncomprar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncomprar.Name = "btncomprar";
            this.btncomprar.Size = new System.Drawing.Size(124, 46);
            this.btncomprar.TabIndex = 16;
            this.btncomprar.Text = "Comprar";
            this.btncomprar.UseVisualStyleBackColor = false;
            // 
            // btnagregarc
            // 
            this.btnagregarc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnagregarc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarc.FlatAppearance.BorderSize = 0;
            this.btnagregarc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarc.ForeColor = System.Drawing.Color.White;
            this.btnagregarc.Location = new System.Drawing.Point(1026, 338);
            this.btnagregarc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnagregarc.Name = "btnagregarc";
            this.btnagregarc.Size = new System.Drawing.Size(124, 88);
            this.btnagregarc.TabIndex = 17;
            this.btnagregarc.Text = "Agregar al Carrito";
            this.btnagregarc.UseVisualStyleBackColor = false;
            // 
            // txtSearch2
            // 
            this.txtSearch2.BackColor = System.Drawing.Color.White;
            this.txtSearch2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch2.Location = new System.Drawing.Point(148, 91);
            this.txtSearch2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch2.Multiline = true;
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(746, 26);
            this.txtSearch2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar un producto";
            // 
            // ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1196, 758);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch2);
            this.Controls.Add(this.btnagregarc);
            this.Controls.Add(this.btncomprar);
            this.Controls.Add(this.gridProducts);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ventas";
            this.Text = "ventas";
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.Button btncomprar;
        private System.Windows.Forms.Button btnagregarc;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.Label label1;
    }
}