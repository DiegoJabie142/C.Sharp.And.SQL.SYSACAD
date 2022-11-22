using System;
using System.Windows.Forms;
using Entidades;
using EntidadesDao;

namespace SYSACAD
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Usuario usuario = null;

            bool seHaNotificado = false;

            try
            {
                usuario = UsuarioDao.Login(int.Parse(txtDNI.Text), txtContraseña.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Debe ingresar su DNI correctamente.");
                seHaNotificado = true;
            }

            if (usuario is Administrador)
            {
                Form frmAdmin = new FrmAdministrador((Administrador)usuario);
                frmAdmin.ShowDialog();
            }
            else if(usuario is Profesor)
            {
                Form frmProfesor = new FrmProfesor((Profesor)usuario);
                frmProfesor.ShowDialog();
            }
            else if(usuario is Alumno)
            {
                Form frmAlumno = new frmAdministrarAlumno(int.Parse(txtDNI.Text), false);
                frmAlumno.ShowDialog();
            }
            else if(seHaNotificado == false)
            {
                MessageBox.Show("DNI O CONTRASEÑA INCORRECTO/S");
            }
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "42598320";
            txtContraseña.Text = "12345678";

        }

        private void btnProfesorPrLb_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "42555555";
            txtContraseña.Text = "12345678";
        }

        private void btnAlumnoPrgLb_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "42598322";
            txtContraseña.Text = "12345678";
        }
    }
}
