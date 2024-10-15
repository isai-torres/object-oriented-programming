// Clase Empleado

public class Empleado {
  public string numeroEmpleado;
  public double workYears;

  // Método constructor sin parámetros

  public Empleado() {
    
  }

  // Método constructor con parámetros
  public Empleado(string NumeroEmpleado, double WorkYears) {

    numeroEmpleado = NumeroEmpleado;
    workYears = WorkYears;
  }

  // Método tipo de contrato

  public string tipoContrato() {
    if (workYears >= 1D) {

      Console.WriteLine($"Numero del empleado: {numeroEmpleado}");
      return "Tipo de Contrato: permanente";

    } else {

      Console.WriteLine($"Numero del empleado: {numeroEmpleado}");
      return "Tipo de Contrato: probatorio";
    }
  } 
}