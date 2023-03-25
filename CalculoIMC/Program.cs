using System;

namespace CalculoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Entidad secretariaSalud = new Entidad();

            int salir = 2;
            while (salir == 2)
            {
                Console.Write("========== MENU ==========");
                Console.Write("\n1.Listar personas encuestadas.");
                Console.Write("\n2.Buscar persona.");
                Console.Write("\n3.Agregar persona.");
                Console.Write("\n4.Eliminar persona.");
                Console.Write("\n5.Calcular IMC");
                Console.Write("\n\nIngrese el numero de la opción deseada...\n");
                int opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            Console.Write("\n1.Listar personas encuestadas.");
                            secretariaSalud.listarPersonas();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("\n2.Buscar persona.");
                            Console.Write("\nIngrese el ID de la persona a buscar en la lista: ");
                            int id = Int32.Parse(Console.ReadLine());
                            secretariaSalud.buscarPersona(id);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("\n3.Agregar persona.");
                            Console.Write("\nIngrese el ID de la persona: ");
                            int id = Int32.Parse(Console.ReadLine());
                            Console.Write("\nIngrese el NOMBRE de la persona: ");
                            String nombre = Console.ReadLine();
                            Console.Write("\nIngrese el PESO de la persona:\n(utilice punto(.) como separador de decimales) ");
                            double peso = Double.Parse(Console.ReadLine());
                            Console.Write("\nIngrese la ALTURA de la persona:\n(utilice punto(.) como separador de decimales) ");
                            double altura = Double.Parse(Console.ReadLine());
                            secretariaSalud.agregarPersona(id, nombre, peso, altura);
                            break;
                        }
                    case 4:
                        {
                            Console.Write("\n4.Eliminar persona.");
                            Console.Write("\nIngrese el ID de la persona que se desea aliminar de la lista: ");
                            int id = Int32.Parse(Console.ReadLine());
                            secretariaSalud.eliminarPersona(id);
                            break;
                        }
                    case 5:
                        {
                            Console.Write("\n5.Calcular IMC");
                            Console.Write("\nIngrese el ID de la persona para calcular el IMC: ");
                            int id = Int32.Parse(Console.ReadLine());
                            Console.Write(secretariaSalud.calcularIMC(id));
                            break;
                        }
                    default:
                        {
                            Console.Write("\nOpción invalida. ");
                            break;
                        }
                }
                Console.Write("\nSi desea salir escriba (1) ");
                Console.Write("\nSi desea continuar escriba (2) ");
                salir = Int32.Parse(Console.ReadLine());
            }
        }
    }
}