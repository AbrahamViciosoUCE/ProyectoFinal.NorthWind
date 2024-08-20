using NorthWind.Application.Services.ProductService;
using NorthWind.Application.ViewModels;
using NorthWind.Infrastructure;
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
        private BindingList<ProductViewModel> productViewModelsBindingList;

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
            _productModal._productViewModel = new ProductViewModel();
            _productModal.modalMode = Enums.ModalMode.Create;
            if (_productModal.ShowDialog() == DialogResult.OK)
            {
                productViewModelsBindingList.Add(_productModal._productViewModel);
            }
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {
            productViewModelsBindingList = new BindingList<ProductViewModel>(_productService.GetAllProducts().ToList());
            dataGridView.DataSource = productViewModelsBindingList;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductViewModel productViewModelSelected = (ProductViewModel)dataGridView.SelectedRows[0].DataBoundItem;
            _productModal._productViewModel = productViewModelSelected;
            _productModal.modalMode = Enums.ModalMode.Edit;
            if (_productModal.ShowDialog() == DialogResult.OK)
            {
                productViewModelsBindingList.ResetItem(dataGridView.SelectedRows[0].Index);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You want delete this record?","Warning",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _productService.DeleteProduct((ProductViewModel)dataGridView.SelectedRows[0].DataBoundItem);
                    productViewModelsBindingList.Remove((ProductViewModel)dataGridView.SelectedRows[0].DataBoundItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error this element is indelible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
