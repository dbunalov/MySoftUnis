using System;
using System.Collections.Generic;
using System.Linq;


namespace PhoneBook
{
    class PhoneBook
    {
        static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();


            string commandLine = Console.ReadLine();

            while (!commandLine.Equals("END")) // executes loop until receive END command
            {
                string[] commandArgs = commandLine.Split(' ');
                string command = commandArgs[0];

                if (command.Equals("A"))
                {
                    string contact = commandArgs[1];
                    string number = commandArgs[2];

                    //phonebook.Add(contact, number);// just add without replace
                    phonebook[contact] = number; // add and replace

                }
                else if (command.Equals("S"))
                {
                    string contact = commandArgs[1];
                    if (phonebook.ContainsKey(contact))
                    {
                        Console.WriteLine($"{contact} -> {(phonebook[contact])}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {contact} does not exist.");
                    }
                    
                }

                commandLine = Console.ReadLine();
            }
        }
    }
}
