using System;

namespace actividad_clase_libro_05 {

  // Se crea la clase
  public class Libro {

    // Atributos
    public string titulo {get; set;}
    public string autor {get; set;}
    public string genero {get; set;}
    public int numPaginas {get; set;}

    // Método para mostrar detalles
    public void MostrarDetalles() {
      Console.WriteLine($"1. Titulo: {titulo} \n2. Autor: {autor} \n3. Genero: {genero} \n4. Total de paginas: {numPaginas}");
    }
  }

  class Program {
    private static void Main(string[] args) {

      // Creación de los objetos
      
      Libro libro = new Libro();
      libro.titulo = "Meditations";
      libro.autor = "Marcus Aurelius";
      libro.genero = "Filosofía";
      libro.numPaginas = 450;

      Libro libro2 = new Libro();
      libro2.titulo = "El Principito";
      libro2.autor = "Antoine";
      libro2.genero = "Novela";
      libro2.numPaginas = 120;

      Libro libro3 = new Libro();
      libro3.titulo = "Python";
      libro3.autor = "Robert Lafore";
      libro3.genero = "Programming";
      libro3.numPaginas = 1040;

      // Mostrar detalles de los libros

      Console.WriteLine("Detalles del libro 1: ");
      Console.WriteLine();
      libro.MostrarDetalles();
      Console.WriteLine(); // Esto es para crear un espacio en blanco

      Console.WriteLine("Detalles del libro 2: ");
      Console.WriteLine();
      libro2.MostrarDetalles();
      Console.WriteLine(); // Esto es para crear un espacio en blanco

      Console.WriteLine("Detalles del libro 3: ");
      Console.WriteLine();
      libro3.MostrarDetalles();
    }
  }
}