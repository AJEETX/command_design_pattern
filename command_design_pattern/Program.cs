using System;
using System.Collections.Generic;

namespace command_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySwitch = new Switch(); // create the invoker 'Switch'

            var bulb = new Bulb(); //create receiver

            var onCmd = new Command<Bulb>(bulb, l => l.On()); // Pass 'bulb' receiver to create ON command 
            var offCmd = new Command<Bulb>(bulb, l => l.Off()); // Pass 'bulb' receiver to create OFF command 

            Console.WriteLine("Enter Commands (ON/OFF) : ");
            string cmd = Console.ReadLine();
            if(cmd.ToUpper()=="ON")
                mySwitch.Press(onCmd);   // pass the ON command to  invoker 'Switch' to process the command on the receiver 'bulb'
            else
                mySwitch.Press(offCmd);
            Console.ReadKey();
        }
    }
}
