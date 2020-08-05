using System;

namespace DeberPOO2._1
{
    class Audifono
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public float Costo { get; set; }
        public Audifono Clientes { get; set; }

        //Volumen
        public string EstadoVolumen()
        {
            return $"Su volumen esta Alto";
        }
        public string Encender(string prNombre)
        {
            return $"Encendiendo{prNombre}";
        }
        public string Apagar(string pNombre)
        {
            return $"Apagando{pNombre}";
        }

    }
}




