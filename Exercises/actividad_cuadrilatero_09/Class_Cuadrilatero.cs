// Clase Cuadrilatero

public class Cuadrilatero {
  public double lado1;
  public double lado2;

  // Método constructor sin parámetros

  public Cuadrilatero() {

  }

  // Método para calcular el tipo de cuadrilátero

  public string tipoCuadrilatero() {

    if (lado1 == lado2) {
      return "Cuadrado";

    } else {
      return "Rectángulo";
    }

  }
}