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

        public override string registro()
        {
           return $"Se cargo a Cliente: {this.nombre} {this.apellido} , ID: {this.IdCliente}";
        }

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

        public static bool operator !=(List<Cliente> clientes, Cliente cliente)
        {
            return !(clientes == cliente);
        }

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
