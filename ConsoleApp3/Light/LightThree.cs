namespace ConsoleApp3.Light
{
    internal class LightThree : ILightState
    {


        public string PressSwitch(Light light)
        {
            light.State = new LightTwo();
            return LightStatusEnum.LightTwo.ToString();
        }
    }
}