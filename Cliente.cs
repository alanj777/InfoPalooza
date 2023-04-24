class cliente{
       public string DNI {get; private set;}
       public string Apellido {get; private set;}
       public string Nombre {get; private set;}
       public DateTime FechaInscripción {get; private set;}
       public int TipoEntrada {get; private set;}
       public double TotalAbonado {get; private set;}
  public Cliente(string dni, string apellido, string nombre, int tipoentrada, int totalabonado){
       
 }
 public bool CambiarEntrada(int tipoentrada, double totalabonado){
  string respuesta;
  if (tipoentrada != 4){
  Console.WriteLine("Desea cambiar la entrada?");
  respuesta = Console.ReadLine();
  if (respuesta = "si" || respuesta = "sí" || respuesta = "SI" || respuesta = "SÍ" || respuesta = "Sí" || respuesta = "Si"){
  Console.WriteLine("Qué entrada prefiere entre las otras 2? (Escribir cancelar para cancelar acción)");
  respuesta = Console.ReadLine();
  if (respuesta != "cancelar"){
    totalabonado = totalabonado + 10000;
    Console.WriteLine("Total abonado luego de la compra: $" + totalabonado);
    return true
  }
  else{
    Console.WriteLine("Regresando al menú principal");
    return false;
  }
  }
  else{
    Console.WriteLine("Regresando al menú principal");
    return false;
  }
 }
 }

}