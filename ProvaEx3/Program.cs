using System;

namespace ProvaEx3
{
    public class Programa
    {
        // mètode per comprovar si el número és parell o no
        public static bool IsEven(int numero)
        {
            return numero % 2 == 0;
        }

        public static void Main()
        {
            //constants
            const string Msg = "Introdueix un número:";
            //inici programa
            Console.WriteLine(Msg);
            int numero = Convert.ToInt32(Console.ReadLine());
            // comprovem si és parell o senar utilitzant el mètode IsEven
            if (IsEven(numero))
            {
                Console.WriteLine($"El número {numero} és parell.");
            }
            else
            {
                Console.WriteLine($"El número {numero} és senar.");
            }
        }
    }
}
