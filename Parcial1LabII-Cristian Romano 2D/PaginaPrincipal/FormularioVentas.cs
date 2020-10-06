using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace ParcialLabII
{
    public partial class FormularioVentas : Form
    {

     
        int conteo;
        private Venta MiVenta;
        private Cliente MiCliente;
        SoundPlayer sonidoPeep;
        SoundPlayer apu;
        SoundPlayer sonidoCaja;
        SoundPlayer zulma;

        List<Producto> ListaProductos;
       


        public float acumulador = 0;



        public FormularioVentas()
        {

            InitializeComponent();

            ListaProductos = new List<Producto>();
        }

        public Venta MiVenta1 { get => MiVenta; set => MiVenta = value; }
        public List<Producto> ListaProducto { get => ListaProducto; set => ListaProducto = value; }
        public Cliente MiCliente1 { get => MiCliente; set => MiCliente = value; }



        private void FormularioVentas_Load(object sender, EventArgs e)
        {
            // dtgVentas.Columns.RemoveAt(dtgVentas.Columns.Count - 1);

            tmrFormVenta.Start();

            conteo = 0;

            this.cmbProductosVenta.DataSource = Comercio.Productos;
            this.cmbProductosVenta.DisplayMember = "Nombre";

            this.dtgClientes.DataSource = Comercio.Clientes;
            this.dtgClientes.DataSource = null;
            this.dtgClientes.DataSource = Comercio.Clientes;

            this.dtgEmpleado.DataSource = Comercio.Empleados;
            this.dtgEmpleado.DataSource = null;
            this.dtgEmpleado.DataSource = Comercio.Empleados;

            transparenteLabels();

           
            sonidoPeep = new SoundPlayer();
            sonidoCaja = new SoundPlayer();
            zulma = new SoundPlayer();
            apu = new SoundPlayer();
            
          


        }



        private void transparenteLabels()
        {
            lbApellidoVenta.Parent = pctbLogoVentas;
            lbApellidoVenta.BackColor = Color.Transparent;

            lbApellidoVendedor.Parent = pctbLogoVentas;
            lbApellidoVendedor.BackColor = Color.Transparent;

            lbCartelClientes.Parent = pctbLogoVentas;
            lbCartelClientes.BackColor = Color.Transparent;

            lbCartelEmpleados.Parent = pctbLogoVentas;
            lbCartelEmpleados.BackColor = Color.Transparent;

            lbIDCliente.Parent = pctbLogoVentas;
            lbIDCliente.BackColor = Color.Transparent;

            lbID_Empleado.Parent = pctbLogoVentas;
            lbID_Empleado.BackColor = Color.Transparent;

            lbNombreVendedor.Parent = pctbLogoVentas;
            lbNombreVendedor.BackColor = Color.Transparent;

            lbNombreVenta.Parent = pctbLogoVentas;
            lbNombreVenta.BackColor = Color.Transparent;

            lbPrecio.Parent = pctbLogoVentas;
            lbPrecio.BackColor = Color.Transparent;

            lbProductoVenta.Parent = pctbLogoVentas;
            lbProductoVenta.BackColor = Color.Transparent;

            lbCartelRegistrarVenta.Parent = pctbLogoVentas;
            lbCartelRegistrarVenta.BackColor = Color.Transparent;

            lbCartelCompra.Parent = pctbLogoVentas;
            lbCartelCompra.BackColor = Color.Transparent;

            lbPrecioItem.Parent = pctbLogoVentas;
            lbPrecioItem.BackColor = Color.Transparent;

            lbStock.Parent = pctbLogoVentas;
            lbStock.BackColor = Color.Transparent;

        }

        private void btnAceptarVentas_Click(object sender, EventArgs e)
        {

            tmrFormVenta.Stop();

            sonidoCaja.Stream = Properties.Resources.caja;
            sonidoCaja.Play();

            int id = int.Parse(this.txtIDVendedor.Text);

            MiVenta = new Venta(this.txtNombreVendedor.Text, txtApellidoVendedor.Text, id, ListaProductos);


            this.dtgVentas.DataSource = null;

            this.btnAgregarProducto.Enabled = false;

            this.btnAceptarVentas.Enabled = false;

            bool existe = ClienteYaExistente();

            if (existe == false)
            {


                MiCliente = new Cliente(this.txtNombreVentas.Text, this.txtApellidoVentas.Text);
            }



            // MessageBox.Show("Graciass Vuelvass Prontoss", "Agradecimiento");



        }


        private void cmbProductosVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

            Producto MiProducto = (Producto)this.cmbProductosVenta.SelectedItem;


            this.txtStock.Text = MiProducto.Stock.ToString();

            this.txtPrecioItem.Text = MiProducto.Precio.ToString();

          





        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            tmrFormVenta.Stop();

           

            Producto MiProducto = (Producto)this.cmbProductosVenta.SelectedItem;

            if (MiProducto.Stock == 0)
            {
                MessageBox.Show("No hay Stock", "Warning");

            }

            else
            {



                sonidoPeep.Stream = Properties.Resources.beep;
                sonidoPeep.Play();


                MiProducto.Stock--;

                this.txtStock.Text = MiProducto.Stock.ToString();

                ListaProductos.Add(MiProducto);


             /*   if (this.txtApellidoVentas.Text.Equals("Simpson"))
                {
                    acumulador += MiProducto.Precio;

                   // descuento = (acumulador * 0.13f);


                  //  this.txtPrecioTotal.Text = descuento.ToString();
                }*/
           
                    acumulador += MiProducto.Precio;

                    this.txtPrecioTotal.Text = acumulador.ToString();
                




                RefrescarDataGridVenta();

                dtgVentas.Columns.Remove("Stock");



                // MessageBox.Show(array[i]);



            }




        }

        private void RefrescarDataGridVenta()
        {

            this.dtgVentas.DataSource = ListaProductos;
            this.dtgVentas.DataSource = null;
            this.dtgVentas.DataSource = ListaProductos;


        }

        private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtNombreVentas.Text = dtgClientes.CurrentRow.Cells[1].Value.ToString();
            this.txtNombreVentas.Enabled = false;
            this.txtApellidoVentas.Text = dtgClientes.CurrentRow.Cells[2].Value.ToString();
            this.txtApellidoVentas.Enabled = false;
            this.txtIDCliente.Text = dtgClientes.CurrentRow.Cells[0].Value.ToString();
            this.txtIDCliente.Enabled = false;


        }

        private void dtgEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtNombreVendedor.Text = dtgEmpleado.CurrentRow.Cells[0].Value.ToString();
            this.txtNombreVendedor.Enabled = false;
            this.txtApellidoVendedor.Text = dtgEmpleado.CurrentRow.Cells[1].Value.ToString();
            this.txtApellidoVendedor.Enabled = false;
            this.txtIDVendedor.Text = dtgEmpleado.CurrentRow.Cells[2].Value.ToString();
            this.txtIDVendedor.Enabled = false;
        }


        private bool ClienteYaExistente()
        {
            int idCliente;


            if (int.TryParse(this.txtIDCliente.Text, out idCliente))
            {
                foreach (Cliente item in Comercio.Clientes)
                {
                    if (item.IdCliente == idCliente)
                    {
                        return true;
                    }

                }
            }

            return false;

        }

        private void FormularioVentas_FormClosing(object sender, FormClosingEventArgs e)
        {

            if(MiVenta != null)
            {
                this.DialogResult = DialogResult.OK;
                apu.Stream = Properties.Resources.apu;
                apu.Play();
            }

            else
            {
                zulma.Stream = Properties.Resources.zulma;
                zulma.Play();
            }
            
        }



        private void tmrFormVenta_Tick(object sender, EventArgs e)
        {
            conteo++;
            deslogueo();
        }

        private void deslogueo()
        {
            if (conteo == 600)
            {



                this.Close();


            }

        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            string directorio = Directory.GetCurrentDirectory();

            float descuento = 0;

            // SE CREA EN C:\Users\Cristian\Desktop\ParcialLabII-2D\Parcial1Lab\PaginaPrincipal\bin\Debug;

            StreamWriter sw = new StreamWriter(string.Concat(directorio , "/tickets.txt"),false);
           
            sw.WriteLine($"------------------------------");
            sw.WriteLine("TICKET DE COMPRA KWIK E MART");
            sw.WriteLine($"------------------------------");
            sw.WriteLine($"Hora: {DateTime.Now.ToString("G")}");
            sw.WriteLine($"------------------------------");
            sw.WriteLine($"Empleado: {this.txtNombreVendedor.Text},{this.txtApellidoVendedor.Text} ");
            sw.WriteLine($"------------------------------");
            sw.WriteLine($"ID: {this.txtIDVendedor.Text}");
            sw.WriteLine($"------------------------------");
            sw.WriteLine($" ");
            sw.WriteLine($" ");
            sw.WriteLine($"------------------------------");
            sw.WriteLine($"Productos vendidos x listado ");
            sw.WriteLine($"------------------------------");

            foreach (Producto item in ListaProductos)
            {
                float acumulador = 0;

                sw.WriteLine($"Item: {item.Nombre} x Precio: {item.Precio}");
                sw.WriteLine($"------------------------------");
                acumulador += item.Precio;
            }

           
                if (this.txtApellidoVentas.Text.Equals("Simpson"))
                {
                    descuento = (acumulador * 13) / 100;

                    acumulador -= descuento;

                    sw.WriteLine($"DESCUENTO DEL %13 POR SER SIMPSON ");
                    sw.WriteLine($"------------------------------");
                    
                }

            
                sw.WriteLine($"Precio Final: {acumulador}");
                sw.WriteLine($"------------------------------");
                sw.WriteLine($"GRACIAS POR TU COMPRA REY");
                sw.Close();

                MessageBox.Show("TICKET GENERADO CON EXITO!", "TICKET X TU COMPRA <3");         

        }




    }
}
