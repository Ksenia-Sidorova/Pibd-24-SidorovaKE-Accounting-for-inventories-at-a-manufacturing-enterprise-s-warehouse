using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ProductForm : Form
    {
        private readonly IProductRepository _productRepository;

        public ProductForm(IProductRepository productRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            GridProducts.DataSource = null;
            GridProducts.DataSource = _productRepository.GetAll().ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var editForm = new ProductEditForm())
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    _productRepository.Add(editForm.CreatedProduct);
                    LoadData();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (GridProducts.CurrentRow == null) return;
            var selected = (Product)GridProducts.CurrentRow.DataBoundItem;

            using (var editForm = new ProductEditForm(selected.ID))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    _productRepository.Update(editForm.CreatedProduct);
                    LoadData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GridProducts.CurrentRow == null) return;
            var selected = (Product)GridProducts.CurrentRow.DataBoundItem;

            if (MessageBox.Show("Удалить продукт?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _productRepository.Delete(selected.ID);
                LoadData();
            }
        }
    }
}