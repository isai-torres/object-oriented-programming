public class Enciclopedia : Libro {
  public override void mostrarDescripcion() {
    Console.WriteLine($"Titulo: {titulo} \nAutor: {autor} \nEste es un libro de referencia.");
  }
}