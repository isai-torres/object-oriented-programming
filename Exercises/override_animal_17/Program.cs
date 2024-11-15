using System;

namespace override_animal_17 {
  class Program {
    private static void Main(string[] args) {
      // Crear las instancias
      Perro capitan = new Perro();
      Gato simba = new Gato();

      // Agregar valoras del nombre y la edad

      // Perro
      capitan.nombre = "Capitan";
      capitan.edad = 8;

      // Gato
      simba.nombre = "Simba";
      simba.edad = 3;

      // Mostrar la información del animal y su comportamiento

      capitan.mostrarPersonalidad();

      Console.WriteLine("------------------------------");

      simba.mostrarPersonalidad();
    }
  }
}