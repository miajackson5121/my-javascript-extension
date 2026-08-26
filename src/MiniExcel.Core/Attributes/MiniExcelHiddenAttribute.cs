namespace MiniExcelLib.Core.Attributes;

public class MiniExcelHiddenAttribute(bool hidden = true) : MiniExcelAttributeBase
{
    public bool Hidden { get; set; } = hidden;
}

// 31128b
