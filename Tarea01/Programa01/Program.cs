﻿using System;

namespace Programa01
{
    class Program
    {
        static int Main(string[] args)
        {
            
            int op,c,suma=0;
            //Console.Clear();
            if (args.Length==0)
            {
                Console.WriteLine("Prgrama que ejemplifica el uso de ciclos y estructuras de control en c#\n");
                Console.WriteLine("Debes de especificar la opcion deseada\n");
                menu();
                return 1;
            }

            op=int.Parse(args[0]);
            switch (op)
            {
                case 1:{
                c=1;

                while(c<=100){
                    Console.Write($" {c} \n");
                    c++;
                    suma+=c;

                }

                }break;

                case 2:{

                    c=100;
                    while(c>=1){
                        Console.Write($" {c}\n");
                        suma+=c--;
                    }


                }break;

                case 3:{
                    for (int i = 50; i <= 200 ; i++)
                    {
                        suma+=1;
                        Console.Write($" {i}\n");
                        
                    }
                }break;

                case 4:{

                    // for (int i = 2; i <= 100 ; i++){
                    //     suma+=i;
                    //     Console.Write($" {i}\n");
                        
                    // }
                     for (int i = 2; i <= 100; i += 2) {
                         suma+=i;
                         Console.Write($" {i}\n");
                     }

                }break;

                case 5:{

                     for (int i = 99; i >=1; i-=2){
                        suma+=i;
                        Console.Write($" {i}\n");
                        
                    }


                }break;

                case 6: {
                    c=272;
                    while (c>=40)
                    {
                        Console.Write($" {c}\n");
                        suma+=c;
                        c-=4;
                    }
                }break;
                
                
                
               // default:
            }

            Console.WriteLine($"\nLa suma es {suma} ");
            return 0;



           

        }

        static void menu(){
           
            Console.WriteLine("1. Números del 1 al 100 con ciclo while");
            Console.WriteLine("2. Números del 100 al 1 con ciclo do .. while");
            Console.WriteLine("3. Números del 50 al 200 con ciclo for");
            Console.WriteLine("4. Números del 2 al 100 solo los pares con ciclo for");
            Console.WriteLine("5. Números del 99 al 1 solo los impares con ciclo for");
            Console.WriteLine("6. Números del 40 al 272 en decrementos de 4 con ciclo while");
           



        }

    }
}
