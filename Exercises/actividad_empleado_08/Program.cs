using System;

namespace actividad_empleado_08 {
  class Program {
    private static void Main(string[] args)
    {
      // Crear objetos para la clase Empleado

      Empleado empleado1 = new Empleado();
      Empleado empleado2 = new Empleado("5469", 2D);

      // Empleado 1, pedir al usuario que ingrese su numero de empleado y los años en la empresa

      Console.Write("Ingrese su numero de empleado: ");
      empleado1.numeroEmpleado = Console.ReadLine();

      Console.Write("Ingrese los años trabajado en la empresa: ");
      empleado1.workYears = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine(" ");

      Console.WriteLine(empleado1.tipoContrato());

      Console.WriteLine(" ");

      Console.WriteLine("---------------------------------------------------------");

      Console.WriteLine(" ");

      // Empleado 2 utilizando los parámetros del método

      Console.WriteLine(empleado2.tipoContrato());
    }
  }
}