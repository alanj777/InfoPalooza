using System.Collections.Generic;
namespace TP03_Jolodovsky;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, cliente> Inscripciones= new Dictionary<int, cliente>();
        Console.WriteLine("i. Nueva Inscripción \nii. Obtener Estadísticas Del Evento \niii. Buscar Cliente \niv. Cambiar Entrada De Un Cliente \nv. Salir\n(Ingresar opción con numeros del teclado, no en números romanos)");

    }
    static int IngresarEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
       int entero = int.Parse(Console.ReadLine());
        return entero;
    }
    static int IngresarEnteroEnRango(string mensaje, int minimo, int maximo)
    {
        int entero;
        entero = IngresarEntero(mensaje);
        while (entero < minimo || entero > maximo)
        {
            entero = IngresarEntero("---Error---Número inválido--- " + mensaje);
        }
        return entero;
    }
}
