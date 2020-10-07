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
        double dni;

        public Empleado(string nombre, string apellido, ETurno turno , double dni) : base(nombre, apellido)
        {
            this.id = acumID++;
            this.turno = turno;
            this.dni = dni;
        }

        public int ID { get => id; }
        public ETurno Turno { get => turno; }
        public double Dni { get => dni; }
        public override string registro()
        {
            return $"Se ha registrado a Empleado ID: {this.ID} , Nombre: {this.nombre}";
        }

        public static bool operator ==(List<Empleado> empleados, Empleado empleado)
        {
            foreach (Empleado item in empleados)
            {
                if (item.dni == empleado.dni)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool operator !=(List<Empleado> empleados, Empleado empleado)
        {
            return !(empleados == empleado);
        }
        public static bool operator +(List<Empleado> empleados, Empleado empleado)
        {
            bool retorno = false;

            if (empleados != empleado)
            {
                empleados.Add(empleado);
                retorno = true;
            }

            return retorno;
        }     
        
        public static bool operator -(List<Empleado> empleados, Empleado empleado)
        {
            bool retorno = false;

            foreach (Empleado item in empleados)
            {
                if(item.dni == empleado.dni)
                {
                    empleados.Remove(item);
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

    }
}
