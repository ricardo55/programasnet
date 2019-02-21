using System;
using ProyectoBancario.clases;

namespace ProyectoBancario
{
    class Program
    {
        static void Main1(string[] args)
        {
            /* 
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
            */
        }
        static void Main(string[] args)
        {
            Banco miBanco = new Banco("Mac Pato SA de CV");

            miBanco.AgregarCliente(new Cliente("Cachorrin 1"));
            miBanco.AgregarCliente(new Cliente("Cachorrin 2"));
            miBanco.AgregarCliente(new Cliente("Cachorrin 3"));
            miBanco.AgregarCliente(new Cliente("Cachorrin 4"));
            miBanco.AgregarCliente(new Cliente("Cachorrin 5"));

            miBanco.Clientes[0].AgregarCuenta(new CuentaDeCheques(100,2000));
            miBanco.Clientes[1].AgregarCuenta(new CuentaDeCheques(200,1000));
            miBanco.Clientes[1].AgregarCuenta(new CuentaDeAhorros(300,0.5));
            miBanco.Clientes[3].AgregarCuenta(new CuentaDeAhorros(1300,5000));
            miBanco.Clientes[3].AgregarCuenta(new CuentaDeCheques(1300,5000));

            miBanco.Clientes[0].Cuentas[0].Retira(300);
            miBanco.Clientes[1].Cuentas[1].Deposita(600);
            miBanco.Clientes[3].Cuentas[1].Deposita(50000);





            Console.WriteLine("-------- REPORTE GENERAL DEL BANCO------");
            Console.WriteLine($"Cliente: {miBanco.Nombre}");


            foreach (Cliente cte in miBanco.Clientes)
            {
                Console.WriteLine($"Cliente: {cte.Nombre}");
                Console.WriteLine("");
                foreach (CuentaBancaria cta in cte.Cuentas)
                {
                    Console.WriteLine("Cuentas:");
                    if (cta is CuentaDeAhorros)
                    {
                        Console.WriteLine($"Ahorros: saldo: {cta.Saldo}");
                        Console.WriteLine("");
                        
                    }else
                    {
                        Console.WriteLine($"Cheques: saldo: {cta.Saldo}");
                        Console.WriteLine("");
                        
                    }
                }
            }




        }
        
    }
}
