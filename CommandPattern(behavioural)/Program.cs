using CommandPattern_behavioural_.Models;

namespace CommandPattern_behavioural_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Television television = new Television();

            ICommand oncmd = new OnCommand(television);
            ICommand offcmd = new OffCommand(television);

            RemoteControl remoteControl = new RemoteControl(oncmd);

             remoteControl.PressButton();

           //change the cmd to turn the television off
            remoteControl.SetCommand(offcmd);
            //turning off tv using remote control
            remoteControl.PressButton();

        }


    }
}
