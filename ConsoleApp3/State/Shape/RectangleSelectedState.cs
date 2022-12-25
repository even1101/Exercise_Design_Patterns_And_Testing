namespace ConsoleApp3.State.Shape;

public class RectangleSelectedState : InitState
{
    private Module _module;

    public RectangleSelectedState(Module module)
    {
        _module = module;
    }

    public void Input(string answer)
    {
        try
        {
            _module.State = new ASelectedState(_module, Convert.ToInt32(answer));
        }
        catch (Exception e)
        {
            // do nothing
        }
    }

    public string Print()
    {
        return "Rectangle side A length?";
    }
}