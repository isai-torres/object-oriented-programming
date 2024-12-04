using System;

namespace FinalProject {
  class Program {
    private static void Main(string[] args) {

      //---------------------------- Pacientes ----------------------------

      // Objetos y listas de la clase Persona Y información del paciente:

      // Pacientes
      Paciente paciente1 = new Paciente("Maria", 25, "I9988", "TryCare");
      Paciente paciente2 = new Paciente("Ricardo", 30, "R0087", "Triple-S");
      Paciente paciente3 = new Paciente("Roberto", 22, "T4532", "Triple-S");

      // Paciente 1 Lista Historial Medico
      List<HistorialMedico> listaHistorialPaciente1 = new List<HistorialMedico>();
      listaHistorialPaciente1.Add(new HistorialMedico("2/ago/2020", "Dolor de cabeza"));
      listaHistorialPaciente1.Add(new HistorialMedico("20/ago/2020", "Dolor de cuello"));

      // Paciente 2 Lista Historial Medico
      List<HistorialMedico> listaHistorialPaciente2 = new List<HistorialMedico>();
      listaHistorialPaciente2.Add(new HistorialMedico("22/ene/2021", "Dolor de brazo"));
      listaHistorialPaciente2.Add(new HistorialMedico("10/nov/2021", "Dolor de ojo izquierdo"));

      // Paciente 3 Lista Historial Medico
      List<HistorialMedico> listaHistorialPaciente3 = new List<HistorialMedico>();
      listaHistorialPaciente3.Add(new HistorialMedico("19/feb/2022", "Dolor de espalda"));
      listaHistorialPaciente3.Add(new HistorialMedico("10/oct/2023", "Dolor de pies"));

      // Mostrar detalles pacientes 

      // Paciente 1
      Console.WriteLine("Información del paciente:");
      paciente1.verDatos();

      Console.WriteLine("Historial medico:");
      foreach (HistorialMedico historialPaciente1 in listaHistorialPaciente1 ) {
        historialPaciente1.verHistorial();
      }

      paciente1.agregarNota("Paciente necesita revision del cuello");

      Console.WriteLine();

      // Paciente 2
      Console.WriteLine("Información del paciente:");
      paciente2.verDatos();

      Console.WriteLine("Historial medico:");
      foreach (HistorialMedico historialPaciente2 in listaHistorialPaciente2 ) {
        historialPaciente2.verHistorial();
      }

      paciente2.agregarNota("Paciente necesita revision del ojo izquierdo");

      Console.WriteLine();

      // Paciente 3
      Console.WriteLine("Información del paciente:");
      paciente3.verDatos();

      Console.WriteLine("Historial medico:");
      foreach (HistorialMedico historialPaciente3 in listaHistorialPaciente3 ) {
        historialPaciente3.verHistorial();
      }

      paciente3.agregarNota("Paciente necesita revision del pies");

      Console.WriteLine("-----------------------------------------------------------------------------------------------------");

      //---------------------------- Doctores ----------------------------

      // Objetos y listas de la clase Doctor Y información del doctor:

      // Doctores
      Doctor doctor1 = new Doctor("Lopez", 40, "Y77856", "Cirujano");
      Doctor doctor2 = new Doctor("Juan", 55, "Y76544", " Gastroenterólogo");

      // Mostrar detalles de los doctores 

      // Doctor 1
      Console.WriteLine("Información del doctor:");
      doctor1.verDatos();
      Console.WriteLine();

      // Doctor 2
      Console.WriteLine("Información del doctor:");
      doctor2.verDatos();

      Console.WriteLine("-----------------------------------------------------------------------------------------------------");

      // Lista de pacientes atendidos por los doctores
      doctor1.listaPacientesAtendidos.Add(paciente1);
      doctor1.listaPacientesAtendidos.Add(paciente2);
      doctor2.listaPacientesAtendidos.Add(paciente3);

      // Mostrar pacientes atendidos por los doctores
      doctor1.verPacientesAtendidos();
      Console.WriteLine();
      doctor2.verPacientesAtendidos();

      Console.WriteLine("-----------------------------------------------------------------------------------------------------");
      
      //---------------------------- Consulta ----------------------------

      // Objetos de la clase Consulta Y información de la consulta:
      Consulta consulta1 = new Consulta(paciente1, doctor1, "Revision de dolor de cuello");
      Consulta consulta2 = new Consulta(paciente2, doctor1, "Revision del ojo izquierdo");
      Consulta consulta3 = new Consulta(paciente3, doctor2, "Revision de dolor de pies");


      // Mostrar detalles de las consultas
      consulta1.verDetallesConsulta();
      consulta2.verDetallesConsulta();
      consulta3.verDetallesConsulta();

      Console.WriteLine("--------------------------------------- Pacientes Registrados ---------------------------------------");

      //---------------------------- Pacientes Registrados ----------------------------

      RegistroPacientes registroDelPaciente = new RegistroPacientes();

      // Lista de registro de pacientes
      registroDelPaciente.listaPacienteRegistrado.Add(paciente1);
      registroDelPaciente.listaPacienteRegistrado.Add(paciente2);
      registroDelPaciente.listaPacienteRegistrado.Add(paciente3);

      // Mostrar pacientes registrados
      registroDelPaciente.verRegistroPacientes();
      Console.WriteLine();

      Console.WriteLine("--------------------------------------- Doctores Disponibles ----------------------------------------");

      //---------------------------- Doctores Disponibles ----------------------------

      DoctoresDisponibles disponibilidadDoctor = new DoctoresDisponibles();

      // Lista de doctores disponibles
      disponibilidadDoctor.listaDoctoresDisponibles.Add(doctor1);
      disponibilidadDoctor.listaDoctoresDisponibles.Add(doctor2);

      // Mostrar los doctores disponibles
      disponibilidadDoctor.verDoctorDisponible();
      Console.WriteLine();

      Console.WriteLine("--------------------------------------- Consultas Realizadas ----------------------------------------");

      //---------------------------- Consultas Realizadas ----------------------------

      ConsultaRealizada consultaRealizada = new ConsultaRealizada();

      // Lista de consultas realizadas
      consultaRealizada.listaConsultaRealizada.Add(paciente1);
      consultaRealizada.listaConsultaRealizada.Add(paciente3);

      // Mostrar las consultas realizadas
      consultaRealizada.verConsultaRealizada();
      Console.WriteLine();
    }
  }
}
