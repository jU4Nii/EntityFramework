using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Models
{
    public class Vehiculo
    {

        public Vehiculo(string Marca, int Modelo, string Patente, int CantPuertas, string Motor)
        {
            
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Patente = Patente;
            this.CantPuertas = CantPuertas;
            this.Motor = Motor;
        }

        

        public string Marca { get; set; }

        public int Modelo { get; set; }

        public string Patente { get; set; }

        public int CantPuertas { get; set; }

        public string Motor {  get; set; }



    }
}
