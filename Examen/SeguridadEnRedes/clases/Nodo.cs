using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SeguridadEnRedes.clases
{
    public class Nodo:Red
    {

        private string ip;
        private string tipo;
        private int puertos;
        private int saltos;
        private string so;
        private List<Vulnerabilidad> vulnerabilidades;

        public Nodo() { }

        public Nodo(string ip)
        {
            this.ip = ip;
            vulnerabilidades = new List<Vulnerabilidad>();
        }

        public string IP
        {
            get { return ip; }
            set { ip = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int Puertos
        {
            get { return puertos; }
            set { puertos = value; }
        }

        public int Saltos
        {
            get { return saltos; }
            set { saltos = value; }
        }

        public string SO
        {
            get { return so; }
            set { so = value; }
        }

        public List<Vulnerabilidad> Vulnerabilidades
        {
            get { return vulnerabilidades; }
        }

        //Metodo que sirve para agregar vulnerabilidades
        public void agregaVulnerabilidades(Vulnerabilidad vuln)
        {
            vulnerabilidades.Add(vuln);
        }

        // Metodo que sirve para mostrar el total de vulnerabilidades
        public int TotalVulnerabilidades
        {
            get { return vulnerabilidades.Count; }
        }

        //Metodo que muestra el conteo de vulnerabilidades por nodo
        public int VulnerabilidadNodo
        {
            get { return vulnerabilidades.Count; }
        }

        //Metodo que sirve para imprimir todo lo necsario con un formato deseado
        public override string ToString()
        {
            return "IP: " + ip + ", Tipo: " + tipo + ", Puertos: " + puertos + ", Saltos: " + saltos + ", SO: " + so;
        }





        
    }//<--
}