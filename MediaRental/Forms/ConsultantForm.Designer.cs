namespace MediaRental.Forms;

partial class ConsultantForm
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
        labelFullName = new Label();
        textBoxFullName = new TextBox();
        labelPhone = new Label();
        textBoxPhone = new TextBox();
        panelFields.SuspendLayout();
        panelButtons.SuspendLayout();
        SuspendLayout();
        // panelFields
        panelFields.Size = new Size(620, 330);
        panelFields.Dock = DockStyle.Fill;
        panelFields.AutoScroll = true;
        panelFields.Name = "panelFields";
        // panelButtons
        panelButtons.Size = new Size(620, 60);
        panelButtons.Dock = DockStyle.Bottom;
        panelButtons.Height = 60;
        panelButtons.Name = "panelButtons";
        // buttonSave
        buttonSave.Text = "Сохранить";
        buttonSave.Location = new Point(330, 12);
        buttonSave.Size = new Size(130, 36);
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Name = "buttonSave";
        buttonSave.Click += ButtonSave_Click;
        panelButtons.Controls.Add(buttonSave);
        // buttonCancel
        buttonCancel.Text = "Отмена";
        buttonCancel.Location = new Point(470, 12);
        buttonCancel.Size = new Size(130, 36);
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Click += ButtonCancel_Click;
        panelButtons.Controls.Add(buttonCancel);
        buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        // labelFullName
        labelFullName.Text = "ФИО";
        labelFullName.Location = new Point(20, 24);
        labelFullName.Size = new Size(165, 24);
        labelFullName.Name = "labelFullName";
        panelFields.Controls.Add(labelFullName);
        // textBoxFullName
        textBoxFullName.Location = new Point(195, 20);
        textBoxFullName.Size = new Size(400, 28);
        textBoxFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textBoxFullName.AccessibleName = "ФИО";
        textBoxFullName.MaxLength = 300;
        textBoxFullName.Name = "textBoxFullName";
        panelFields.Controls.Add(textBoxFullName);
        // labelPhone
        labelPhone.Text = "Телефон";
        labelPhone.Location = new Point(20, 72);
        labelPhone.Size = new Size(165, 24);
        labelPhone.Name = "labelPhone";
        panelFields.Controls.Add(labelPhone);
        // textBoxPhone
        textBoxPhone.Location = new Point(195, 68);
        textBoxPhone.Size = new Size(400, 28);
        textBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textBoxPhone.AccessibleName = "Телефон";
        textBoxPhone.MaxLength = 300;
        textBoxPhone.Name = "textBoxPhone";
        panelFields.Controls.Add(textBoxPhone);
        panelFields.AutoScrollMinSize = new Size(0, 126);
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(620, 390);
        MinimumSize = new Size(620, 390);
        Name = "ConsultantForm";
        Text = "Продавец-консультант";
        StartPosition = FormStartPosition.CenterParent;
        Controls.Add(panelFields);
        Controls.Add(panelButtons);
        AcceptButton = buttonSave;
        CancelButton = buttonCancel;
        panelFields.ResumeLayout(false);
        panelFields.PerformLayout();
        panelButtons.ResumeLayout(false);
        panelButtons.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Panel panelFields;
    private Panel panelButtons;
    private Button buttonSave;
    private Button buttonCancel;
    private Label labelFullName;
    private TextBox textBoxFullName;
    private Label labelPhone;
    private TextBox textBoxPhone;
}
