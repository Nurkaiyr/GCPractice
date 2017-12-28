using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            GC.GetGeneration(person);
            GC.Collect();
            Console.WriteLine(GC.GetGeneration(person));
            Console.ReadLine();
        }
    }
}

