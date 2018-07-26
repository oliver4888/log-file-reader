using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFileEater.Classes
{
    class LogReader : IDisposable
    {
        private Action<object, DataReceivedEventArgs, string> DataCallback;
        private string LogFile;
        private Process p;
        public string LogFileName { get; private set; }

        public LogReader(Action<object, DataReceivedEventArgs, string> dataCallback, Action<string> addPage,string logFile)
        {
            DataCallback = dataCallback;
            LogFile = logFile;
            Run();
            LogFileName = Path.GetFileNameWithoutExtension(logFile);
            addPage(LogFileName);
        }

        public void Dispose()
        {
            DataCallback = null;
            if (!p.HasExited)
            {
                p.Kill();
            }
            GC.SuppressFinalize(this);
        }

        private void Run()
        {
            string currentLocation = Environment.CurrentDirectory;

            string powerShellExe = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.CreateNoWindow = true;
            psi.FileName = powerShellExe;
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;
            psi.Arguments = "Get-Content " + LogFile + " -Wait";
            psi.UseShellExecute = false;

            p = new Process();
            p.StartInfo = psi;
            p.EnableRaisingEvents = true;
            p.OutputDataReceived += new DataReceivedEventHandler(Output);
            p.ErrorDataReceived += new DataReceivedEventHandler(Output);
            p.Start();
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
        }

        private void Output(object sender, DataReceivedEventArgs e)
        {
			DataCallback?.Invoke(sender, e, LogFileName);
		}
    }
}
