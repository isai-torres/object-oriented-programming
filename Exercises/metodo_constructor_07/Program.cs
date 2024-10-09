using System;

namespace metodo_constructor_07 
{
  class Program 
  {
    private static void Main(string[] args) 
    {
      // Ejercicio 1
      Console.WriteLine("Ejercicio 1 Clase Persona:");
      Persona persona = new Persona("Juan", 24);
      persona.DetallesPersona();
      Console.WriteLine(); // Este Console.WriteLine es para crear un espacio en blanco en la consola

      // Ejercicio 2
      Console.WriteLine("Ejercicio 2 Clase Auto:");
      Auto auto = new Auto("Mitsubishi", "Outlander", 2020);
      auto.detallesAuto();
    }
  }
}