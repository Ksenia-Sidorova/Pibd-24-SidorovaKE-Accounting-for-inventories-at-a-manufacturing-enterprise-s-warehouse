using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ZaavkaForm : Form
    {
        private readonly IZaavkaNaZakupkyRepository _repository;

        public ZaavkaForm(IZaavkaNaZakupkyRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void ZaavkaForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            GridRequests.DataSource = null;
            GridRequests.DataSource = _repository.GetAll().ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new ZaavkaEditForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    _repository.Add(addForm.CreatedRequest);
                    LoadData();
                }
            }
        }
    }
}