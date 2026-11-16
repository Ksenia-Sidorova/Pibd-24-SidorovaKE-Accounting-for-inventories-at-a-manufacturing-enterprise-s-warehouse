namespace WinFormsApp1
{
    partial class ProductForm
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
            GridProducts = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)GridProducts).BeginInit();
            SuspendLayout();
            // 
            // GridProducts
            // 
            GridProducts.BackgroundColor = SystemColors.ActiveCaption;
            GridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridProducts.GridColor = SystemColors.InactiveCaption;
            GridProducts.Location = new Point(2, 4);
            GridProducts.Name = "GridProducts";
            GridProducts.Size = new Size(793, 338);
            GridProducts.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(79, 380);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(188, 380);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(119, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(339, 380);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(GridProducts);
            Name = "ProductForm";
            Text = "Продукт";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)GridProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridProducts;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}