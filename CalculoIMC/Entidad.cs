using System;
using System.Collections.Generic;

namespace CalculoIMC
{
	public class Entidad
	{
		// ATRIBUTOS
		private List<Persona> personas;

		// METODO CONSTRUCTOR
		public Entidad()
		{
			personas = new List<Persona>();
			personas.Add(new Persona(111, "Celso", 87.0, 1.75));
            personas.Add(new Persona(222, "Javier", 75.0, 1.75));
            personas.Add(new Persona(333, "Euripides", 70.0, 1.68));
            personas.Add(new Persona(444, "Jacinto", 110.0, 1.82));
            personas.Add(new Persona(555, "Aristobulo", 50.0, 1.50));

        }

		// METODO PARA LISTAR LAS PERSONAS QUE ESTAN EN LA LISTA
		public void listarPersonas()
		{
			for (int i = 0; i < personas.Count; i++)
			{
				Console.Write("\n" + personas[i]);
			}
		}

		// METODO PARA BUSCAR UNA PERSONA EN LA LISTA
		public Persona buscarPersona(int id)
		{
			Persona buscada = null;
			bool encontrado = false;
			for(int i = 0; i < personas.Count && encontrado == false; i++)
			{
				if (personas[i].getId() == id)
				{
					buscada = personas[i];
					encontrado = true;
				}
			}
			return buscada;
		}

        // METODO PARA AGREGAR UNA PERSONA A LA LISTA
        public void agregarPersona(int id, String nombre, double peso, double altura)
		{
			Persona buscada = buscarPersona(id);
			if(buscada == null)
			{
				Persona nueva = new Persona(id, nombre, peso, altura);
				personas.Add(nueva);
                Console.Write("\nSe agrego la persona a la lista.");
            }
			else
			{
				Console.Write("\nLa persona ya esta en la lista. No se puede duplicar.");
			}
        }

		// METODO PARA ELIMINAR UNA PERSONA DE LA LISTA
		public void eliminarPersona(int id)
		{
			Persona buscada = buscarPersona(id);
			if (buscada != null)
			{
				personas.Remove(buscada);
			}
			else
			{
				Console.Write("La persona no se encuentra en la lista para ser eliminada. ");
			}
		}

		// METODO PARA CALCULAR EL IMC DE CUALQUIER PERSONA DE LA LISTA
		public String calcularIMC(int id)
		{
            Persona buscada = buscarPersona(id);
            String respuesta = null;
            if (buscada != null)
			{
				double imc = buscada.calcularIMC();
				
				if (imc < 18.5)
				{
					respuesta = "IMC = " + imc + " te encuentras bajo de peso.";
				}
				else if (imc >= 18.5 && imc < 25)
				{
					respuesta = "IMC = " + imc + " te encuentras con un peso normal.";
				}
				else if (imc >= 25 && imc < 30)
				{
					respuesta = "IMC = " + imc + " te encuentras con sobrepeso.";
				}
				else if (imc >= 30)
				{
					respuesta = "IMC = " + imc + " te encuentras obeso.";
				}
			}
			else
			{
				Console.Write("No se encuentra la persona en la lista.");
			}
            return respuesta;
		}
	}
}

