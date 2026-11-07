using MediaRental.Entities;
using MediaRental.Repositories;

namespace MediaRental.Forms;

public partial class ClientForm : Form
{
    private readonly IClientRepository _repository = null!;
    private int? _id;

    public int Id
    {
        set
        {
            var entity = _repository.ReadClientById(value) ?? throw new InvalidOperationException("Запись не найдена.");
            textBoxFullName.Text = entity.FullName;
            textBoxPhone.Text = entity.Phone;
            textBoxEmail.Text = entity.Email;
            checkBoxIsRegular.Checked = entity.IsRegular;
            _id = value;
        }
    }

    public ClientForm()
    {
        InitializeComponent();
    }

    public ClientForm(IClientRepository repository) : this()
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    private void ButtonSave_Click(object? sender, EventArgs e) => FormTools.Try(this, () =>
    {
        FormTools.Required(textBoxFullName, "ФИО");
        FormTools.Required(textBoxPhone, "Телефон");
        var entity = Client.CreateEntity(_id ?? 0, textBoxFullName.Text.Trim(), textBoxPhone.Text.Trim(), textBoxEmail.Text.Trim(), checkBoxIsRegular.Checked);
        if (_id.HasValue) _repository.UpdateClient(entity);
        else _repository.CreateClient(entity);
        DialogResult = DialogResult.OK;
        Close();
    });
    private void ButtonCancel_Click(object? sender, EventArgs e) => Close();
}
