using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MaterialForm : Form
    {
        private readonly IMaterialRepository _materialRepository;

        //Внедрение зависимости через конструктор
        public MaterialForm(IMaterialRepository materialRepository)
        {
            InitializeComponent();
            _materialRepository = materialRepository;
        }

        private void MaterialForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            GridMaterials.DataSource = null;
            GridMaterials.DataSource = _materialRepository.GetAll().ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var editForm = new MaterialEditForm())
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    _materialRepository.Add(editForm.CreatedMaterial);
                    LoadData(); // Обновляем таблицу
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (GridMaterials.CurrentRow == null) return;

            var selectedMaterial = (Material)GridMaterials.CurrentRow.DataBoundItem;

            using (var editForm = new MaterialEditForm(selectedMaterial.ID))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    _materialRepository.Update(editForm.CreatedMaterial);
                    LoadData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GridMaterials.CurrentRow == null) return;

            var selectedMaterial = (Material)GridMaterials.CurrentRow.DataBoundItem;

            if (MessageBox.Show("Удалить материал?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _materialRepository.Delete(selectedMaterial.ID);
                LoadData();
            }
        }
    }
}