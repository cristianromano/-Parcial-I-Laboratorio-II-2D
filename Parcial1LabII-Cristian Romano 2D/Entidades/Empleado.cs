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

        /// <summary>
        /// informa datos de registro de empleado al registrarse 
        /// </summary>
        /// <returns></returns>
        public override string registro()
        {
            return $"Se ha registrado a Empleado ID: {this.ID} , Nombre: {this.nombre}";
        }


        /// <summary>
        /// indica que si el dni de un empleado de la lista es igual al que se le pasa por parametro devuelva true;
        /// </summary>
        /// <param name="empleados"></param>
        /// <param name="empleado"></param>
        /// <returns>bool</returns>
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
        /// <summary>
        /// indica que si el dni de un empleado de la lista es igual al que se le pasa por parametro devuelva false , niega el ==;
        /// </summary>
        /// <param name="empleados"></param>
        /// <param name="empleado"></param>
        /// <returns>bool</returns>
        public static bool operator !=(List<Empleado> empleados, Empleado empleado)
        {
            return !(empleados == empleado);
        }
        /// <summary>
        /// agrega un elemento a la lista en caso de no encontrarse en la misma
        /// </summary>
        /// <param name="empleados"></param>
        /// <param name="empleado"></param>
        /// <returns>bool</returns>
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
        /// <summary>
        /// elimia un empleado de la lista en caso de encontrarse en la misma
        /// </summary>
        /// <param name="empleados"></param>
        /// <param name="empleado"></param>
        /// <returns>bool</returns>
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
