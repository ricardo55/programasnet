using System.Collections.Generic;
using System;
namespace ProyectoBancario.clases
{
    [Serializable]
    public class Banco
    {
        public Banco()
        {

        }
        private string nombre;

        private List<Cliente> clientes;

        public Banco(string nombre)
        {
            this.nombre=nombre;
            clientes=new List<Cliente>();

        }




        public string Nombre
        {
            get { return nombre;}
            set { nombre = value;}
        }

        public void AgregarCliente(Cliente cte)
        {

            clientes.Add(cte);
        }

        public List<Cliente> Clientes
        {
            get{return clientes;}

        }
        





        
    }
}