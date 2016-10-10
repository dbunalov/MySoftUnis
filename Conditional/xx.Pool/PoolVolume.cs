using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xx.Pool
{
    class PoolVolume
    {
        static void Main(string[] args)
        {
 //Да се отпечата на конзолата едно от двете възможни състояния:
//До колко се е запълнил басейна и коя тръба с колко процента е допринесла. Всички проценти се свеждат до цяло число(без закръгляне).
//"The pool is [x]% full. Pipe 1: [y]%. Pipe 2: [z]%."
//Aко басейнът се е препълнил – с колко литра е прелял за даденото време, число с плаваща запетая
//"For [x] hours the pool overflows with [y] liters."
//Имайте предвид, че поради свеждането до цяло число се губят данни и нормално сборът на процентите да е 99 %, а не 100 %.


            var poolVolume = int.Parse(Console.ReadLine());
            var pipe1PerHr = int.Parse(Console.ReadLine());
            var pipe2PerHr = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());
            var percentige = 0.0;
            var pipe1Perc = 0.0;
            var pipe2Perc = 0.0;

            var filledWater = (pipe1PerHr * hours) + (pipe2PerHr * hours);
            var overFlow = filledWater - poolVolume;

            percentige = (filledWater / poolVolume) * 100;
            pipe1Perc = (pipe1PerHr * hours) / filledWater * 100;
            pipe2Perc = (pipe2PerHr * hours) / filledWater * 100;

            if (overFlow > poolVolume)// if there is overflow
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, overFlow);
            }
            else //if theres no overflow
            {
                Console.WriteLine("The pool is {0:0}% full. Pipe 1: {1:0}%. Pipe 2: {2:0} %.", percentige, pipe1Perc, pipe2Perc );
            }

        }
    }
}
