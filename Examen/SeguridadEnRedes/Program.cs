using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeguridadEnRedes.clases;

namespace SeguridadEnRedes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("");

            //Inicio una red

            Red red = new Red("Red Patito, S.A. de C.V.");
            red.Propietario = "Mr Pato Macdonald";
            red.Domicilio = "Av. Princeton 123, Orlando Florida";

            //Inicio los nodos

            Nodo nodo1 = new Nodo("192.168.0.10");
            Nodo nodo2 = new Nodo("192.168.0.12");
            Nodo nodo3 = new Nodo("192.168.0.20");
            Nodo nodo4 = new Nodo("192.168.0.15");

            //Pongo la informacion para cada nodo

            nodo1.Tipo = "servidor";
            nodo1.Puertos = 5;
            nodo1.Saltos = 10;
            nodo1.SO = "Linux";

            nodo2.Tipo = "equipoactivo";
            nodo2.Puertos = 2;
            nodo2.Saltos = 12;
            nodo2.SO = "iOS";

            nodo3.Tipo = "computadora";
            nodo3.Puertos = 8;
            nodo3.Saltos = 5;
            nodo3.SO = "Windows";

            nodo4.Tipo = "servidor";
            nodo4.Puertos = 10;
            nodo4.Saltos = 22;
            nodo4.SO = "Linux";

            //Agrego los nodos a cada red

            red.agregarNodos(nodo1);
            red.agregarNodos(nodo2);
            red.agregarNodos(nodo3);
            red.agregarNodos(nodo4);

            //Inicializo las vulnerabilidades

            Vulnerabilidad vuln1 = new Vulnerabilidad("CVE-2015-1635");
            Vulnerabilidad vuln2 = new Vulnerabilidad("CVE-2017-0004");
            Vulnerabilidad vuln3 = new Vulnerabilidad("CVE-2017-3847");
            Vulnerabilidad vuln4 = new Vulnerabilidad("CVE-2009-2504");
            Vulnerabilidad vuln5 = new Vulnerabilidad("CVE-2016-7271");
            Vulnerabilidad vuln6 = new Vulnerabilidad("CVE-2017-2996");
            Vulnerabilidad vuln7 = new Vulnerabilidad("CVE-2015-6545");

            //Agrego informacion a cada vulnerabilidad

            vuln1.Vendedor = "microsoft";
            vuln1.Descripcion = "HTTP.sys permite a atacantes remotos ejecutar código arbitrario";
            vuln1.TipoVulnerabilidad = "remota";
            vuln1.Fecha = "04/08/2015";

            vuln2.Vendedor = "microsoft";
            vuln2.Descripcion = "El servicio LSASS permite causar una denegación de servicio";
            vuln2.TipoVulnerabilidad = "local";
            vuln2.Fecha = "01/10/2019";

            vuln3.Vendedor = "cisco";
            vuln3.Descripcion = "Cisco Firepower Management Center XSS";
            vuln3.TipoVulnerabilidad = "remota";
            vuln3.Fecha = "02/08/2017";

            vuln4.Vendedor = "microsoft";
            vuln4.Descripcion = "Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1";
            vuln4.TipoVulnerabilidad = "local";
            vuln4.Fecha = "11/09/2009";

            vuln5.Vendedor = "microsoft";
            vuln5.Descripcion = "Elevación de privilegios Kernel Segura en Windows 10 Gold";
            vuln5.TipoVulnerabilidad = "local";
            vuln5.Fecha = "12/05/2016";

            vuln6.Vendedor = "adobe";
            vuln6.Descripcion = "Adobe Flash Player 24.0.0.194 corrupción de memoria explotable";
            vuln6.TipoVulnerabilidad = "remota";
            vuln6.Fecha = "15/02/2017";

            vuln7.Vendedor = "wordpress";
            vuln7.Descripcion = "Peticiones ilimitadas, XRHCP";
            vuln6.TipoVulnerabilidad = "remota";
            vuln7.Fecha = "02/05/2015";

            //Agrega vulnerabilidades a cada nodo

            nodo1.agregaVulnerabilidades(vuln1);
            nodo1.agregaVulnerabilidades(vuln2);
            nodo2.agregaVulnerabilidades(vuln3);
            nodo3.agregaVulnerabilidades(vuln4);
            nodo3.agregaVulnerabilidades(vuln5);
            nodo3.agregaVulnerabilidades(vuln6);
            nodo4.agregaVulnerabilidades(vuln7);

            // Informacion como debe de salir en pantalla

            Console.WriteLine(">> Datos generales de la red:\n");
            Console.WriteLine(red.ToString());
            Console.WriteLine("Total nodos red: " + red.TotalNodos);
            Console.WriteLine("Total vulnerabilidades: " + (nodo1.TotalVulnerabilidades + nodo2.TotalVulnerabilidades + nodo3.TotalVulnerabilidades + nodo4.TotalVulnerabilidades) + "\n");


            Console.WriteLine(">> Datos generales de los nodos:\n");
            foreach (Nodo nodo in red.Nodos)
            {
                Console.WriteLine(nodo.ToString()+ ", TotVul:" + nodo.VulnerabilidadNodo);
            }
            Console.WriteLine("\nMayor número de saltos: " + red.MayorSaltos);
            Console.WriteLine("Menor número de saltos: " + red.MenorSaltos);
            

            Console.WriteLine("\n>> Vulnerabilidades por nodo:\n");
            for (int i = 0; i < nodo1.Vulnerabilidades.Count; i++){
                if (i < 1) Console.WriteLine("> Ip: " + nodo1.IP + ", Tipo: " + nodo1.Tipo + "\n\nVulnerabilidades:");
                else if (i < 1 && nodo1.Vulnerabilidades.Count < 1) Console.WriteLine("No tiene vulnerabilidades ..");
                Console.WriteLine(nodo1.Vulnerabilidades[i].ToString());
            }
            for (int i = 0; i < nodo2.Vulnerabilidades.Count; i++)
            {
                if (i < 1) Console.WriteLine("\n> Ip: " + nodo2.IP + ", Tipo: " + nodo2.Tipo + "\n\nVulnerabilidades:");
                else if (i < 1 && nodo2.Vulnerabilidades.Count < 1) Console.WriteLine("No tiene vulnerabilidades ..");
                Console.WriteLine(nodo2.Vulnerabilidades[i].ToString());
            }
            for (int i = 0; i < nodo3.Vulnerabilidades.Count; i++)
            {
                if (i < 1) Console.WriteLine("\n> Ip: " + nodo3.IP + ", Tipo: " + nodo3.Tipo + "\n\nVulnerabilidades:");
                else if (i < 1 && nodo3.Vulnerabilidades.Count < 1) Console.WriteLine("No tiene vulnerabilidades ..");
                Console.WriteLine(nodo3.Vulnerabilidades[i].ToString());
            }
            for (int i = 0; i < nodo4.Vulnerabilidades.Count; i++)
            {
                if (i < 1) Console.WriteLine("\n> Ip: " + nodo4.IP + ", Tipo: " + nodo4.Tipo + "\n\nVulnerabilidades:");
                else if (i < 1 && nodo4.Vulnerabilidades.Count < 1) Console.WriteLine("No tiene vulnerabilidades ..");
                Console.WriteLine(nodo4.Vulnerabilidades[i].ToString());
            }

            //Console.ReadLine();
            Console.WriteLine("");














        }//<--
    }
}
