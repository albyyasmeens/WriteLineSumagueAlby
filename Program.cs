using System.Diagnostics;

using System;
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        string GRULower = "Gru";
        string GRUUpper = "GRU";
        Console.WriteLine(GRUUpper);
        Console.WriteLine("No, no, no!");
        Console.WriteLine(GRUUpper);
        Console.WriteLine("Ok, my turn");

        Console.WriteLine("He said \"What??!\"\n");
Console.WriteLine("And I said \"I Know!\"");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}

internal record struct NewStruct(object Item1, object Item2)
{
    public static implicit operator (object, object)(NewStruct value)
    {
        return (value.Item1, value.Item2);
    }

    public static implicit operator NewStruct((object, object) value)
    {
        return new NewStruct(value.Item1, value.Item2);
    }
}
