using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Comercio
    {

        static List<Empleado> ListaEmpleados;
        static List<Cliente> ListaClientes;
        static List<Producto> ListaProductos;
        static List<Venta> ListaVentas;

        static Comercio()
        {
            ListaEmpleados = new List<Empleado>();
            ListaClientes = new List<Cliente>();
            ListaProductos = new List<Producto>();
            ListaVentas = new List<Venta>();
        }

        public static List<Empleado> Empleados { get => ListaEmpleados; }
        public static List<Cliente> Clientes { get => ListaClientes;  }
        public static List<Producto> Productos { get => ListaProductos; }
        public static List<Venta> Ventas { get => ListaVentas; }
        public static void hardcodeoDatos()
        {
            string[] nombre = { "Magic", "Bart" };
            string[] apellido = { "Jonson", "Simpson" };
            string[] nombreV = { "Kobe", "Lebron" };
            string[] apellidoV = { "Bryant", "James" };
            ETurno[] turnos = { ETurno.Noche, ETurno.Dia , ETurno.Tarde };
            double[] dni = { 25258561, 25369878 };
            string[] codigo = { "AAB4", "AGG4", "ABB5", "ZZC5", "ZZX8", "JJHY6", "HHGS3", "GGDQ3", "QRE4", "BBV3" };
            string[] nombreProducto = { "Oreo", "Rumba", "Rodecia", "Merengadas", "Chocolinas", "9 de Oro", "Mellizas", "Saladix", "Surtido", "Pitusas" };
            float[] precio = { 30.25f, 80.75f, 20.99f, 30.33f, 69.99f, 25.20f, 74.35f, 30.80f, 60.45f, 90.50f };
            int[] stock = { 15, 5, 20, 4, 10, 14, 18, 20, 60, 30 };

            for (int i = 0; i < 2; i++)
            {
                ListaClientes.Add(new Cliente(nombre[i], apellido[i]));
                ListaEmpleados.Add(new Empleado(nombreV[i], apellidoV[i],turnos[i] , dni[i]));
            }

            for (int i = 0; i < 10; i++)
            {
                ListaProductos.Add(new Producto(codigo[i], nombreProducto[i], precio[i], stock[i]));
            }

        }

    }
}
