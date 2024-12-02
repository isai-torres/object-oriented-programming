using System;

namespace FinalProject {
  class Program {
    private static void Main(string[] args) {

      //---------------------------- Pacientes ----------------------------

      // Objetos y listas de la clase Persona Y información del paciente:

      // Paciente 1
      Paciente paciente1 = new Paciente("Isai", 25, "I9988", "TryCare");
      // Paciente 1 Lista Historial Medico
      List<HistorialMedico> listaHistorialPaciente1 = new List<HistorialMedico>();
      listaHistorialPaciente1.Add(new HistorialMedico("2/ago/2020", "Dolor de cabeza"));
      listaHistorialPaciente1.Add(new HistorialMedico("20/ago/2020", "Dolor de cuello"));

      // Mostrar detalles pacientes 

      // Paciente 1
      Console.WriteLine("Información del paciente:");
      paciente1.verDatos();

      Console.WriteLine("Historial medico:");
      foreach (HistorialMedico historialPaciente1 in listaHistorialPaciente1 ) {
        historialPaciente1.verHistorial();
      }

      Console.WriteLine("------------------------------------");

      //---------------------------- Doctores ----------------------------

      // Objetos y listas de la clase Doctor Y información del doctor:

      // Doctor 1
      Doctor doctor1 = new Doctor("Lopez", 40, "Y77856", "Cirujano");

      // Mostrar detalles de los doctores 

      // Doctor 1
      Console.WriteLine("Información del doctor:");
      doctor1.verDatos();


      // Mostrar lista de pacientes atendidos Doctor 1
      doctor1.listaPacientesAtendidos.Add(paciente1);

      // Mostrar pacientes atendidos por los doctores

      // Pacientes Doctor 1
      doctor1.verPacientesAtendidos();
      
    }
  }
}