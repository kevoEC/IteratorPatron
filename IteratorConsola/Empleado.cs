using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorConsola
{
    class Empleado
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public Empleado(string nombre, int id) { 
        
            Nombre = nombre;
            Id = id;
        }
    }
}
