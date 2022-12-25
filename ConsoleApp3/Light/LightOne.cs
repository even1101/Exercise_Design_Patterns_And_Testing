﻿namespace ConsoleApp3.Light;

public class LightOne : ILightState
{

    public string PressSwitch(Light light)
    {
        light.State = new LightOff();
        return LightStatusEnum.Off.ToString();
    }
}