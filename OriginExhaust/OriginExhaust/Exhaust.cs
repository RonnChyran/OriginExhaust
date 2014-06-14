using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace OriginExhaust
{
    public class Exhaust
    {
        public Origin origin;
        public string exeName;
        public Exhaust(string exeName, string originId)
        {
            this.origin = new Origin(String.Format(@"""/StartClientMinimized"" ""origin://LaunchGame/{0}""", originId));
            this.exeName = exeName;
        }
        public static Process GetProcess(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            if (processes.Length == 1)
            {
                return processes[0];
            }
            else
            {
                return null;
            }
        }

        public static bool IsProcessRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            if (processes.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Start()
        {
            origin.StartOrigin();
            while (true)
            {
                Process process = null;
                while (process == null)
                {
                    if (Exhaust.IsProcessRunning(this.exeName))
                    {
                        process = Exhaust.GetProcess(this.exeName);
                        break;
                    }
                    Thread.Sleep(500);
                }
                process.WaitForExit();
                origin.KillOrigin(10000);
                break;
            }
        }
    }
}
