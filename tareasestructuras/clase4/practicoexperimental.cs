

//registro de aportes de integrantes de una asociación de empleados de
//una institución.

using System;
using System.Collections.Generic;

class RegistroAportes

{
    // Clase para representar un socio
    public class Socio // Plublic: modificador de acseso público
    {
        public int IdSocio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<decimal> Aportes { get; set; }

        public Socio(int socio, string nombre, string apellido)
        {
            IdSocio =socio;//identificador del socio
            Nombre = nombre;
            Apellido = apellido;
            Aportes = new List<decimal>();// almacenamiento de los aporte del socio(Listas)
        }

        public void RegistrarAporte(decimal monto)// Instancia para crear el objeto socio,recibir montos de tipo decimal
        {
            Aportes.Add(monto);
        }

        public decimal ObtenerTotalAportes()//recorre la lista para sumar montos aportados 
        {
            decimal total = 0;
            foreach (var aporte in Aportes)
            {
                total += aporte;
            }
            return total;
        }

        public override string ToString()//Muestra un formato presentable que incluye el ID del socio, su nombre completo, y el total de sus aportes.

        {
            return $"ID: {IdSocio}, Nombre: {Nombre} {Apellido}, Total Aportes: {ObtenerTotalAportes():C}";
        }
    }

    // Clase para administrar la asociación
    public class Asociacion//Agrega socios y gestiona aportes
    {
        private List<Socio> socios;//Private Modificador de acseso privado

        public Asociacion()// Inicializacion de lista vacia
        {
            socios = new List<Socio>();
        }

        public void AgregarSocio(Socio socio) //recibe y agreaga los socios
        {
            socios.Add(socio);
        }

        public void RegistrarAporteIdSocio(int idSocio, decimal monto)// busca si existe o no tal socio
        {
            var socio = socios.Find(s => s.IdSocio == idSocio);
            if (socio != null)
            {
                socio.RegistrarAporte(monto);
                Console.WriteLine($"Aporte de {monto:C} registrado para {socio.Nombre} {socio.Apellido}");
            }
            else
            {
            Console.WriteLine("socio no encontrado.");// espaciado 
            }
        }
            public void MostrarSocios()// Recorre la lista e imprime la informacion de cada socio
        {
            Console.WriteLine("\nLista de Socios y Aportes:");
               Console.WriteLine();
            foreach (var socio in socios)
            {Console.WriteLine(socio.ToString());
           
              
            }
        }
    }
           
    // Clase principal con el punto de entrada
    class Program
    {
        static void Main(string[] args) // se ejecutan las intrucciones 
        {
            // Crear instancia de la asociación
            Asociacion asociacion = new Asociacion();

            // Crear socios
            Socio socio1 = new Socio(1, "Romel", "Pérez");
            Socio socio2 = new Socio(2, "wilma", "García");
            Socio socio3 = new Socio(3, "Esteban", "Quiroz");
            Socio socio4 = new Socio(4, "Leonel", "Quiroz");
            

            // Agregar socios
            asociacion.AgregarSocio(socio1);//Agraga socios a la lista interna de la asosiacion
            asociacion.AgregarSocio(socio2);
            asociacion.AgregarSocio(socio3);
            asociacion.AgregarSocio(socio4);
            

            // Registrar aportes
            
            asociacion.RegistrarAporteIdSocio(1, 500.75m);//Se imprime el Id del socio con su respectivo aporte
            asociacion.RegistrarAporteIdSocio(2, 500.75m);
            asociacion.RegistrarAporteIdSocio(3, 100.25m);
            asociacion.RegistrarAporteIdSocio(4, 100.25m);
             

            // Mostrar lista de socios
            
            asociacion.MostrarSocios();
            Console.WriteLine();
            Console.Write("EL EXITO NO SE MIDEPOR LO QUE LOGRAS, SINO POR LOS OBSTACULOS QUE SUPERAS");
            Console.WriteLine();
            Console.WriteLine("\nPresione sobre una tecla para salir...");
            Console.ReadKey();
            
        }
    }
}
