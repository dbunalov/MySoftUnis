using System;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            int posOne = 1;
            int posTwo = 1;
            int posThree = 1;
            int posFour = 1;
            int n = int.Parse(Console.ReadLine());

            if (n < 1)
            {
                n = 1;
            }
            else if (n > 600000)
            {
                n = 600000;
            }
            for (int j = 1111; j <= 9999; j++)
            {
                posOne = j / 1000 % 10;
                posTwo = j / 100 % 10;
                posThree = j / 10 % 10;
                posFour = j % 10;

                if (posOne == 0)
                {
                    j++;
                    posOne++;
                }
                else if (posTwo == 0)
                {
                    j++;
                    posTwo++;
                }
                else if (posThree == 0)
                {
                    j++;
                    posThree++;
                }
                else if (posFour == 0)
                {
                    j++;
                    posFour++;
                }
                
                if (n % posOne == 0 && n % posTwo == 0 && n % posThree == 0 && n % posFour == 0)
                {
                    Console.Write(j + " ");
                }
            }

        }
    }
}