using System;
using ProyectoBancario.clases;

namespace ProyectoBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos instancia de la clase y reservamos espacio de memoria
            CuentaBancaria miCuenta;
            miCuenta=new CuentaBancaria();
            miCuenta.Saldo = 100;
            miCuenta.Deposita(50);


            //Creamos instancia de la clase y asignamos espacio de memoria de una vez
            CuentaBancaria miOtraCuenta=new CuentaBancaria();
             //miOtraCuenta.Saldo = 300;
             miOtraCuenta.Deposita(10);

             Cliente miCliente = new Cliente("Juan Perez Diaz");
             miCliente.Cuenta=miCuenta;

             Cliente miOtroCliente=new Cliente("Maria Lopez Perez");
             miOtroCliente.Cuenta=miOtraCuenta;

             Cliente clientazo=new Cliente("Cahorrin Cachorron");
             clientazo.Cuenta=new CuentaBancaria(10000);
             
             if (miOtraCuenta.Retira(250))
             {
                 Console.WriteLine("Retiro exitoso");
             }else
             {
                 Console.WriteLine("No tienes saldo suficiente para el retiro");
                 
             }

             Console.WriteLine($"Saldo de mi cuenta 1 {miCuenta.Saldo}");
             Console.WriteLine($"Saldo de mi cuenta 2 {miOtraCuenta.Saldo}");

             //Imprimir datos del cliente y saldo de sus cuentas

             Console.WriteLine($"{miCliente.Nombre},{miCliente.Cuenta.Saldo}");
             Console.WriteLine($"{miOtroCliente.Nombre},{miOtroCliente.Cuenta.Saldo}");
             Console.WriteLine($"{clientazo.Nombre},{clientazo.Cuenta.Saldo}");





            Console.WriteLine("Hello World!");
        }
    }
}
