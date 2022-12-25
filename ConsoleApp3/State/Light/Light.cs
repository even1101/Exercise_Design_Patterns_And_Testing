using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.State.Light;

public class Light
{
    public ILightState State;
    public Light(ILightState state)
    {
        State = state;
    }

    public string Switch()
    {
        return State.PressSwitch(this);
    }

    /*
     * 未重構之前
        private LightStatusEnum _status = LightStatusEnum.Off;
        public string Switch()
        {
            return State.PressSwitch(this);
            if (_status == LightStatusEnum.Off)
            {
                _status = LightStatusEnum.On;
                return _status.ToString();
            }
            if (_status == LightStatusEnum.On)
            {
                _status = LightStatusEnum.LightAll;
                return _status.ToString();
            }
            if (_status == LightStatusEnum.LightAll)
            {
                _status = LightStatusEnum.LightThree;
                return _status.ToString();

            }
            if (_status == LightStatusEnum.LightThree)
            {
                _status = LightStatusEnum.LightTwo;
                return _status.ToString();

            }
            if (_status == LightStatusEnum.LightTwo)
            {

                _status = LightStatusEnum.LightOne;
                return _status.ToString();
            }
            if (_status == LightStatusEnum.LightOne)
            {
                _status = LightStatusEnum.Off;
                return _status.ToString();

            }
            return "";

        }
    */
}
