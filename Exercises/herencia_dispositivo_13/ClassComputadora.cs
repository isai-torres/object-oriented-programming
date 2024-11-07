public class Computadora : Dispositivo {

  // Atributos
  private string tipoDeProcesador {get; set;}

  // Get / Set

  public string TipoDeProcesador {
    get{return tipoDeProcesador;}
    set{tipoDeProcesador = value;}
  }
}