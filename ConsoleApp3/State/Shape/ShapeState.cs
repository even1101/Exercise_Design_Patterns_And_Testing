using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.State.Shape;

public class ShapeState : InitState
{
    private Module _module;

    public ShapeState(Module module)
    {
       _module = module;
    }

    public void Input(string answer)
    {
        if (answer == "R") _module.State = new RectangleSelectedState(_module);
        else if (answer == "C") _module.State = new CircleSelectedState(_module);
    }

    public string Print()
    {
        return "Shape: (C)ircle or (R)ectangle?";
    }
}
