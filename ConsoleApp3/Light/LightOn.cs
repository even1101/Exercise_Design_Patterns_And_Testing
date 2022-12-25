namespace ConsoleApp3.Light
{
    internal class LightOn : ILightState
    {

        public string PressSwitch(Light light)
        {
            light.State = new LightAll();
            return LightStatusEnum.LightAll.ToString();
        }
    }
}