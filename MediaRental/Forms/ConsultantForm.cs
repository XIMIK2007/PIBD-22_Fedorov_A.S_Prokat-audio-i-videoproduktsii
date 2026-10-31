using MediaRental.Entities;
using MediaRental.Repositories;

namespace MediaRental.Forms;

public partial class ConsultantForm : Form
{
    private readonly IConsultantRepository _repository = null!;
    private int? _id;

    public int Id
    {
        set
        {
            var entity = _repository.ReadConsultantById(value) ?? throw new InvalidOperationException("Запись не найдена.");
            textBoxFullName.Text = entity.FullName;
            textBoxPhone.Text = entity.Phone;
            _id = value;
        }
    }

    public ConsultantForm()
    {
        InitializeComponent();
    }

    public ConsultantForm(IConsultantRepository repository) : this()
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    private void ButtonSave_Click(object? sender, EventArgs e) => FormTools.Try(this, () =>
    {
        FormTools.Required(textBoxFullName, "ФИО");
        FormTools.Required(textBoxPhone, "Телефон");
        var entity = Consultant.CreateEntity(_id ?? 0, textBoxFullName.Text.Trim(), textBoxPhone.Text.Trim());
        if (_id.HasValue) _repository.UpdateConsultant(entity);
        else _repository.CreateConsultant(entity);
        DialogResult = DialogResult.OK;
        Close();
    });
    private void ButtonCancel_Click(object? sender, EventArgs e) => Close();
}
