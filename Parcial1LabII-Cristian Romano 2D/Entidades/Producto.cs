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

        /// <summary>
        /// funcion utilizada para verificar si el objeto pasado por parametro ya tiene el mismo codigo que alguno perteneciente a la lista , de ser asi devuelve un true
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>bool</returns>
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

        /// <summary>
        /// niega el metodo ==
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>bool</returns>
        public static bool operator !=(List<Producto> productos, Producto producto)
        {
            return !(productos == producto);
        }

        /// <summary>
        /// agrega un nuevo producto a la lista
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>bool</returns>
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

        /// <summary>
        /// elimina un producto de la lista
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator -(List<Producto> productos, Producto producto)
        {
            bool retorno = false;

            foreach (Producto item in productos)
            {
                if (item.codigo == producto.codigo)
                {
                    productos.Remove(item);
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

    }
}
