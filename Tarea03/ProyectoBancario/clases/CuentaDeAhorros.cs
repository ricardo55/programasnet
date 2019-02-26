using System.Collections.Generic;
using System;
namespace ProyectoBancario.clases
{
    [Serializable]
    public class CuentaDeAhorros: CuentaBancaria //Hereda de la cuenta bancaria
    {
        private double tasa;


        //invocamos constructor de la clase base
        public CuentaDeAhorros(double saldo,double tasa):base(saldo) 
        {
            this.tasa=tasa;
        }

        
    }
}