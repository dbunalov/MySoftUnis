using System;
class BooleanVariable
{
    static void Main()
    {
        string text = Console.ReadLine();
        bool isYesOrNo = Convert.ToBoolean(text);

        //if (isYesOrNo)
        //{
        //    Console.WriteLine("Yes");
        //}
        //else
        //{
        //    Console.WriteLine("No");
        //}

        Console.WriteLine(isYesOrNo ? "Yes" : "No"); //(expression ? true : false)
    }
}