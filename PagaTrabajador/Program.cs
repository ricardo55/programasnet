using System;

namespace PagaTrabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Clear();
            

            String nombre;
            int horas;
            float paga,tasa=0.1f;
            float pagaBruta,impuesto,pagaNeta;

            Console.WriteLine("Programa que Calcula la paga de un Trabajador \n");

            Console.Write("Nombre del trabajador: \n");
            nombre=Console.ReadLine();

            Console.Write("Horas Trabajadas: \n");
            horas=int.Parse(Console.ReadLine());

            Console.Write("Paga por Hora: \n");
            paga=int.Parse(Console.ReadLine());

            //Proceso
            pagaBruta = horas * paga;
            impuesto = pagaBruta * tasa;
            pagaNeta = pagaBruta - impuesto;

            //Salida

            Console.Write($"El Trabajador {nombre} \n");
            Console.Write($"Trabajo {horas} horas, se le pago {paga} pesos por hora\n");
            Console.Write($"Se tiene un impuesto de {impuesto} \n");
            Console.Write($"Se tiene una paga Bruta de {pagaBruta} \n");
            Console.Write($"Se tiene una paga Neta de {pagaNeta} \n");

           
            





        }
    }
}
