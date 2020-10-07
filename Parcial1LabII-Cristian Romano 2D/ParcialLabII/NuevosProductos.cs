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

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {

            tmrAgregarProducto.Stop();
            float precio;
            int stock;


            precio = float.Parse(this.txtPrecio.Text);
            stock = int.Parse(this.txtStock.Text);

            MiProducto = new Producto(this.txtCodigo.Text, this.txtNombre.Text, precio, stock);

            this.DialogResult = DialogResult.OK;
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

        private void dtgAgregarProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             this.txtCodigo.Text = dtgAgregarProducto.CurrentRow.Cells[0].Value.ToString();
             this.txtCodigo.Enabled = false;
             this.txtNombre.Text = dtgAgregarProducto.CurrentRow.Cells[1].Value.ToString();
             this.txtNombre.Enabled = false;
             this.txtPrecio.Text = dtgAgregarProducto.CurrentRow.Cells[2].Value.ToString();
             this.txtPrecio.Enabled = false;
        }
    }
}
