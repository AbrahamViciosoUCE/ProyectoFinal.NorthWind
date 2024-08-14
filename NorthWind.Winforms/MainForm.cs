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

        public MainForm(ProductUserControl productUserControl)
        {
            InitializeComponent();
            _productUserControl = productUserControl;
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _productUserControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(_productUserControl);

        }
    }
}
