namespace inventario
{
    partial class inventario
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
            this.components = new System.ComponentModel.Container();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteProduct.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(968, 440);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(124, 46);
            this.btnDeleteProduct.TabIndex = 9;
            this.btnDeleteProduct.Text = "Eliminar";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditProduct.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Location = new System.Drawing.Point(968, 362);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(124, 46);
            this.btnEditProduct.TabIndex = 10;
            this.btnEditProduct.Text = "Editar";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProduct.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(968, 288);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(124, 46);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Agregar";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(50, 178);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(762, 38);
            this.txtSearch.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(424, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar un producto";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButton1.BackColor = System.Drawing.Color.MediumOrchid;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(825, 178);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(66, 38);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Violet;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1122, 3);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(51, 52);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PRODUCTO,
            this.CANTIDAD,
            this.PRECIO});
            this.dataGridView1.GridColor = System.Drawing.Color.MediumOrchid;
            this.dataGridView1.Location = new System.Drawing.Point(36, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(888, 390);
            this.dataGridView1.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.HeaderText = "PRODUCTO";
            this.PRODUCTO.MinimumWidth = 8;
            this.PRODUCTO.Name = "PRODUCTO";
            this.PRODUCTO.ReadOnly = true;
            this.PRODUCTO.Width = 150;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.MinimumWidth = 8;
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Width = 150;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.MinimumWidth = 8;
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.Width = 150;
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(1178, 788);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inventario";
            this.Load += new System.EventHandler(this.inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptButtonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autoScrollDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autoSizeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoSizeModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoValidateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formBorderStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancelButtonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn controlBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn helpButtonDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn iconDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMdiContainerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn keyPreviewDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainMenuStripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn maximizeBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn minimizeBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rightToLeftLayoutDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn showInTaskbarDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn showIconDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeGripStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn topMostDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transparencyKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windowStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoScrollMarginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoScrollMinSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibleDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibleRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allowDropDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anchorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn backgroundImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backgroundImageLayoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn causesValidationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextMenuStripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBindingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foreColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightToLeftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useWaitCursorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn visibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paddingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
    }
}