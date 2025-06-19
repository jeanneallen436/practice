using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Animals
{
    public class Dog : Animal
    {
        public void Speak()
        {
             Console.WriteLine("A dog says woof");
        }
    }
}