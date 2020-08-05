using System;

namespace DeberPOO2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Bienvenidos a Almacenes LaGanga");
            var random = new Random();
            //Instancias del cliente
            Computadora computadora = new Computadora
            
            {
                Id = new Random().Next(),
                Nombre = "Geimer",
                Marca = "HP",
                CapacidadDeAlmacenamiento = "2TB",
                Modelo = "Intel Corei7",
                Costo = 499,
                Funcion = new Cliente
                {
                    Id = random.Next(),
                    Nombre = "Alisson",
                    Apellido = "Chavez"
                }
            };
            Cliente cliente1 = new Cliente
            {
                Id = new Random().Next(),
                Nombre = "Jean",
                Apellido = "Pierre",
                Funcion = new Computadora
                {
                    Id = random.Next(),
                    Nombre = "Alisson",
                    Marca = "hp 250",
                    Costo = 140
                }
            };

            Parlante parlante = new Parlante
            {
                Id = new Random().Next(),
                Nombre = "Secuiryti 20",
                Marca = "Samsung",
                Costo = 50
            };

            Cliente cliente2 = new Cliente
            {
                Id = new Random().Next(),
                Nombre = "Sara",
                Apellido = "Velez",
                Funcion1 = new Parlante 
                {
                    Id = random.Next(),
                    Nombre = "Sony Spiria",
                    Marca = "Sony",
                    Costo = 140
                }
            };

            Audifono audifono = new Audifono
            {
                Id = new Random().Next(),
                Nombre = "SmartWatch 4",
                Marca = "Sony",
                Costo = 24
            };

            Cliente cliente3 = new Cliente
            {
                Id = new Random().Next(),
                Nombre = "Diego",
                Apellido = "Perez",
                
            };

            Empleado trabajador1 = new Empleado
            {
                Id = 1,
                Nombre = "Jhonatan"
            };
            Empleado trabajador2 = new Empleado
            {
                Id = 2,
                Nombre = "Sara"
            };

            Almacen empresaTrab1 = new Almacen
            {
                Id = new Random().Next(),
                Nombre = "Point ",
                Direccion = "Simon Bolivar y Aldas",
                TipoDeEquipos = "tecnologicos",
                MiTrabajo = trabajador1
            };
            Almacen empresaTrab2 = new Almacen
            {
                Id = new Random().Next(),
                Nombre = "Point ",
                Direccion = "AV.Mariscal Sucre",
                TipoDeEquipos = "tecnologicos",
                MiTrabajo = trabajador2
            };
            Console.WriteLine(computadora.Caracteristicas());
            Console.ReadKey();
            Console.WriteLine(parlante.ProvarVolumen());
            Console.ReadKey();
            Console.WriteLine(audifono.EstadoVolumen());
            Console.ReadKey();
        }
    }

}
