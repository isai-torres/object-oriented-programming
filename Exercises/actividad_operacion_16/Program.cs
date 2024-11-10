using System;

namespace actividad_operacion_16 {
  class Program {
    private static void Main(string[] args) {
      // Crear las instancias
      Operacion operacionMatematica = new Operacion();

      // Mostrar los resultados y asignar el valor de los parámetros
      Console.WriteLine("La suma de los dos números enteros es: " + operacionMatematica.calcular(7, 7));
      Console.WriteLine("La multiplicadion de los tres doubles es: " + operacionMatematica.calcular(2.2, 3.4, 5.6));
    }
  }
}