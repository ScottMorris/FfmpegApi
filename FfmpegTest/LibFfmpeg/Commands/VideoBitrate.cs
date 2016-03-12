using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFfmpeg.Commands
{
	public class VideoBitrate : FfmpegCommand
	{
		public override string Argument { get; set; }

		public override string Name { get { return "VideoBitrate"; } }

		public override string Switch { get { return "-b:v"; } }
	}
}
