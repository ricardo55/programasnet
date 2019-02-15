using System;

namespace Programa06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            double leer;
            double [] Arreglo=new double[10];
            double [] B=new double[10];
            double [] C=new double[10];


            Console.WriteLine("Arreglo A");
            for (int i=0;i<Arreglo.Length;i++)
            {
                Console.WriteLine("Introduzca número\n");
                leer=double.Parse(Console.ReadLine());

                Arreglo[i]=leer;

            }

            Console.WriteLine("Arreglo B");
            for (int i=0;i<B.Length;i++)
            {
                Console.WriteLine("Introduzca número\n");
                leer=double.Parse(Console.ReadLine());

                B[i]=leer;

            }


           Console.WriteLine("Arreglo A");
           Imprimir(Arreglo);

           Console.WriteLine("Arreglo B");
           Imprimir(B);

           Console.WriteLine("Arreglo C Multiplicado");
           multiplicaArreglos(Arreglo,B,C);
           Imprimir(C);
           



        }

        // Multiplica Arreglos Tambien por otro metodo

         static double[] multiplicaVectores(double[] a, double[] b){
            double[] t= new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                t[i]=a[i]*b[i];
                
            }
            return t;
         }


        //Metodo que sirve para multiplicar los arreglos y en tercer arreglo los muestra multiuplicados

        static void multiplicaArreglos(double[] arr1, double[] arr2, double[] arr3)
        {
            //Array.Reverse(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i] * arr2[i];
            }
        }


         //Metodo que sirve para imprimir los vectores
        static void Imprimir(double[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");

                
            }
             Console.WriteLine(" ");


        }//cierra funcion

        static void leer(double[] v){

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"Elemento {i+1}= ");
                v[i]=double.Parse(Console.ReadLine());
            }


        }//Cierra funcion leer

    }
}
