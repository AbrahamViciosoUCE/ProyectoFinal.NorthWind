using NorthWind.Application.Services.SupplierService;
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
    public partial class SupplierUserControl : UserControl
    {
        private readonly ISupplierService _supplierService;
        private BindingList<Supplier> _supplierBindingList;

        public SupplierModal _supplierModal { get; }

        public SupplierUserControl(ISupplierService supplierService, SupplierModal supplierModal)
        {
            InitializeComponent();
            this._supplierService = supplierService;
            _supplierModal = supplierModal;
        }

        private void SupplierUserControl_Load(object sender, EventArgs e)
        {
            _supplierBindingList = new BindingList<Supplier>(_supplierService.GetAllSuppliers().ToList());
            dataGridView1.DataSource = _supplierBindingList;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_supplierModal.ShowDialog() == DialogResult.OK)
            {
                _supplierBindingList.Add(_supplierModal._supplierViewModel);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _supplierModal.modalMode = Enums.ModalMode.Edit;
            Supplier supplierSelected = (Supplier)dataGridView1.SelectedRows[0].DataBoundItem;
            _supplierModal._supplierViewModel = supplierSelected;
            if (_supplierModal.ShowDialog() == DialogResult.OK)
            {
                _supplierBindingList.ResetItem(dataGridView1.SelectedRows[0].Index);
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want delete this record?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _supplierService.DeleteSupplier((Supplier)dataGridView1.SelectedRows[0].DataBoundItem);
                    _supplierBindingList.Remove((Supplier)dataGridView1.SelectedRows[0].DataBoundItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error this element is indelible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
