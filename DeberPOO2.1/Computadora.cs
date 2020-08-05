using System;
using System.Collections.Generic;
using System.Text;

namespace DeberPOO2._1
{
    class Computadora
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string CapacidadDeAlmacenamiento { get; set; }
        public string Modelo { get; set; }
        public float Costo { get; set; }
        private Cliente funcion;
        public Cliente Funcion { get { return funcion; } set { funcion = value; funcion.Dueño = this; } }
        public Cliente Propietario { get; set; }

        public string Caracteristicas()
        {
            return $"Las caracteristicas de esta computadora son {Nombre},{Marca},{Modelo}";

        }
        public string Ejecutar()
        {
            return $"Esta computadora es muy rapida al ejecutar";

        }

        public string Encender(string prNombre)
        {
            return $"Encendiendo {prNombre}";
        }
        public string Apagar(string pNombre)
        {
            return $"Apagando {pNombre}";
        }
    }
}
