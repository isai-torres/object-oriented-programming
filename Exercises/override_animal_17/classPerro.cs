public class Perro : Animal {
  public override void mostrarPersonalidad() {
    Console.WriteLine($"Nombre: {nombre} \nEdad: {edad} \nEl perro es amigable y leal.");
  }
}