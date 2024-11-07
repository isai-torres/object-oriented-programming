using System;

namespace herencia_dispositivo_13 {
  class Program {
    private static void Main(string[] args) {

      // Crear instancias

      Telefono telefono = new Telefono();
      Computadora computadora = new Computadora();

      // Establecer los valores

      // Teléfono

      Console.Write("Ingrese la marca de su telefono: ");
      telefono.Marca = Console.ReadLine();

      Console.Write("Ingrese el modelo de su telefono: ");
      telefono.Modelo = Console.ReadLine();

      Console.Write("Ingrese el Precio de su telefono: ");
      telefono.Precio = Convert.ToInt32(Console.ReadLine());

      Console.Write("Ingrese cuantas cámaras tiene el telefono: ");
      telefono.NumeroDeCamaras = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("---------------------------------------------");

      // Computadora

      Console.Write("Ingrese la marca de su computadora: ");
      computadora.Marca = Console.ReadLine();

      Console.Write("Ingrese el modelo de su computadora: ");
      computadora.Modelo = Console.ReadLine();

      Console.Write("Ingrese el precio de su computadora: ");
      computadora.Precio = Convert.ToInt32(Console.ReadLine());

      Console.Write("Ingrese el tipo de procesador de su computadora: ");
      computadora.TipoDeProcesador = Console.ReadLine();

      Console.WriteLine("---------------------------------------------");

      // Mostrar la información de los dispositivo

      // Teléfono

      Console.WriteLine($"Información de su telefono: \nMarca: {telefono.Marca} \nModelo: {telefono.Modelo} \nPrecio: {telefono.Precio:C} \nCamaras: {telefono.NumeroDeCamaras}");

      Console.WriteLine("---------------------------------------------");

      // Computadora

      Console.WriteLine($"Información de su computadora: \nMarca: {computadora.Marca} \nModelo: {computadora.Modelo} \nPrecio: {computadora.Precio:C} \nProcesador: {computadora.TipoDeProcesador}");

    }
  }
}