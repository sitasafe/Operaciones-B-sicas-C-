
//Tarea Semana 2 Willan Efrén Álvarez Carmona
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace suma_resta_multiplicacion_division_residuo

}
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0, s = 0, r = 0, m = 0, d = 0, R = 0;
            Console.Write("Escribe  el Primer Número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Escribe Segundo Número: ");
            n2 = int.Parse(Console.ReadLine());
            s = n1 + n2;
            r = n1 - n2;
            m = n1 * n2;
            d = n1 / n2;
            R = n1 % n2;
            Console.WriteLine("La Suma de {0} + {1} = {2}", n1, n2, s);
            Console.WriteLine("La Resta de {0} - {1} = {2}", n1, n2, r);
            Console.WriteLine("La Multiplicación de {0} * {1} = {2}", n1, n2, m);
            Console.WriteLine("La división de {0} / {1} = {2}", n1, n2, d);
            Console.WriteLine("El Residuo  de {0} % {1} = {2}", n1, n2, R);
            // El operador de módulo (%) calcula el resto de dividir su primer operando por el segundo.
            Console.ReadKey();
        }
    }