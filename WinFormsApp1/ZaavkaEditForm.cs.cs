using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ZaavkaEditForm : Form
    {
        public ZaavkaNaZakupky CreatedRequest { get; private set; }

        public ZaavkaEditForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaterialId.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
                    throw new ArgumentException("Заполните все поля!");

                int materialId = int.Parse(txtMaterialId.Text);
                int quantity = int.Parse(txtQuantity.Text);

                CreatedRequest = ZaavkaNaZakupky.Create(materialId, quantity);
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
