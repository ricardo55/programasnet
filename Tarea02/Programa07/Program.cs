using System;

namespace Programa07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que lee un arreglo de n elementos y realiza calculos");
            double[] A;
            int n;

            double elMayor=0;
            double elMenor=0;
            double valorPromedio = 0.0;
            double valorVarianza = 0.0;
            double valorDesviacion = 0.0;

            //Entrada
            Console.Write("Cuantos Elementos");
            n=int.Parse(Console.ReadLine());
            A=new double[n];

            Console.WriteLine("Dame los elementos de arreglo\n");
            leer(A);

            //Calculos
            elMayor=obtenerElementoMayor(A);
            Imprimir(A);
            elMenor=obtenerElementoMenor(A);
            valorPromedio=Media(A);
            valorVarianza=varianza2(A,n,valorPromedio);
            valorDesviacion=Math.Sqrt(valorVarianza);

           


            //Salida
            Console.WriteLine("Arreglo \n");
            Imprimir(A);
            Console.WriteLine($"Mayor {elMayor} \n");
            Console.WriteLine($"Menor {elMenor} \n");
            Console.WriteLine($"Media {valorPromedio} \n");
            Console.WriteLine($"Varianza {valorVarianza} \n");
            Console.WriteLine($"Desviacion Estandar {valorDesviacion} \n");






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

        //Metodo que sirve para leer los numeros por consola
        static void leer(double[] v){

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"Elemento {i+1}= ");
                v[i]=double.Parse(Console.ReadLine());
            }


        }//Cierra funcion leer

        static double obtenerElementoMayor(double[] V)
        {
            double m=V[0];
            for (int i = 0; i < V.Length; i++)
            {
                if (V[i]>m)
                {
                    m=V[i];
                    
                }
                
            }
            return m;



            
        }//termina elementos mayor

        static double Media(double[] V)
        {
            double s=0;
            for (int i = 0; i < V.Length; i++)
            {
                s+=V[i];
                
            }
            return (s/V.Length);

        }

        //Obtiene el elemento menor de un arreflo
        static double obtenerElementoMenor(double[] V)
        {
            double m=V[0];
            for (int i = 0; i < V.Length; i++)
            {
                if (V[i]<m)
                {
                    m=V[i];
                    
                }
                
            }
            return m;



            
        }//termina elementos menor
        

         //Metodo para calcular la Variaza
         static double varianza2(double[] V,int n,double media)
         {
             double s=0;
             for (int i = 0; i < V.Length; i++)
             {
                 s+=Math.Pow((V[i]-media),2);
                 
             }
             return (s/(n-1));

         }





    }
}
