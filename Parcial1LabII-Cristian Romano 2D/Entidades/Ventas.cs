using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Venta
    {
        string nombre;
        string apellido;
        int id;
        List<Producto> productos;

        public Venta(string nombre, string apellido, int id, List<Producto> productos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Id = id;
            this.Productos = productos;
            productos = new List<Producto>();
           
        }
        public int Id { get => id; set => id = value; }
        public List<Producto> Productos { get => productos; set => productos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public static bool operator +(List<Venta> ventas , Venta venta)
        {
            ventas.Add(venta);
            return true;
        }

    }

}
