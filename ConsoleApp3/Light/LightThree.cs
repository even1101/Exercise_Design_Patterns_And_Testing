namespace ConsoleApp3.Light;

public class LightThree : ILightState
{


    public string PressSwitch(Light light)
    {
        light.State = new LightTwo();
        return LightStatusEnum.LightTwo.ToString();
    }
}