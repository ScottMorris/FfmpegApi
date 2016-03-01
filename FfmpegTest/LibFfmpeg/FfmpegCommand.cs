using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibFfmpeg
{
    public abstract class FfmpegCommand : ICommand
    {
        public abstract string Argument { get; set; }
        public abstract string Name { get; }
        public abstract string Switch { get; }
    }
}
