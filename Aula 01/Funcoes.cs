using System.Runtime.InteropServices.ComTypes;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;

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
            Console.Clear();
            Console.WriteLine("Tabuada do número: ");
            double n1 = double.Parse(Console.ReadLine());
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
        public static void Calcular()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das quatro operações");
                Console.WriteLine("1 - Adição \t\t 2 - Subtração");
                Console.WriteLine(" 3 - Multiplicação \t\t 4 - Divisão \n\t\t 5 - Sair");
                int d = int.Parse(Console.ReadLine());
                switch (d)
                {
                    case 1:Adicao();
                    break;
                    case 2:Subtracao();
                    break;
                    case 3:Multiplicacao();
                    break;
                    case 4:Divisao();
                    break;
                    case 5:Menu();
                    break;
                    default:Calcular();
                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO!!   " + e);
                Console.ReadKey();
                Funcoes.Menu();
            }
            
        }
        public static void Adicao()
        {
            Console.Clear();
            Console.Write("Parcela 1: ");
            double p1 = double.Parse(Console.ReadLine());
            Console.Write("\n Parcela 2: ");
            double p2 = double.Parse(Console.ReadLine());
            Console.WriteLine("------------");
            Console.WriteLine("Soma: " + (p1+p2));
            Console.ReadKey();
            Calcular();
        }
        public static void Subtracao()
        {
            Console.Clear();
            Console.Write("Minuendo 1: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("\n Subtraendo 2: ");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("------------");
            Console.WriteLine("Resto: " + (m-s));
            Console.ReadKey();
            Calcular();
        }
        public static void Multiplicacao()
        {
            Console.Clear();
            Console.Write("Multiplicando: ");
            double m1 = double.Parse(Console.ReadLine());
            Console.Write("\n Mulitiplicador: ");
            double m2 = double.Parse(Console.ReadLine());
            Console.WriteLine("------------");
            Console.WriteLine("Produto: " + (m1*m2));
            Console.ReadKey();
            Calcular();
        }
        public static void Divisao()
        {
            Console.Clear();
            Console.Write("Numerador: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("\n Denominador: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("------------");
            Console.WriteLine("Quociente: " + (n/d));
            Console.ReadKey();
            Calcular();
        }
    }
}