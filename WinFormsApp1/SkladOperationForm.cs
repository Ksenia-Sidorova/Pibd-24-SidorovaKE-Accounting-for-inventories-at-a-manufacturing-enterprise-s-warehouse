using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SkladOperationForm : Form
    {
        private readonly ISkladOperationRepository _operationRepository;

        public SkladOperationForm(ISkladOperationRepository operationRepository)
        {
            InitializeComponent();
            _operationRepository = operationRepository;
        }

        private void SkladOperationForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            GridOperations.DataSource = null;
            GridOperations.DataSource = _operationRepository.GetAll().ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Для операций мы просто добавим тестовую запись (по заданию кнопка "Добавить" есть)
            var operation = SkladOperation.Create(1, OperationType.Income, 10, DateTime.Now);
            _operationRepository.Add(operation);
            LoadData();
        }
    }
}