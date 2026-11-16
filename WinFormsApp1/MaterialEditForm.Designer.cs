namespace WinFormsApp1
{
    partial class MaterialEditForm
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
            label1 = new Label();
            txtName = new TextBox();
            EdenicaIzm = new Label();
            txtUnit = new TextBox();
            MinOstatoksForm = new Label();
            txtMinOstatok = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // txtName
            // 
            txtName.Location = new Point(29, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // EdenicaIzm
            // 
            EdenicaIzm.AutoSize = true;
            EdenicaIzm.Location = new Point(164, 9);
            EdenicaIzm.Name = "EdenicaIzm";
            EdenicaIzm.Size = new Size(88, 15);
            EdenicaIzm.TabIndex = 2;
            EdenicaIzm.Text = "Ед. измерения:";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(164, 37);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(100, 23);
            txtUnit.TabIndex = 3;
            // 
            // MinOstatoksForm
            // 
            MinOstatoksForm.AutoSize = true;
            MinOstatoksForm.Location = new Point(298, 9);
            MinOstatoksForm.Name = "MinOstatoksForm";
            MinOstatoksForm.Size = new Size(83, 15);
            MinOstatoksForm.TabIndex = 4;
            MinOstatoksForm.Text = "Мин. остаток:";
            // 
            // txtMinOstatok
            // 
            txtMinOstatok.Location = new Point(298, 37);
            txtMinOstatok.Name = "txtMinOstatok";
            txtMinOstatok.Size = new Size(100, 23);
            txtMinOstatok.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(424, 37);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // MaterialEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtMinOstatok);
            Controls.Add(MinOstatoksForm);
            Controls.Add(txtUnit);
            Controls.Add(EdenicaIzm);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "MaterialEditForm";
            Text = "Параметры материала";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label EdenicaIzm;
        private TextBox txtUnit;
        private Label MinOstatoksForm;
        private TextBox txtMinOstatok;
        private Button btnSave;
    }
}