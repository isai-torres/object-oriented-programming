public class DoctoresDisponibles : Doctor {
  public List<Doctor> listaDoctoresDisponibles { get; set; } = new List<Doctor>();

  // Constructor vació
  public DoctoresDisponibles() {

  }

  // Método para mostrar los doctores disponibles
  public void verDoctorDisponible() {
    Console.WriteLine("Doctores disponibles:");
    foreach (Doctor doctorDisponible in listaDoctoresDisponibles) {
      Console.WriteLine($"{doctorDisponible.nombre} - {doctorDisponible.identificacion}");
    }
  }
}