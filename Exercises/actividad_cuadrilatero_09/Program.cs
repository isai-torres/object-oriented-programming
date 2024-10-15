using System;

namespace actividad_cuadrilatero_09 {

  class Program {
    static void Main(string[] args) {

      // Crear el objeto para la clase Cuadrilatero

      Cuadrilatero cuadrilatero = new Cuadrilatero();

      // Pedir al usuario que ingrese el valor de los lados

      Console.Write("Ingrese el valor para el lado 1 del cuadrilátero: ");
      cuadrilatero.lado1 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Ingrese el valor para el lado 2 del cuadrilátero: ");
      cuadrilatero.lado2 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine(" ");

      Console.Write("Según los valores que ingreso el cuadrilátero es un: " + cuadrilatero.tipoCuadrilatero());
    }
  }
}