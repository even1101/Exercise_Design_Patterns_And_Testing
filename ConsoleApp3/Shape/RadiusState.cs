namespace ConsoleApp3.Shape;

public class RadiusState : InitState
{
    private Module _module;
    private int _r;

    public RadiusState(Module module, int r)
    {
        _module = module;
        _r = r;
    }

    public void Input(string answer)
    {
        throw new NotImplementedException();
    }

    public string Print()
    {
        return "Area=" + (_r * _r * 3) + ", Circumference=" + (2 * _r * 3);
    }
}