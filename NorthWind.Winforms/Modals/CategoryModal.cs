using NorthWind.Application.Services.CategoryService;
using NorthWind.Infrastructure;
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
    public partial class CategoryModal : Form
    {
        public Category _categoryViewModel = new Category();
        public Enums.ModalMode modalMode = Enums.ModalMode.Create;
        private readonly ICategoryService _categoryService;

        public CategoryModal(ICategoryService categoryService)
        {
            InitializeComponent();
            this._categoryService = categoryService;
        }

        private void CategoryModal_Load(object sender, EventArgs e)
        {
            categorybindingSource.Add(_categoryViewModel);
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (modalMode == Enums.ModalMode.Create)
            {
                _categoryService.CreateCategory(_categoryViewModel);
            }
            else if (modalMode == Enums.ModalMode.Edit)
            {
                _categoryService.EditCategory(_categoryViewModel);
            }
        }

        private void CategoryModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            modalMode = Enums.ModalMode.Edit;
            _categoryViewModel = new Category();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertArrayToImage(byte[] bytes)
        {
            pictureBox1.Image = Image.FromStream(new MemoryStream(bytes));
        }

        private void categorybindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            convertArrayToImage(_categoryViewModel.Picture);
        }
    }
}
