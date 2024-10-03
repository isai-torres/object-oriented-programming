// Clase Persona del ejercicio 1
public class Persona {

  // Atributos de la clase Persona
  public string nombre;
  public int edad;

  // Método Constructor de la clase Persona
  public Persona(string Nombre, int Edad) {
    nombre = Nombre;
    edad = Edad;
  }

  // Método para mostrar los detalles de la persona
  public void DetallesPersona() {
    Console.WriteLine($"Nombre: {nombre} \nEdad: {edad}");
  }
}

// Clase Auto del ejercicio 2
public class Auto {

  // Atributos de la clase Auto
  public string marca;
  public string modelo;
  public int year;

  // Método constructor de la clase Auto
  public Auto(string Marca, string Modelo, int Year) {
    marca = Marca;
    modelo = Modelo;
    year = Year;
  }

  // Método para mostrar los detalles del auto
  public void detallesAuto() {
    Console.WriteLine($"La marca es: {marca} \nEl modelo es: {modelo} \nEl año: {year}");
  }
}