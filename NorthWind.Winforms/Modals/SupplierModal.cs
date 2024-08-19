using NorthWind.Application.Services.SupplierService;
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
    public partial class SupplierModal : Form
    {
        public Enums.ModalMode modalMode = Enums.ModalMode.Create;
        private readonly ISupplierService _supplierService;
        public Supplier _supplierViewModel = new Supplier();

        public SupplierModal(ISupplierService supplierService)
        {
            InitializeComponent();
            this._supplierService = supplierService;
        }

        private void SupplierModal_Load(object sender, EventArgs e)
        {
            supplierBindingSource.Add(_supplierViewModel);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            modalMode = Enums.ModalMode.Create;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (modalMode == Enums.ModalMode.Create)
            {
                _supplierService.CreateSupplier(_supplierViewModel);
            }
            else if (modalMode == Enums.ModalMode.Edit)
            {
                _supplierService.EditSupplier(_supplierViewModel);

            }
            this.Close();
        }

        private void SupplierModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            _supplierViewModel = new Supplier();
            supplierBindingSource.Clear();
        }

    }
}
