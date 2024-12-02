public class Persona {
 public string nombre {get; set;}
 public int edad {get; set;}
 private string id {get; set;}

  // Método constructor vació
  public Persona() {

  }

  // Método constructor
  public Persona(string Nombre, int Edad, string Id) {
    nombre = Nombre;
    edad = Edad;
    id = Id;
  }

  // Método virtual para mostrar los detalles
  public virtual void verDatos() {
    Console.WriteLine($"Nombre: {nombre} \nEdad: {edad} \nId: {identificacion}");
    Console.WriteLine();
  }

  // Get / Set para el id
  public string identificacion {
    get{return id;}
    set{id = value;}
  }
}