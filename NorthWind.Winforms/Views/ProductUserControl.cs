using NorthWind.Application.ProductService;
using NorthWind.Winforms.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.Winforms.Views
{
    public partial class ProductUserControl : UserControl
    {
        private readonly IProductService _productService;
        private ProductModal _productModal;

        public ProductUserControl(
            IProductService productService,
            ProductModal productModal
        )
        {
            InitializeComponent();
            _productService = productService;
            _productModal = productModal;
        }

       
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _productModal.ShowDialog();
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productService.GetAllProducts().ToList();
        }
    }
}
