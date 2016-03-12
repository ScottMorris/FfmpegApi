using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFfmpeg.Commands
{
	public class OutputFile : FfmpegCommand
	{
		private string _argument;
		public override string Argument
		{
			get { return $"\"{_argument}\""; }
			set { _argument = value; }
		}

		public override string Name { get { return "OutputFile"; } }

		public override string Switch { get { return string.Empty; } }
	}
}
