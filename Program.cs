using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList names = new ArrayList();

            //Add items to the arraylist 
            names.Add("Joe");
            names.Add("John");
            names.Add("Jack");
            names.Add("Steve");
            names.Add("Dave");

            Console.WriteLine("Names in ArrayList: ");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Using contains
            Console.WriteLine("\n Does the ArrayList contain 'John'? " + names.Contains("John"));

            //Using count
            Console.WriteLine("\n Total name in the ArrayList: " + names.Count);

            //Using Equals to compare 2 arrayLists
            ArrayList anotherList = new ArrayList();
            anotherList.Add("Joe");
            anotherList.Add("John");
            Console.WriteLine("\n Is names equal to anotherList? " + names.Equals(anotherList));

            //Using GetType
            Console.WriteLine("\n Type of names ArrayList: " + names.GetType());

            //Using OfType<>
            var stringNames = names.OfType<string>();
            Console.WriteLine("\n Names of type string: ");
            foreach (var name in stringNames)
            {
                Console.WriteLine(name);
            }

            names.Clear();
            Console.WriteLine("\n Names after clearing the Array List: " + names.Count);

            Console.ReadLine();
            
            /*
                // Declare Variables
                Stack<string> names = new Stack<string>();
                // Add items to the stack
                names.Push("Joe");
                names.Push("Joe");
                Console.WriteLine("Name on top of stack: " + names.Peek());
                names.Push("John");
                Console.WriteLine("Name on top of stack: " + names.Peek());
                names.Push("Jack");
                Console.WriteLine("Name on top of stack: " + names.Peek());
                names.Push("Steve");
                Console.WriteLine("Name on top of stack: " + names.Peek());
                names.Push("Dave");
                Console.WriteLine("Name on top of stack: " + names.Peek());
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Removing item for top of stack. ");

                if (!(names.Count == 0))
                {
                    Console.WriteLine("Name of top of stack is: " + names.Peek());
                    names.Pop();
                }
                if (!(names.Count == 0))
                {
                    Console.WriteLine("Name of top of stack is: " + names.Peek());
                    names.Pop();
                }
                if (!(names.Count == 0))
                {
                    Console.WriteLine("Name of top of stack is: " + names.Peek());
                    names.Pop();
                }
                if (!(names.Count == 0))
                {
                    Console.WriteLine("Name of top of stack is: " + names.Peek());
                    names.Pop();
                }
                if (!(names.Count == 0))
                {
                    Console.WriteLine("Name of top of stack is: " + names.Peek());
                    names.Pop();
                }
                Console.ReadLine();
            */
        }
    }
}
/*
Clear() method, would remove all the elements from the ArrayList
Contains(object item), shows whether an element is in the ArrayList
Count() would get the number of elements contained in the ArrayList
Equals(object obj) determines whether the specifed object is equal to the current object.
*/