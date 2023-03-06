// See https://aka.ms/new-console-template for more information

namespace MyApp;

internal static class Program
{
    private static void Main()
    {
        var temp = Program.GetRandomInteger();

        Console.WriteLine("Hello, World! {0}", temp);
    }

    [Log]
    private static int GetRandomInteger()
    {
        return Random.Shared.Next();
    }
}