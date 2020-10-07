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
    public partial class FormularioAgregarEmpleado : Form
    {

        private Empleado MiEmpleado;
        public FormularioAgregarEmpleado()
        {
            InitializeComponent();          
        }

        private void FormularioAgregarEmpleado_Load(object sender, EventArgs e)
        {
            this.cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));

            this.dtgEliminarAgregar.DataSource = Comercio.Empleados;
            this.dtgEliminarAgregar.DataSource = null;
            this.dtgEliminarAgregar.DataSource = Comercio.Empleados;

            this.lbNombre.Parent = pictureBox1;
            this.lbNombre.BackColor = Color.Transparent;

            this.lbApellido.Parent = pictureBox1;
            this.lbApellido.BackColor = Color.Transparent;

            this.lbTurno.Parent = pictureBox1;
            this.lbTurno.BackColor = Color.Transparent;

            this.lbDNI.Parent = pictureBox1;
            this.lbDNI.BackColor = Color.Transparent;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MiEmpleado = new Empleado(this.txtNombre.Text, this.txtApellido.Text, (ETurno)this.cmbTurno.SelectedItem, double.Parse(this.txtDNI.Text));

            if (Comercio.Empleados + MiEmpleado)
            {
                MessageBox.Show(MiEmpleado.registro());
                this.DialogResult = DialogResult.OK;
            }

            else
            {
                MessageBox.Show("El DNI ingresado ya pertenece a un Empleado", "Warning");
            }          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {       
            this.txtNombre.Text = dtgEliminarAgregar.CurrentRow.Cells[3].Value.ToString();
            this.txtNombre.Enabled = false;
            this.txtApellido.Text = dtgEliminarAgregar.CurrentRow.Cells[4].Value.ToString();
            this.txtApellido.Enabled = false;
            this.txtDNI.Text = dtgEliminarAgregar.CurrentRow.Cells[2].Value.ToString();
            this.txtDNI.Enabled = false;
            this.cmbTurno.Text = dtgEliminarAgregar.CurrentRow.Cells[1].Value.ToString();
            this.cmbTurno.Enabled = false;
        }

        private void lbRemover_Click(object sender, EventArgs e)
        {
            MiEmpleado = new Empleado(this.txtNombre.Text, this.txtApellido.Text, (ETurno)this.cmbTurno.SelectedItem, double.Parse(this.txtDNI.Text));
         
               if (Comercio.Empleados - MiEmpleado)
               {
                   MessageBox.Show("Empleado eliminado del sistema", "Mensaje");
                   this.dtgEliminarAgregar.DataSource = Comercio.Empleados;
                   this.dtgEliminarAgregar.DataSource = null;
                   this.dtgEliminarAgregar.DataSource = Comercio.Empleados;
               }

            else
            {
                MessageBox.Show("Empleado no existe en el sistema", "Mensaje");
            }
        }
    }
}
