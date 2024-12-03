public class Consulta : Persona {
  public string descripcionConsulta {get; set;}
  public Paciente pacienteConsulta {get; set;}
  public Doctor doctorConsulta {get; set;}
  public DateTime fechaConsulta { get; set;}

  // Constructor vació
  public Consulta() {

  }

  // Método constructor
  public Consulta(Paciente PacienteConsulta, Doctor DoctorConsulta, string DescripcionConsulta) {
    pacienteConsulta = PacienteConsulta;
    doctorConsulta = DoctorConsulta;
    descripcionConsulta = DescripcionConsulta;
    fechaConsulta = DateTime.Now;
  }

  // Método para mostrar los detalles de la consulta
  public void verDetallesConsulta() {
    Console.WriteLine($"Consulta del paciente: {pacienteConsulta.nombre} \nDoctor asignado: {doctorConsulta.nombre} \nDescripción de la consulta: {descripcionConsulta} - {fechaConsulta}");
    Console.WriteLine();
  }
}