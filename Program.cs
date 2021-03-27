using System;

namespace A133590.Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 4.");
            Console.WriteLine("Ingrese frases separadas con la tecla enter.");
            Console.WriteLine("El programa finalizará cuando ingrese \"fin\"");

            while (Console.ReadLine() != "fin") ;

            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
