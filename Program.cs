using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2._18_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            book book1 = new book("Harry Potter", "JK Rowling", 400);

            Console.WriteLine(book1.title);
            Console.ReadKey();

        }
    }
}
