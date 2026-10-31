namespace MediaRental.Forms;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        menuMain = new MenuStrip();
        menuReferences = new ToolStripMenuItem();
        menuProducts = new ToolStripMenuItem();
        menuClients = new ToolStripMenuItem();
        menuConsultants = new ToolStripMenuItem();
        menuOperations = new ToolStripMenuItem();
        menuRentals = new ToolStripMenuItem();
        menuRentalReturns = new ToolStripMenuItem();
        menuReports = new ToolStripMenuItem();
        labelWelcome = new Label();
        menuMain.SuspendLayout();
        SuspendLayout();
        // 
        // menuMain
        // 
        menuMain.Items.AddRange(new ToolStripItem[] { menuReferences, menuOperations, menuReports });
        menuMain.Location = new Point(0, 0);
        menuMain.Name = "menuMain";
        menuMain.Size = new Size(928, 24);
        menuMain.TabIndex = 1;
        // 
        // menuReferences
        // 
        menuReferences.DropDownItems.AddRange(new ToolStripItem[] { menuProducts, menuClients, menuConsultants });
        menuReferences.Name = "menuReferences";
        menuReferences.Size = new Size(94, 20);
        menuReferences.Text = "Справочники";
        // 
        // menuProducts
        // 
        menuProducts.Name = "menuProducts";
        menuProducts.Size = new Size(213, 22);
        menuProducts.Text = "Продукция";
        menuProducts.Click += menuProducts_Click;
        // 
        // menuClients
        // 
        menuClients.Name = "menuClients";
        menuClients.Size = new Size(213, 22);
        menuClients.Text = "Клиенты";
        menuClients.Click += menuClients_Click;
        // 
        // menuConsultants
        // 
        menuConsultants.Name = "menuConsultants";
        menuConsultants.Size = new Size(213, 22);
        menuConsultants.Text = "Продавцы-консультанты";
        menuConsultants.Click += menuConsultants_Click;
        // 
        // menuOperations
        // 
        menuOperations.DropDownItems.AddRange(new ToolStripItem[] { menuRentals, menuRentalReturns });
        menuOperations.Name = "menuOperations";
        menuOperations.Size = new Size(75, 20);
        menuOperations.Text = "Операции";
        // 
        // menuRentals
        // 
        menuRentals.Name = "menuRentals";
        menuRentals.Size = new Size(180, 22);
        menuRentals.Text = "Выдача в прокат";
        menuRentals.Click += menuRentals_Click;
        // 
        // menuRentalReturns
        // 
        menuRentalReturns.Name = "menuRentalReturns";
        menuRentalReturns.Size = new Size(180, 22);
        menuRentalReturns.Text = "Возврат продукции";
        menuRentalReturns.Click += menuRentalReturns_Click;
        // 
        // menuReports
        // 
        menuReports.Name = "menuReports";
        menuReports.Size = new Size(60, 20);
        menuReports.Text = "Отчёты";
        // 
        // labelWelcome
        // 
        labelWelcome.Dock = DockStyle.Fill;
        labelWelcome.Font = new Font("Segoe UI", 14F);
        labelWelcome.Location = new Point(0, 24);
        labelWelcome.Name = "labelWelcome";
        labelWelcome.Padding = new Padding(35);
        labelWelcome.Size = new Size(928, 526);
        labelWelcome.TabIndex = 0;
        labelWelcome.Text = "Прокат аудио- и видеопродукции\n\nВыберите раздел в меню.\n\n";
        labelWelcome.Click += labelWelcome_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(928, 550);
        Controls.Add(labelWelcome);
        Controls.Add(menuMain);
        MainMenuStrip = menuMain;
        MinimumSize = new Size(850, 500);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Прокат аудио- и видеопродукции";
        menuMain.ResumeLayout(false);
        menuMain.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private MenuStrip menuMain;
    private ToolStripMenuItem menuReferences;
    private ToolStripMenuItem menuOperations;
    private ToolStripMenuItem menuReports;
    private ToolStripMenuItem menuProducts;
    private ToolStripMenuItem menuClients;
    private ToolStripMenuItem menuConsultants;
    private ToolStripMenuItem menuRentals;
    private ToolStripMenuItem menuRentalReturns;
    private Label labelWelcome;
}
