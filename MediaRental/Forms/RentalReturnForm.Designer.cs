namespace MediaRental.Forms;

partial class RentalReturnForm
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
        labelRental = new Label();
        comboBoxRental = new ComboBox();
        labelConsultant = new Label();
        comboBoxConsultant = new ComboBox();
        labelPaidAmount = new Label();
        numericPaidAmount = new NumericUpDown();
        labellabelReturnDate = new Label();
        labelReturnDate = new Label();
        panelFields.SuspendLayout();
        panelButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericPaidAmount).BeginInit();
        SuspendLayout();
        // panelFields
        panelFields.Size = new Size(680, 310);
        panelFields.Dock = DockStyle.Fill;
        panelFields.AutoScroll = true;
        panelFields.Name = "panelFields";
        // panelButtons
        panelButtons.Size = new Size(680, 60);
        panelButtons.Dock = DockStyle.Bottom;
        panelButtons.Height = 60;
        panelButtons.Name = "panelButtons";
        // buttonSave
        buttonSave.Text = "Сохранить";
        buttonSave.Location = new Point(390, 12);
        buttonSave.Size = new Size(130, 36);
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Name = "buttonSave";
        buttonSave.Click += ButtonSave_Click;
        panelButtons.Controls.Add(buttonSave);
        // buttonCancel
        buttonCancel.Text = "Отмена";
        buttonCancel.Location = new Point(530, 12);
        buttonCancel.Size = new Size(130, 36);
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Click += ButtonCancel_Click;
        panelButtons.Controls.Add(buttonCancel);
        buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        // labelRental
        labelRental.Text = "Выдача в прокат";
        labelRental.Location = new Point(20, 24);
        labelRental.Size = new Size(165, 24);
        labelRental.Name = "labelRental";
        panelFields.Controls.Add(labelRental);
        // comboBoxRental
        comboBoxRental.Location = new Point(195, 20);
        comboBoxRental.Size = new Size(460, 28);
        comboBoxRental.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        comboBoxRental.AccessibleName = "Выдача в прокат";
        comboBoxRental.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxRental.DisplayMember = "Id";
        comboBoxRental.ValueMember = "Id";
        comboBoxRental.Name = "comboBoxRental";
        panelFields.Controls.Add(comboBoxRental);
        // labelConsultant
        labelConsultant.Text = "Консультант";
        labelConsultant.Location = new Point(20, 72);
        labelConsultant.Size = new Size(165, 24);
        labelConsultant.Name = "labelConsultant";
        panelFields.Controls.Add(labelConsultant);
        // comboBoxConsultant
        comboBoxConsultant.Location = new Point(195, 68);
        comboBoxConsultant.Size = new Size(460, 28);
        comboBoxConsultant.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        comboBoxConsultant.AccessibleName = "Консультант";
        comboBoxConsultant.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxConsultant.DisplayMember = "FullName";
        comboBoxConsultant.ValueMember = "Id";
        comboBoxConsultant.Name = "comboBoxConsultant";
        panelFields.Controls.Add(comboBoxConsultant);
        // labelPaidAmount
        labelPaidAmount.Text = "Оплачено, руб.";
        labelPaidAmount.Location = new Point(20, 120);
        labelPaidAmount.Size = new Size(165, 24);
        labelPaidAmount.Name = "labelPaidAmount";
        panelFields.Controls.Add(labelPaidAmount);
        // numericPaidAmount
        numericPaidAmount.Location = new Point(195, 116);
        numericPaidAmount.Size = new Size(460, 28);
        numericPaidAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        numericPaidAmount.AccessibleName = "Оплачено, руб.";
        numericPaidAmount.DecimalPlaces = 2;
        numericPaidAmount.Maximum = 10000000m;
        numericPaidAmount.Name = "numericPaidAmount";
        panelFields.Controls.Add(numericPaidAmount);
        // labellabelReturnDate
        labellabelReturnDate.Text = "Дата возврата";
        labellabelReturnDate.Location = new Point(20, 168);
        labellabelReturnDate.Size = new Size(165, 24);
        labellabelReturnDate.Name = "labellabelReturnDate";
        panelFields.Controls.Add(labellabelReturnDate);
        // labelReturnDate
        labelReturnDate.Location = new Point(195, 164);
        labelReturnDate.Size = new Size(460, 28);
        labelReturnDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        labelReturnDate.AccessibleName = "Дата возврата";
        labelReturnDate.Text = "Текущая дата при сохранении";
        labelReturnDate.Name = "labelReturnDate";
        panelFields.Controls.Add(labelReturnDate);
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(680, 370);
        MinimumSize = new Size(680, 370);
        Name = "RentalReturnForm";
        Text = "Возврат продукции";
        StartPosition = FormStartPosition.CenterParent;
        Controls.Add(panelFields);
        Controls.Add(panelButtons);
        AcceptButton = buttonSave;
        CancelButton = buttonCancel;
        panelFields.ResumeLayout(false);
        panelFields.PerformLayout();
        panelButtons.ResumeLayout(false);
        panelButtons.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericPaidAmount).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Panel panelFields;
    private Panel panelButtons;
    private Button buttonSave;
    private Button buttonCancel;
    private Label labelRental;
    private ComboBox comboBoxRental;
    private Label labelConsultant;
    private ComboBox comboBoxConsultant;
    private Label labelPaidAmount;
    private NumericUpDown numericPaidAmount;
    private Label labellabelReturnDate;
    private Label labelReturnDate;
}
