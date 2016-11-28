using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
    public class Listener
    {
        public void Subscribe(Ticker t)
        {
            t.Tick += HeardIt;
        }

        private void HeardIt(Ticker t, TimeOfTick e)
        {
            Console.WriteLine("Heard It At {0}", e.Time);
        }

        
    }

    public class Test
    {
        public static void Main()
        {
            Ticker t = new Ticker();
            Listener l = new Listener();
            l.Subscribe(t);
            t.Start();
        }
    }
}
