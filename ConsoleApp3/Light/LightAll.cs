namespace ConsoleApp3.Light;

public class LightAll : ILightState
{

    public string PressSwitch(Light light)
    {
        light.State = new LightThree();
        return LightStatusEnum.LightThree.ToString();
    }
}