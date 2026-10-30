namespace MiniExcelLib.Core.Attributes;

public class MiniExcelColumnWidthAttribute(double columnWidth) : MiniExcelAttributeBase
{
    public double ExcelColumnWidth { get; set; } = columnWidth;
}
// 1701d8

// b94c62
