using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Cliente:Persona
    {

        int idCliente;
        static int auto = 30;

        public Cliente(string nombre, string apellido):base(nombre,apellido)
        {
            this.IdCliente = auto++;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }

        /// <summary>
        ///  informa nombre , apellido y ID de cliente al cargarse
        /// </summary>
        /// <returns>string</returns>
        public override string registro()
        {
           return $"Se cargo a Cliente: {this.nombre} {this.apellido} , ID: {this.IdCliente}";
        }

        /// <summary>
        /// retorna un bool en caso de que el elemento pasado por parametro tenga el mismo nombre y apellido que algun elemento de la lista
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns>bool</returns>
        public static bool operator ==(List<Cliente>clientes , Cliente cliente)
        {
            foreach (Cliente item in clientes)
            {
                if(item.nombre == cliente.nombre && item.apellido == cliente.apellido)
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// niega el ==
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns>bool</returns>
        public static bool operator !=(List<Cliente> clientes, Cliente cliente)
        {
            return !(clientes == cliente);
        }
        /// <summary>
        /// agrega un cliente a la lista en caso de no existir en la misma
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns>bool</returns>
        public static bool operator +(List<Cliente> clientes, Cliente cliente)
        {
            if(clientes != cliente)
            {
                clientes.Add(cliente);
                return true;
            }

            return false;
        }


    }
}
