namespace NorthWind.Winforms.Views
{
    partial class CategoryUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryUserControl));
            menuStrip1 = new MenuStrip();
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
            editarToolStripMenuItem = new ToolStripMenuItem();
            deshacerToolStripMenuItem = new ToolStripMenuItem();
            rehacerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cortarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            pegarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            seleccionartodoToolStripMenuItem = new ToolStripMenuItem();
            herramientasToolStripMenuItem = new ToolStripMenuItem();
            personalizarToolStripMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            contenidoToolStripMenuItem = new ToolStripMenuItem();
            índiceToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            acercadeToolStripMenuItem = new ToolStripMenuItem();
            dataGridView = new DataGridView();
            CategoryId = new DataGridViewTextBoxColumn();
            Products = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Picture = new DataGridViewImageColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem, herramientasToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(615, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
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
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deshacerToolStripMenuItem, rehacerToolStripMenuItem, toolStripSeparator3, cortarToolStripMenuItem, copiarToolStripMenuItem, pegarToolStripMenuItem, toolStripSeparator4, seleccionartodoToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // deshacerToolStripMenuItem
            // 
            deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            deshacerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            deshacerToolStripMenuItem.Size = new Size(163, 22);
            deshacerToolStripMenuItem.Text = "&Deshacer";
            // 
            // rehacerToolStripMenuItem
            // 
            rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            rehacerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            rehacerToolStripMenuItem.Size = new Size(163, 22);
            rehacerToolStripMenuItem.Text = "&Rehacer";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(160, 6);
            // 
            // cortarToolStripMenuItem
            // 
            cortarToolStripMenuItem.Image = (Image)resources.GetObject("cortarToolStripMenuItem.Image");
            cortarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            cortarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cortarToolStripMenuItem.Size = new Size(163, 22);
            cortarToolStripMenuItem.Text = "&Cortar";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Image = (Image)resources.GetObject("copiarToolStripMenuItem.Image");
            copiarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copiarToolStripMenuItem.Size = new Size(163, 22);
            copiarToolStripMenuItem.Text = "&Copiar";
            // 
            // pegarToolStripMenuItem
            // 
            pegarToolStripMenuItem.Image = (Image)resources.GetObject("pegarToolStripMenuItem.Image");
            pegarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            pegarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pegarToolStripMenuItem.Size = new Size(163, 22);
            pegarToolStripMenuItem.Text = "&Pegar";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(160, 6);
            // 
            // seleccionartodoToolStripMenuItem
            // 
            seleccionartodoToolStripMenuItem.Name = "seleccionartodoToolStripMenuItem";
            seleccionartodoToolStripMenuItem.Size = new Size(163, 22);
            seleccionartodoToolStripMenuItem.Text = "&Seleccionar todo";
            // 
            // herramientasToolStripMenuItem
            // 
            herramientasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personalizarToolStripMenuItem, opcionesToolStripMenuItem });
            herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            herramientasToolStripMenuItem.Size = new Size(90, 20);
            herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // personalizarToolStripMenuItem
            // 
            personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            personalizarToolStripMenuItem.Size = new Size(137, 22);
            personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(137, 22);
            opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contenidoToolStripMenuItem, índiceToolStripMenuItem, buscarToolStripMenuItem, toolStripSeparator5, acercadeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // contenidoToolStripMenuItem
            // 
            contenidoToolStripMenuItem.Name = "contenidoToolStripMenuItem";
            contenidoToolStripMenuItem.Size = new Size(135, 22);
            contenidoToolStripMenuItem.Text = "&Contenido";
            // 
            // índiceToolStripMenuItem
            // 
            índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            índiceToolStripMenuItem.Size = new Size(135, 22);
            índiceToolStripMenuItem.Text = "Índ&ice";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(135, 22);
            buscarToolStripMenuItem.Text = "&Buscar";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(132, 6);
            // 
            // acercadeToolStripMenuItem
            // 
            acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            acercadeToolStripMenuItem.Size = new Size(135, 22);
            acercadeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // dataGridView
            // 
            dataGridView.AllowDrop = true;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { CategoryId, Products, CategoryName, Description, Picture });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 24);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 200;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(615, 479);
            dataGridView.TabIndex = 1;
            // 
            // CategoryId
            // 
            CategoryId.DataPropertyName = "CategoryId";
            CategoryId.HeaderText = "CategoryId";
            CategoryId.Name = "CategoryId";
            // 
            // Products
            // 
            Products.DataPropertyName = "Products";
            Products.HeaderText = "Products";
            Products.Name = "Products";
            Products.Visible = false;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "CategoryName";
            CategoryName.Name = "CategoryName";
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Picture
            // 
            Picture.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Picture.DataPropertyName = "Picture";
            Picture.HeaderText = "Picture";
            Picture.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Picture.Name = "Picture";
            Picture.Resizable = DataGridViewTriState.True;
            Picture.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // CategoryUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView);
            Controls.Add(menuStrip1);
            Name = "CategoryUserControl";
            Size = new Size(615, 503);
            Load += CategoryUserControl_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
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
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem deshacerToolStripMenuItem;
        private ToolStripMenuItem rehacerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cortarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem seleccionartodoToolStripMenuItem;
        private ToolStripMenuItem herramientasToolStripMenuItem;
        private ToolStripMenuItem personalizarToolStripMenuItem;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem contenidoToolStripMenuItem;
        private ToolStripMenuItem índiceToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem acercadeToolStripMenuItem;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn CategoryId;
        private DataGridViewTextBoxColumn Products;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewImageColumn Picture;
    }
}
