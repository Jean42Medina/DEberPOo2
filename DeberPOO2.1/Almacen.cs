using System;
using System.Collections.Generic;
using System.Text;

namespace DeberPOO2._1
{
    class Almacen
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string TipoDeEquipos { get; set; }

        Empleado trabajador;
        public Empleado MiTrabajo
        {
            get
            {
                return trabajador;
            }

            set
            {
                trabajador = value;
            }
        }

        public string PlazaTrabajo()
        {
           return $"vendedor";
        }

    }
}
