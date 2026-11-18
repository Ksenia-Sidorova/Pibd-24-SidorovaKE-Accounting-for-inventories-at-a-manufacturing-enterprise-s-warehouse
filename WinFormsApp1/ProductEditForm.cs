using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ProductEditForm : Form
    {
        public Product CreatedProduct { get; private set; }
        private int _productId;

        public ProductEditForm(int productId = 0)
        {
            InitializeComponent();
            _productId = productId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNameBox.Text;
                int unit = int.Parse(txtUnitBox.Text);

                CreatedProduct = Product.Create(name, unit);

                if (_productId > 0)
                {
                    CreatedProduct.SetId(_productId);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}