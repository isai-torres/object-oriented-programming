public class Fraccion {
  public int numerador;
  public int denominador;

  // Método constructor sin parámetro

  public Fraccion() {

  }

  public Fraccion(int Numerador, int Denominador) {

    numerador = Numerador;
    denominador = Denominador;
  }

  public string TipoFraccion() {
    if (numerador < denominador)
      return "Propia";

    if (numerador > denominador)
      return "Impropia";

    return "Aparente";
  } 
}