using Parcial1Lab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaginaPrincipal
{
    public partial class FormularioHistorialVentas : Form
    {
        int conteo;
        public FormularioHistorialVentas()
        {
            InitializeComponent();
        }

        private void FormularioHistorialVentas_Load(object sender, EventArgs e)
        {

            tmrFormHistorial.Start();

            conteo = 0;

            this.dtgHistorialVentas.DataSource = Comercio.Ventas;

            this.dtgHistorialVentas.DataSource = null;

            this.dtgHistorialVentas.DataSource = Comercio.Ventas;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo++;
            deslogueo();

        }

        private void deslogueo()
        {
            if (conteo == 225)
            {

                

                this.Close();


            }

        }
    }
}
