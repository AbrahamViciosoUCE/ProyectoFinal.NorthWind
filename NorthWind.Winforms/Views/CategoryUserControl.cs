using NorthWind.Application.Services.CategoryService;
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
            dataGridView.DataSource = _categoryService.GetAllCategories().ToList();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _categoryModal.modalMode = Enums.ModalMode.Create;
            _categoryModal.ShowDialog();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _categoryModal.modalMode = Enums.ModalMode.Edit;
            _categoryModal._categoryViewModel = (Category)dataGridView.SelectedRows[0].DataBoundItem;
            _categoryModal.ShowDialog();
        }
    }
}
