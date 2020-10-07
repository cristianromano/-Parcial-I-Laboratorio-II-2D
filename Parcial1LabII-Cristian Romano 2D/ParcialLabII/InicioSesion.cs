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



namespace ParcialLabII
{
    public partial class InicioSesion : Form
    {
        int intentos = 3;
        
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            string user, pass;

            user = this.txtUsuario.Text;
            pass = this.txtPassword.Text;

            if (user == "Administrador" && pass == "sistema01")
            {
                PaginaPrincipal accesoPaginaPrincipal = new PaginaPrincipal();

                accesoPaginaPrincipal.Show();

                this.Hide();
            }

            else if (intentos == 0)
            {
                MessageBox.Show("se te acabaron los intentos.");
                Application.Exit();
            }

            else //(user != "Administador" || pass != "sistema01")
            {
                user = "";
                pass = "";
                MessageBox.Show("Password incorrecta");
                intentos--;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string user, pass;

                user = this.txtUsuario.Text;
                pass = this.txtPassword.Text;

                if (user == "Administrador" && pass == "sistema01")
                {
                    PaginaPrincipal accesoPaginaPrincipal = new PaginaPrincipal();

                    accesoPaginaPrincipal.Show();

                    this.Hide();
                }

                else if (intentos == 0)
                {
                    MessageBox.Show("se te acabaron los intentos.", "MENSAJE");
                    Console.ReadKey();
                    Application.Exit();
                }

                else // (user != "Administador" || pass != "sistema01")
                {
                    user = "";
                    pass = "";
                    MessageBox.Show("Password incorrecta");
                    intentos--;
                }
            }


        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            this.lbUsuario.Parent = pictureBox1;
            this.lbUsuario.BackColor = Color.Transparent; 

            this.lbPassword.Parent = pictureBox1;
            this.lbPassword.BackColor = Color.Transparent;
        }

        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
