using NorthWind.Application.Abstractions;

namespace NorthWind.Winforms
{
    public partial class MainForm : Form
    {
        IProductRepository _productRepository { get; set; }
        public MainForm(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            InitializeComponent();

            dataGridView1.DataSource = _productRepository.GetProducts().ToList();
        }
    }
}
