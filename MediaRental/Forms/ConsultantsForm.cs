using MediaRental.Entities;
using MediaRental.Repositories;
using Unity;

namespace MediaRental.Forms;

public partial class ConsultantsForm : Form
{
    private readonly IUnityContainer _container = null!;
    private readonly IConsultantRepository _repository = null!;

    public ConsultantsForm()
    {
        InitializeComponent();
    }

    public ConsultantsForm(IUnityContainer container, IConsultantRepository repository) : this()
    {
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    private void LoadList() => dataGridRecords.DataSource = _repository.ReadConsultants().ToList();

    private void ButtonAdd_Click(object? sender, EventArgs e) => FormTools.Try(this, () =>
    {
        using var form = _container.Resolve<ConsultantForm>();
        form.ShowDialog(this);
        LoadList();
    });

    private int SelectedId()
    {
        if (dataGridRecords.CurrentRow?.DataBoundItem is not Consultant entity)
            throw new InvalidOperationException("Выберите запись в списке.");
        return entity.Id;
    }

    private void ButtonEdit_Click(object? sender, EventArgs e) => FormTools.Try(this, () =>
    {
        int id = SelectedId();
        using var form = _container.Resolve<ConsultantForm>();
        form.Id = id;
        form.ShowDialog(this);
        LoadList();
    });

    private void ButtonDelete_Click(object? sender, EventArgs e) => FormTools.Try(this, () =>
    {
        int id = SelectedId();
        if (MessageBox.Show(this, "Удалить выбранную запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            _repository.DeleteConsultant(id);
            LoadList();
        }
    });


    private void Form_Load(object? sender, EventArgs e)
    {
        if (!DesignMode) FormTools.Try(this, LoadList);
    }

    private void ButtonRefresh_Click(object? sender, EventArgs e) => FormTools.Try(this, LoadList);
}
