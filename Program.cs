using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0, resta=0,suma=0;

            Console.WriteLine("Hola Mundo");
            Console.ReadLine();

            Console.WriteLine("primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("segundo numero");
            b = int.Parse(Console.ReadLine());
            resta = a - b;
            Console.WriteLine($"la resta es: {resta}");
            Console.ReadLine();

            Console.WriteLine("primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("segundo numero");
            b = int.Parse(Console.ReadLine());
            suma = a + b;
            Console.WriteLine($"la suma es: {suma}");

            Console.ReadKey();
        }
    }
}
