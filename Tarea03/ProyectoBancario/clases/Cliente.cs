namespace ProyectoBancario.clases
{
    public class Cliente
    {
         private string nombre;
         private CuentaBancaria cuenta;

        public Cliente(string nombre){
            this.nombre=nombre;

        }

        public Cliente(){
        }


        public string Nombre
        {
            get { return nombre;}
            //set { nombre = value;}
        }


       
        public CuentaBancaria Cuenta
        {
            get { return cuenta;}
            set { cuenta = value;}
        }
        
        
        
    }
}