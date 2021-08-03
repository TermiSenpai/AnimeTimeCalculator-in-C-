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

            while(true)
            {
                cap = capInput();
                animeTime(cap);

                Console.ReadLine();

                clearScreen();
            }
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
                    Console.ReadLine();
                    clearScreen();
                }

                if (userCapInput != 0)
                {
                    validInput = true;
                }

            }
            while (!validInput);

            return userCapInput;
        }
    
        static void animeTime(int capitulos)
        {
            int dias;
            int horas;
            int minutos;

            minutos = capitulos * 25;
            horas = minutos / 60;
            dias = horas / 24;
            horas %= 24;
            minutos %= 60;


            Console.WriteLine($"\nSe tardará un aproximado de {dias} días, {horas} horas y {minutos} minutos en ver ese anime.");
        }

        static void clearScreen()
        {
            Console.Clear();
        }
    }
}
