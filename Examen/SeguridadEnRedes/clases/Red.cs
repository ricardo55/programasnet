using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SeguridadEnRedes.clases
{
    public class Red
    {

        private string empresa;
        private string propietario;
        private string domicilio;
        public List<Nodo> nodos;

        public Red() { }

        public Red(string empresa)
        {
            this.empresa = empresa;
            nodos = new List<Nodo>();
        }


        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public string Propietario
        {
            get { return propietario; }
            set { propietario = value; }
        }

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public List<Nodo> Nodos
        {
            get { return nodos; }
        }

        public void agregarNodos(Nodo nodo)
        {
            nodos.Add(nodo);
        }

        public int TotalNodos
        {
            get { return nodos.Count; }
        }

        //Metodo que sirve para saber cual es el mayor del sato objetivo
        public int MayorSaltos
        {
            get
            {
                int mayor = 0;
                for (int i = 0; i < nodos.Count; i++)
                {
                    if (i == 0)
                    {
                        mayor = nodos[i].Saltos;
                    }
                    else
                    {
                        if (mayor < nodos[i].Saltos)
                        {
                            mayor = nodos[i].Saltos;
                        }
                    }
                }
                return mayor;
            }    
        }

        //Metodo que sirve para saber cual es el menor del sato objetivo

        public int MenorSaltos
        {
            get
            {
                int menor = 0;
                for (int i = 0; i < nodos.Count; i++)
                {
                    if (i == 0)
                    {
                        menor = nodos[i].Saltos;
                    }
                    else
                    {
                        if (menor > nodos[i].Saltos)
                        {
                            menor = nodos[i].Saltos;
                        }
                    }
                }
                return menor;
            }
        }

        //Metodo que sirve para mandar todo a imprimir con un formato necesario
        public override string ToString()
        {
            string todo = "";
            todo = todo + string.Format("Empresa     : {0}\n", empresa);
            todo = todo + string.Format("Propietario : {0}\n", propietario);
            todo = todo + string.Format("Domicilio   : {0}\n", domicilio);
            return todo;
        }

        
    }
}