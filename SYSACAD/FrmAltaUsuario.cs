using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesDao;

namespace SYSACAD
{
    public partial class FrmAltaUsuario : Form
    {
        public FrmAltaUsuario()
        {
            InitializeComponent();
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string contraseña = txtContraseña.Text;
            string confirmarContraseña = txtConfirmarContraseña.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int tipoUsuario = -1;

            if (rdBtnAdmin.Checked == true)
            {
                tipoUsuario = 0;
            }else if(rdBtnProfesor.Checked == true)
            {
                tipoUsuario = 1;
            }else if(rdBtnAlumno.Checked == true)
            {
                tipoUsuario = 2;
            }
            

            if (dni.Length >= 6 && dni.Length <= 12  && contraseña.Length >= 8 && contraseña.Length < 99 && contraseña.Equals(confirmarContraseña) && nombre.Length >= 4 && nombre.Length < 99 && apellido.Length >= 4 && apellido.Length < 99)
            {
                try
                {
                    if(UsuarioDao.CrearUsuario(int.Parse(dni), nombre, apellido, contraseña, tipoUsuario) == true)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Algún campo no cumple con los requisitos necesarios o ya existe un usuario con tal DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Algún campo no cumple con los requisitos necesarios.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Algún campo no cumple con los requisitos necesarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
