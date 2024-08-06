using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_behavioural_.Models
{
    internal class RemoteControl
    {
         ICommand _command;

        public RemoteControl(ICommand cmd)
        {
            _command = cmd;
        }

        //this method executes the current cmd on pressing the btn
        public void PressButton()
        {
            _command.Execute();
        }

        //method to change the cmd at runtime
        public void SetCommand(ICommand cmd)
        {
            _command = cmd;
        }


    }
}
