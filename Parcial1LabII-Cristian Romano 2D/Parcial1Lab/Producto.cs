using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        string codigo;
        string nombre;
        float precio;
        int stock;
      //  Producto[] productos;
    

        public Producto(string codigo, string nombre, float precio, int stock)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }

        public static explicit operator Producto(string v)
        {
            throw new NotImplementedException();
        }
    }
}
