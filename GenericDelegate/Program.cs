using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork((a, b) => { return a * b; }, 1.2, 3.0);  //Type double here
            DoWork((a, b) => { return a / b; }, 6, 2);      //Type int here
            DoWork((a, b) => { return a + b; }, "lo", "ve!");//Type string here
            Console.ReadKey();
        }
        static void DoWork<T>(Func<T, T, T> func1, T a, T b)
        {
            T result = func1(a, b);
            Console.WriteLine(result);
        }
    }
}
