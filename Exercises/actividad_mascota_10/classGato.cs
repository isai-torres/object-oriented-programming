public class Gato : Mascota 
{
  public string ColorPelaje {get; set;}

  public override void EmitirSonido()
  {
    Console.WriteLine("Miau Miau");
  }
}