using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Animals
{
    public class Cat : Animal
    {
        private string soundField = "purr";

        public override string ToString()
        {
            return "This is the cat class";
        }

        
        public static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;


        }

        // Lambda expression
        Func<int, bool> isPositive = x => x > 0;

        // public string Sound
        // {
        //     get
        //     {
        //         return soundField;
        //     }
        //     private set
        //     {

        //         if (value == "woof")
        //         {
        //             throw new Exception("That's not the sound a cat makes!");
        //         }

        //         sound = value;
        //     }
        // }

        public string Sound { get; set; }
        public Cat(string soundValue)
        {
            Sound = soundValue;
            Console.WriteLine(Sound);
        }

        public Cat()
        {
            Sound = "meow";
            Console.WriteLine(Sound);
        }

        public Cat(int amount, string sound)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write($"{sound} ");
            }
            Console.WriteLine();
        }

        public void Speak()
        {
            Console.WriteLine($"A cat says {Sound}");
        }
    }
}