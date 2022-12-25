namespace ConsoleApp3.State.Light;

public class LightOne : ILightState
{

    public string PressSwitch(Light light)
    {
        light.State = new LightOff();
        return LightStatusEnum.Off.ToString();
    }
}