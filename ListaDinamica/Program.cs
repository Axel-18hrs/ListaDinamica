using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> lista = new LinkedList<int>();
            bool salir = true;

            while (salir)
            {
                Console.Clear();
                Console.WriteLine("// Select an option" +
                    "\n[1]: Enter a value " +
                    "\n[2]: Delete a value" +
                    "\n[3]: Search number" +
                    "\n[4]: Show stack" +
                    "\n[5]: Exit");

                int opcion;

                try
                {
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {

                        case 1:
                            Console.Clear();
                            Console.WriteLine("Enter a value:");
                            lista.AddLast(Convert.ToInt32(Console.ReadLine()));
                            break;

                        case 2:
                            Console.Clear();

                            if (lista.Count > 0)
                            {
                                Console.WriteLine("Number to delete:");
                                int valor = Convert.ToInt32(Console.ReadLine());

                                // Crear una copia de los elementos a eliminar
                                List<int> elementosAEliminar = new List<int>();

                                foreach (int elemento in lista)
                                {
                                    if (elemento == valor)
                                    {
                                        elementosAEliminar.Add(elemento);
                                    }
                                }

                                // Eliminar los elementos de la lista
                                foreach (int elemento in elementosAEliminar)
                                {
                                    lista.Remove(elemento);
                                    Console.WriteLine("Element of LinkedList removed: " + elemento);
                                }
                            }
                            else
                            {
                                Console.WriteLine("// The LinkedList is empty");
                            }

                            break;
                        case 3:
                            Console.Clear();

                            if (lista.Count > 0)
                            {
                                Console.WriteLine("Number to search for:");
                                int valor2 = Convert.ToInt32(Console.ReadLine());
                                foreach (int elemento in lista)
                                {
                                    if (elemento == valor2)
                                    {
                                        Console.WriteLine("Element of LinkedList: " + elemento);
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The LinkedList is empty");
                            }
                            break;
                        case 4:
                            Console.Clear();
                            if (lista.Count > 0)
                            {
                                foreach (int elemento in lista)
                                {
                                    Console.WriteLine("Element of LinkedList: " + elemento);
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The LinkedList is empty");
                            }

                            break;

                        case 5:
                            salir = false;
                            Console.Clear();
                            Console.WriteLine("Good bye.");
                            break;
                    }
                }
                catch (Exception e)
                {

                    Console.Clear();
                    Console.WriteLine("// Not a valid choice");
                }

                Console.ReadKey();
            }
        }
    }
}
