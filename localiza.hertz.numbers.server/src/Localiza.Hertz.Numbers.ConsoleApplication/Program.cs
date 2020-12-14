using System;

namespace Localiza.Hertz.Numbers.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, essa aplicação recebe o número informado e retorna os seus divisores e dentre os divisores os que são primos!");

            Menu();
        }

        static void Menu()
        {
            decimal number;

            Console.WriteLine("\nDigite 0 para iniciar ou 1 para sair: ");

            try
            {
                number = Convert.ToDecimal(Console.ReadLine());

                switch (number)
                {
                    case 0:
                        Start();
                        break;
                    case 1:
                        System.Environment.Exit(-1);
                        break;
                    default:
                        Menu();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Entrada inválida!");
            }
        }

        static void Start()
        {
            decimal number;

            Console.WriteLine("\nInforme o número maior que zero: ");

            try
            {
                number = Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Entrada inválida!");
            }
        }
    }
}
