using System.Runtime.CompilerServices;
using System;
using System.Windows;
namespace Curso_de_CShARP_do_Torne_se_um_programador
{
    public interface Funcoes
    {
        public static void Menu()
        {
            int d;
            Console.Clear();
            Console.WriteLine("0 - Sair ");
            Console.WriteLine("1 - Ler Arquivo ");
            Console.WriteLine("2 - Tabuada ");
            Console.WriteLine("3 - Calcular");
            d = int.Parse(Console.ReadLine());
            if (d==1) LerArquivo();
            else if (d==2) Tabuada();
            else if (d==3) Calcular();
            else if (d==0) Environment.Exit(0);
            else Menu();
        }
        public static void LerArquivo()
        {

        }
        public static void Tabuada()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Tabuada do número: ");
                long n1 = long.Parse(Console.ReadLine());
                for(int i=0;i<=10;i++)
                {
                    Console.WriteLine("{0} * {1} = {2}",n1,i,(n1*i));
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Deseja calcular novamente?[s/n]");
                char d = char.Parse(Console.ReadLine());
                if (d=='s' || d == 'S') Tabuada();
                else if (d==n1||d=='N') Menu();
                else Environment.Exit(0);
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Error: " + e);
                Console.ReadKey();
                Menu();
            }
            
        }
        public static void Calcular()
        {

        }
    }
}