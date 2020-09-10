using System.Collections.Generic;
using System;

namespace Curso_de_CShARP_do_Torne_se_um_programador
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var a = new List<int>();
            foreach(int element in a)
            {
                a.Add(3);
                a[1] = 2;
                Console.WriteLine(a[2]==1?"a0 é 1":" ");
                Console.WriteLine(a[1]==2? "a[1] é 2":" ");
                Console.WriteLine(a.Exists(e => e == 3)? "hello":" ");
            }
        }
    }
}
