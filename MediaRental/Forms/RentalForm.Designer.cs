namespace MediaRental.Forms;

partial class RentalForm
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
        panelFields = new Panel();
        panelButtons = new Panel();
        buttonSave = new Button();
        buttonCancel = new Button();
        labelClient = new Label();
        comboBoxClient = new ComboBox();
        labelConsultant = new Label();
        comboBoxConsultant = new ComboBox();
        labelProduct = new Label();
        comboBoxProduct = new ComboBox();
        labelDue = new Label();
        dateTimeDue = new DateTimePicker();
        buttonAddProduct = new Button();
        buttonRemoveProduct = new Button();
        dataGridItems = new DataGridView();
        columnTitle = new DataGridViewTextBoxColumn();
        columnInventoryNumber = new DataGridViewTextBoxColumn();
        columnDailyPrice = new DataGridViewTextBoxColumn();
        panelFields.SuspendLayout();
        panelButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridItems).BeginInit();
        SuspendLayout();
        // panelFields
        panelFields.Size = new Size(850, 590);
        panelFields.Dock = DockStyle.Fill;
        panelFields.AutoScroll = true;
        panelFields.Name = "panelFields";
        // panelButtons
        panelButtons.Size = new Size(850, 60);
        panelButtons.Dock = DockStyle.Bottom;
        panelButtons.Height = 60;
        panelButtons.Name = "panelButtons";
        // buttonSave
        buttonSave.Text = "Сохранить";
        buttonSave.Location = new Point(560, 12);
        buttonSave.Size = new Size(130, 36);
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Name = "buttonSave";
        buttonSave.Click += ButtonSave_Click;
        panelButtons.Controls.Add(buttonSave);
        // buttonCancel
        buttonCancel.Text = "Отмена";
        buttonCancel.Location = new Point(700, 12);
        buttonCancel.Size = new Size(130, 36);
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Click += ButtonCancel_Click;
        panelButtons.Controls.Add(buttonCancel);
        buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        // labelClient
        labelClient.Text = "Клиент";
        labelClient.Location = new Point(20, 24);
        labelClient.Size = new Size(165, 24);
        labelClient.Name = "labelClient";
        panelFields.Controls.Add(labelClient);
        // comboBoxClient
        comboBoxClient.Location = new Point(195, 20);
        comboBoxClient.Size = new Size(630, 28);
        comboBoxClient.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        comboBoxClient.AccessibleName = "Клиент";
        comboBoxClient.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxClient.DisplayMember = "FullName";
        comboBoxClient.ValueMember = "Id";
        comboBoxClient.Name = "comboBoxClient";
        panelFields.Controls.Add(comboBoxClient);
        // labelConsultant
        labelConsultant.Text = "Консультант";
        labelConsultant.Location = new Point(20, 72);
        labelConsultant.Size = new Size(165, 24);
        labelConsultant.Name = "labelConsultant";
        panelFields.Controls.Add(labelConsultant);
        // comboBoxConsultant
        comboBoxConsultant.Location = new Point(195, 68);
        comboBoxConsultant.Size = new Size(630, 28);
        comboBoxConsultant.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        comboBoxConsultant.AccessibleName = "Консультант";
        comboBoxConsultant.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxConsultant.DisplayMember = "FullName";
        comboBoxConsultant.ValueMember = "Id";
        comboBoxConsultant.Name = "comboBoxConsultant";
        panelFields.Controls.Add(comboBoxConsultant);
        // labelProduct
        labelProduct.Text = "Продукция";
        labelProduct.Location = new Point(20, 168);
        labelProduct.Size = new Size(165, 24);
        labelProduct.Name = "labelProduct";
        panelFields.Controls.Add(labelProduct);
        // comboBoxProduct
        comboBoxProduct.Location = new Point(195, 164);
        comboBoxProduct.Size = new Size(630, 28);
        comboBoxProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        comboBoxProduct.AccessibleName = "Продукция";
        comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxProduct.DisplayMember = "Title";
        comboBoxProduct.ValueMember = "Id";
        comboBoxProduct.Name = "comboBoxProduct";
        panelFields.Controls.Add(comboBoxProduct);
        // labelDue
        labelDue.Text = "Вернуть до";
        labelDue.Location = new Point(20, 120);
        labelDue.Size = new Size(165, 24);
        labelDue.Name = "labelDue";
        panelFields.Controls.Add(labelDue);
        // dateTimeDue
        dateTimeDue.Location = new Point(195, 116);
        dateTimeDue.Size = new Size(630, 28);
        dateTimeDue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dateTimeDue.AccessibleName = "Вернуть до";
        dateTimeDue.Format = DateTimePickerFormat.Short;
        dateTimeDue.Name = "dateTimeDue";
        panelFields.Controls.Add(dateTimeDue);
        // buttonAddProduct
        buttonAddProduct.Text = "Добавить диск";
        buttonAddProduct.Location = new Point(195, 216);
        buttonAddProduct.Size = new Size(130, 36);
        buttonAddProduct.UseVisualStyleBackColor = true;
        buttonAddProduct.Name = "buttonAddProduct";
        buttonAddProduct.Click += ButtonAddProduct_Click;
        panelFields.Controls.Add(buttonAddProduct);
        // buttonRemoveProduct
        buttonRemoveProduct.Text = "Убрать диск";
        buttonRemoveProduct.Location = new Point(340, 216);
        buttonRemoveProduct.Size = new Size(130, 36);
        buttonRemoveProduct.UseVisualStyleBackColor = true;
        buttonRemoveProduct.Name = "buttonRemoveProduct";
        buttonRemoveProduct.Click += ButtonRemoveProduct_Click;
        panelFields.Controls.Add(buttonRemoveProduct);
        // dataGridItems
        dataGridItems.AllowUserToAddRows = false;
        dataGridItems.AllowUserToDeleteRows = false;
        dataGridItems.AutoGenerateColumns = false;
        dataGridItems.ReadOnly = true;
        dataGridItems.MultiSelect = false;
        dataGridItems.RowHeadersVisible = false;
        dataGridItems.AllowUserToResizeRows = false;
        dataGridItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridItems.BackgroundColor = Color.White;
        dataGridItems.Location = new Point(20, 270);
        dataGridItems.Size = new Size(810, 280);
        dataGridItems.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        dataGridItems.Name = "dataGridItems";
        // columnTitle
        columnTitle.DataPropertyName = "Title";
        columnTitle.HeaderText = "Название";
        columnTitle.Name = "columnTitle";
        // columnInventoryNumber
        columnInventoryNumber.DataPropertyName = "InventoryNumber";
        columnInventoryNumber.HeaderText = "Инвентарный номер";
        columnInventoryNumber.Name = "columnInventoryNumber";
        // columnDailyPrice
        columnDailyPrice.DataPropertyName = "DailyPrice";
        columnDailyPrice.HeaderText = "Цена за сутки, руб.";
        columnDailyPrice.Name = "columnDailyPrice";
        dataGridItems.Columns.AddRange(new DataGridViewColumn[] { columnTitle, columnInventoryNumber, columnDailyPrice });
        panelFields.Controls.Add(dataGridItems);
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(850, 650);
        MinimumSize = new Size(850, 500);
        Name = "RentalForm";
        Text = "Выдача продукции в прокат";
        StartPosition = FormStartPosition.CenterParent;
        Controls.Add(panelFields);
        Controls.Add(panelButtons);
        AcceptButton = buttonSave;
        CancelButton = buttonCancel;
        panelFields.ResumeLayout(false);
        panelFields.PerformLayout();
        panelButtons.ResumeLayout(false);
        panelButtons.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridItems).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Panel panelFields;
    private Panel panelButtons;
    private Button buttonSave;
    private Button buttonCancel;
    private Label labelClient;
    private ComboBox comboBoxClient;
    private Label labelConsultant;
    private ComboBox comboBoxConsultant;
    private Label labelProduct;
    private ComboBox comboBoxProduct;
    private Label labelDue;
    private DateTimePicker dateTimeDue;
    private Button buttonAddProduct;
    private Button buttonRemoveProduct;
    private DataGridView dataGridItems;
    private DataGridViewTextBoxColumn columnTitle;
    private DataGridViewTextBoxColumn columnInventoryNumber;
    private DataGridViewTextBoxColumn columnDailyPrice;
}
