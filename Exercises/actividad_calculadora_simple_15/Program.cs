using System;

namespace actividad_calculadora_simple_15 {
  class Program {
    private static void Main(string[] args) {
      // Crear instancias
      CalculadoraSimple miCalculadoraSimple = new CalculadoraSimple();

      // Mostrar los resultados
      Console.WriteLine("Multiplicación de dos enteros: " + miCalculadoraSimple.Multiplicar(4, 2));
      Console.WriteLine("Multiplicación de dos doubles: " + miCalculadoraSimple.Multiplicar(2.44, 2.44));
    }
  }
}