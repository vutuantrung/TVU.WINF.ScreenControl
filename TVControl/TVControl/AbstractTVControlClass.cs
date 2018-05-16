using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVControl
{
    public abstract class AbstractTVControlClass
    {
        public abstract void On();

        public abstract void Off();

        public abstract string GetPowerStatus();

        public abstract string SetPowerOn();

        public abstract string SetPowerOff();

        public abstract string GetVolMuteStatus();

        public abstract string SetVolMuteOn();

        public abstract string SetVolMuteOff();

        public abstract string GetVolValue();

        public abstract string SetVolValue(int volValue);
    }
}
