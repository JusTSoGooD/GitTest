// using System;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int response = 0;
            string name = "";
            string surname = "";
            int age = 0;
            int weight = 0;
            int height = 0;
            while (response != -1)
            {
                Console.WriteLine("Enter 0 to enter name" + Environment.NewLine +
                                    "Enter 1 to enter surname" + Environment.NewLine +
                                    "Enter 2 to enter age" + Environment.NewLine +
                                    "Enter 3 to enter weight" + Environment.NewLine +
                                    "Enter 4 to enter height" + Environment.NewLine +
                                    "Enter -2 to print your application" + Environment.NewLine +
                                    "Enter -1 to exit");

                response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    case 0:
                        {
                            name = Console.ReadLine();
                            break;
                        }
                    case 1:
                        {
                            surname = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            age = int.Parse(Console.ReadLine());
                            break;
                        }
                    case -1:
                        {
                            Console.WriteLine("You exited program");
                            break;
                        }
                    case -2:
                        {
                            Console.WriteLine(name);
                            Console.WriteLine(surname);
                            Console.WriteLine(age);
                            break;
                        }
                    case 3:
                        {
                            weight = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 4:
                        {
                            height = int.Parse(Console.ReadLine());
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Not valid command");
                            break;
                        }
                }
            }

            Console.ReadKey();
        }
    }
}
