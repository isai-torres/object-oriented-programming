public class Novela : Libro {
  public override void mostrarDescripcion() {
    Console.WriteLine($"Titulo: {titulo} \nAutor: {autor} \nEste es un libro ficticio.");
  }
}