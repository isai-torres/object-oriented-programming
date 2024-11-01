using System;

namespace encapsulamiento_producto_11 {
  class Program {
    private static void Main(string[] args) {
      
      // Objetos de la clase producto

      Producto producto1 = new Producto();
      Producto producto2 = new Producto();

      // Objeto utilizando el método del constructor con parámetros

      Producto producto3 = new Producto("Computadora", 850.99);

      // Establecer los valores utilizando los métodos set

      producto1.Nombre = "Nevera";
      Console.Write("Ingrese el precio de la nevera: ");
      producto1.Precio = Convert.ToDouble(Console.ReadLine());

      producto2.Nombre = "Calculadora";
      producto2.Precio = 12.25;

      // Mostrar producto 1
      producto1.mostrarNombrePrecio();
      Console.WriteLine("-------------");

      // Mostrar producto 2
      producto2.mostrarNombrePrecio();
      Console.WriteLine("-------------");

      // Mostrar producto 3
      producto3.mostrarNombrePrecio();
    }
  }
}