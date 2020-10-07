using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace ParcialLabII
{
    public partial class PaginaPrincipal : Form
    {

        int conteo;
        public PaginaPrincipal()
        {
            InitializeComponent();
        }


        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            Comercio.hardcodeoDatos();

            RefrescarDataGrid();

            this.lbIventanrio.Parent = picbLogo;
            this.lbIventanrio.BackColor = Color.Transparent;
            btnHistorialVentas.Enabled = false;

            tmrLogeo.Start();
            conteo = 0;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            tmrLogeo.Stop();

            NuevosProductos OpcionProductos = new NuevosProductos();

            if (OpcionProductos.ShowDialog() == DialogResult.OK)
            {
                RefrescarDataGrid();
            }

            tmrLogeo.Start();
        }

        private void RefrescarDataGrid()
        {
            this.dtgvProductos.DataSource = Comercio.Productos;

            this.dtgvProductos.DataSource = null;

            this.dtgvProductos.DataSource = Comercio.Productos;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            tmrLogeo.Stop();

            FormularioVentas formularioVentas = new FormularioVentas();

            if (formularioVentas.ShowDialog() == DialogResult.OK)
            {
                btnHistorialVentas.Enabled = true;

                RefrescarDataGrid();
            }

            tmrLogeo.Start();

        }

        private void btnHistorialVentas_Click(object sender, EventArgs e)
        {
            tmrLogeo.Stop();

            FormularioHistorialVentas formHistorialVentas = new FormularioHistorialVentas();
            if (formHistorialVentas.ShowDialog() == DialogResult.OK)
            {
                RefrescarDataGrid();
            }
            tmrLogeo.Start();

        }

        private void btnBajoStock_Click(object sender, EventArgs e)
        {
            tmrLogeo.Stop();

            List<Producto> aux = new List<Producto>();

            foreach (Producto item in Comercio.Productos)
            {
                if (item.Stock < 10)
                {
                    aux.Add(item);
                }
            }

            this.dtgvProductos.DataSource = aux;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefrescarDataGrid();
        }

        private void PaginaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tmrLogeo_Tick(object sender, EventArgs e)
        {
            tmrLogeo.Start();

            conteo++;
            deslogueo();
        }

        private void deslogueo()
        {
            if (conteo == 600)
            {
                InicioSesion sesion = new InicioSesion();

                sesion.Show();

                this.Hide();

                MessageBox.Show("SESION A EXPIRADO", "DESLOGUEO AUTOMATICO");

            }

        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            FormularioAgregarEmpleado agregarEmpleado = new FormularioAgregarEmpleado();

            if (agregarEmpleado.ShowDialog() == DialogResult.OK)
            {
                RefrescarDataGrid();
            }
        }
    }

}
