using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Lab
{
    public sealed class Cliente:Persona
    {

        int idCliente;
        static int auto = 30;

        public Cliente(string nombre, string apellido):base(nombre,apellido)
        {
            this.IdCliente = auto++;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }


    }
}
