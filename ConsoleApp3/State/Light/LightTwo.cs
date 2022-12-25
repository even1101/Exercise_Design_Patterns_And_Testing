namespace ConsoleApp3.State.Light;

public class LightTwo : ILightState
{
    public string PressSwitch(Light light)
    {
        light.State = new LightOne();
        return LightStatusEnum.LightOne.ToString();
    }
}