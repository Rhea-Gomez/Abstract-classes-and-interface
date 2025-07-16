using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomationSystem
{
    internal class Light
    {
        public bool Light1 { get; set; } = false;

        public void Switch()
        {
            Light1 = !Light1;
            if (Light1)
            {
                Console.WriteLine("Switched On successfully");
            }
            else
            {
                Console.WriteLine("Switched Off successfully");
            }
        }

        public void ReportStatus()
        {
            Random random = new Random();
            string[] colour = { "blue", "red", "dim", "green", "white", "off-white" };
            int status = random.Next(colour.Length);

            if(Light1)
            {
                Console.WriteLine("Light is turned on");
                Console.WriteLine(colour[status] + " light is turned on");
            }
            else
            {
                 Console.WriteLine("Light is turned off");
            }
        }
    }
}
