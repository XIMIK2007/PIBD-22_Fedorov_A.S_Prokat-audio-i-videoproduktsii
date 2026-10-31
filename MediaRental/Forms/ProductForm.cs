using MediaRental.Entities;
using MediaRental.Entities.Enums;
using MediaRental.Repositories;

namespace MediaRental.Forms;

public partial class ProductForm : Form
{
    private readonly IProductRepository _repository = null!;
    private int? _id;

    public int Id
    {
        set
        {
            var entity = _repository.ReadProductById(value) ?? throw new InvalidOperationException("Запись не найдена.");
            _id = value;
            textBoxTitle.Text = entity.Title;
            textBoxInventoryNumber.Text = entity.InventoryNumber;
            textBoxPerformers.Text = entity.Performers;
            textBoxActors.Text = entity.Actors;
            comboBoxProductType.SelectedItem = entity.ProductType;
            comboBoxDiscFormat.SelectedItem = entity.DiscFormat;
            numericDailyPrice.Value = Math.Clamp(entity.DailyPrice, numericDailyPrice.Minimum, numericDailyPrice.Maximum);
            for (int i = 0; i < checkedListBoxGenres.Items.Count; i++)
                checkedListBoxGenres.SetItemChecked(i, entity.Genres.HasFlag((Genre)checkedListBoxGenres.Items[i]));
        }
    }

    public ProductForm()
    {
        InitializeComponent();
    }

    public ProductForm(IProductRepository repository) : this()
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        comboBoxProductType.DataSource = Enum.GetValues<ProductType>().ToList();
        comboBoxDiscFormat.DataSource = Enum.GetValues<DiscFormat>().ToList();
        FormTools.FormatEnum(comboBoxProductType);
        FormTools.FormatEnum(comboBoxDiscFormat);
        foreach (Genre genre in Enum.GetValues<Genre>())
        {
            if (genre != Genre.None) checkedListBoxGenres.Items.Add(genre);
        }
        checkedListBoxGenres.Format += Genres_Format;
    }

    private void ButtonSave_Click(object? sender, EventArgs e) => FormTools.Try(this, () =>
    {
        FormTools.Required(textBoxTitle, "Альбом / название");
        FormTools.Required(textBoxInventoryNumber, "Инвентарный номер");
        var type = (ProductType)comboBoxProductType.SelectedItem!;
        var format = (DiscFormat)comboBoxDiscFormat.SelectedItem!;
        if (type == ProductType.None || format == DiscFormat.None) throw new InvalidOperationException("Выберите вид продукции и формат диска.");
        if (type == ProductType.AudioAlbum) FormTools.Required(textBoxPerformers, "Исполнители");
        Genre genres = Genre.None;
        foreach (Genre genre in checkedListBoxGenres.CheckedItems) genres |= genre;
        if (genres == Genre.None) throw new InvalidOperationException("Выберите хотя бы один жанр.");
        var product = Product.CreateEntity(_id ?? 0, textBoxTitle.Text.Trim(), textBoxInventoryNumber.Text.Trim(), type, format, genres, textBoxPerformers.Text.Trim(), textBoxActors.Text.Trim(), numericDailyPrice.Value);
        if (_id.HasValue) _repository.UpdateProduct(product);
        else _repository.CreateProduct(product);
        DialogResult = DialogResult.OK;
        Close();
    });
    private void ButtonCancel_Click(object? sender, EventArgs e) => Close();

    private void Genres_Format(object? sender, ListControlConvertEventArgs e)
    {
        if (e.ListItem is Genre value) e.Value = FormTools.EnumLabel(value);
    }
}
