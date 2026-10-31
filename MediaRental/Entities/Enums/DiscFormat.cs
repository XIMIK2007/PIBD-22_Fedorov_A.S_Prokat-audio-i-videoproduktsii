using System.ComponentModel;

namespace MediaRental.Entities.Enums;

public enum DiscFormat
{
    [Description("Не выбран")]
    None = 0,

    [Description("CD")]
    CD = 1,

    [Description("DVD")]
    DVD = 2,
}
