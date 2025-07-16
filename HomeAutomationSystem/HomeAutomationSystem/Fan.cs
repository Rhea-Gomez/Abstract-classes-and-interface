using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomationSystem
{
    internal class Fan : ISwitchable, IStatusReportable
    {
        public bool Switch1 {  get; set; } = false;
        
        
        
        public void Switch()
        {

            Switch1 = !Switch1;
            if (Switch1)
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
            int speedOfFan = random.Next(5);
            if (Switch1)
            {
                Console.WriteLine("Status: Fan is On");
                Console.WriteLine("Fan is at Speed " + speedOfFan);
            }
            else
            {
                Console.WriteLine("Status: Fan is Off");
            }
        }
    }
}
