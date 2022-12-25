using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.State.Shape;

public class Module : InitState
{
    public InitState State;

    public Module()
    {
        if (State == null) State = new ShapeState(this);
    }


    public string Print()
    {
        return State.Print();
    }

    public void Input(string answer)
    {
        State.Input(answer);
    }
}
