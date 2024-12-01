using System;

namespace FinalProject {
  class Program {
    private static void Main(string[] args) {
      // Objetos de la clase Persona Y información del paciente

      // Paciente 1
      Paciente paciente1 = new Paciente("Isai", 25, "I9988", "TryCare");
      // Paciente 1 Lista Historial Medico
      List<HistorialMedico> listaHistorialPaciente1 = new List<HistorialMedico>();
      listaHistorialPaciente1.Add(new HistorialMedico("2/ago/2020", "Dolor de cabeza"));
      listaHistorialPaciente1.Add(new HistorialMedico("20/ago/2020", "Dolor de cuello"));

      // Mostrar detalles paciente 1
      Console.WriteLine("Información del paciente:");
      paciente1.verDatos();

      Console.WriteLine("Historial medico:");
      foreach (HistorialMedico historialPaciente1 in listaHistorialPaciente1 ) {
        historialPaciente1.verHistorial();
      }
    }
  }
}