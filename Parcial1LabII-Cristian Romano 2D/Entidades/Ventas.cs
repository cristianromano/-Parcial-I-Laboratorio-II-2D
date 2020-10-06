using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Venta : Persona
    {

        int id;
        List<Producto> productos;

        public Venta(string nombre, string apellido, int id, List<Producto> productos) : base(nombre, apellido)
        {
           
            this.Id = id;
            this.Productos = productos;
            productos = new List<Producto>();
           
        }
        public int Id { get => id; set => id = value; }
        public List<Producto> Productos { get => productos; set => productos = value; }
    }

}
