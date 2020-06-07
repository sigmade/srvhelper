using System;
using System.Diagnostics;

namespace IPhelperLib
{
    public class PingInfo
    {
         public static string Ping(string ipinfo)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c chcp 65001 & ping {ipinfo}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            });


            string pin = process.StandardOutput.ReadToEnd();
            return pin;

        }
    }
}
