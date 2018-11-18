using System.Diagnostics;

namespace ProcessWrapper
{
    public class ProcessInfo : IProcessInfo
    {
        public bool IsProcessRunning(string processName)
        {
            return Process.GetProcessesByName(processName).Length > 0;
        }
    }
}
