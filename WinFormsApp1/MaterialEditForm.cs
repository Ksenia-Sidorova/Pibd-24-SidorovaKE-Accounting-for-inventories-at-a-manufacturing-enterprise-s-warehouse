using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MaterialEditForm : Form
    {
        public Material CreatedMaterial { get; private set; }
        private int _materialId;
        public MaterialEditForm(int materialId = 0)
        {
            InitializeComponent();
            _materialId = materialId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int unit = int.Parse(txtUnit.Text);
                decimal minStock = decimal.Parse(txtMinOstatok.Text);

                // Используем наш статический метод Create с проверками
                CreatedMaterial = Material.Create(name, unit, minStock);

                if (_materialId > 0)
                {
                    CreatedMaterial.SetId(_materialId);
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