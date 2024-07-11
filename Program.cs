using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InOutParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tryparse example
            int number;
            Console.WriteLine("-------------------");
            Console.WriteLine("Try Parse Example");
            Console.WriteLine("-------------------");

            Console.WriteLine("Enter a number");
            if(int.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Your number is successfully converted "+number);
            else
                Console.WriteLine("Your number is not converted ");

            Console.WriteLine("-------------------");
            Console.WriteLine("In Out Example");
            Console.WriteLine("-------------------");
            //in and out example
            int n1 = 25, n2 = 15;
            if (Addition(in n1, in n2, out int sum))
                Console.WriteLine("Addition is greater than 50 :" + sum);
            else
                Console.WriteLine("Addition is less than 50 :" + sum);

            Console.WriteLine("-------------------");
            Console.WriteLine("Params Example");
            Console.WriteLine("-------------------");
            //params example
            showName("Jatin"," Kumar");
            showName("Software", " Developer");
        }

        //in out function
        static bool Addition(in int n1,in int n2,out int sum)
        {
            sum=n1 + n2;
            if (sum > 50)
                return true;
            return false;
        }

        // params example
        static void showName(params string[] names)
        {
            foreach(string name in names)
                Console.Write(name);
                Console.WriteLine();
        }
    }
}

