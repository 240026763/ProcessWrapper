using System;
using System.Diagnostics;

namespace ProcessWrapper
{
    public interface IProcessUtility
    {
        bool EnableRaisingEvents { get; set; }
        int ExitCode { get; }
        bool HasExited { get; }
        string ProcessName { get; }

        event EventHandler Exited;

        void Kill();
        void Start(ProcessStartInfo startInfo);
        void Start(string fileName);
        void Start(string fileName, string arguments);
    }
}