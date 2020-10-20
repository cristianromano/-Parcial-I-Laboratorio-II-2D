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
        public List<Producto> ListaProducto { get => ListaProducto; set => ListaProducto = value; }

        private void FormularioVentas_Load(object sender, EventArgs e)
        {
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

            this.dtgEmpleado.Columns[2].Visible = false;
            this.txtPrecioTotal.Text = "0";
        }

        /// <summary>
        /// funcion para darle transparencia a los labels
        /// </summary>
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

        /// <summary>
        /// agrego una nueva venta y un nuevo cliente (en caso de no existir previamente) a sus respectivas listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptarVentas_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(this.txtNombreVentas.Text) == false && string.IsNullOrWhiteSpace(this.txtApellidoVentas.Text) == false
                    && string.IsNullOrWhiteSpace(this.txtNombreVendedor.Text) == false && string.IsNullOrWhiteSpace(this.txtApellidoVendedor.Text) == false)
                {
                    int id = int.Parse(this.txtIDVendedor.Text);

                    MiVenta = new Venta(this.txtNombreVendedor.Text, txtApellidoVendedor.Text, id, ListaProductos);

                    if (Comercio.Ventas + MiVenta)
                    {
                        MessageBox.Show($"Venta exitosa!");
                    }

                    this.dtgVentas.DataSource = null;

                    this.btnAgregarProducto.Enabled = false;

                    this.btnAceptarVentas.Enabled = false;

                    MiCliente = new Cliente(this.txtNombreVentas.Text, this.txtApellidoVentas.Text);

                    if (Comercio.Clientes + MiCliente)
                    {
                        MessageBox.Show(MiCliente.registro());
                        this.dtgClientes.DataSource = Comercio.Clientes;
                        this.dtgClientes.DataSource = null;
                        this.dtgClientes.DataSource = Comercio.Clientes;
                    }

                    tmrFormVenta.Stop();
                    sonidoCaja.Stream = Properties.Resources.caja;
                    sonidoCaja.Play();
                }

                else
                {
                    throw new Excepciones("faltan datos para poder generar el reporte");
                }

            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Excepciones ex)
            {
                MessageBox.Show(ex.Message);
            }

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

                acumulador += MiProducto.Precio;

                this.txtPrecioTotal.Text = acumulador.ToString();

                RefrescarDataGridVenta();

                dtgVentas.Columns.Remove("Stock");

            }

        }

        private void RefrescarDataGridVenta()
        {

            this.dtgVentas.DataSource = ListaProductos;
            this.dtgVentas.DataSource = null;
            this.dtgVentas.DataSource = ListaProductos;


        }

        /// <summary>
        /// agrego datos a textbox del COMPRADOR extraidos del datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtNombreVentas.Text = dtgClientes.CurrentRow.Cells[1].Value.ToString();
            this.txtNombreVentas.Enabled = false;
            this.txtApellidoVentas.Text = dtgClientes.CurrentRow.Cells[2].Value.ToString();
            this.txtApellidoVentas.Enabled = false;
            this.txtIDCliente.Text = dtgClientes.CurrentRow.Cells[0].Value.ToString();
            this.txtIDCliente.Enabled = false;
        }

        /// <summary>
        /// agrego datos a textbox del VENDEDOR extraidos del datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtNombreVendedor.Text = dtgEmpleado.CurrentRow.Cells[3].Value.ToString();
            this.txtNombreVendedor.Enabled = false;
            this.txtApellidoVendedor.Text = dtgEmpleado.CurrentRow.Cells[4].Value.ToString();
            this.txtApellidoVendedor.Enabled = false;
            this.txtIDVendedor.Text = dtgEmpleado.CurrentRow.Cells[0].Value.ToString();
            this.txtIDVendedor.Enabled = false;
            this.txtTurno.Text = dtgEmpleado.CurrentRow.Cells[1].Value.ToString();
            this.txtTurno.Enabled = false;
        }

        /// <summary>
        /// funcion en caso de que el usuario cierre el formulario sin haber realizado una compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormularioVentas_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MiVenta != null)
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

        /// <summary>
        /// funcion que va contando el tiempo para cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// genero ticket de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtNombreVentas.Text) == false && string.IsNullOrWhiteSpace(this.txtApellidoVentas.Text) == false
                    && string.IsNullOrWhiteSpace(this.txtNombreVendedor.Text) == false && string.IsNullOrWhiteSpace(this.txtApellidoVendedor.Text) == false)
                {
                    string directorio = Directory.GetCurrentDirectory();
                    float descuento = 0;

                    StreamWriter sw = new StreamWriter(string.Concat(directorio, "/tickets.txt"), false);

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

                else
                {
                    throw new Excepciones("no se puede generar tickets sin datos");
                }
            }
            catch (Excepciones ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
