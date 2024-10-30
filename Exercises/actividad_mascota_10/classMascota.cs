public class Mascota {
  public string Nombre {get; set;}
  public int Edad {get; set;}
  public string Dueno {get; set;}

  public virtual void EmitirSonido() 
  {
    Console.WriteLine("EL animal hace un sonido.");
  }

  public virtual void MostrarInformacion() 
  {
    Console.WriteLine($"{Nombre} {Edad} {Dueno}");
  }
}