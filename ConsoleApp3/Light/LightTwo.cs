namespace ConsoleApp3.Light;

public class LightTwo : ILightState
{
    public string PressSwitch(Light light)
    {
        light.State = new LightOne();
        return LightStatusEnum.LightOne.ToString();
    }
}