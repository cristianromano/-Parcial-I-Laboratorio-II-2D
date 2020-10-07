using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Producto
    {
        string codigo;
        string nombre;
        float precio;
        int stock;
    
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

        public static bool operator ==(List <Producto> productos , Producto producto)
        {
            bool retorno = false;

            foreach (Producto item in productos)
            {
                if(item.codigo == producto.codigo)
                {
                    retorno =  true;
                    break;
                    
                }
            }

            return retorno;
        }

        public static bool operator !=(List<Producto> productos, Producto producto)
        {
            return !(productos == producto);
        }

        public static bool operator +(List<Producto> productos, Producto producto)
        {
            bool retorno = false;

            if(productos != producto)
            {
                productos.Add(producto);

                retorno = true;
               
            }

            else
            {
                foreach (Producto item in productos)
                {
                    if(item.codigo == producto.codigo)
                    {
                        item.stock += producto.Stock;
                    }
                }              
            }
            return retorno;
        }

    }
}
