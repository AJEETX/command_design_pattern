# command design pattern ![GitHub release](https://img.shields.io/github/release/ajeetx/command_design_pattern.svg?style=for-the-badge) ![Maintenance](https://img.shields.io/maintenance/yes/2019.svg?style=for-the-badge)

![Travis](https://img.shields.io/travis/AJEETX/command_design_pattern.svg) |![GitHub Release Date](https://img.shields.io/github/release-date/ajeetx/command_design_pattern.svg)|[![.Net Framework](https://img.shields.io/badge/DotNet-2.0-blue.svg?style=plastic)](https://www.microsoft.com/en-au/download/details.aspx?id=1639) | ![GitHub language count](https://img.shields.io/github/languages/count/ajeetx/command_design_pattern.svg) | ![GitHub top language](https://img.shields.io/github/languages/top/ajeetx/command_design_pattern.svg) |![GitHub repo size in bytes](https://img.shields.io/github/repo-size/ajeetx/command_design_pattern.svg) 
| ---          | ---        | ---      | ---        |  --- | --- |

---------------------------------------
## Introduction

A very simple Command design pattern implementation.   

## Repository codebase
 
The repository consists of a project:
1) Asp.Net Core2 Console 

## Features
Receiver: the component on which action implementation exist 
```
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
```

Command : 
```
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
```

Invoker :
```
class Switch
    {
        public void Press(ICommand cmd)
        {
            cmd.Execute();
        }
    }
```

### Support or Contact

Having any trouble? Check out our [documentation](https://github.com/AJEETX/command_design_pattern/blob/master/README.md) or [contact support](mailto:ajeetkumar@email.com) and we’ll help you sort it out.


[![HitCount](http://hits.dwyl.io/ajeetx/command_design_pattern/projects/1.svg)](http://hits.dwyl.io/ajeetx/command_design_pattern/projects/1) | ![GitHub contributors](https://img.shields.io/github/contributors/ajeetx/command_design_pattern.svg?style=plastic)|![license](https://img.shields.io/github/license/ajeetx/command_design_pattern.svg?style=plastic)|
 | --- | --- | ---|
