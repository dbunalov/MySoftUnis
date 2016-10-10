using System;

namespace _04.Fruit_or_Vegetable
{
    class FruitOrVegetable
    {
        static void Main(string[] args)
        {
//Плодовете "fruit" са banana, apple, kiwi, cherry, lemon и grapes
//Зеленчуците "vegetable" са tomato, cucumber, pepper и carrot
//Всички останали са "unknown"
//Да се изведе “fruit”, “vegetable” или “unknown” според въведения продукт.Примери:

            var product = Console.ReadLine();

            if (product == "banana" || product =="apple" || product == "kiwi" || product=="cherry" || product == "lemon" || product == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else Console.WriteLine("unknown");
        }
    }
}
