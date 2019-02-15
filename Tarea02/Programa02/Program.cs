using System;

namespace Programa02
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           Random rnd=new Random();

           //Declarar 3 arreglos con 15 elementos vacios
           int [] A=new int[15];
           int [] B=new int[15];
           int [] C=new int[15];

           //Generar numeros aleatorios y llenar los vectores A y B

           for (int i = 0; i < A.Length; i++)
           {
               A[i]=rnd.Next(100);
               //Next(1,30);
               
           }

           for (int i = 0; i < B.Length; i++)
           {
               B[i]=rnd.Next(100);
               
           }

           //Sumar vector A y B y poner el resultado en C

            for (int i = 0; i < A.Length; i++)
           {
               C[i]=A[i]+B[i];
               
           }

           //Imprimir los vectores A, B y C

           Console.WriteLine("El vector A:");
           Imprimir(A);
           Console.WriteLine("\nEl vector B:");
           Imprimir(B);
           Console.WriteLine("\nEl vector C:");
           Imprimir(C);
           Console.WriteLine("");









        }

        //Metodo que sirve para imprimir los vectores
        static void Imprimir(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
                
            }

        }//cierra funcion
    }
}
