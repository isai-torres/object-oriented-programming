using System;

namespace override_libro_18 {
  class Program {
    private static void Main(string[] args) {

      // Crear las instancias

      Novela novela = new Novela();
      Enciclopedia enciclopedia = new Enciclopedia();

      // Agregar los valores titulo y autor

      // Novela
      novela.titulo = "Don Quijote";
      novela.autor = "Miguel de Cervantes";

      // Enciclopedia
      enciclopedia.titulo = "Conocimiento Universal";
      enciclopedia.autor = "John Doe";

      // Mostrar la información de los libros en la consola

      // Novela
      novela.mostrarDescripcion();

      Console.WriteLine("-------------------------");

      // Enciclopedia
      enciclopedia.mostrarDescripcion();
    }
  }
}