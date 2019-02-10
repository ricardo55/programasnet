using System;

namespace Programa03
{
    class Program
    {
        //Programa que sirve para imprimir las tablas de multiplicar
        //Ricardo Villagrana
        //07/02/18
       
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("1. Imprimir una tabla de multiplicar específica hasta cierto número");
                Console.WriteLine("2. Imprimir las tablas deseadas hasta el número deseado");
                Console.WriteLine("3. Salir");
                opcion=int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:{

                        tablasTodas();
                    }break;

                    case 2:{

                        tablaSola();

                    }break;
                    
                    default:
                    Console.WriteLine("");
                    break;
                }
                
            } while (opcion!=3);
           


            
        }

        static void tablasTodas(){
             Console.WriteLine("Tablas de Multiplicar");
            Console.WriteLine ("Desde el rango A: ");
            int A=int.Parse(Console.ReadLine());
            Console.WriteLine ("Hasta el rango B: ");
            int B=int.Parse(Console.ReadLine());
            Console.Clear();
   
   
            for(int i=A;i<=B;i++){
   
            for(int j=1;j<=10;j++){
                Console.WriteLine (i+"x"+j+"="+(i*j));
     
            }
            Console.WriteLine (" ");
   
    
         }
            //Console.ReadKey();
           // Console.WriteLine (" ");
  

        }

         static void tablaSola(){

            int number=1;
             
            Console.WriteLine("Introduce un número:");
            number=int.Parse(Console.ReadLine());
             
            for(int i=1; i<=10;i++)
            {
                Console.WriteLine(number+"x"+i+"="+(i*number));
            }
             
             
            Console.Write("Presiona cualquier tecla para continuar . . . ");
            Console.ReadKey(true);
        

        }

       
    }
}
