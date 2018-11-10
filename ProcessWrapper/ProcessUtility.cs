using System;
using System.Diagnostics;

namespace ProcessWrapper
{
    public class ProcessUtility : IProcessUtility
    {
        private Process _process;

        public ProcessUtility()
        {
            _process = new Process();
            _process.Exited += Process_Exited;
        }

        public event EventHandler Exited;

        public bool EnableRaisingEvents { get; set; }

        public string ProcessName => _process.ProcessName;

        public bool HasExited => _process.HasExited;

        public int ExitCode => _process.ExitCode;

        public void Start(ProcessStartInfo startInfo)
        {
            _process.StartInfo = startInfo;
            _process.EnableRaisingEvents = EnableRaisingEvents;
            _process.Start();
        }

        public void Start(string fileName, string arguments)
        {
            var startInfo = new ProcessStartInfo(fileName, arguments);
            Start(startInfo);
        }

        public void Start(string fileName)
        {
            var startInfo = new ProcessStartInfo(fileName);
            Start(startInfo);
        }

        public void Kill()
        {
            _process.Kill();
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            Exited?.Invoke(this, e);
        }
    }
}
