namespace WinFormsApp1
{
    partial class ZaavkaForm
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
            GridRequests = new DataGridView();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)GridRequests).BeginInit();
            SuspendLayout();
            // 
            // GridRequests
            // 
            GridRequests.BackgroundColor = SystemColors.ActiveCaption;
            GridRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridRequests.Location = new Point(3, 3);
            GridRequests.Name = "GridRequests";
            GridRequests.Size = new Size(785, 344);
            GridRequests.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 372);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ZaavkaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(GridRequests);
            Name = "ZaavkaForm";
            Text = "Заявка";
            Load += ZaavkaForm_Load;
            ((System.ComponentModel.ISupportInitialize)GridRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridRequests;
        private Button btnAdd;
    }
}