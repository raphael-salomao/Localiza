using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

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
                Menu();
            }
        }

        static void Start()
        {
            decimal number;

            Console.WriteLine("\nInforme o número maior que zero: ");

            try
            {
                List<decimal> divisorNumbers;
                var primeNumbers = new List<decimal>();

                number = Convert.ToDecimal(Console.ReadLine());

                using (var response = new HttpClient().GetAsync($"https://localhost:5001/DivisorNumbers/{number}").Result)
                {
                    if (!response.IsSuccessStatusCode)
                        throw new InvalidOperationException("Erro ao realizar os calculos.");

                    var result = response.Content.ReadAsStringAsync().Result;

                    if (string.IsNullOrWhiteSpace(result))
                        throw new InvalidOperationException("Erro ao ler o retorno dos calculos");

                    divisorNumbers = JsonConvert.DeserializeObject<List<decimal>>(result);
                }

                var stringDivisorNumbers = string.Join(",", divisorNumbers.Select(s => string.Format("'{0}'", s.ToString())));

                Console.WriteLine($"\nOs divisores do número informado são: {stringDivisorNumbers}");

                foreach (var item in divisorNumbers)
                {
                    using (var response = new HttpClient().GetAsync($"https://localhost:5001/PrimeNumbers/{item}").Result)
                    {
                        if (!response.IsSuccessStatusCode)
                            throw new InvalidOperationException("Erro ao realizar os calculos.");

                        var result = response.Content.ReadAsStringAsync().Result;

                        if (string.IsNullOrWhiteSpace(result))
                            throw new InvalidOperationException("Erro ao ler o retorno dos calculos");

                        if (JsonConvert.DeserializeObject<bool>(result))
                        {
                            primeNumbers.Add(item);
                        }
                    }
                }

                var stringPrimeNumbers = string.Join(",", primeNumbers.Select(s => string.Format("'{0}'", s.ToString())));

                Console.WriteLine($"\nOs divisores primos são: {stringPrimeNumbers}");

                Menu();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Entrada inválida!");
                Menu();
            }
        }
    }
}
