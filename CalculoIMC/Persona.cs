using System;

namespace CalculoIMC
{
    public class Persona
    {
        // ATRIBUTOS
        private int id;
        private String nombre;
        private double peso;
        private double altura;

        // METODO CONSTRUCTOR
        public Persona(int id, String nombre, double peso, double altura)
        {
            this.id = id;
            this.nombre = nombre;
            this.peso = peso;
            this.altura = altura;
        }

        // METODOS GET - SET POR CADA ATRIBUTO

        // PARA EL ATRIBUTO id
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        // PARA EL ATRIBUTO nombre
        public String getNombre()
        {
            return nombre;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        // PARA EL ATRIBUTO peso
        public double getpeso()
        {
            return peso;
        }
        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        // PARA EL ATRIBUTO altura
        public double getAltura()
        {
            return altura;
        }
        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        // METODO TOSTRING
        override
            public String ToString()
        {
            return "Persona: [" + " id: " + id + " nombre: " + nombre + " peso: " + peso + " altura: " + altura + " ]" ;
        }

        // METODO CALCULAR IMC
        public double calcularIMC()
        {
            return peso / (altura * altura);
        }
    }
}