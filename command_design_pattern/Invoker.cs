using System;
using System.Collections.Generic;
using System.Text;

namespace command_design_pattern
{
    class Switch
    {
        public void Press(ICommand cmd)
        {
            cmd.Execute();
        }
    }
}
