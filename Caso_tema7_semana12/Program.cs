using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_tema7_semana12
{
    internal class Program
    {
        static public void numeros_naturales()
        {
            Console.WriteLine("Ingresar número de N: ");
            int N = int.Parse(Console.ReadLine());
            int s = 0;
            for (int c = 1; c <= N; c++)
            {
                s += c;
                
            }
            Console.WriteLine($"La suma es: {s}");
        }

        static public int sumaNN_con_recursividad(int N)
        {
            if (N == 1)
            {
                return 1;
            }
            return N + sumaNN_con_recursividad(N - 1);
        }
        static public int sumaNP_con_recursividad(int N)
        {
            if (N == 2)
            {
                return 2;
            }
            return N + sumaNP_con_recursividad(N - 2);
            
        }

        static public long factorialesNN_con_recursividad(int N)
        {
           if (N == 1)
           {
               return 1;
           }
           return N * factorialesNN_con_recursividad(N - 1);
        }

        static public long exponente_recursividad(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            return a * exponente_recursividad(a, b - 1);
        }
        static public void numeros_naturales_con_recursividad(int N)
        {
            Console.WriteLine(N);
            if (N == 0)
            {
                return;
            }
            numeros_naturales_con_recursividad(N - 1);
            
        }
        static void Main(string[] args)
        {
            int opc;
            bool valor = true;
            while (valor)
            {
                Console.WriteLine("************************************************");
                Console.WriteLine("\t\tMenú de opciones");
                Console.WriteLine("************************************************");
                Console.WriteLine("[1] Suma de N números naturales");
                Console.WriteLine("[2] Sume de N números naturales con recursividad");
                Console.WriteLine("[3] Suma de N números naturales pares con recursividad");
                Console.WriteLine("[4] Factorial de N números naturales con recursividad");
                Console.WriteLine("[5] Potencia de un número natural con recursividad");
                Console.WriteLine("[6] Contero Regresivo con recursividad");
                Console.WriteLine("[7] Arreglos");
                Console.WriteLine("[8] Salir");
                Console.WriteLine("-----------------------------------------------");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        numeros_naturales();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese un número natural: ");
                        int N = int.Parse(Console.ReadLine());
                        Console.WriteLine($"La suma es: {sumaNN_con_recursividad(N)}");
                        break;
                    case 3:
                        Console.WriteLine("Ingrese un número natural par: ");
                        int N1 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"La suma de pares es: {sumaNP_con_recursividad(N1)}");
                        break;
                    case 4:
                        Console.WriteLine("Ingrese un número natural: ");
                        int N2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"El factorial es: {factorialesNN_con_recursividad(N2)}");
                        break;
                    case 5:
                        Console.WriteLine("Ingresar base: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresar exponente: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es: " + exponente_recursividad(a, b));
                        break;
                    case 6:
                        Console.WriteLine("Ingrese un número natural: ");
                        int N3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El contero regresivo es: ");
                        numeros_naturales_con_recursividad(N3);
                        break;
                    case 7:
                        break;
                    case 8:
                        valor = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
