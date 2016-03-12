using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFfmpeg.Commands
{
	public class VideoCodec : FfmpegCommand
	{
		public override string Argument { get; set; }

		public override string Name	{ get { return "VideoCodec"; } }

		public override string Switch { get { return "-c:v"; } }
	}
}
