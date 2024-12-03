public class Paciente : Persona {
  // Atributos
  public string seguroMedico {get; set;}

  // Método constructor vació
  public Paciente() {

  }

  // Método constructor
  public Paciente(string Nombre, int Edad, string Id, string SeguroMedico) 
    : base(Nombre, Edad, Id) {
    seguroMedico = SeguroMedico;
  }

  // Método override para mostrar los detalles
  public override void verDatos() {
    Console.WriteLine($"Nombre: {nombre} \nEdad: {edad} \nId: {identificacion} \nSeguro Medico: {seguroMedico}");
    Console.WriteLine();
  }

  // Método para mostrar nota medica del paciente
  public void agregarNota(string notaMedica) {
    Console.WriteLine($"Nota medica: {notaMedica}");
  }
}