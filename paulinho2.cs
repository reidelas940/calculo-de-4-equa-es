using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paulinho2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opção;
            double resultado, numero1, numero2;

            Console.WriteLine("escolha a operação");
            Console.WriteLine("1- soma");
            Console.WriteLine("2- subtração");
            Console.WriteLine("3- divisão");
            Console.WriteLine("3- multiplicação");

            opção = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opção)
            {

                case 1:
                    Console.WriteLine("Insira o numero1");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira o numero2");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 + numero2 ;

                    Console.WriteLine(resultado);

                    break;

                case 2:
                    Console.WriteLine("Insira o numero1");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira o numero2");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 - numero2 ;

                    Console.WriteLine(resultado);

                    break;


                case 3:
                    Console.WriteLine("Insira o numero1");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira o numero2");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 / numero2 ;

                    Console.WriteLine(resultado);

                    break;

                case 4:
                    Console.WriteLine("Insira o numero1");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira o numero2");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 * numero2;

                    Console.WriteLine(resultado);

                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
