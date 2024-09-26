using System;

namespace actividad_clase_estudiante_06 {

  // Crear clase Estudiante
  public class Estudiante {

    // Atributos
    public string nombre {get; set;}
    public int edad {get; set;}
    public string concentracion {get; set;}
    public float clasificacionPromedio {get; set;}

    // Método para mostrar Detalles

    public void MostrarDetalles() {
      Console.WriteLine($"1. Nombre: {nombre} \n2. Edad: {edad} \n3. Concentración: {concentracion} \n4. Clasificación {clasificacionPromedio}");
    }
  }
  internal class Program {
    private static void Main(string[] args)
    {
      // Creación de los objetos

      Estudiante estudiante = new Estudiante();
      estudiante.nombre = "Pedro";
      estudiante.edad = 25;
      estudiante.concentracion = "Ciencias de Computadora";
      estudiante.clasificacionPromedio = 80.45f;

      Estudiante estudiante2 = new Estudiante();
      estudiante2.nombre = "Juan";
      estudiante2.edad = 22;
      estudiante2.concentracion = "Ciencias de Computadora";
      estudiante2.clasificacionPromedio = 60.52f;

      Estudiante estudiante3 = new Estudiante();
      estudiante3.nombre = "Karla";
      estudiante3.edad = 23;
      estudiante3.concentracion = "Biología";
      estudiante3.clasificacionPromedio = 90.49f;

      // Mostrar detalles de los estudiantes

      Console.WriteLine("Mostrar detalles del estudiante 1");
      Console.WriteLine();
      estudiante.MostrarDetalles();
      Console.WriteLine();

      Console.WriteLine("Mostrar detalles del estudiante 2");
      Console.WriteLine();
      estudiante2.MostrarDetalles();
      Console.WriteLine();

      Console.WriteLine("Mostrar detalles del estudiante 3");
      Console.WriteLine();
      estudiante3.MostrarDetalles();
      Console.WriteLine();

      // Modificación del valor de un atributo de los objetos
      estudiante3.concentracion = "Ciencias de Computadoras";
      Console.WriteLine("Karla cambio de concentracion de Biología a Ciencias de Computadoras.");
      Console.WriteLine();
      estudiante3.MostrarDetalles();
    }
  }
}