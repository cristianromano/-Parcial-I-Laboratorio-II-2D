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

namespace ParcialLabII
{
    public partial class NuevosProductos : Form
    {
        int conteo;

        private Producto MiProducto;

        public Producto Producto
        {
            get
            {
                return MiProducto;
            }

            set
            {
                 MiProducto = value;
            }

        }

        public NuevosProductos()
        {
            InitializeComponent();
        }

        private void NuevosProductos_Load(object sender, EventArgs e)
        {
            tmrAgregarProducto.Start();
            conteo = 0;

            this.lbNombre.Parent = pictureBox1;
            this.lbNombre.BackColor = Color.Transparent;

            this.lbCodigo.Parent = pictureBox1;
            this.lbCodigo.BackColor = Color.Transparent;

            this.lbPrecio.Parent = pictureBox1;
            this.lbPrecio.BackColor = Color.Transparent;

            this.lbStock.Parent = pictureBox1;
            this.lbStock.BackColor = Color.Transparent;

            this.dtgAgregarProducto.DataSource = Comercio.Productos;
            this.dtgAgregarProducto.DataSource = null;
            this.dtgAgregarProducto.DataSource = Comercio.Productos;         
        }

        /// <summary>
        /// Agrega un nuevo producto a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearProducto_Click(object sender, EventArgs e)
        {

            try
            {
                tmrAgregarProducto.Stop();
                float precio;
                int stock;

                precio = float.Parse(this.txtPrecio.Text);
                stock = int.Parse(this.txtStock.Text);

                if (string.IsNullOrWhiteSpace(this.txtNombre.Text) == false && string.IsNullOrWhiteSpace(this.txtCodigo.Text) == false)
                {
                    MiProducto = new Producto(this.txtCodigo.Text, this.txtNombre.Text, precio, stock);

                    if (Comercio.Productos + MiProducto)
                    {
                        MessageBox.Show("Agregado con exito");
                    }

                    else
                    {
                        MessageBox.Show($"Se ha agregado Stock a Producto: {MiProducto.Nombre}");
                    }

                    this.DialogResult = DialogResult.OK;
                }

                else
                {
                    throw new Excepciones("faltan datos para cargar el nuevo producto");
                }
                    
            }
            catch (Excepciones ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void tmrAgregarProducto_Tick(object sender, EventArgs e)
        {
            conteo++;
            deslogueo();

        }

        private void deslogueo()
        {
            if (conteo == 400)
            {
                this.Close();
            }

        }

        /// <summary>
        /// cargo los textbox con datos de datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgAgregarProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             this.txtCodigo.Text = dtgAgregarProducto.CurrentRow.Cells[0].Value.ToString();
             this.txtCodigo.Enabled = false;
             this.txtNombre.Text = dtgAgregarProducto.CurrentRow.Cells[1].Value.ToString();
             this.txtNombre.Enabled = false;
             this.txtPrecio.Text = dtgAgregarProducto.CurrentRow.Cells[2].Value.ToString();
             this.txtPrecio.Enabled = false;
        }

        /// <summary>
        /// Elimino un producto de la lista de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            float precio;
            int stock;

            try
            {
                precio = float.Parse(this.txtPrecio.Text);
                stock = int.Parse(this.txtStock.Text = dtgAgregarProducto.CurrentRow.Cells[3].Value.ToString());

                if (string.IsNullOrWhiteSpace(this.txtNombre.Text) == false && string.IsNullOrWhiteSpace(this.txtCodigo.Text) == false)
                {
                    MiProducto = new Producto(this.txtCodigo.Text, this.txtNombre.Text, precio, stock);

                    this.txtStock.Text = "";

                    if (Comercio.Productos - MiProducto)
                    {
                        MessageBox.Show("Producto eliminado de inventario", "Alerta Inventario");
                        this.dtgAgregarProducto.DataSource = Comercio.Productos;
                        this.dtgAgregarProducto.DataSource = null;
                        this.dtgAgregarProducto.DataSource = Comercio.Productos;

                        this.DialogResult = DialogResult.OK;
                    }

                    else
                    {
                        MessageBox.Show("No existe producto seleccionado en este inventario", "Alerta Inventario");
                    }
                }

                else
                {
                    throw new Excepciones("faltan datos del producto a eliminar");
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
    }
}
