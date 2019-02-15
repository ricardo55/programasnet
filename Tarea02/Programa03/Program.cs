using System;

namespace Programa03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

             // Console.WriteLine("Hello World!");
           Random rnd=new Random();

           //Declarar 1 arreglos con 20 elementos vacios
           double [] A=new double[20];
           double [] C=new double[20];
           

           //Generar numeros aleatorios y llenar los vectores A 

           for (int i = 0; i < A.Length; i++)
           {
               A[i]=rnd.Next(10);
               //Next(1,30);
               
           }

           

           //Elevar el vector A al cubo y poner el resultado en C

            for (int i = 0; i < A.Length; i++)
           {
               C[i]=Math.Pow(A[i],3);
               
           }

           //Imprimir los vectores A y C

           Console.WriteLine("El vector A:");
           Imprimir(A);
           Console.WriteLine("\nEl vector C:");
           Imprimir(C);
           Console.WriteLine("");




        }
         //Metodo que sirve para imprimir los vectores
        static void Imprimir(double[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
                
            }

        }//cierra funcion
    }
}
