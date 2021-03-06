﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to test console app, type help to get some help!");

            while (true)
            {
                string input = Console.ReadLine();

                int commandEndIndex = input.IndexOf(' ');

                string command = string.Empty;
                string commandParameters = string.Empty;

                if (commandEndIndex > -1)
                {
                    command = input.Substring(0, commandEndIndex);
                    commandParameters = input.Substring(commandEndIndex + 1, input.Length - commandEndIndex - 1);
                }
                else
                {
                    command = input;
                }

                command = command.ToUpper();

                switch (command)
                {
                    case "EXIT":
                        {
                            return;
                        }
                    case "HELP":
                        {
                            Console.WriteLine("  - enter EXIT to exit this application");
                            Console.WriteLine("  - enter CLS to clear the screen");
                            Console.WriteLine("  - enter FORECOLOR value to change text fore color (sample: FORECOLOR Red) ");
                            Console.WriteLine("  - enter BACKCOLOR value to change text back color (sample: FORECOLOR Green) ");
                            Console.WriteLine("  - enter VER to check version of this software...");
                            break;
                        }
                    case "VER":
                        {
                            Console.Clear();
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("  This is 1.00 version of this software...");
                            Console.WriteLine("  We are happy that you are using it :) ");
                            Console.WriteLine("  Also we hope you are happy too :D");
                            Console.WriteLine("---------------------------------------------");
                            break;
                        }
                    case "CLS":
                        {
                            Console.Clear();
                            break;
                        }

                    case "FORECOLOR":
                        {
                            try
                            {
                                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), commandParameters);
                            }
                            catch
                            {
                                Console.WriteLine("!!! Parameter not valid");
                            }

                            break;
                        }
                    case "BACKCOLOR":
                        {
                            try
                            {
                                Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), commandParameters);
                            }
                            catch
                            {
                                Console.WriteLine("!!! Parameter not valid");
                            }

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Bad or unknown command!!!");
                            break;
                        }
                }
            }
        }
    }
}
