using System.ComponentModel;

namespace MediaRental.Entities.Enums;

[Flags]
public enum Genre
{
    [Description("Не выбран")]
    None = 0,

    [Description("Поп")]
    Pop = 1,

    [Description("Рок")]
    Rock = 2,

    [Description("Джаз")]
    Jazz = 4,

    [Description("Классика")]
    Classical = 8,

    [Description("Комедия")]
    Comedy = 16,

    [Description("Драма")]
    Drama = 32,

    [Description("Боевик")]
    Action = 64,

    [Description("Документальный")]
    Documentary = 128,
}
