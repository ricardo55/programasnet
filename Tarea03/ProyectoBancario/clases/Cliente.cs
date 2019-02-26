using System.Collections.Generic;
using System;
namespace ProyectoBancario.clases
{
    [Serializable]
    public class Cliente
    {
         private string nombre;
         //private CuentaBancaria cuenta;
         private List<CuentaBancaria> cuentas; 

        public Cliente(string nombre){
            this.nombre=nombre;
            cuentas= new List<CuentaBancaria>();

        }

        public Cliente(){
        }


        public string Nombre
        {
            get { return nombre;}
            //set { nombre = value;}
        }


       
        public List<CuentaBancaria> Cuentas
        {
            get { return cuentas;}
            //set { cuenta = value;}
        }

        public void AgregarCuenta(CuentaBancaria cta)
        {
            cuentas.Add(cta);

        }
        
        
        
    }
}