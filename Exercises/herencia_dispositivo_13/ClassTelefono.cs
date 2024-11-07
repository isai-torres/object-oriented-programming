public class Telefono : Dispositivo {

  // Atributos
  private int numeroDeCamaras {get; set;}

  // Get / Set

  public int NumeroDeCamaras {
    get{return numeroDeCamaras;}
    set{
      if(value >= 1) {
        numeroDeCamaras = value;
      }
    }
  }
}