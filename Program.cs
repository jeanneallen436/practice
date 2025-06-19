// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");

string friend = "    Bill    ";

Console.WriteLine(double.MaxValue);
Console.WriteLine(double.MinValue);
double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);

decimal e = 1.0M;

double rad = 2.50;
double ans = Math.PI * (rad * rad);

Console.WriteLine(ans);

var tup = (X: 1, Y: 2);
var tup2 = tup with { Y = 10, X = 5 };

Console.WriteLine(tup2);

// return two elements from a function
// public (int Age, string Name) GetPersonInfo() { return (30, "Alice"); }

/*
All named types in C# are either class or struct types. A class is a reference type. A struct is a value type. Variables of a value type store the contents of the instance inline in memory. In other words, a record struct Point stores two integers: X and Y. Variables of a reference type store a reference, or pointer, to the storage for the instance. In other words, a record class Point stores a reference to a block of memory that holds the values for X and Y.
*/

/*
A cast operation between reference types doesn't change the run-time type of the underlying object; it only changes the type of the value that is being used as a reference to that object. For more information, see Polymorphism. ??
*/

/*
You use the struct, class, interface, enum, and record constructs to create your own custom types.
*/