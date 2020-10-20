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
            this.comboBox1.DataSource = Enum.GetValues(typeof(ETurno));

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

        /// <summary>
        /// al ser seleccionado agrega un nuevo empleado a la lista
        /// en caso de tener espacios sin datos arroja mi excepcion
        /// en caso de tener un error de formato arroja excepcion heredada de libreria Exception
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtNombre.Text) == false && string.IsNullOrWhiteSpace(this.txtApellido.Text) == false && string.IsNullOrWhiteSpace(this.txtDNI.Text) == false)
                {
                    MiEmpleado = new Empleado(this.txtNombre.Text, this.txtApellido.Text, (ETurno)this.comboBox1.SelectedItem, double.Parse(this.txtDNI.Text));

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
                
                else
                {
                    throw new Excepciones("no se pudo realizar ingreso de empleado , faltan datos");
                }

                
            }


            catch (Excepciones miExcepcion)
            {
                MessageBox.Show(miExcepcion.Message);
            }

            catch(FormatException miExcepcion)
            {
                MessageBox.Show(miExcepcion.Message);
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
            this.comboBox1.Text = dtgEliminarAgregar.CurrentRow.Cells[1].Value.ToString();
            this.comboBox1.Enabled = false;
        }

        /// <summary>
        /// al ser seleccionado elimina un empleado de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbRemover_Click(object sender, EventArgs e)
        {
            MiEmpleado = new Empleado(this.txtNombre.Text, this.txtApellido.Text, (ETurno)this.comboBox1.SelectedItem, double.Parse(this.txtDNI.Text));

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
