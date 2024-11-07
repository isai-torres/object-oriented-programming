public class Dispositivo {

  // Atributos
  private string marca {get; set;}
  private string modelo {get; set;}
  private int precio {get; set;}

  // Método para establecer los valores

  // Get / Set

  public string Marca {
    get{return marca;}
    set{marca = value;}
  }

  public string Modelo {
    get{return modelo;}
    set{modelo = value;}
  }

  public int Precio {
    get{return precio;}
    set {
      if(value >= 0) {
        precio = value;
      }
    }
  }

}