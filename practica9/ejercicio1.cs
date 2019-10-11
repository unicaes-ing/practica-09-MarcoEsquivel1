using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    class ejercicio1
    {
        //Marco René Esquivel Juárez
        //02-oct-2019
        public struct frutas
        {
            public string nombre;
        }
        public void ejer1()
        {
            string nombre;
            int index;
            int op;
            bool isInt;
            List<string> listaFruta = new List<string>();

            do
            {
                Console.Clear();
                Console.WriteLine("1- Agregar a la lista");
                Console.WriteLine("2- Mostrar lista");
                Console.WriteLine("3- Insertar en la lista");
                Console.WriteLine("4- Eliminar de la lista");
                Console.WriteLine("5- Buscar en la lista");
                Console.WriteLine("6- Vaciar la lista");
                Console.WriteLine("7- Salir");
                do
                {
                    isInt = int.TryParse(Console.ReadLine(), out op);
                } while (isInt == false || op < 1 || op > 7);
                Console.Clear();
                switch (op)
                {
                    case 1:

                        Console.WriteLine("Ingrese el nombre de la fruta");
                        listaFruta.Add(Console.ReadLine());
                        Console.WriteLine("Presione <ENTER> para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        for (int i = 0; i < listaFruta.Count; i++)
                        {
                            Console.WriteLine("{0}- {1}", i + 1, listaFruta[i]);
                        }
                        Console.WriteLine("Presione <ENTER> para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Inserte la posicion");
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserte el nombre de la fruta");
                        listaFruta.Insert(index, Console.ReadLine());
                        Console.WriteLine("Presione <ENTER> para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Ingrese la posicion de la fruta que desea eliminar");
                        index = Convert.ToInt32(Console.ReadLine());
                        listaFruta.RemoveAt(index);
                        Console.WriteLine("Presione <ENTER> para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Ingrese el nombre de la fruta que desea buscar");
                        nombre = Console.ReadLine();
                        if (listaFruta.Contains(nombre))
                        {
                            Console.WriteLine("Existe en la lista");
                        }
                        else
                        {
                            Console.WriteLine("No existe en la lista");
                        }
                        Console.WriteLine("Presione <ENTER> para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        listaFruta.Clear();
                        Console.WriteLine("Presione <ENTER> para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                Console.Clear();

            } while (op != 7);
        }
    }
}
