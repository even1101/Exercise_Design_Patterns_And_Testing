namespace ConsoleApp3.State.Shape;

public class ASelectedState : InitState
{
    private Module _module;
    private int _a;
    public ASelectedState(Module module, int a)
    {
        _module = module;
        _a = a;
    }

    public void Input(string answer)
    {
        try
        {
            int b = Convert.ToInt32(answer);
            _module.State = new BSelectedState(_module, _a, b);
        }
        catch (Exception e)
        {
            // do nothing
        }
    }

    public string Print()
    {
        return "Rectangle side B length?";
    }
}