namespace HomeAutomationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Fan fan = new Fan();
            Light light = new Light();
            do
            {
                Console.WriteLine("Which device would you like: ");
                Console.WriteLine("1. Fan \n2. Light \n3. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        
                        fan.ReportStatus();
                        if (fan.Switch1)
                        {
                            Console.WriteLine("Which action would you like to do:  ");
                            Console.WriteLine("1. Switch Off \n2. Report Status");
                            Console.Write("Enter your choice: ");
                            int choice1 = int.Parse(Console.ReadLine());

                            switch (choice1)
                            {
                                case 1:
                                    fan.Switch();
                                    break;
                                case 2:
                                    fan.ReportStatus();
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice!");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Which action would you like to do:  ");
                            Console.WriteLine("1. Switch On \n2. Report Status");
                            Console.Write("Enter your choice: ");
                            int choice1 = int.Parse(Console.ReadLine());

                            switch (choice1)
                            {
                                case 1:
                                    fan.Switch();
                                    break;
                                case 2:
                                    fan.ReportStatus();
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice!");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        
                        light.ReportStatus();
                        if (light.Light1)
                        {
                            Console.WriteLine("Which action would you like to do:  ");
                            Console.WriteLine("1. Switch Off \n2. Report Status");
                            Console.Write("Enter your choice: ");
                            int choice1 = int.Parse(Console.ReadLine());

                            switch (choice1)
                            {
                                case 1:
                                    light.Switch();
                                    break;
                                case 2:
                                    light.ReportStatus();
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice!");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Which action would you like to do:  ");
                            Console.WriteLine("1. Switch On \n2. Report Status");
                            Console.Write("Enter your choice: ");
                            int choice1 = int.Parse(Console.ReadLine());

                            switch (choice1)
                            {
                                case 1:
                                    light.Switch();
                                    break;
                                case 2:
                                    light.ReportStatus();
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice!");
                                    break;
                            }
                        }
                        break;
                    case 3: break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;

                }


            } while (choice != 3);
        }
    }
}
