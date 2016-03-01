using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibFfmpeg.Commands
{
    public class InputFile : FfmpegCommand
    {
        public override string Argument { get; set; }
        public override string Name { get { return "InputFile"; } }
        public override string Switch { get { return "-i";} }
    }
}
