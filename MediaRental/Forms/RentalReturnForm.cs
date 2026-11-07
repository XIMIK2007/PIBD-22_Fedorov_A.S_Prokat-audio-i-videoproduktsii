using MediaRental.Entities;
using MediaRental.Repositories;

namespace MediaRental.Forms;

public partial class RentalReturnForm : Form
{
    private readonly IRentalReturnRepository _repository = null!;

    public RentalReturnForm()
    {
        InitializeComponent();
    }

    public RentalReturnForm(IRentalReturnRepository repository, IRentalRepository rentalRepository, IConsultantRepository consultantRepository) : this()
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        ArgumentNullException.ThrowIfNull(rentalRepository);
        ArgumentNullException.ThrowIfNull(consultantRepository);
        var returnedIds = repository.ReadRentalReturns().Select(x => x.RentalId).ToHashSet();
        comboBoxRental.DataSource = rentalRepository.ReadRentals().Where(x => !returnedIds.Contains(x.Id)).ToList();
        comboBoxConsultant.DataSource = consultantRepository.ReadConsultants().ToList();
        comboBoxRental.FormattingEnabled = true;
        comboBoxRental.Format += Rental_Format;
    }

    private void ButtonSave_Click(object? sender, EventArgs e) => FormTools.Try(this, () =>
    {
        if (comboBoxRental.SelectedItem is not Rental rental) throw new InvalidOperationException("Выберите выдачу в прокат.");
        if (comboBoxConsultant.SelectedItem is not Consultant consultant) throw new InvalidOperationException("Выберите консультанта.");
        if (rental.RentalDate > DateTime.Now) throw new InvalidOperationException("Дата возврата не может быть раньше даты выдачи.");
        var entity = RentalReturn.CreateOperation(0, rental.Id, consultant.Id, numericPaidAmount.Value);
        _repository.CreateRentalReturn(entity);
        DialogResult = DialogResult.OK;
        Close();
    });

    private void ButtonCancel_Click(object? sender, EventArgs e) => Close();

    private void Rental_Format(object? sender, ListControlConvertEventArgs e)
    {
        if (e.ListItem is Rental rental)
            e.Value = $"Выдача №{rental.Id} от {rental.RentalDate:dd.MM.yyyy}, вернуть до {rental.DueDate:dd.MM.yyyy}";
    }
}
