using System.ComponentModel;

namespace MediaRental.Entities.Enums;

public enum ProductType
{
    [Description("Не выбран")]
    None = 0,

    [Description("Аудиоальбом")]
    AudioAlbum = 1,

    [Description("Видео")]
    Video = 2,
}
