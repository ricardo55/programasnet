using System.Collections.Generic;
using System;
namespace ProyectoBancario.clases
{
    [Serializable]
    public class CuentaDeCheques: CuentaBancaria
    {
        private double sobreGiro;

        public CuentaDeCheques(double saldo,double sobreGiro):base(saldo)
        {
            this.sobreGiro=sobreGiro;
        }

         //override perimite sobrecargar el metodo original
        public override bool Retira(double cantidad)
        {
            if (cantidad > saldo)
            {
                double requiere= cantidad -saldo;
                
                if (sobreGiro < requiere)
                {
                    return false;
                    
                }else
                {
                    saldo=0.0;
                    sobreGiro -= requiere;
                }

            }else
            {
                saldo-=cantidad;
                return true;
            }
            return true;

        }//<--
        
    }
}