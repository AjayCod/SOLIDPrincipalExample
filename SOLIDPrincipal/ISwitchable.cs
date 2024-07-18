using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipal
{
    public interface ISwitchable
    {
        void TornOn();
        void TournOff();
        bool isOn { get; }
    }
    public class Light : ISwitchable
    {
        public bool isOn { get; private set; }

        public void TornOn()
        {
            isOn = true;
            Console.WriteLine("Light is on");
        }

        public void TournOff()
        {
            isOn = false;
            Console.WriteLine("Light is of");
        }
    }
    public class ElectricPowerSwitch
    {
        private ISwitchable _switchable;
        public ElectricPowerSwitch(ISwitchable switchable)
        {
            _switchable = switchable;
        }
       public void Press()
        {
            if (_switchable.isOn)
            {
                _switchable.TournOff();
            }
            else
            {
                _switchable.TornOn();
            }
        }
    }
}
