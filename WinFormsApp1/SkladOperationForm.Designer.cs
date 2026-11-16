namespace WinFormsApp1
{
    partial class SkladOperationForm
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
            GridOperations = new DataGridView();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)GridOperations).BeginInit();
            SuspendLayout();
            // 
            // GridOperations
            // 
            GridOperations.BackgroundColor = SystemColors.ActiveCaption;
            GridOperations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridOperations.Location = new Point(4, 3);
            GridOperations.Name = "GridOperations";
            GridOperations.Size = new Size(784, 330);
            GridOperations.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 368);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // SkladOperationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(GridOperations);
            Name = "SkladOperationForm";
            Text = "Операции склада";
            Load += SkladOperationForm_Load;
            ((System.ComponentModel.ISupportInitialize)GridOperations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridOperations;
        private Button btnAdd;
    }
}