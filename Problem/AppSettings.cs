using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    internal static class AppSettings
    {
        public static string Name { get; set; }

        public static string Version { get; set; }
        public static Uri Website { get; set; }
        public static string Publisher { get; set; }

        static AppSettings()
        {
            Name = "ConsoleApp";
            Version = "1.0.0";
            Website = new Uri("http://www.bing.com/");
            Publisher = "Microsoft";
        }
    }
}
