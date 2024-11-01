public class Empleado {
  private string nombre {get; set;}
  private double salario {get; set;}

  // Método para mostrar el nombre y el salario
  public void mostrarNombreSalario() {
    Console.WriteLine($"Nombre: {Nombre} \nSalario {Salario:C}");
  }

  // Método constructor sin parámetros

  public Empleado() {

  }

  // Método constructor con parámetros

  public Empleado(string ElNombre, double ElSalario) {
    nombre = ElNombre;
    salario = ElSalario;
  }

  // Get / Set

  public string Nombre {
    get{return nombre;}
    set{nombre = value;}
  }

  public double Salario {
    get{return salario;}
    set {
      if(value >= 0) {
        salario = value;
      }
    }
  }
}