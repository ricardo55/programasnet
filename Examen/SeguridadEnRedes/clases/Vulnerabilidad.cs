using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SeguridadEnRedes.clases
{
    public class Vulnerabilidad
    {

        private string clave;
        private string vendedor;
        private string descripcion;
        private string tipoVulnerabilidad;
        private string fecha;

        public Vulnerabilidad() { }

        public Vulnerabilidad(string clave)
        {
            this.clave = clave;
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public string Vendedor
        {
            get { return vendedor; }
            set { vendedor = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        
        public string TipoVulnerabilidad
        {
            get { return tipoVulnerabilidad; }
            set { tipoVulnerabilidad = value; }
        }
        
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        //Metodo que sirve para saber cual es la antiguedad de las vulnerabilidades con las fechas
        public string Antiguedad
        {
            get { return Math.Truncate((DateTime.Today-DateTime.Parse(fecha)).TotalDays/365).ToString(); }
        }

        //Metodo que sirve para imprimir todo lo necesario con el formato solicitado
        public override string ToString()
        {
            return "\nClave: " + clave + ", Vendedor: " + vendedor + ", Descripción: " + descripcion +
                ", Tipo: " + tipoVulnerabilidad + ", Fecha: " + fecha + ", Antiguedad: " + Antiguedad;
        }


        
    }//<--
}