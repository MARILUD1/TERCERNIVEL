

//registro de aportes de integrantes de una asociación de empleados de
//una institución.

using System;
using System.Collections.Generic;

namespace RegistroAportes
{
    // Clase para representar un socio
    public class Socio
    {
        public int IdSocio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<decimal> Aportes { get; set; }

        public Socio(int socio, string nombre, string apellido)
        {
            IdSocio =socio;
            Nombre = nombre;
            Apellido = apellido;
            Aportes = new List<decimal>();
        }

        public void RegistrarAporte(decimal monto)
        {
            Aportes.Add(monto);
        }

        public decimal ObtenerTotalAportes()
        {
            decimal total = 0;
            foreach (var aporte in Aportes)
            {
                total += aporte;
            }
            return total;
        }

        public override string ToString()
        {
            return $"ID: {IdSocio}, Nombre: {Nombre} {Apellido}, Total Aportes: {ObtenerTotalAportes():C}";
        }
    }

    // Clase para administrar la asociación
    public class Asociacion
    {
        private List<Socio> socioss;

        public Asociacion()
        {
            socioss = new List<Socio>();
        }

        public void AgregarEmpleado(Socio socio)
        {
            socio.Add(socio);
        }

        public void RegistrarAporteEmpleado(int idEmpleado, decimal monto)
        {
            var socio socios = socio socios.Find(e => e.IdSocio == idsocio);
            if (socio != null)
            {
                socio.RegistrarAporte(monto);
                Console.WriteLine($"Aporte de {monto:C} registrado para {socio.Nombre} {socio.Apellido}");
            }
            else
            {
                Console.WriteLine("socio no encontrado.");
            }
        }

        public void MostrarEmpleados()
        {
            Console.WriteLine("\nLista de Empleados y Aportes:");
            foreach (var socio in
            {
                Console.WriteLine(socio.ToString());
            }
        }
    }

    // Clase principal con el punto de entrada
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancia de la asociación
            Asociacion asociacion = new Asociacion();

            // Crear socios
            Socio socio1 = new Socio(1, "Romel", "Pérez");
            Socio socio2 = new Socio(2, "wilma", "García");
            Socio socio3 = new Socio(3, "Esteban", "Quiroz");

            // Agregar socios
            asociacion.AgregarEmpleado(socio1);
            asociacion.AgregarSocio(socio2);
            asociacion.AgregarSocio(socio3);
            

            // Registrar aportes
            
            asociacion.RegistrarAporteIdsocio(1, 300.50m);
            asociacion.RegistrarAporteSocio(2, 500.75m);
            asociacion.RegistrarAporteSocio(3, 100.25m);
            asociacion.RegistrarAporteSocio(4, 100.25m);
             

            // Mostrar lista de socios
            asociacion.MostrarEmpleados();

            Console.WriteLine("\nPresione sobre una tecla para salir...");
            Console.ReadKey();
        }
    }
}
