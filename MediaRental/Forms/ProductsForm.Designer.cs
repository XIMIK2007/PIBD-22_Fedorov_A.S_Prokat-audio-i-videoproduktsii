namespace MediaRental.Forms;

partial class ProductsForm
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
        dataGridRecords = new DataGridView();
        columnTitle = new DataGridViewTextBoxColumn();
        columnInventoryNumber = new DataGridViewTextBoxColumn();
        columnProductType = new DataGridViewTextBoxColumn();
        columnDiscFormat = new DataGridViewTextBoxColumn();
        columnGenres = new DataGridViewTextBoxColumn();
        columnPerformers = new DataGridViewTextBoxColumn();
        columnActors = new DataGridViewTextBoxColumn();
        columnDailyPrice = new DataGridViewTextBoxColumn();
        panelButtons = new Panel();
        buttonAdd = new Button();
        buttonEdit = new Button();
        buttonDelete = new Button();
        buttonRefresh = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridRecords).BeginInit();
        panelButtons.SuspendLayout();
        SuspendLayout();
        // dataGridRecords
        dataGridRecords.AllowUserToAddRows = false;
        dataGridRecords.AllowUserToDeleteRows = false;
        dataGridRecords.AutoGenerateColumns = false;
        dataGridRecords.ReadOnly = true;
        dataGridRecords.MultiSelect = false;
        dataGridRecords.RowHeadersVisible = false;
        dataGridRecords.AllowUserToResizeRows = false;
        dataGridRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridRecords.BackgroundColor = Color.White;
        dataGridRecords.Dock = DockStyle.Fill;
        dataGridRecords.Name = "dataGridRecords";
        // columnTitle
        columnTitle.DataPropertyName = "Title";
        columnTitle.HeaderText = "Альбом / название";
        columnTitle.Name = "columnTitle";
        // columnInventoryNumber
        columnInventoryNumber.DataPropertyName = "InventoryNumber";
        columnInventoryNumber.HeaderText = "Инв. номер";
        columnInventoryNumber.Name = "columnInventoryNumber";
        // columnProductType
        columnProductType.DataPropertyName = "ProductType";
        columnProductType.HeaderText = "Вид";
        columnProductType.Name = "columnProductType";
        // columnDiscFormat
        columnDiscFormat.DataPropertyName = "DiscFormat";
        columnDiscFormat.HeaderText = "Диск";
        columnDiscFormat.Name = "columnDiscFormat";
        // columnGenres
        columnGenres.DataPropertyName = "Genres";
        columnGenres.HeaderText = "Жанры";
        columnGenres.Name = "columnGenres";
        // columnPerformers
        columnPerformers.DataPropertyName = "Performers";
        columnPerformers.HeaderText = "Исполнители";
        columnPerformers.Name = "columnPerformers";
        // columnActors
        columnActors.DataPropertyName = "Actors";
        columnActors.HeaderText = "Актёры";
        columnActors.Name = "columnActors";
        // columnDailyPrice
        columnDailyPrice.DataPropertyName = "DailyPrice";
        columnDailyPrice.HeaderText = "Цена за сутки";
        columnDailyPrice.Name = "columnDailyPrice";
        dataGridRecords.Columns.AddRange(new DataGridViewColumn[] { columnTitle, columnInventoryNumber, columnProductType, columnDiscFormat, columnGenres, columnPerformers, columnActors, columnDailyPrice });
        // panelButtons
        panelButtons.Dock = DockStyle.Top;
        panelButtons.Height = 58;
        panelButtons.Name = "panelButtons";
        // buttonAdd
        buttonAdd.Text = "Добавить";
        buttonAdd.Location = new Point(10, 10);
        buttonAdd.Size = new Size(130, 36);
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Click += ButtonAdd_Click;
        panelButtons.Controls.Add(buttonAdd);
        // buttonEdit
        buttonEdit.Text = "Изменить";
        buttonEdit.Location = new Point(150, 10);
        buttonEdit.Size = new Size(130, 36);
        buttonEdit.UseVisualStyleBackColor = true;
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Click += ButtonEdit_Click;
        panelButtons.Controls.Add(buttonEdit);
        // buttonDelete
        buttonDelete.Text = "Удалить";
        buttonDelete.Location = new Point(290, 10);
        buttonDelete.Size = new Size(130, 36);
        buttonDelete.UseVisualStyleBackColor = true;
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Click += ButtonDelete_Click;
        panelButtons.Controls.Add(buttonDelete);
        // buttonRefresh
        buttonRefresh.Text = "Обновить";
        buttonRefresh.Location = new Point(430, 10);
        buttonRefresh.Size = new Size(130, 36);
        buttonRefresh.UseVisualStyleBackColor = true;
        buttonRefresh.Name = "buttonRefresh";
        buttonRefresh.Click += ButtonRefresh_Click;
        panelButtons.Controls.Add(buttonRefresh);
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(950, 520);
        MinimumSize = new Size(850, 500);
        Name = "ProductsForm";
        Text = "Продукция";
        StartPosition = FormStartPosition.CenterParent;
        Controls.Add(dataGridRecords);
        Controls.Add(panelButtons);
        Load += Form_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridRecords).EndInit();
        panelButtons.ResumeLayout(false);
        panelButtons.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private DataGridView dataGridRecords;
    private DataGridViewTextBoxColumn columnTitle;
    private DataGridViewTextBoxColumn columnInventoryNumber;
    private DataGridViewTextBoxColumn columnProductType;
    private DataGridViewTextBoxColumn columnDiscFormat;
    private DataGridViewTextBoxColumn columnGenres;
    private DataGridViewTextBoxColumn columnPerformers;
    private DataGridViewTextBoxColumn columnActors;
    private DataGridViewTextBoxColumn columnDailyPrice;
    private Panel panelButtons;
    private Button buttonAdd;
    private Button buttonEdit;
    private Button buttonDelete;
    private Button buttonRefresh;
}
