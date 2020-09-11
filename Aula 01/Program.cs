using System.Collections.Generic;
using System;

namespace Curso_de_CShARP_do_Torne_se_um_programador
{
    class Program
    {
        static void Main(string[] args)
        {   
            try
            {
                Funcoes.Menu();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO!!   " + e);
                Console.ReadKey();
                Funcoes.Menu();
            }
        }
    }
}
