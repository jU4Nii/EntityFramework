using System.Security.Cryptography.X509Certificates;
using BibliotecaDeClases.Models;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo("BMW", 2015, "AGV200", 4, "V12");
            Vehiculo vehiculo1 = new Vehiculo("Audi", 2016, "EOW240", 4, "V12");
        }
    }
}
