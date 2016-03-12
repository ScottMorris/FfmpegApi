using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibFfmpeg;
using LibFfmpeg.Commands;

namespace FfmpegTest
{
    class Program
    {
        static void Main(string[] args)
        {
			var ffmpeg = new FfmpegWrapper(@"C:\Users\Scott\Source\Repos\FfmpegApi\FfmpegTest\Ffmpeg\64bit\bin\ffmpeg.exe");
			ffmpeg
				.AddCommands(
					new InputFile() { Argument = @"C:\Users\Scott\Videos\Costa Rica in 4K 1080p Sample.webm" },
					new VideoCodec() { Argument = "libx264"},
					new VideoBitrate() { Argument = "1M"},
					new OutputFile() { Argument = @"C:\Users\Scott\Videos\Costa Rica in 4K 1080p Sample x264.mkv"}
				)
				;
			ffmpeg.ExecuteCommands();

			Console.ReadLine();
		}
    }
}
