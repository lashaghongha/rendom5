using rendom10;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace rendom5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate Inheritance and Polymorphism
            List<Person> people = new List<Person>
            {
                new Student("Alice", 20, 90),
                new Teacher("Bob", 45, "Mathematics")
            };

            foreach (var person in people)
            {
                person.PrintDetails();
                Console.WriteLine();
            }

            // Demonstrate Interface Implementation
            List<IMovable> movables = new List<IMovable>
            {
                new Car(),
                new Bicycle()
            };

            foreach (var movable in movables)
            {
                movable.Move();
            }

            // Demonstrate Abstraction
            List<Shape> shapes = new List<Shape>
            {
                new Circle(5),
                new Rectangle(4, 6)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area: {shape.CalculateArea()}");
            }
        }
    }
}


//1.სახელმწიფო და კლასები:

//rendom10 namespace-ში ყველა კლასი შედის.
//Person კლასი წარმოადგენს ზოგად პიროვნებას სახელით და ასაკით.
//Student და Teacher კლასები მემკვიდრეობით იღებენ Person კლასისგან და ამატებენ კონკრეტულ ველებს (Grade სტუდენტებისთვის და Subject მასწავლებლებისთვის).



//2.მემკვიდრეობა და პოლიმორფიზმი:

//PrintDetails მეთოდი გადატვირთულია Student და Teacher კლასებში, რათა მიაწოდოს სპეციფიკური დეტალები.
//Person ობიექტების სია გამოიყენება პოლიმორფიზმის დემონსტრირებისთვის.


//3.ინტერფეისის იმპლემენტაცია:
//IMovable ინტერფეისი განსაზღვრავს Move მეთოდს.
//Car და Bicycle კლასები იმპლემენტირებენ IMovable ინტერფეისს და თავიანთი Move მეთოდებს.


//4.აბსტრაქცია:

//Shape აბსტრაქტული კლასი განსაზღვრავს აბსტრაქტულ მეთოდს CalculateArea.
//Circle და Rectangle კლასები მემკვიდრეობით იღებენ Shape კლასისგან და თავიანთი CalculateArea მეთოდებს.

//5.მთავარი მეთოდი:

//მემკვიდრეობის და პოლიმორფიზმის დემონსტრირება Person ობიექტების სიით.
//ინტერფეისის იმპლემენტაციის დემონსტრირება IMovable ობიექტების სიით.
//აბსტრაქციის დემონსტრირება Shape ობიექტების სიით და მათი ფართობის გაანგარიშება.
