using System;

public interface IName
{
    string Name { get; set; }
}

public abstract class DataType : IName
{
    public string Name { get; set; }
    public abstract int SizeInBytes { get; }
}

public class ValueType : DataType
{
    public bool IsSigned { get; set; }
    public override int SizeInBytes { get; }
}

public class ReferenceType : DataType
{
    public override int SizeInBytes { get; }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine();
    }
}
