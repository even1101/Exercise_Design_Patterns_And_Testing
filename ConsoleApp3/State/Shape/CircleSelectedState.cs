namespace ConsoleApp3.State.Shape
{
    internal class CircleSelectedState : InitState
    {
        private Module _module;

        public CircleSelectedState(Module module)
        {
            _module = module;
        }

        public void Input(string answer)
        {
            try
            {
                int r = Convert.ToInt32(answer);

                _module.State = new RadiusState(_module, r);
            }
            catch (Exception e)
            {
                // do nothing

            }
        }

        public string Print()
        {
            return "Circle radius?";
        }
    }
}