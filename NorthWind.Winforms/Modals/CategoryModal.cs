using NorthWind.Application.Services.CategoryService;
using NorthWind.Application.ViewModels;
using NorthWind.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, ImageFormat.Png);
                _categoryViewModel.Picture = ms.ToArray();
            }

            if (modalMode == Enums.ModalMode.Create)
            {
                try
                {
                    _categoryViewModel = _categoryService.CreateCategory(_categoryViewModel).First();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Error", exp.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.Cancel;
                }
            }
            else if (modalMode == Enums.ModalMode.Edit)
            {
                try
                {
                    _categoryViewModel = _categoryService.EditCategory(_categoryViewModel).First();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Error", exp.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.Cancel;
                }

            }
            this.Close();
        }

        private void CategoryModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            modalMode = Enums.ModalMode.Edit;
            categorybindingSource.Clear();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categorybindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }
    }
}
