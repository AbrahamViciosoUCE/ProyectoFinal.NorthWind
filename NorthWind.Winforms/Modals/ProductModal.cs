using NorthWind.Application.Abstractions;
using NorthWind.Application.Services.CategoryService;
using NorthWind.Application.Services.ProductService;
using NorthWind.Application.Services.SupplierService;
using NorthWind.Application.ViewModels;
using NorthWind.Infrastructure;
using NorthWind.Winforms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.Winforms.Modals
{
    public partial class ProductModal : Form
    {
        public ModalMode modalMode = ModalMode.Create;

        public ProductViewModel _productViewModel;

        public ICategoryService _categoryService;

        public ISupplierService _supplierService;

        public IProductService _productService;

        public ProductModal(ISupplierService supplierService,
                            ICategoryService categoryService,
                            IProductService productService)
        {
            InitializeComponent();

            _supplierService = supplierService;
            _categoryService = categoryService;
            _productService = productService;
            supplierComboBox.DataSource = _supplierService.GetAllSuppliers().ToList();
            supplierComboBox.DisplayMember = nameof(Supplier.CompanyName);
            supplierComboBox.ValueMember = nameof(Supplier.SupplierId);

            categoryComboBox.DataSource = _categoryService.GetAllCategories().ToList();
            categoryComboBox.DisplayMember = nameof(Category.CategoryName);
            categoryComboBox.ValueMember = nameof(Category.CategoryId);
        }

        private void ProductModal_Load(object sender, EventArgs e)
        {
            productBindingSource.Add(_productViewModel);
        }

        private void ProductModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            productBindingSource.Clear();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (modalMode == ModalMode.Create) {
                _productService.CreateProduct(_productViewModel);
            }else if (modalMode == ModalMode.Edit)
            {
                _productService.EditProduct(_productViewModel);
            }
        }
    }
}
