using System;

namespace CubeProperties
{
    public class CubeProperties
    {
        //Write a program that can calculate 
        //the length of the face diagonals,         ok
        //space diagonals,                          ok
        //volume and                                ok
        //surface area of a cube                    ok
        //by a given side. 
        //On the first line you will get the side of the cube. 
       

        public static double faceDiagonals(double sideSize)
        {
            double result = Math.Sqrt(2 * Math.Pow(sideSize,2));
            return result;
        }
        public static double spaceDiagonals(double sideSize)
        {
            double result = Math.Sqrt(3 * Math.Pow(sideSize, 2));
            return result;
        }
        public static double volumeOfCube(double sideSize)
        {
            double result = Math.Pow(sideSize, 3);
            return result;
        }
        public static double surfaceAreaOfCube(double sideSize)
        {
            double result = 6 * Math.Pow(sideSize, 2);
            return result;
        }


        public static void Main()
        {
            double sideSize = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine().ToLower();

            switch (operation)
            {//On the second line is given the parameter (face, space, volume or area).
                case "face":
                    double resultOfFace = faceDiagonals(sideSize);
                    Console.WriteLine($"{resultOfFace:f2}");
                    break;
                case "space":
                    double resultOfSpace = spaceDiagonals(sideSize);
                    Console.WriteLine($"{resultOfSpace:f2}");
                    break;
                case "volume":
                    double resultOfVolume = volumeOfCube(sideSize);
                    Console.WriteLine($"{resultOfVolume:f2}");
                    break;
                case "area":
                    double resultOfArea = surfaceAreaOfCube(sideSize);
                    Console.WriteLine($"{resultOfArea:f2}");
                    break;
                default:
                    break;
            }
        }
    }
}
