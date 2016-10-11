using System;
using System.Collections.Generic;
using System.Linq;


namespace PhoneBookUpgrade
{
    class PhoneBookUpgrade
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
                    AddNewEntry(phonebook, commandArgs);

                }
                else if (command.Equals("S"))
                {
                    PrintEntry(phonebook, commandArgs);

                }
                else if (command.Equals("ListAll"))
                {
                    PrintAllEntries(phonebook);
                }

                commandLine = Console.ReadLine();
            }
        }

        private static void PrintAllEntries(Dictionary<string, string> phonebook)
        {
            List<KeyValuePair<string, string>> orderedPhoneBook = phonebook.OrderBy(x => x.Key).ToList();

            foreach (var entry in orderedPhoneBook)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }

        private static void PrintEntry(Dictionary<string, string> phonebook, string[] commandArgs)
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

        private static void AddNewEntry(Dictionary<string, string> phonebook, string[] commandArgs)
        {
            string contact = commandArgs[1];
            string number = commandArgs[2];

            //phonebook.Add(contact, number);// just add without replace
            phonebook[contact] = number; // add and replace
        }
    }
}
