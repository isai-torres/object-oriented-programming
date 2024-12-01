using System;

namespace FinalProject {
  class Program {
    private static void Main(string[] args) {
      // Objetos de la clase Persona Y información del paciente

      // Paciente 1
      Paciente paciente1 = new Paciente("Isai", 25, "I9988", "TryCare");

      // Mostrar detalles paciente 1
      Console.WriteLine("Información del paciente:");
      paciente1.verDatos();
    }
  }
}