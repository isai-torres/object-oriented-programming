public class HistorialMedico : Persona {
  private string historialMedico {get; set;}
  public string fecha {get; set;}

  // Constructor vació
  public HistorialMedico() {

  }

  // Método constructor
  public HistorialMedico(string Fecha, string HistorialMedico) {
      fecha = Fecha;
      historialMedico = HistorialMedico;
    }
    

  // Get / Set para historialMedico
  public string historialMedicoPaciente {
    get{return historialMedico;}
    set{historialMedico = value;}
  }

  // Método mostrar el historial medico
  public void verHistorial() {
    Console.WriteLine($"{fecha} - {historialMedico}");
  }
}