using System;

namespace actividad_clase_libro_05 {
  class Libro {
    public string titulo {get; set;}
    public string autor {get; set;}
    public string genero {get; set;}
    public int numPaginas {get; set;}

    public void MostrarDetalles() {
      Console.WriteLine($"1. Titulo: {titulo} \n2. Autor: {autor} \n3. Genero: {genero} \n4. Total de paginas: {numPaginas}");
    }
  }

  class Program {
    private static void Main(string[] args) {

      Libro libro = new Libro();
      libro.titulo = "Meditations";
      libro.autor = "Marcus Aurelius";
      libro.genero = "Filosofía";
      libro.numPaginas = 450;
      libro.MostrarDetalles();
    }
  }
}