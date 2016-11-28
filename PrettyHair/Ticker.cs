using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
    
    public class Ticker
    {
        private bool Looper = true;

        public event TickHandler Tick;
        public EventArgs e = null;

        public delegate void TickHandler(Ticker t, TimeOfTick e);

        public void Start()
        {
            while (Looper)
            {
                System.Threading.Thread.Sleep(3000);
                if (Tick != null)
                {
                    TimeOfTick TOT = new TimeOfTick();
                    TOT.Time = DateTime.Now;
                    Tick(this, TOT);
                }
            }
        }
    }

    public class TimeOfTick : EventArgs
    {
        private DateTime TimeNow;

        public DateTime Time
        {
            set { TimeNow = value; }
            get { return this.TimeNow; }
        }
    }
}
