using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Titulo
    {
        public Titulo(string nombreAutor, string ttitulo, string categoria, double precio, string notas)
        {
            NombreAutor = nombreAutor;
            Ttitulo = ttitulo;
            Categoria = categoria;
            Precio = precio;
            Notas = notas;
        }

        public string NombreAutor { get; set; }
        public string Ttitulo { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public string Notas { get; set; }
    }
}