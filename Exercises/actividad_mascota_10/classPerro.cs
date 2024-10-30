public class Perro : Mascota {
  public string Raza {get; set;}

  public override void EmitirSonido() 
  {
    Console.WriteLine("Guau Guau");
  }
}