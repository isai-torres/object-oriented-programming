using System;

namespace metodo_overloading_14 {
  class Program {
    private static void Main(string[] args) {
      // Crear las instancias
      Calculadora calculadora = new Calculadora();

      // Obtener los valores de los parámetros y mostrarlos
      Console.WriteLine(calculadora.sumar(8, 8));
      Console.WriteLine(calculadora.sumar(20.10, 20.10));
      Console.WriteLine(calculadora.sumar(5, 5, 5));
    }
  }
}