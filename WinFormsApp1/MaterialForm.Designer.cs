namespace WinFormsApp1
{
    partial class MaterialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GridMaterials = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)GridMaterials).BeginInit();
            SuspendLayout();
            // 
            // GridMaterials
            // 
            GridMaterials.BackgroundColor = SystemColors.ActiveCaption;
            GridMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridMaterials.Location = new Point(3, 2);
            GridMaterials.Name = "GridMaterials";
            GridMaterials.Size = new Size(898, 352);
            GridMaterials.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(34, 393);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(141, 393);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(291, 393);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // MaterialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(GridMaterials);
            Name = "MaterialForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Управление материалами";
            Load += MaterialForm_Load;
            ((System.ComponentModel.ISupportInitialize)GridMaterials).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridMaterials;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}