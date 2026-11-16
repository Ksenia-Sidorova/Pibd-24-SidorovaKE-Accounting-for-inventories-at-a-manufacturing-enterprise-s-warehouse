namespace WinFormsApp1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            Spravochniki = new ToolStripMenuItem();
            MaterialsMenu = new ToolStripMenuItem();
            ProductiaMenu = new ToolStripMenuItem();
            Operacia = new ToolStripMenuItem();
            SkladskiiOperacii = new ToolStripMenuItem();
            Zaavki = new ToolStripMenuItem();
            Otchet = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { Spravochniki, Operacia, Otchet });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Spravochniki
            // 
            Spravochniki.DropDownItems.AddRange(new ToolStripItem[] { MaterialsMenu, ProductiaMenu });
            Spravochniki.Name = "Spravochniki";
            Spravochniki.Size = new Size(94, 20);
            Spravochniki.Text = "Справочники";
            // 
            // MaterialsMenu
            // 
            MaterialsMenu.Name = "MaterialsMenu";
            MaterialsMenu.Size = new Size(138, 22);
            MaterialsMenu.Text = "Материалы";
            MaterialsMenu.Click += MaterialsMenu_Click;
            // 
            // ProductiaMenu
            // 
            ProductiaMenu.Name = "ProductiaMenu";
            ProductiaMenu.Size = new Size(138, 22);
            ProductiaMenu.Text = "Продукция";
            ProductiaMenu.Click += ProductiaMenu_Click;
            // 
            // Operacia
            // 
            Operacia.DropDownItems.AddRange(new ToolStripItem[] { SkladskiiOperacii, Zaavki });
            Operacia.Name = "Operacia";
            Operacia.Size = new Size(75, 20);
            Operacia.Text = "Операции";
            // 
            // SkladskiiOperacii
            // 
            SkladskiiOperacii.Name = "SkladskiiOperacii";
            SkladskiiOperacii.Size = new Size(189, 22);
            SkladskiiOperacii.Text = "Складские операции";
            SkladskiiOperacii.Click += SkladskiiOperacii_Click;
            // 
            // Zaavki
            // 
            Zaavki.Name = "Zaavki";
            Zaavki.Size = new Size(189, 22);
            Zaavki.Text = "Заявки";
            Zaavki.Click += ZaavkiMenu_Click;
            // 
            // Otchet
            // 
            Otchet.Name = "Otchet";
            Otchet.Size = new Size(60, 20);
            Otchet.Text = "Отчеты";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Главная форма";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Spravochniki;
        private ToolStripMenuItem MaterialsMenu;
        private ToolStripMenuItem ProductiaMenu;
        private ToolStripMenuItem Operacia;
        private ToolStripMenuItem SkladskiiOperacii;
        private ToolStripMenuItem Zaavki;
        private ToolStripMenuItem Otchet;
    }
}