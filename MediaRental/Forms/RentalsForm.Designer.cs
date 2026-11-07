namespace MediaRental.Forms;

partial class RentalsForm
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
        columnId = new DataGridViewTextBoxColumn();
        columnClientId = new DataGridViewTextBoxColumn();
        columnConsultantId = new DataGridViewTextBoxColumn();
        columnRentalDate = new DataGridViewTextBoxColumn();
        columnDueDate = new DataGridViewTextBoxColumn();
        panelButtons = new Panel();
        buttonAdd = new Button();
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
        // columnId
        columnId.DataPropertyName = "Id";
        columnId.HeaderText = "Номер выдачи";
        columnId.Name = "columnId";
        // columnClientId
        columnClientId.DataPropertyName = "ClientId";
        columnClientId.HeaderText = "Клиент";
        columnClientId.Name = "columnClientId";
        // columnConsultantId
        columnConsultantId.DataPropertyName = "ConsultantId";
        columnConsultantId.HeaderText = "Консультант";
        columnConsultantId.Name = "columnConsultantId";
        // columnRentalDate
        columnRentalDate.DataPropertyName = "RentalDate";
        columnRentalDate.HeaderText = "Дата выдачи";
        columnRentalDate.Name = "columnRentalDate";
        // columnDueDate
        columnDueDate.DataPropertyName = "DueDate";
        columnDueDate.HeaderText = "Вернуть до";
        columnDueDate.Name = "columnDueDate";
        dataGridRecords.Columns.AddRange(new DataGridViewColumn[] { columnId, columnClientId, columnConsultantId, columnRentalDate, columnDueDate });
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
        // buttonRefresh
        buttonRefresh.Text = "Обновить";
        buttonRefresh.Location = new Point(150, 10);
        buttonRefresh.Size = new Size(130, 36);
        buttonRefresh.UseVisualStyleBackColor = true;
        buttonRefresh.Name = "buttonRefresh";
        buttonRefresh.Click += ButtonRefresh_Click;
        panelButtons.Controls.Add(buttonRefresh);
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(950, 520);
        MinimumSize = new Size(850, 500);
        Name = "RentalsForm";
        Text = "Выдача в прокат";
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
    private DataGridViewTextBoxColumn columnId;
    private DataGridViewTextBoxColumn columnClientId;
    private DataGridViewTextBoxColumn columnConsultantId;
    private DataGridViewTextBoxColumn columnRentalDate;
    private DataGridViewTextBoxColumn columnDueDate;
    private Panel panelButtons;
    private Button buttonAdd;
    private Button buttonRefresh;
}
