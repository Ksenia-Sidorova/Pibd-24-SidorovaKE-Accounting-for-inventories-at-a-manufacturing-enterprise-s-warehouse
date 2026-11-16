using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private readonly IMaterialRepository _materialRepository;
        private readonly IProductRepository _productRepository;
        private readonly ISkladOperationRepository _operationRepository;
        private readonly IZaavkaNaZakupkyRepository _zaavkaRepository;

        public MainForm(
            IMaterialRepository materialRepository,
            IProductRepository productRepository,
            ISkladOperationRepository operationRepository,
            IZaavkaNaZakupkyRepository zaavkaRepository)
        {
            InitializeComponent();
            _materialRepository = materialRepository;
            _productRepository = productRepository;
            _operationRepository = operationRepository;
            _zaavkaRepository = zaavkaRepository;
        }

        private void MaterialsMenu_Click(object sender, EventArgs e)
        {
            var form = new MaterialForm(_materialRepository);
            form.ShowDialog();
        }

        private void ProductiaMenu_Click(object sender, EventArgs e)
        {
            var form = new ProductForm(_productRepository);
            form.ShowDialog();
        }

        private void SkladskiiOperacii_Click(object sender, EventArgs e)
        {
            var form = new SkladOperationForm(_operationRepository);
            form.ShowDialog();
        }

        private void ZaavkiMenu_Click(object sender, EventArgs e)
        {
            var form = new ZaavkaForm(_zaavkaRepository);
            form.ShowDialog();
        }
    }
}