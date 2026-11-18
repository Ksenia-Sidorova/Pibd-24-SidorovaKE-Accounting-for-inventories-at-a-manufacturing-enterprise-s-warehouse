using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    partial class ZaavkaEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblMaterialId = new Label();
            txtMaterialId = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblMaterialId
            // 
            lblMaterialId.AutoSize = true;
            lblMaterialId.Location = new Point(25, 20);
            lblMaterialId.Name = "lblMaterialId";
            lblMaterialId.Size = new Size(83, 15);
            lblMaterialId.TabIndex = 4;
            lblMaterialId.Text = "ID материала:";
            // 
            // txtMaterialId
            // 
            txtMaterialId.Location = new Point(25, 40);
            txtMaterialId.Name = "txtMaterialId";
            txtMaterialId.Size = new Size(120, 23);
            txtMaterialId.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(170, 20);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(75, 15);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Количество:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(170, 40);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(120, 23);
            txtQuantity.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(315, 39);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 25);
            btnSave.TabIndex = 0;
            btnSave.Text = "Сохранить";
            btnSave.Click += btnSave_Click;
            // 
            // ZaavkaEditForm
            // 
            ClientSize = new Size(517, 236);
            Controls.Add(btnSave);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtMaterialId);
            Controls.Add(lblMaterialId);
            Name = "ZaavkaEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Создание заявки на закупку";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMaterialId;
        private TextBox txtMaterialId;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnSave;
    }
}