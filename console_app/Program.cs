using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ConsoleApp.Animals;
using ConsoleApp.Interfaces;

namespace ConsoleApp
{
    internal class Program
    {
        // access modifier is private by default
        // public List<Animal> animals = new List<Animal>();
        public static List<Animal> animals = new List<Animal>();

        public static List<int> myList = [1, 2, 3];



        static async Task Main(string[] args)
        {
            // int one = myList.Find(n => n == 1);
            // int idx = myList.FindIndex(n => n == 3);
            // Cat newCat = new();
            // Console.WriteLine(newCat.ToString());
            // Cat newCat2 = new();
            // Console.WriteLine(newCat.Equals(newCat2));

            // string? nullableString = null;

            // Console.WriteLine(Convert.ToString(nullableString));

            // Console.WriteLine(int.MaxValue);
            int a = 2147483647;
            int b = 2147483647;
            try
            {
                int c = checked(a + b);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                // throw; This will show you the exception type you are throwing and you need to specifically catch that exception, it will stop the program unless followed by a catch block
            }
            catch (Exception)
            {
                //catch a general exception
                Console.WriteLine("General exception");
            }
            finally
            {
                Console.WriteLine("This is called after all catch blocks execute");
            }

            // unary operator
            // ++, --, -, !

            // tryParse


            // Console.WriteLine(c);

            Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                {"one", 1},
                {"two", 2},
                {"three", 3}
            };

            foreach (KeyValuePair<string, int> kvp in myDict)
            {
                Console.WriteLine($"Key is {kvp.Key} and val is {kvp.Value}");
            }

            //iterate through dict
            myDict.AsParallel()
            .ForAll(entry => Console.WriteLine(entry.Key + ":" + entry.Value));

            myDict["four"] = 4;

            Dictionary<int, Student> dictionaryStudents = new Dictionary<int, Student>
            {
                { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
                { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"} },
                { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}},

            };
            // string greeting = "Hello, World!";

            // Console.WriteLine(greeting);

            // // Console.ReadKey();
            // Cat myCat = new Cat();
            // Console.Write("What sound does a cat make?: ");
            // string userSound = Console.ReadLine();
            // Cat myCat2 = new Cat(userSound);
            // Cat myCat4 = new Cat("meow");
            // myCat4.Speak();
            // Cat myCat6 = new Cat(10, "squeak");
            // Cat myCat3 = new Cat("woof");
            // Program program = new();

            // Cat myCat5 = new Cat("chirp");
            // animals.Add(myCat5);

            // Dog myDog = new();
            // animals.Add(myDog);

            // foreach (Animal an in animals)
            //     an.Speak();

            // control flow: 
            /*
            if, else, else if; switch; goto label; (label:); try/catch; break/continue;
            */
            int condition = 10;
            switch (condition)
            {
                case 1:
                    Console.Write("one");
                    break;
                case 10:
                    Console.WriteLine("yay!");
                    break;
                default:
                    Console.WriteLine("condition not included");
                    break;
            }

            //nullable
            int? nullableNum = 20;
            nullableNum = null;

            Console.WriteLine(nullableNum);


            //pass by value vs. reference
            /*
            to update an object, automatically references memory address
            to update a value, use ref in front of type in param 
            Delegates => reference pointers to functions
            */


            //Datetime

            DateTime date = DateTime.ParseExact("01-01-1989", "dd-MM-yyyy", null, DateTimeStyles.None);

            Console.WriteLine(date.ToShortDateString());
            DateTime now = DateTime.Now;
            DateTime oneSecondLater = now.AddSeconds(2);
            int count = 0;
            while (true)
            {
                Console.WriteLine(count++);
                if (DateTime.Now > oneSecondLater)
                {
                    break;
                }
                await Task.Delay(200); //preferred in web apps
                if (count > 7)
                {

                    // Thread.Sleep(200);
                    continue; // will break out of this iteration of the loop and skip any following code
                }
                Console.WriteLine("less than 7");
            }

            Console.WriteLine("broke out of the loop");

            // arrays
            int[] myArray = new int[5];

            myArray[0] = 4;
            myArray[1] = 4;
            myArray[2] = 4;
            myArray[3] = 4;
            myArray[4] = 4;

            int[] init = { 1, 2, 3 };
            int[] init2 = new int[] { 1, 2, 3 };

            //2d array
            int[,] twoD = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            System.Console.WriteLine(twoD[1, 1]);
            
            int[][] jaggedArray = new int[][] // does not need to have the same size 
            {
                new int[] {1, 2, 3, 4},
                new int[] {5, 6},
                new int[] {7, 8, 9, 10, 11, 12}
            };
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
    }
}
