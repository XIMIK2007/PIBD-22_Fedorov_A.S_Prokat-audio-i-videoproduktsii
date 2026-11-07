using Unity;

namespace MediaRental.Forms;

public partial class MainForm : Form
{
    private readonly IUnityContainer _container = null!;

    public MainForm()
    {
        InitializeComponent();
    }

    public MainForm(IUnityContainer container) : this()
    {
        _container = container ?? throw new ArgumentNullException(nameof(container));
    }

    private void menuProducts_Click(object? sender, EventArgs e) => OpenForm<ProductsForm>();
    private void menuClients_Click(object? sender, EventArgs e) => OpenForm<ClientsForm>();
    private void menuConsultants_Click(object? sender, EventArgs e) => OpenForm<ConsultantsForm>();
    private void menuRentals_Click(object? sender, EventArgs e) => OpenForm<RentalsForm>();
    private void menuRentalReturns_Click(object? sender, EventArgs e) => OpenForm<RentalReturnsForm>();

    private void labelWelcome_Click(object sender, EventArgs e)
    {

    }

    private void OpenForm<T>() where T : Form => FormTools.Try(this, () =>
    {
        using var form = _container.Resolve<T>();
        form.ShowDialog(this);
    });
}
