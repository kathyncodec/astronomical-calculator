using System;
using System.IO.Pipes;

namespace AstronomicalCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Astronômica");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Converter Unidades Astronômicas");
            Console.WriteLine("2 - Calcular Gravidade em Outros Planetas");
            Console.WriteLine("3 - Sair");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    ConverterUnid();
                    break;

                case 2:
                    CalcGravidade();
                    break;

                case 3:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }



        }
        static void ConverterUnid()
        {
            Console.WriteLine("Digite a quantidade de anos Luz:");
            double anosLuz = Double.Parse(Console.ReadLine());

            double km = anosLuz * 9.461e12;
            double UA = anosLuz * 63241;
            Console.WriteLine($"{anosLuz} anos-luz equivalem a:");
            Console.WriteLine($"- {UA} Unidades Astronômicas (UA)");
            Console.WriteLine($"- {km} quilômetros (km)");
        }

        static void CalcGravidade()
        {
            var planetas = new (string, double)[]
            {
                ("Mercúrio", 3.7),
                ("Vênus", 8.87),
                ("Terra", 9.8),
                ("Marte", 3.71),
                ("Júpiter", 24.79),
                ("Saturno", 10.44),
                ("Urano", 8.69),
                ("Netuno", 11.15)
            };

            Console.WriteLine("Escolha um planeta:");
            for(int i = 0; i < planetas.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {planetas[i].Item1}");
            }

            int escolha = int.Parse(Console.ReadLine()) - 1;
            if(escolha <0 || escolha >= planetas.Length)
            {
                Console.WriteLine("Opção inválida!");

            }
            Console.WriteLine("Digite seu peso na Terra (kg):");

            double peso = double.Parse(Console.ReadLine());
            double gravidade = planetas[escolha].Item2;
            double pesoNoPlaneta = peso * (gravidade / 9.8);

            Console.WriteLine($"Seu peso em {planetas[escolha].Item1} seria aproximadamente {pesoNoPlaneta:F2} kg.");
        }
    }




}