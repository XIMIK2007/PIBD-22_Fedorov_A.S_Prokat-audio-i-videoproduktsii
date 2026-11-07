namespace MediaRental.Forms;

partial class ProductForm
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
        labelTitle = new Label();
        textBoxTitle = new TextBox();
        labelInventoryNumber = new Label();
        textBoxInventoryNumber = new TextBox();
        labelProductType = new Label();
        comboBoxProductType = new ComboBox();
        labelDiscFormat = new Label();
        comboBoxDiscFormat = new ComboBox();
        labelPerformers = new Label();
        textBoxPerformers = new TextBox();
        labelActors = new Label();
        textBoxActors = new TextBox();
        labelGenres = new Label();
        checkedListBoxGenres = new CheckedListBox();
        labelDailyPrice = new Label();
        numericDailyPrice = new NumericUpDown();
        panelFields.SuspendLayout();
        panelButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericDailyPrice).BeginInit();
        SuspendLayout();
        // panelFields
        panelFields.Size = new Size(700, 590);
        panelFields.Dock = DockStyle.Fill;
        panelFields.AutoScroll = true;
        panelFields.Name = "panelFields";
        // panelButtons
        panelButtons.Size = new Size(700, 60);
        panelButtons.Dock = DockStyle.Bottom;
        panelButtons.Height = 60;
        panelButtons.Name = "panelButtons";
        // buttonSave
        buttonSave.Text = "Сохранить";
        buttonSave.Location = new Point(410, 12);
        buttonSave.Size = new Size(130, 36);
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Name = "buttonSave";
        buttonSave.Click += ButtonSave_Click;
        panelButtons.Controls.Add(buttonSave);
        // buttonCancel
        buttonCancel.Text = "Отмена";
        buttonCancel.Location = new Point(550, 12);
        buttonCancel.Size = new Size(130, 36);
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Click += ButtonCancel_Click;
        panelButtons.Controls.Add(buttonCancel);
        buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        // labelTitle
        labelTitle.Text = "Альбом / название";
        labelTitle.Location = new Point(20, 24);
        labelTitle.Size = new Size(165, 24);
        labelTitle.Name = "labelTitle";
        panelFields.Controls.Add(labelTitle);
        // textBoxTitle
        textBoxTitle.Location = new Point(195, 20);
        textBoxTitle.Size = new Size(480, 28);
        textBoxTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textBoxTitle.AccessibleName = "Альбом / название";
        textBoxTitle.MaxLength = 300;
        textBoxTitle.Name = "textBoxTitle";
        panelFields.Controls.Add(textBoxTitle);
        // labelInventoryNumber
        labelInventoryNumber.Text = "Инвентарный номер";
        labelInventoryNumber.Location = new Point(20, 72);
        labelInventoryNumber.Size = new Size(165, 24);
        labelInventoryNumber.Name = "labelInventoryNumber";
        panelFields.Controls.Add(labelInventoryNumber);
        // textBoxInventoryNumber
        textBoxInventoryNumber.Location = new Point(195, 68);
        textBoxInventoryNumber.Size = new Size(480, 28);
        textBoxInventoryNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textBoxInventoryNumber.AccessibleName = "Инвентарный номер";
        textBoxInventoryNumber.MaxLength = 300;
        textBoxInventoryNumber.Name = "textBoxInventoryNumber";
        panelFields.Controls.Add(textBoxInventoryNumber);
        // labelProductType
        labelProductType.Text = "Вид продукции";
        labelProductType.Location = new Point(20, 120);
        labelProductType.Size = new Size(165, 24);
        labelProductType.Name = "labelProductType";
        panelFields.Controls.Add(labelProductType);
        // comboBoxProductType
        comboBoxProductType.Location = new Point(195, 116);
        comboBoxProductType.Size = new Size(480, 28);
        comboBoxProductType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        comboBoxProductType.AccessibleName = "Вид продукции";
        comboBoxProductType.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxProductType.Name = "comboBoxProductType";
        panelFields.Controls.Add(comboBoxProductType);
        // labelDiscFormat
        labelDiscFormat.Text = "Формат диска";
        labelDiscFormat.Location = new Point(20, 168);
        labelDiscFormat.Size = new Size(165, 24);
        labelDiscFormat.Name = "labelDiscFormat";
        panelFields.Controls.Add(labelDiscFormat);
        // comboBoxDiscFormat
        comboBoxDiscFormat.Location = new Point(195, 164);
        comboBoxDiscFormat.Size = new Size(480, 28);
        comboBoxDiscFormat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        comboBoxDiscFormat.AccessibleName = "Формат диска";
        comboBoxDiscFormat.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxDiscFormat.Name = "comboBoxDiscFormat";
        panelFields.Controls.Add(comboBoxDiscFormat);
        // labelPerformers
        labelPerformers.Text = "Исполнители";
        labelPerformers.Location = new Point(20, 216);
        labelPerformers.Size = new Size(165, 24);
        labelPerformers.Name = "labelPerformers";
        panelFields.Controls.Add(labelPerformers);
        // textBoxPerformers
        textBoxPerformers.Location = new Point(195, 212);
        textBoxPerformers.Size = new Size(480, 28);
        textBoxPerformers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textBoxPerformers.AccessibleName = "Исполнители";
        textBoxPerformers.MaxLength = 300;
        textBoxPerformers.Name = "textBoxPerformers";
        panelFields.Controls.Add(textBoxPerformers);
        // labelActors
        labelActors.Text = "Актёры";
        labelActors.Location = new Point(20, 264);
        labelActors.Size = new Size(165, 24);
        labelActors.Name = "labelActors";
        panelFields.Controls.Add(labelActors);
        // textBoxActors
        textBoxActors.Location = new Point(195, 260);
        textBoxActors.Size = new Size(480, 28);
        textBoxActors.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textBoxActors.AccessibleName = "Актёры";
        textBoxActors.MaxLength = 300;
        textBoxActors.Name = "textBoxActors";
        panelFields.Controls.Add(textBoxActors);
        // labelGenres
        labelGenres.Text = "Жанры";
        labelGenres.Location = new Point(20, 312);
        labelGenres.Size = new Size(165, 24);
        labelGenres.Name = "labelGenres";
        panelFields.Controls.Add(labelGenres);
        // checkedListBoxGenres
        checkedListBoxGenres.Location = new Point(195, 308);
        checkedListBoxGenres.Size = new Size(480, 176);
        checkedListBoxGenres.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        checkedListBoxGenres.AccessibleName = "Жанры";
        checkedListBoxGenres.CheckOnClick = true;
        checkedListBoxGenres.FormattingEnabled = true;
        checkedListBoxGenres.Name = "checkedListBoxGenres";
        panelFields.Controls.Add(checkedListBoxGenres);
        // labelDailyPrice
        labelDailyPrice.Text = "Цена за сутки, руб.";
        labelDailyPrice.Location = new Point(20, 508);
        labelDailyPrice.Size = new Size(165, 24);
        labelDailyPrice.Name = "labelDailyPrice";
        panelFields.Controls.Add(labelDailyPrice);
        // numericDailyPrice
        numericDailyPrice.Location = new Point(195, 504);
        numericDailyPrice.Size = new Size(480, 28);
        numericDailyPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        numericDailyPrice.AccessibleName = "Цена за сутки, руб.";
        numericDailyPrice.DecimalPlaces = 2;
        numericDailyPrice.Minimum = 0.01m;
        numericDailyPrice.Maximum = 100000m;
        numericDailyPrice.Value = 10m;
        numericDailyPrice.Name = "numericDailyPrice";
        panelFields.Controls.Add(numericDailyPrice);
        panelFields.AutoScrollMinSize = new Size(0, 562);
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(700, 650);
        MinimumSize = new Size(700, 500);
        Name = "ProductForm";
        Text = "Продукция";
        StartPosition = FormStartPosition.CenterParent;
        Controls.Add(panelFields);
        Controls.Add(panelButtons);
        AcceptButton = buttonSave;
        CancelButton = buttonCancel;
        panelFields.ResumeLayout(false);
        panelFields.PerformLayout();
        panelButtons.ResumeLayout(false);
        panelButtons.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericDailyPrice).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Panel panelFields;
    private Panel panelButtons;
    private Button buttonSave;
    private Button buttonCancel;
    private Label labelTitle;
    private TextBox textBoxTitle;
    private Label labelInventoryNumber;
    private TextBox textBoxInventoryNumber;
    private Label labelProductType;
    private ComboBox comboBoxProductType;
    private Label labelDiscFormat;
    private ComboBox comboBoxDiscFormat;
    private Label labelPerformers;
    private TextBox textBoxPerformers;
    private Label labelActors;
    private TextBox textBoxActors;
    private Label labelGenres;
    private CheckedListBox checkedListBoxGenres;
    private Label labelDailyPrice;
    private NumericUpDown numericDailyPrice;
}
