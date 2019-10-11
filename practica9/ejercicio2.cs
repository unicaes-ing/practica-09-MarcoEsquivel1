using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    class ejercicio2
    {
        //Marco René Esquivel Juárez
        //02-oct-2019
        public struct Alumnos
        {
            public string carnet;
            public string nombre;
            public string carrera;
            private decimal cum;

            public void setCum(decimal cum)
            {
                if (cum >= 0 && cum <= 10)
                {
                    this.cum = cum;
                }
                else
                {
                    setCum(Convert.ToDecimal(Console.ReadLine()));
                }
            }
            public decimal getCum()
            {
                return cum;
            }
        }
        public void ejer2()
        {
            string carnet;
            int op;
            bool isInt;
            Dictionary<string, Alumnos> universidad = new Dictionary<string, Alumnos>();
            do
            {
                Console.Clear();
                Console.WriteLine("1- Agregar alumno");
                Console.WriteLine("2- Mostrar alumnos");
                Console.WriteLine("3- Eliminar alumnos");
                Console.WriteLine("4- Buscar alumno");
                Console.WriteLine("5- Vaciar diccionario");
                Console.WriteLine("6- Salir");
                do
                {
                    isInt = int.TryParse(Console.ReadLine(), out op);
                } while (isInt == false || op < 1 || op > 6);
                switch (op)
                {
                    case 1:
                        Alumnos alumno = new Alumnos();
                        do
                        {
                            Console.WriteLine("Ingrese el carnet del alumno");
                            alumno.carnet = Console.ReadLine();
                            if (universidad.ContainsKey(alumno.carnet))
                            {
                                Console.WriteLine("El carnet ya existe");
                            }
                        } while (universidad.ContainsKey(alumno.carnet));
                        Console.WriteLine("Ingrese el nombre del alumno");
                        alumno.nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la carrera");
                        alumno.carrera = Console.ReadLine();
                        Console.WriteLine("Ingrese el cum");
                        alumno.setCum(Convert.ToDecimal(Console.ReadLine()));
                        universidad.Add(alumno.carnet, alumno);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("{0,-10} {1,-25}  {2,-5}", "carnet", "nombre", "cum");
                        foreach (KeyValuePair<string, Alumnos> datos in universidad)
                        {
                            alumno = datos.Value;
                            Console.WriteLine("{0,-10} {1,-25} {2, -5} ",
                            alumno.carnet,
                            alumno.nombre,
                            alumno.getCum());
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el carnet del alumno que desea eliminar");
                        carnet = Console.ReadLine();
                        if (universidad.ContainsKey(carnet))
                        {
                            universidad.Remove(carnet);
                            Console.WriteLine("Se eliminaron los datos");
                        }
                        else
                        {
                            Console.WriteLine("No existe un alumno con el carnet ingresado");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el carnet del alumno que desea buscar");
                        carnet = Console.ReadLine();
                        if (universidad.ContainsKey(carnet))
                        {
                            universidad.TryGetValue(carnet, out alumno);
                            Console.WriteLine("{0,-10} {1,-25} {2, -5} ",
                            alumno.carnet,
                            alumno.nombre,
                            alumno.getCum());
                            Console.ReadKey();
                            Console.Clear();
                        }
                        
                        break;
                    case 5:
                        universidad.Clear();
                        Console.WriteLine("Se borraron los datos");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (op != 6);
        }
    }
}
