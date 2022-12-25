namespace ConsoleApp3.State.Shape;

public class BSelectedState : InitState
{
    private Module _module;
    private int _a;
    private int _b;

    public BSelectedState(Module module, int a, int b)
    {
        _module = module;
        _a = a;
        _b = b;
    }

    public void Input(string answer)
    {
        throw new NotImplementedException();
    }

    public string Print()
    {
        return "Area=" + (_a * _b) + ", Circumference=" + (2 * (_a + _b));
    }
}