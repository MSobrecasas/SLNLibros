using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Publicador
    {
        public Publicador(string nombre, string cuidad, string domicilio, string contacto, string pais)
        {
            Nombre = nombre;
            Cuidad = cuidad;
            Domicilio = domicilio;
            Contacto = contacto;
            Pais = pais;
        }

        public string Nombre { get; set; }
        public string Cuidad { get; set; }
        public string Domicilio { get; set; }
        public string Contacto { get; set; }
        public string Pais { get; set; }

    }
}