using NorthWind.Application.Services.SupplierService;
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

        public SupplierModal _supplierModal { get; }

        public SupplierUserControl(ISupplierService supplierService, SupplierModal supplierModal)
        {
            InitializeComponent();
            this._supplierService = supplierService;
            _supplierModal = supplierModal;
        }

        private void SupplierUserControl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _supplierService.GetAllSuppliers().ToList();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _supplierModal.ShowDialog();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _supplierModal.modalMode = Enums.ModalMode.Edit;
            _supplierModal._supplierViewModel = (Supplier)dataGridView1.SelectedRows[0].DataBoundItem;
            _supplierModal.ShowDialog();
            
        }
    }
}
