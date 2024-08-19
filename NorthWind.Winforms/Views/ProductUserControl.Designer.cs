namespace NorthWind.Winforms.Views
{
    partial class ProductUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUserControl));
            dataGridView = new DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            SupplierId = new DataGridViewTextBoxColumn();
            CategoryId = new DataGridViewTextBoxColumn();
            QuantityPerUnit = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            UnitsInStock = new DataGridViewTextBoxColumn();
            UnitsOnOrder = new DataGridViewTextBoxColumn();
            ReorderLevel = new DataGridViewTextBoxColumn();
            Discontinued = new DataGridViewCheckBoxColumn();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarcomoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            vistapreviadeimpresiónToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductName, SupplierName, CategoryName, SupplierId, CategoryId, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 24);
            dataGridView.Name = "dataGridView";
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(763, 543);
            dataGridView.TabIndex = 1;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "ProductId";
            ProductId.Name = "ProductId";
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 100;
            ProductName.Name = "ProductName";
            // 
            // SupplierName
            // 
            SupplierName.DataPropertyName = "SupplierName";
            SupplierName.HeaderText = "SupplierName";
            SupplierName.Name = "SupplierName";
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "CategoryName";
            CategoryName.Name = "CategoryName";
            // 
            // SupplierId
            // 
            SupplierId.DataPropertyName = "SupplierId";
            SupplierId.HeaderText = "SupplierId";
            SupplierId.Name = "SupplierId";
            SupplierId.Visible = false;
            // 
            // CategoryId
            // 
            CategoryId.DataPropertyName = "CategoryId";
            CategoryId.HeaderText = "CategoryId";
            CategoryId.Name = "CategoryId";
            CategoryId.Visible = false;
            // 
            // QuantityPerUnit
            // 
            QuantityPerUnit.DataPropertyName = "QuantityPerUnit";
            QuantityPerUnit.HeaderText = "QuantityPerUnit";
            QuantityPerUnit.Name = "QuantityPerUnit";
            // 
            // UnitPrice
            // 
            UnitPrice.DataPropertyName = "UnitPrice";
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.Name = "UnitPrice";
            // 
            // UnitsInStock
            // 
            UnitsInStock.DataPropertyName = "UnitsInStock";
            UnitsInStock.HeaderText = "UnitsInStock";
            UnitsInStock.Name = "UnitsInStock";
            // 
            // UnitsOnOrder
            // 
            UnitsOnOrder.DataPropertyName = "UnitsOnOrder";
            UnitsOnOrder.HeaderText = "UnitsOnOrder";
            UnitsOnOrder.Name = "UnitsOnOrder";
            // 
            // ReorderLevel
            // 
            ReorderLevel.DataPropertyName = "ReorderLevel";
            ReorderLevel.HeaderText = "ReorderLevel";
            ReorderLevel.Name = "ReorderLevel";
            // 
            // Discontinued
            // 
            Discontinued.DataPropertyName = "Discontinued";
            Discontinued.HeaderText = "Discontinued";
            Discontinued.Name = "Discontinued";
            Discontinued.Resizable = DataGridViewTriState.True;
            Discontinued.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, toolStripSeparator, guardarToolStripMenuItem, guardarcomoToolStripMenuItem, toolStripSeparator1, imprimirToolStripMenuItem, vistapreviadeimpresiónToolStripMenuItem, toolStripSeparator2, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Image = (Image)resources.GetObject("nuevoToolStripMenuItem.Image");
            nuevoToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            nuevoToolStripMenuItem.Size = new Size(206, 22);
            nuevoToolStripMenuItem.Text = "&Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Image = (Image)resources.GetObject("abrirToolStripMenuItem.Image");
            abrirToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            abrirToolStripMenuItem.Size = new Size(206, 22);
            abrirToolStripMenuItem.Text = "&Editar";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(203, 6);
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Image = (Image)resources.GetObject("guardarToolStripMenuItem.Image");
            guardarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            guardarToolStripMenuItem.Size = new Size(206, 22);
            guardarToolStripMenuItem.Text = "&Guardar";
            // 
            // guardarcomoToolStripMenuItem
            // 
            guardarcomoToolStripMenuItem.Name = "guardarcomoToolStripMenuItem";
            guardarcomoToolStripMenuItem.Size = new Size(206, 22);
            guardarcomoToolStripMenuItem.Text = "Guardar &como";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(203, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Image = (Image)resources.GetObject("imprimirToolStripMenuItem.Image");
            imprimirToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            imprimirToolStripMenuItem.Size = new Size(206, 22);
            imprimirToolStripMenuItem.Text = "&Imprimir";
            // 
            // vistapreviadeimpresiónToolStripMenuItem
            // 
            vistapreviadeimpresiónToolStripMenuItem.Image = (Image)resources.GetObject("vistapreviadeimpresiónToolStripMenuItem.Image");
            vistapreviadeimpresiónToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            vistapreviadeimpresiónToolStripMenuItem.Name = "vistapreviadeimpresiónToolStripMenuItem";
            vistapreviadeimpresiónToolStripMenuItem.Size = new Size(206, 22);
            vistapreviadeimpresiónToolStripMenuItem.Text = "&Vista previa de impresión";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(203, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(206, 22);
            salirToolStripMenuItem.Text = "&Salir";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(763, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ProductUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView);
            Controls.Add(menuStrip1);
            Name = "ProductUserControl";
            Size = new Size(763, 567);
            Load += ProductUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarcomoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem vistapreviadeimpresiónToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem salirToolStripMenuItem;
        private MenuStrip menuStrip1;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn SupplierId;
        private DataGridViewTextBoxColumn CategoryId;
        private DataGridViewTextBoxColumn QuantityPerUnit;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn UnitsInStock;
        private DataGridViewTextBoxColumn UnitsOnOrder;
        private DataGridViewTextBoxColumn ReorderLevel;
        private DataGridViewCheckBoxColumn Discontinued;
    }
}
