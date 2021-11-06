using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, peso;
            string sexo, dsAltura;
            bool vfAltura;
            
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n-------------- Cálculo de Peso Ideal --------------\n");
            Console.ResetColor();

            Console.WriteLine("Insira suas especificações de sexo e altura, para\ncalcular o seu peso ideal.\n");

            Console.Write("Digite a sua altura em metros....................: ");
            dsAltura = Console.ReadLine();

            Console.Write("Digite 'M' para masculino ou 'F' para feminino...: ");
            sexo = Console.ReadLine().ToUpper();

            vfAltura = Double.TryParse(dsAltura, out altura);

            if (vfAltura)
            {
                if (sexo == "M" && altura < 3 && altura > 0.5)
                {
                    peso = altura * 72.7 - 58.0;
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n* Seu peso ideal é {peso:N1}kg.\n");
                    Console.ResetColor();
                }
                if (sexo == "F" && altura < 3 && altura > 0.5)
                {
                    peso = altura * 62.1 - 44.7;
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n* Seu peso ideal é {peso:N1}kg.\n");
                    Console.ResetColor();
                }
                if (sexo != "M" && sexo != "F" && (altura >= 3 || altura <= 0.5))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n* Insira corretamente suas especificações.\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("---------------------------------------------------\n");
                    Console.ResetColor();

                    Environment.Exit(-1);
                }
                if (sexo != "M" && sexo != "F")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n* Insira corretamente sua especificação de sexo.\n");
                    Console.ResetColor();
                }
                if (altura >= 3 || altura <= 0.5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n* Insira corretamente sua especificação de altura.\n");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n* Insira apenas números em sua especificação de altura.\n");
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("---------------------------------------------------\n");
            Console.ResetColor();
        }
    }
}
