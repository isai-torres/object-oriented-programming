using System;

namespace encapsulamiento_empleado_12 {
  class Program {
    private static void Main(string[] args) {

      // Crear las instancias

      Empleado empleado1 = new Empleado();
      Empleado empleado2 = new Empleado();
      Empleado empleado3 = new Empleado("Juan", 15.25);

      // Establecer los valores utilizando los métodos set

      // Empleado 1

      Console.Write("Ingrese su nombre: ");
      empleado1.Nombre = Console.ReadLine();
      Console.Write("Ingrese su salario: ");
      empleado1.Salario = Convert.ToDouble(Console.ReadLine());

      //Empleado 2

      empleado2.Nombre = "Pedro";
      empleado2.Salario = 20.25;

      // Mostrar el nombre y el salario del empleado

      empleado1.mostrarNombreSalario();
      Console.WriteLine("-------------");

      empleado2.mostrarNombreSalario();
      Console.WriteLine("-------------");
      
      empleado3.mostrarNombreSalario();
    }
  }
}