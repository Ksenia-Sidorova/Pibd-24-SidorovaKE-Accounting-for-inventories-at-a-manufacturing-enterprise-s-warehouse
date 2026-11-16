namespace WinFormsApp1
{
    partial class ProductEditForm
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
            txtName = new Label();
            txtUnit = new Label();
            btnSave = new Button();
            txtNameBox = new TextBox();
            txtUnitBox = new TextBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new Point(23, 14);
            txtName.Name = "txtName";
            txtName.Size = new Size(62, 15);
            txtName.TabIndex = 0;
            txtName.Text = "Название:";
            // 
            // txtUnit
            // 
            txtUnit.AutoSize = true;
            txtUnit.Location = new Point(166, 14);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(88, 15);
            txtUnit.TabIndex = 1;
            txtUnit.Text = "Ед. измерения:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(306, 14);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtNameBox
            // 
            txtNameBox.Location = new Point(23, 36);
            txtNameBox.Name = "txtNameBox";
            txtNameBox.Size = new Size(100, 23);
            txtNameBox.TabIndex = 3;
            // 
            // txtUnitBox
            // 
            txtUnitBox.Location = new Point(166, 36);
            txtUnitBox.Name = "txtUnitBox";
            txtUnitBox.Size = new Size(100, 23);
            txtUnitBox.TabIndex = 4;
            // 
            // ProductEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUnitBox);
            Controls.Add(txtNameBox);
            Controls.Add(btnSave);
            Controls.Add(txtUnit);
            Controls.Add(txtName);
            Name = "ProductEditForm";
            Text = "Редактор продукта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtName;
        private Label txtUnit;
        private Button btnSave;
        private TextBox txtNameBox;
        private TextBox txtUnitBox;
    }
}