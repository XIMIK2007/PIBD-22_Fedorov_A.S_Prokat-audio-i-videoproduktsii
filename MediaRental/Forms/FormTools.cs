using System.ComponentModel;
using System.Reflection;

namespace MediaRental.Forms;

public static class FormTools
{
    public static void Try(Form form, Action action)
    {
        try { action(); }
        catch (Exception error)
        {
            MessageBox.Show(form, error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    public static void Required(TextBox box, string field)
    {
        if (string.IsNullOrWhiteSpace(box.Text))
        {
            box.Focus();
            throw new InvalidOperationException($"Заполните поле «{field}».");
        }
    }

    public static string EnumLabel(Enum value) => value.GetType().GetField(value.ToString())?
        .GetCustomAttribute<DescriptionAttribute>()?.Description ?? value.ToString();

    public static void FormatEnum(ComboBox box)
    {
        box.FormattingEnabled = true;
        box.Format += (_, e) => { if (e.ListItem is Enum value) e.Value = EnumLabel(value); };
    }
}
