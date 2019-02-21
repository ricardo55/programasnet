using System.Collections.Generic;
namespace ProyectoBancario.clases
{
    public class Banco
    {
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