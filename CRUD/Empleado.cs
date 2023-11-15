using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUD
{
    public class Empleado
    {
        public int legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string SectorTrabajo { get; set; }
        //public double Sueldo { get; set; }
        //public int horasTrabajadas { get; set; }
        //public double precioHoraTrabajo { get; set; }

        public Empleado(int legajo, string nombre, string apellido, int dni, string Sectortrabajo)
        {
            this.legajo = legajo;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI= dni;
            this.SectorTrabajo = Sectortrabajo;
        }
    }
}