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
using Entidades;
using System.Net;

namespace SYSACAD
{
    public partial class frmAdministrarAlumno : Form
    {
        private delegate bool Serializador(List<Alumno> lista, string materia);
        private bool soyAdministrador;
        int dniAlumno;
        public frmAdministrarAlumno(int dni, bool administrador)
        {
            InitializeComponent();

            soyAdministrador = administrador;
            dniAlumno = dni;

            if(soyAdministrador)
            {
                foreach (var alumno in UsuarioDao.ListarDniPorTipo(TipoUsuario.Alumno))
                {
                    lstBxAlumnos.Items.Add(alumno);
                }

                btnCerrarSesion.Visible = false;
            }
            else
            {
                lstBxAlumnos.Visible = false;
                lblAlumnos.Visible = false;

                foreach(var materia in MateriaDao.ListarMateriasActualesDeUnAlumno(dniAlumno))
                {
                    lstBxMateriasActuales.Items.Add(materia);
                }

                foreach (var materia in MateriaDao.ListarMateriasAprobadasDeUnAlumno(dniAlumno))
                {
                    lstBxMateriasAprobadas.Items.Add(materia);
                }

                try
                {
                    lblAlumnoSeleccionado.Text = "Alumno: " + UsuarioDao.ListarNombrePorDni(dniAlumno);
                    lblAlumnoSeleccionado.Visible = true;
                }
                catch (Exception)
                {

                }
            }

            foreach(var materia in MateriaDao.ListarNombreMaterias())
            {
                lstBxMateriasDeLaCarrera.Items.Add(materia);
            }
        }

        private void lstBxAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstBxAlumnos.SelectedItems.Count == 1)
            {
                lstBxMateriasActuales.Items.Clear();
                lstBxMateriasAprobadas.Items.Clear();

                dniAlumno = int.Parse(lstBxAlumnos.Text);

                foreach(var materia in MateriaDao.ListarMateriasActualesDeUnAlumno(dniAlumno)){
                    lstBxMateriasActuales.Items.Add(materia);
                }

                foreach (var materia in MateriaDao.ListarMateriasAprobadasDeUnAlumno(dniAlumno))
                {
                    lstBxMateriasAprobadas.Items.Add(materia);
                }

                try
                {
                    lblAlumnoSeleccionado.Text = "Alumno seleccionado: " + UsuarioDao.ListarNombrePorDni(dniAlumno);
                    lblAlumnoSeleccionado.Visible = true;
                }
                catch (Exception)
                {

                }
            }
        }

        private void lstBxMateriasDeLaCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((soyAdministrador = true && lstBxAlumnos.SelectedItems.Count == 1) || soyAdministrador == false) && lstBxMateriasDeLaCarrera.SelectedItems.Count == 1)
            {
                btnAgregar.Visible = true;
                lblMateriaAAsignar.Text = "Materia a agregar: " + lstBxMateriasDeLaCarrera.Text;
                lblMateriaAAsignar.Visible = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if(lstBxMateriasActuales.Items.Count < 2)
            {
                try
                {
                    if (!MateriaDao.AgregarAlumnoAUnaMateria(dniAlumno, lstBxMateriasDeLaCarrera.Text))
                    {
                        MessageBox.Show("No reunes los requisitos para anotarse en dicha materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (soyAdministrador)
                    {
                        this.lstBxAlumnos_SelectedIndexChanged(sender, e);
                    }
                    else
                    {
                        lstBxMateriasActuales.Items.Clear();
                        foreach (var materia in MateriaDao.ListarMateriasActualesDeUnAlumno(dniAlumno))
                        {
                            lstBxMateriasActuales.Items.Add(materia);
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show("Ya estás inscripto actualmente en dos materias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void lstBxMateriasActuales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBxMateriasAprobadas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
