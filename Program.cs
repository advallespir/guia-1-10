using System;

namespace guia_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un texto para convertir en minusculas");
            string texto = Console.ReadLine();
            string textoToLower = texto.ToLower(new System.Globalization.CultureInfo("es-ES", false));
            Console.WriteLine(textoToLower);
            Console.ReadLine();

        }
    }
}
