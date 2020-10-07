using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public enum ETurno { Dia, Tarde, Noche }
    public class Empleado : Persona
    {
        

        int id;
        ETurno turno;
       static int acumID = 354;

        public Empleado(string nombre, string apellido, ETurno turno) : base(nombre, apellido)
        {
            this.id = acumID++;
            this.turno = turno;
        }

        public int Id { get => id; set => id = value; }
        public ETurno Turno { get => turno; }

        public override string registro()
        {
            return $"Se ha registrado a Empleado ID: {this.id} , Nombre: {this.nombre}";
        }

    }
}
