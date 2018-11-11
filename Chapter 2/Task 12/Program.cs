using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            sbyte age = sbyte.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            int uniqueNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("string firstName = " + firstName);
            Console.WriteLine("string lastName = " + lastName);
            Console.WriteLine("sbyte age = " + age);
            Console.WriteLine("char sex = " + sex);
            Console.WriteLine("int uniqueNumber = " + uniqueNumber);
        }
    }
}
