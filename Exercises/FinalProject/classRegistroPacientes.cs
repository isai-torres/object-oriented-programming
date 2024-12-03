public class RegistroPacientes : Paciente {
  public List<Paciente> listaPacienteRegistrado { get; set; } = new List<Paciente>();

  // Constructor Vació
  public RegistroPacientes() {

  }

  // Método para mostrar los pacientes registrados
  public void verRegistroPacientes() {
    Console.WriteLine("Pacientes registrados:");
    foreach (Paciente pacienteRegistrado in listaPacienteRegistrado) {
      Console.WriteLine($"{pacienteRegistrado.nombre} - {pacienteRegistrado.identificacion}");
    }
  }
}