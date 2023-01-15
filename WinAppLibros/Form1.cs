using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppLibros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearDatos_Click(object sender, EventArgs e)
        {
            CargarDatos();

        }
        private static void CargarDatos()
        {
            Autor autor = new Autor("Jhon", "Doe", new DateTime(1989, 6, 21), "Av Siempre viva", "Oregon", "USA");
            string message = "Nombre: " + autor.Nombre + " " + autor.Apellido + "\n";
            message += "Fecha Nacimiento:  " + autor.FechaNacimiento + " " + "Direccion: " + autor.Domicilio + "\n";
            message += "Ciudad: " + autor.FechaNacimiento + " " + "Pais: " + autor.Pais;
            MessageBox.Show(message);

            Empleado empleado = new Empleado("Jane", "Smith", "Recepcionista", new DateTime(2023, 1, 1));
            message = "Nombre: " + empleado.Nombre + " " + empleado.Apellido + "\n";
            message += "Fecha Ingreso  " + autor.FechaNacimiento + "\n" + "Titulo: " + empleado.Titulo;
            MessageBox.Show(message);
        }
    }
}
