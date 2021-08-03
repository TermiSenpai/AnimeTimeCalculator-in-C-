using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeTimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int cap;
            int dias;
            int horas;
            int minutos;
            cap = capInput();

        }

        static int capInput()
        {
            bool validInput = false;
            int userCapInput = 0 ;
            do
            {
                Console.WriteLine("El calculo se realizará teniendo en cuenta que cada capítulo");
                Console.WriteLine("dura una aproximación de 25 min.");
                Console.WriteLine("Introduzca el numero total de capítulos del anime: ");
                try
                {
                    userCapInput = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\n---------------------------");
                    Console.WriteLine("Valor introducido no valido");
                    Console.WriteLine("---------------------------\n");
                    //Console.WriteLine(e);
                }

                if (userCapInput != 0)
                {
                    validInput = true;
                }

            }
            while (!validInput);

            return userCapInput;
        }
    }
}
