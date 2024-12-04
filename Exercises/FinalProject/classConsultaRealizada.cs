public class ConsultaRealizada : Consulta {
  public List<Paciente> listaConsultaRealizada { get; set; } = new List<Paciente>();

  // Constructor Vació
  public ConsultaRealizada() {

  }

  // Método para mostrar las consultas realizadas
  public void verConsultaRealizada() {
    Console.WriteLine("Consultas Realizadas:");
    foreach (Paciente consultaRealizadaPaciente in listaConsultaRealizada) {
      Console.WriteLine($"{consultaRealizadaPaciente.nombre} - {consultaRealizadaPaciente.identificacion} - {DateTime.Now}");
    }
  }
}