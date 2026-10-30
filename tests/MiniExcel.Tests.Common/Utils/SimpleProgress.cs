namespace MiniExcelLib.Tests.Common.Utils;

public class SimpleProgress: IProgress<int>
{
    public int Value { get; private set; }
    public void Report(int value)
    {
        Value += value;
    }
}

// 997e5f
