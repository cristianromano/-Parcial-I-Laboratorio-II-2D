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
        public Empleado MiEmpleado1 { get => MiEmpleado; set => MiEmpleado = value; }

        public FormularioAgregarEmpleado()
        {
            InitializeComponent();

            this.lbNombre.Parent = pictureBox1;
            this.lbNombre.BackColor = Color.Transparent;

            this.lbApellido.Parent = pictureBox1;
            this.lbApellido.BackColor = Color.Transparent;

            this.lbTurno.Parent = pictureBox1;
            this.lbTurno.BackColor = Color.Transparent;
        }

        private void FormularioAgregarEmpleado_Load(object sender, EventArgs e)
        {
            this.cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MiEmpleado = new Empleado(this.txtNombre.Text, this.txtApellido.Text, (ETurno)this.cmbTurno.SelectedItem);

            MessageBox.Show(MiEmpleado.registro());

            this.DialogResult = DialogResult.OK;

        }
    }
}
