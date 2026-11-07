using MediaRental.Entities;
using MediaRental.Repositories;

namespace MediaRental.Forms;

public partial class RentalForm : Form
{
    private readonly IRentalRepository _rentalRepository = null!;
    private readonly List<RentalItem> _items = [];
    private readonly List<Product> _products = [];

    public RentalForm()
    {
        InitializeComponent();
    }

    public RentalForm(IRentalRepository rentalRepository, IProductRepository productRepository, IClientRepository clientRepository, IConsultantRepository consultantRepository) : this()
    {
        _rentalRepository = rentalRepository ?? throw new ArgumentNullException(nameof(rentalRepository));
        ArgumentNullException.ThrowIfNull(productRepository);
        ArgumentNullException.ThrowIfNull(clientRepository);
        ArgumentNullException.ThrowIfNull(consultantRepository);
        _products = productRepository.ReadProducts().ToList();
        comboBoxClient.DataSource = clientRepository.ReadClients().ToList();
        comboBoxConsultant.DataSource = consultantRepository.ReadConsultants().ToList();
        comboBoxProduct.DataSource = _products;
        comboBoxProduct.FormattingEnabled = true;
        comboBoxProduct.Format += Product_Format;
        dateTimeDue.Value = DateTime.Today.AddDays(7);
    }

    private void ButtonAddProduct_Click(object? sender, EventArgs e) => FormTools.Try(this, () =>
    {
        if (comboBoxProduct.SelectedItem is not Product product) throw new InvalidOperationException("Выберите продукцию.");
        if (_items.Any(x => x.ProductId == product.Id)) throw new InvalidOperationException("Этот диск уже добавлен.");
        _items.Add(RentalItem.CreateEntity(0, 0, product.Id, product.DailyPrice));
        LoadItems();
    });

    private void ButtonRemoveProduct_Click(object? sender, EventArgs e) => FormTools.Try(this, () =>
    {
        if (dataGridItems.CurrentRow == null) throw new InvalidOperationException("Выберите диск в таблице.");
        _items.RemoveAt(dataGridItems.CurrentRow.Index);
        LoadItems();
    });

    private void LoadItems()
    {
        dataGridItems.DataSource = _items.Select(item => new
        {
            _products.First(x => x.Id == item.ProductId).Title,
            _products.First(x => x.Id == item.ProductId).InventoryNumber,
            item.DailyPrice
        }).ToList();
    }

    private void ButtonSave_Click(object? sender, EventArgs e) => FormTools.Try(this, () =>
    {
        if (comboBoxClient.SelectedItem is not Client client) throw new InvalidOperationException("Выберите клиента.");
        if (comboBoxConsultant.SelectedItem is not Consultant consultant) throw new InvalidOperationException("Выберите консультанта.");
        if (dateTimeDue.Value.Date < DateTime.Today) throw new InvalidOperationException("Срок возврата не может быть раньше даты выдачи.");
        if (_items.Count == 0) throw new InvalidOperationException("Добавьте хотя бы один диск.");
        var rental = Rental.CreateOperation(0, client.Id, consultant.Id, dateTimeDue.Value.Date, _items);
        _rentalRepository.CreateRental(rental);
        DialogResult = DialogResult.OK;
        Close();
    });

    private void ButtonCancel_Click(object? sender, EventArgs e) => Close();

    private void Product_Format(object? sender, ListControlConvertEventArgs e)
    {
        if (e.ListItem is Product product) e.Value = $"{product.Title} ({product.InventoryNumber})";
    }
}
