namespace DemoLibrary;

public class CallingDemo
{
    private void MakeDemoCalls()
    {
        AccessDemo demo = new();

        demo.InternalDemo();
        demo.ProtectedInternalDemo();
        
    }
}
