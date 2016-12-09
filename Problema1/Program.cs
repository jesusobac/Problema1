using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            string directorio = @"C:\BNN(DESARROLLADOR.NET)\Problema1\Polindromo.txt";
            Console.WriteLine(string.Format("Procesando archivo {0}", directorio));

            if (File.Exists(directorio))
            {
                foreach (string fila in File.ReadAllLines(directorio, Encoding.Default))
                {
                    ProcesaFila(fila);
                }
            }
            else
            {
                Console.WriteLine(string.Format("El archivo {0} no existe", directorio));
            }
            Console.WriteLine("\nFin del proceso");
            Console.ReadKey();
        }

        private static void ProcesaFila(string fila)
        {
            try
            {
                char[] charArray = fila.ToCharArray();
                Array.Reverse(charArray);
                string filaInversa = new string(charArray);
                if (ObtienePolindromo(fila, filaInversa))
                {
                    Console.WriteLine(string.Format("{0} = {1} ?? true", fila, filaInversa));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(string.Format("{0} = {1} ?? false", fila, filaInversa));
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Error {0} en la fila {1}", fila, ex));
            }
        }

        private static bool ObtienePolindromo(string fila, string filaInversa)
        {
            string longest = string.Empty;
            string shortest = string.Empty;
            bool res = false;

            if (fila.Equals(filaInversa, StringComparison.OrdinalIgnoreCase))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
