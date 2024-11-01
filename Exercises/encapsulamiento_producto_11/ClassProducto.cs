public class Producto {
  private string nombre {get; set;}
  private double precio {get; set;}

  // Método para mostrar el Nombre y el Salario
  
  public void mostrarNombrePrecio() {
    Console.WriteLine($"Nombre: {Nombre} \nPrecio: {Precio:C}");
  }

  // Método Constructor sin parámetros

  public Producto() {

  }

  // Método constructor con parámetros

  public Producto(string ELNombre, double ElPrecio) {
    nombre = ELNombre;
    precio = ElPrecio;
  }

  // Get / Set

  public string Nombre {
    get{return nombre;}
    set{nombre = value;}
  }

  public double Precio {
    get{return precio;}
    set {
      if(value >= 0) {
        precio = value;
      }
    }
  }
}