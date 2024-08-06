using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_behavioural_.Models
{
    internal class OffCommand : ICommand
    {
        Television television;

        public OffCommand(Television tv)
        {
            television = tv;
        }

        public  void Execute() {
            television.Off();
        }
    }
}
