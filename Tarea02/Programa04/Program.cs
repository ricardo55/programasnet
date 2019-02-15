using System;

namespace Programa04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

             // Console.WriteLine("Hello World!");
           Random rnd=new Random();

           //Declarar 1 arreglos con 30 elementos vacios
           double [] A=new double[30];
           double pos=0,neg=0,cero=0,spos=0,sneg=0,scero=0;
           

           //Generar numeros aleatorios y llenar los vectores A 

           for (int i = 0; i < A.Length; i++)
           {
               A[i]=rnd.Next(-10,20);
               //Next(1,30);
               
           }
           Console.WriteLine("\nEl vector A: ");
           Imprimir(A);
           Console.WriteLine("");

           for (int i = 0; i < A.Length; i++)
           {
               if (A[i]==0)
               {
                   cero++;
                   scero+=A[i];
                   
               }
               else if (A[i]>0)
               {
                   pos++;
                   spos+=A[i];
                   
               }
               else
               {
                   neg++;
                   sneg+=A[i];
               }
               
               
           }
           Console.WriteLine($"Numeros positivos {pos} y suman {spos}");
           Console.WriteLine($"Numeros positivos {neg} y suman {sneg}");
           Console.WriteLine($"Numeros positivos {cero} y suman {scero}");
         


           










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
