using MediaRental.Entities;
using MediaRental.Repositories;
using Unity;

namespace MediaRental.Forms;

public partial class RentalReturnsForm : Form
{
    private readonly IUnityContainer _container = null!;
    private readonly IRentalReturnRepository _repository = null!;

    public RentalReturnsForm()
    {
        InitializeComponent();
    }

    public RentalReturnsForm(IUnityContainer container, IRentalReturnRepository repository) : this()
    {
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    private void LoadList() => dataGridRecords.DataSource = _repository.ReadRentalReturns().ToList();

    private void ButtonAdd_Click(object? sender, EventArgs e) => FormTools.Try(this, () =>
    {
        using var form = _container.Resolve<RentalReturnForm>();
        form.ShowDialog(this);
        LoadList();
    });


    private void Form_Load(object? sender, EventArgs e)
    {
        if (!DesignMode) FormTools.Try(this, LoadList);
    }

    private void ButtonRefresh_Click(object? sender, EventArgs e) => FormTools.Try(this, LoadList);
}
