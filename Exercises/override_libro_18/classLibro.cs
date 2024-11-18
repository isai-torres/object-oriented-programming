public class Libro {
  public string titulo {get; set;}
  public string autor {get; set;}

  public virtual void mostrarDescripcion() {
    Console.WriteLine("Este es un libro general.");
  }
}