using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaInmueble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inmueble inmueble = new Inmueble
            {
                Tipo = "Casa",
                Direccion = "221B Baker Street",
                Habitaciones = 1,
                Sanitarios = 1,
                Precio = 1500,
                Cliente = new Cliente
                {
                    Nombre = "Sherlock Holmes",
                    Direccion = "221 b Baker St, London NW1 6XE, Reino Unido",
                    Telefono = "23012234"
                },
                Empleado = new Empleado
                {
                    Nombre = "Mrs. Hudson",
                    Departamento = "Ventas",
                    Telefono = 77456207
                },
                TipoContrato = "Alquiler"

            };
            inmueble.MostrarInformacion();
        }
       
    }


    class Cliente
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }

    class Empleado
    {
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public int Telefono { get; set; }
    }

    class Inmueble
    {
        public string Tipo { get; set; }
        public string Direccion { get; set; }
        public int Habitaciones { get; set; }
        public int Sanitarios { get; set; }
        public double Precio { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public string TipoContrato { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine("Tipo de inmueble:" + Tipo);
            Console.WriteLine("Direccion:" + Direccion);
            Console.WriteLine("Habitaciones:" + Habitaciones);
            Console.WriteLine("Sanitarios:" + Sanitarios);
            Console.WriteLine("Precio:" + Precio);
            Console.WriteLine("Cliente:" + Cliente.Nombre);
            Console.WriteLine("Empleado:" + Empleado.Nombre);
            Console.WriteLine("Departamento:" + Empleado.Departamento);
            Console.WriteLine("Tipo de contrato:" + TipoContrato);
        }
    }

    
}
