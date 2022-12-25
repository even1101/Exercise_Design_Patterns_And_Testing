using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Light;

public class LightOff : ILightState
{
    public string PressSwitch(Light light)
    {
        // LOGIC
        light.State = new LightOn();
        return LightStatusEnum.On.ToString();
    }
}
