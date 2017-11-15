using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ServerConfiguration
    {
        public string DatabaseServerName { set; get; }
        public string ApplicationName { set; get; }

        public void LoadConfiguration()
        {
            Console.WriteLine("Configuration loaded");
        }

        public void SaveConfiguration()
        {
            Console.WriteLine("Database server name: " + DatabaseServerName
                + "\nApplication name: " + ApplicationName +
                "\nConfiguration saved");
        }

    }
}
