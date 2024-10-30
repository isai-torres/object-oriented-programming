public class Tortuga : Mascota 
{
  public string TipoCaparazon {get; set;}

  public override void EmitirSonido() {
    Console.WriteLine("Silencioso");
  }

  public override void MostrarInformacion() 
  {
    Console.WriteLine($"{Nombre} {Edad} {Dueno} {TipoCaparazon}");
  }
}