namespace ConsoleApp3.Light;

public class LightOn : ILightState
{

    public string PressSwitch(Light light)
    {
        light.State = new LightAll();
        return LightStatusEnum.LightAll.ToString();
    }
}