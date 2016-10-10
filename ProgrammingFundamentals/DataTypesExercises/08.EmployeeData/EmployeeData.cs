using System;
class EmployeeData
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        long pID = long.Parse(Console.ReadLine());
        int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

        Console.WriteLine($"First name: {firstName}\nLast name: {lastName}\nAge: {age}\nGender: {gender}\nPersonal ID: {pID}\nUnique Employee number: {uniqueEmployeeNumber}");
    }
}
