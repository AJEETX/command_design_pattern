using System;
using System.Collections.Generic;
using System.Text;

namespace command_design_pattern
{
    public enum STATUS { OFF,ON}
    class Bulb
    {
        public void On()
        {
            Console.WriteLine("The light has been switched ON");
        }
        public void Off()
        {
            Console.WriteLine("The light has been switched OFF");
        }
    }
}
