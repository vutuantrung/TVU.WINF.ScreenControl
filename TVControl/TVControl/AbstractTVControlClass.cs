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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pct"></param>
        /// <returns></returns>
        public abstract string GetPowerStatus(string pct);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pct"></param>
        /// <returns></returns>
        public abstract string SetPowerOn(string pct);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pct"></param>
        /// <returns></returns>
        public abstract string SetPowerOff(string pct);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pct"></param>
        /// <returns></returns>
        public abstract string GetVolMuteStatus(string pct);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pct"></param>
        /// <returns></returns>
        public abstract string SetVolMuteOn(string pct);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pct"></param>
        /// <returns></returns>
        public abstract string SetVolMuteOff(string pct);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pct"></param>
        /// <returns></returns>
        public abstract string GetVolValue(string pct);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="volValue"></param>
        /// <param name="pct"></param>
        /// <returns></returns>
        public abstract string SetVolValue(int volValue, string pct);
    }
}
