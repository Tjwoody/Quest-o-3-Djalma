using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3_Djalma_N_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area1, area2, area3, baseT, altT, baseP, altP, baseM, Basem, altTR;
            int forma;
            Console.Write("Formas geométricas disponiveis para calculo da área\n");
            Console.Write("1 - Triangulo\n 2- Paralelogramo\n 3-Trapézio");
            Console.WriteLine();
            forma = Convert.ToInt32(Console.ReadLine());
            switch (forma)
            {
                case 1:
                    Console.Write("Qual a base do seu Triangulo em Cm?");
                    baseT = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Qual a altura do seu Triangulo em Cm?");
                    altT = Convert.ToInt32(Console.ReadLine());
                    area1 = ((baseT * altT) / 2);
                    Console.Write("A área do seu triangulo é" + area1 + "Cm");
                    break;
                case 2:
                    Console.Write("Qual a base do seu Paralelogramo Cm?");
                    baseP = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Qual a altura do seu Paralelogramo em Cm?");
                        altP = Convert.ToInt32(Console.ReadLine());
                    area2 = ((baseP * altP));
                    Console.Write("A área do seu Paralelogramo é" + area2+ "Cm");
                    break;
                case 3:
                    Console.Write("Qual a menor base do seu trapezio Cm?");
                    baseM = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Qual a maior base do seu Trapezio em Cm?");
                    Basem = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Qual a altura do seu Trapezio em Cm?");
                    altTR= Convert.ToInt32(Console.ReadLine());
                    area3 = (((baseM + Basem) * altTR) / 2);
                    Console.Write("A área do seu trapézio é " + area3 + "Cm");
                    break;
                   

            }
           
          
           
            

            Console.ReadKey();
        }
    }
}
