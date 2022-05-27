using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_RoverControlCenter
{
    internal interface IDirectable
    {
        string GetInfo();
        string Explore();
        string Collect();
    }
}
