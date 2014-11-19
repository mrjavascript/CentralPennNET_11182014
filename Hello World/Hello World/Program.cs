using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(String.Format("Hello World it is {0}", DateTime.Now));

            Thread.Sleep(2000);
        }
    }
}
