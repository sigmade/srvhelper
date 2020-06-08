using System;
using System.Diagnostics;
using System.Text;

namespace IPhelperLib
{
    public class Diagnostic
    {
        public string Ip { get; set; }
        public string Domen { get; set; }
        public string ExecutePing()
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c chcp 65001 & ping {Ip}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            });

            string ping = process.StandardOutput.ReadToEnd();
            return ping;
        }
        public string ExecuteTrace()
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c chcp 65001 & tracert {Domen}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            });

            string trace = process.StandardOutput.ReadToEnd();
            return trace;
        }
    }
}
