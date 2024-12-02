public class Doctor : Persona {
  public string especialidad {get; set;}
   public List<Paciente> listaPacientesAtendidos {get; set;} = new List<Paciente>();

  // Constructor vació
  public Doctor() {

  }

  // Método constructor
  public Doctor(string Nombre, int Edad, string Id, string Especialidad) 
    : base (Nombre, Edad, Id) {
      especialidad = Especialidad;
  }

  // Método override para mostrar los detalles
  public override void verDatos() {
    Console.WriteLine($"Nombre: {nombre} \nEdad: {edad} \nId: {identificacion} \nEspecialidad: {especialidad}");
  }

  // Método para mostrar los pacientes atendidos
  public void verPacientesAtendidos() {
    Console.WriteLine($"Pacientes atendidos por el doctor {nombre}:");
    foreach (Paciente paciente in listaPacientesAtendidos) {
      Console.WriteLine($"{paciente.nombre} - {paciente.identificacion}");
    }
  }
}