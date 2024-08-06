using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_behavioural_.Models
{
    internal class Television
    {
        public void On()
        {
            Console.WriteLine("Television is turned On");
        }

        public void Off()
        {
            Console.WriteLine("Television is turned Off");
        }
    }
}
