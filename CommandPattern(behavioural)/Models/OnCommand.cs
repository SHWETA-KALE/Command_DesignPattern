using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_behavioural_.Models
{
    internal class OnCommand:ICommand
    {
        Television television;
        public OnCommand(Television tvobj)
        {
            television = tvobj;
        }

        public void Execute()
        {
            television.On();
        }
    }
}
