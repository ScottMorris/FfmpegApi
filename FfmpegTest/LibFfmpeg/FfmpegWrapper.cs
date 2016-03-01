using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFfmpeg
{
    public class FfmpegWrapper
    {
		private string Path { get; set; }
		private List<FfmpegCommand> Commands { get; set; } = new List<FfmpegCommand>();
		private StringBuilder StandardOutput { get; set; } = new StringBuilder();
		private StringBuilder StandardError { get; set; } = new StringBuilder();

		public FfmpegWrapper(string pathToFfmpeg)
		{
			Path = pathToFfmpeg;
		}

		public FfmpegWrapper AddCommand(FfmpegCommand command)
		{
			Commands.Add(command);
			return this;
		}

		public void ExecuteCommands()
		{
			StandardOutput = new StringBuilder();
			StandardError = new StringBuilder();

			// Need a command builder
			var command = string.Join(" ", Commands.Select(c => $"{c.Switch} {c.Argument}"));

			var process = new Process();
			process.StartInfo.FileName = Path;
			process.StartInfo.Arguments = command;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.Start();

			process.OutputDataReceived += (sender, outputLine) => StandardOutput.AppendLine(outputLine.Data);
			process.ErrorDataReceived += (sender, outputLine) => StandardError.AppendLine(outputLine.Data);

			process.BeginOutputReadLine();
			process.BeginErrorReadLine();
			
			//var stdOutput = process.StandardOutput.ReadToEnd();
			//var stdError = process.StandardError.ReadToEnd();

			process.WaitForExit();
			process.Close();

			Console.WriteLine(StandardError.ToString()); // Test Only - REMOVE ME
		}

		private void Process_OutputDataReceived(object sender, DataReceivedEventArgs outputLine)
		{
			throw new NotImplementedException();
		}
	}
}
