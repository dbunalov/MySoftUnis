using System;
class Elevator
{
    static void Main()
    {
        double persons = double.Parse(Console.ReadLine());
        double elevatorCapacity = double.Parse(Console.ReadLine());
        double totalCourses = 0.0;
        double coursesDone = 0.0;
        double personsRemain = 0.0;
        double coursesRemain = 0.0;
        double personsDone = 0.0;

        if (elevatorCapacity > persons) //if capacity is bigger than number of persons
        {
            totalCourses = persons / elevatorCapacity;
            Console.WriteLine(Math.Ceiling(totalCourses));
        }
        else if (persons % elevatorCapacity != 0)
        {
            totalCourses = persons / elevatorCapacity;
            coursesDone = Math.Floor(totalCourses);
            personsRemain = persons - (elevatorCapacity * coursesDone);
            personsDone = persons - personsRemain;
            coursesRemain = totalCourses - coursesDone;

            Console.WriteLine(coursesDone + Math.Ceiling(coursesRemain));
        }
        else if (persons > elevatorCapacity)
        {
            totalCourses = persons / elevatorCapacity;
            totalCourses = Math.Ceiling(totalCourses);
            Console.WriteLine(totalCourses);
        }
    }
 }