using System;

namespace actividad_mascota_10 {
  internal class Program {
    private static void Main(string[] args)
    {
      // Crear instancias de las mascotas

      Perro rex = new Perro {Nombre = "Rex", Edad = 5, Dueno = "Juan", Raza = "Labrador"};
      Gato felix = new Gato {Nombre = "Felix", Edad = 3, Dueno = "Maria", ColorPelaje = "Negro"};
      Tortuga tina = new Tortuga {Nombre = "Tina", Edad = 10, Dueno = "Pedro", TipoCaparazon = "Caparazón Duro"};

      // Hacer que las mascotas emitan sonidos

      rex.EmitirSonido();
      felix.EmitirSonido();
      tina.EmitirSonido();

      Console.WriteLine("--------------------");

      // Mostrar Información básica de cada mascota

      rex.MostrarInformacion();
      felix.MostrarInformacion();
      tina.MostrarInformacion();
    }
  }
}