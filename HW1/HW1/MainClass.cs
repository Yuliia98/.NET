using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var array = new int[5];
            Operations.ReadArray(array);
            Operations.WriteArray(array);
            Console.ReadKey();
        }

    }
}

