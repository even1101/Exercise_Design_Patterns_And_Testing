namespace ConsoleApp3.Light
{
    internal class LightTwo : ILightState
    {
        public string PressSwitch(Light light)
        {
            light.State = new LightOne();
            return LightStatusEnum.LightOne.ToString();
        }
    }
}