// See https://aka.ms/new-console-template for more information

using System.Reflection;

namespace MyApp;

internal static class Program
{
    private static void Main()
    {
        var temp = Program.GetRandomInteger();

        Console.WriteLine("Hello, World! {0}", temp);

        // What does this loop print? Here is the answer, at least on my machine.
        //
        // Reference: 'System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
        // Reference: 'MethodBoundaryAspect, Version=2.0.118.0, Culture=neutral, PublicKeyToken=296379d5065c9d61'
        // Reference: 'System.Console, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
        // Reference: 'System.Private.CoreLib, Version=7.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e'
        // Reference: 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
        // Reference: 'System.Reflection, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
        foreach (var assemblyName in Assembly.GetExecutingAssembly().GetReferencedAssemblies())
        {
            Console.WriteLine("Reference: '{0}'", assemblyName.FullName);
        }
    }

    [Log]
    private static int GetRandomInteger()
    {
        return Random.Shared.Next();
    }
}