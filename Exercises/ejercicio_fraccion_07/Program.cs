using System;

namespace ejercicio_fraccion_07 {
  class Program {
    static void Main(string[] args)
    {
      Fraccion fraccion1 = new Fraccion();
      Fraccion fraccion2 = new Fraccion(10, 2);

      Console.WriteLine(" ");

      Console.WriteLine("La fracción 2 es de tipo: " + fraccion2.TipoFraccion());

      Console.WriteLine("---------------------------------------------------");

      Console.Write("Ingrese el valor del numerador: ");
      fraccion1.numerador = Convert.ToInt16(Console.ReadLine());

      Console.Write("Ingrese el valor del denominador: ");
      fraccion1.denominador = Convert.ToInt16(Console.ReadLine());

      Console.WriteLine(" ");

      Console.WriteLine("En base a los valores entrados la fraccion es de tipo: " + fraccion1.TipoFraccion());

      fraccion2.numerador = 5;
      fraccion2.denominador = 5;

      Console.WriteLine("-----------------------------------------------------");

      Console.WriteLine("Con los cambios realizados a los datos de la Fraccion2 ahora es una Fraccion de tipo: " + fraccion2.TipoFraccion());

      Console.WriteLine(" ");
    }
  }
}