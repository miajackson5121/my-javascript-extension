namespace MiniExcelLib.Core.Attributes;

public class MiniExcelFormatAttribute(string format) : MiniExcelAttributeBase
{
    public string Format { get; set; } = format;
}
// 640ef9
