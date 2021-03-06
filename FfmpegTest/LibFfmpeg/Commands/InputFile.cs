﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibFfmpeg.Commands
{
    public class InputFile : FfmpegCommand
    {
		private string _argument;
		public override string Argument {
			get { return $"\"{_argument}\""; }
			set { _argument = value; }
		}
        public override string Name { get { return "InputFile"; } }
        public override string Switch { get { return "-i";} }
    }
}
