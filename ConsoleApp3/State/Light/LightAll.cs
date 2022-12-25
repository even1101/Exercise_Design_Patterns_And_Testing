namespace ConsoleApp3.State.Light;

public class LightAll : ILightState
{

    public string PressSwitch(Light light)
    {
        light.State = new LightThree();
        return LightStatusEnum.LightThree.ToString();
    }
}