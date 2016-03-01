using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibFfmpeg
{
    public interface ICommand
    {
        string Name { get; }
        string Switch { get; }
        string Argument { get; set; }
    }
}
