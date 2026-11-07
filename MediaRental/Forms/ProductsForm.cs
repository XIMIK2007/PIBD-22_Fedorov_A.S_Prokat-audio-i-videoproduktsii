using MediaRental.Entities;
using MediaRental.Repositories;
using Unity;

namespace MediaRental.Forms;

public partial class ProductsForm : Form
{
    private readonly IUnityContainer _container = null!;
    private readonly IProductRepository _repository = null!;

    public ProductsForm()
    {
        InitializeComponent();
    }

    public ProductsForm(IUnityContainer container, IProductRepository repository) : this()
    {
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    private void LoadList() => dataGridRecords.DataSource = _repository.ReadProducts().ToList();

    private void ButtonAdd_Click(object? sender, EventArgs e) => FormTools.Try(this, () =>
    {
        using var form = _container.Resolve<ProductForm>();
        form.ShowDialog(this);
        LoadList();
    });

    private int SelectedId()
    {
        if (dataGridRecords.CurrentRow?.DataBoundItem is not Product entity)
            throw new InvalidOperationException("Выберите запись в списке.");
        return entity.Id;
    }

    private void ButtonEdit_Click(object? sender, EventArgs e) => FormTools.Try(this, () =>
    {
        int id = SelectedId();
        using var form = _container.Resolve<ProductForm>();
        form.Id = id;
        form.ShowDialog(this);
        LoadList();
    });

    private void ButtonDelete_Click(object? sender, EventArgs e) => FormTools.Try(this, () =>
    {
        int id = SelectedId();
        if (MessageBox.Show(this, "Удалить выбранную запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            _repository.DeleteProduct(id);
            LoadList();
        }
    });


    private void Form_Load(object? sender, EventArgs e)
    {
        if (!DesignMode) FormTools.Try(this, LoadList);
    }

    private void ButtonRefresh_Click(object? sender, EventArgs e) => FormTools.Try(this, LoadList);
}
