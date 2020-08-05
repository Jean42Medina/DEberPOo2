using System;
using System.Collections.Generic;
using System.Text;

namespace DeberPOO2._1
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Computadora Dueño { get; set; }
        private Computadora funcion;
        public Computadora Funcion { get { return funcion; } set { funcion = value; funcion.Propietario= this; } }
        private Parlante funcion1;
        public Parlante Funcion1 { get { return funcion1; } set { funcion1 = value; funcion1.Propietario = this; } }

    }
}
