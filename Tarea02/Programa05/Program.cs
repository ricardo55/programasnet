using System;

namespace Programa05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

             // Console.WriteLine("Hello World!");
           Random rnd=new Random();

           //Declarar 3 arreglos con 15 elementos vacios
           double [] A=new double[15];
           double [] B=new double[15];
           int tamReal=A.Length-1;
           

           //Generar numeros aleatorios y llenar los vectores A y B

           for (int i = 0; i < A.Length; i++)
           {
               A[i]=rnd.Next(1,30);
               //Next(1,30);
               
           }

           for (int i = 0; i < B.Length; i++)
           {
               B[i]=rnd.Next(100);
               
           }

           for (int i = tamReal; i >= 0 ; i--)
           {
               B[tamReal-i]=A[i]; 
               
           }


           //Imprimir los vectores A, B y C

           Console.WriteLine("El vector A:");
           Imprimir(A);
           Console.WriteLine("\nEl vector B:");
           Imprimir(B);
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
