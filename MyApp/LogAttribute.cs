using MethodBoundaryAspect.Fody.Attributes;

namespace MyApp;

public sealed class LogAttribute : OnMethodBoundaryAspect
{
    public override void OnEntry(MethodExecutionArgs args)
    {
        Console.WriteLine("On entry");
    }

    public override void OnExit(MethodExecutionArgs args)
    {
        Console.WriteLine("On exit");
    }

    public override void OnException(MethodExecutionArgs args)
    {
        Console.WriteLine("On exception");
    }
}