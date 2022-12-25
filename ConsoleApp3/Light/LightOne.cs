namespace ConsoleApp3.Light
{
    internal class LightOne : ILightState
    {

        public string PressSwitch(Light light)
        {
            light.State = new LightOff();
            return LightStatusEnum.Off.ToString();
        }
    }
}