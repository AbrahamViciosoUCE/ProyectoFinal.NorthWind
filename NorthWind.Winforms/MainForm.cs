using NorthWind.Infrastructure;
using NorthWind.Winforms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.Winforms
{
    public partial class MainForm : Form
    {
        private readonly ProductUserControl _productUserControl;
        private readonly SupplierUserControl _supplierUserControl;

        public CategoryUserControl _categoryUserControl { get; }

        public MainForm(ProductUserControl productUserControl, CategoryUserControl categoryUserControl, SupplierUserControl supplierUserControl)
        {
            InitializeComponent();
            _productUserControl = productUserControl;
            _categoryUserControl = categoryUserControl;
            this._supplierUserControl = supplierUserControl;
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _productUserControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(_productUserControl);

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _categoryUserControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(_categoryUserControl);

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _supplierUserControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(_supplierUserControl);
        }
    }
}
