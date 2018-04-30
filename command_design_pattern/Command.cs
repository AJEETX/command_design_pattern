using System;
using System.Collections.Generic;
using System.Text;

namespace command_design_pattern
{ 
    public interface ICommand
    {
        void Execute();
    }
    class Command<T> : ICommand
    {
        private T _target;private Action<T> _command;
        public Command(T target,Action<T> command)
        {
            _target = target;_command = command;
        }
        public void Execute()
        {
            _command(_target);
        }
    }
}

