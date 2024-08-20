using NorthWind.Application.Services.CategoryService;
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
    public partial class CategoryUserControl : UserControl
    {
        private BindingList<Category> _bindingListCategory;
        private readonly ICategoryService _categoryService;
        private CategoryModal _categoryModal { get; }

        public CategoryUserControl(ICategoryService categoryService, CategoryModal categoryModal)
        {
            InitializeComponent();
            this._categoryService = categoryService;
            _categoryModal = categoryModal;
        }


        private void CategoryUserControl_Load(object sender, EventArgs e)
        {
            _bindingListCategory = new BindingList<Category>(_categoryService.GetAllCategories().ToList());
            dataGridView.DataSource = _bindingListCategory;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _categoryModal.modalMode = Enums.ModalMode.Create;
            if (_categoryModal.ShowDialog() == DialogResult.OK)
            {
                _bindingListCategory.Add(_categoryModal._categoryViewModel);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _categoryModal.modalMode = Enums.ModalMode.Edit;
            Category categorySelected = (Category)dataGridView.SelectedRows[0].DataBoundItem;
            _categoryModal._categoryViewModel = categorySelected;
            if (_categoryModal.ShowDialog() == DialogResult.OK)
            {
                _bindingListCategory.ResetItem(dataGridView.SelectedRows[0].Index);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want delete this record?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _categoryService.DeleteCategory((Category)dataGridView.SelectedRows[0].DataBoundItem);
                    _bindingListCategory.Remove((Category)dataGridView.SelectedRows[0].DataBoundItem);
                }
                catch (Exception ex) {
                    MessageBox.Show("Error this element is indelible","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
