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
    }
}
