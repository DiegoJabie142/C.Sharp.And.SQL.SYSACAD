using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using EntidadesDao;

namespace SYSACAD
{
    public partial class FrmAdministrador : Form
    {

        private EstadoMateria estadoMateria;
        public FrmAdministrador(Administrador administrador)
        {
            InitializeComponent();
            this.Text = "Menú de administrador - " + administrador.Nombre;

            foreach(var materia in MateriaDao.ListarNombreMaterias())
            {
                lstBxMaterias.Items.Add(materia);
            }

            foreach(var alumno in UsuarioDao.ListarDniPorTipo(TipoUsuario.Alumno))
            {
                lstBxAlumnos.Items.Add(alumno);
            }

            btnSerializarMateriaJSON.Visible = false;
            btnSerializarMateriaXML.Visible = false;
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            Form frmAltaUsuario = new FrmAltaUsuario();
            DialogResult a = frmAltaUsuario.ShowDialog();
        }

        private void btnAltaMateria_Click(object sender, EventArgs e)
        {
            Form frmAltaMateria = new FrmAltaMateria();
            DialogResult a = frmAltaMateria.ShowDialog();
        }

        private void lstBxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstBxMaterias.SelectedItems.Count == 1)
            {
                lstBxProfesoresActuales.Items.Clear();
                lstBxProfesoresDisponibles.Items.Clear();
                btnEliminarProfesor.Visible = false;
                btnAgregar.Visible = false;
                btnSerializarMateriaJSON.Visible = true;
                btnSerializarMateriaXML.Visible = true;
                lblProfesorActualSeleccionado.Visible = false;
                lblProfesorDisponibleSeleccionado.Visible = false;

                foreach (var item in MateriaDao.ListarProfesoresDeUnaMateria(lstBxMaterias.Text))
                {
                    lstBxProfesoresActuales.Items.Add(item);
                }

                foreach (var item in MateriaDao.ListarProfesoresQueNoDanLaMateria(lstBxMaterias.Text))
                {
                    lstBxProfesoresDisponibles.Items.Add(item);
                }
               
            }
        }

        private void lstBxProfesoresActuales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxProfesoresActuales.SelectedItems.Count == 1)
            {
                btnEliminarProfesor.Visible = true;
                try
                {
                    lblProfesorActualSeleccionado.Text = "Profesor actual seleccionado: " + UsuarioDao.ListarNombrePorDni(int.Parse(lstBxProfesoresActuales.Text));
                    lblProfesorActualSeleccionado.Visible = true;
                }
                catch (Exception)
                {

                }

            }
            else
            {
                btnEliminarProfesor.Visible = false;
                lblProfesorActualSeleccionado.Visible = false;
            }
        }

        private void btnEliminarProfesor_Click(object sender, EventArgs e)
        {
            MateriaDao.EliminarProfesorDeUnaMateria(int.Parse(lstBxProfesoresActuales.Text), lstBxMaterias.Text);
            this.lstBxMaterias_SelectedIndexChanged(sender, e);
        }

        private void lstBxProfesoresDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxProfesoresDisponibles.SelectedItems.Count == 1)
            {
                btnAgregar.Visible = true;
                btnEliminarProfesor.Visible = true;
                try
                {
                    lblProfesorDisponibleSeleccionado.Text = "Profesor disponible seleccionado: " + UsuarioDao.ListarNombrePorDni(int.Parse(lstBxProfesoresDisponibles.Text));
                    lblProfesorDisponibleSeleccionado.Visible = true;
                }
                catch (Exception)
                {

                }
            }
            else
            {
                lblProfesorDisponibleSeleccionado.Visible = false;
                btnAgregar.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MateriaDao.AgregarProfesorAUnaMateria(int.Parse(lstBxProfesoresDisponibles.Text), lstBxMaterias.Text);
            this.lstBxMaterias_SelectedIndexChanged(sender, e);
        }

        private void lstBxAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBxMateriasDelAlumno.Items.Clear();
            if(lstBxAlumnos.SelectedItems.Count == 1)
            {
                try
                {
                    lblAlumnoSeleccionado.Text = "Alumno seleccionado: " + UsuarioDao.ListarNombrePorDni(int.Parse(lstBxAlumnos.Text));
                    lblAlumnoSeleccionado.Visible = true;
                }
                catch (Exception)
                {

                }

                foreach (var materia in MateriaDao.ListarMateriasActualesDeUnAlumno(int.Parse(lstBxAlumnos.Text)))
                {
                    lstBxMateriasDelAlumno.Items.Add(materia);
                }
            }
            else
            {
                lblAlumnoSeleccionado.Visible = false;
            }
            grpBxEstadoMateria.Visible = false;
        }

        private void lstBxMateriasDelAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxMateriasDelAlumno.SelectedItems.Count == 1)
            {
                grpBxEstadoMateria.Visible = true;
            }

            estadoMateria = MateriaDao.ObtenerEstadoMateriaDeUnAlumno(int.Parse(lstBxAlumnos.Text), lstBxMateriasDelAlumno.Text);

            if (estadoMateria == EstadoMateria.Regular)
            {
                rdBtnRegular.Checked = true;
            }
            else if(estadoMateria == EstadoMateria.Libre)
            {
                rdBtnLibre.Checked = true;
            }       
        }

        private void rdBtnRegular_CheckedChanged(object sender, EventArgs e)
        {
            if(rdBtnRegular.Checked == true)
            {
                MateriaDao.CambiarEstadoMateriaAlumno(int.Parse(lstBxAlumnos.Text), lstBxMateriasDelAlumno.Text, EstadoMateria.Regular);
                if (MateriaDao.VerificarSiAprobo(int.Parse(lstBxAlumnos.Text), lstBxMaterias.Text))
                {
                    MessageBox.Show("El alumno aprobó la materia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstBxMaterias_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void rdBtnLibre_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnLibre.Checked == true)
            {
                MateriaDao.CambiarEstadoMateriaAlumno(int.Parse(lstBxAlumnos.Text), lstBxMateriasDelAlumno.Text, EstadoMateria.Libre);
            }
        }

        private void btnInscribirAlumnoEnMateria_Click(object sender, EventArgs e)
        {
            Form frmAdministrarAlumno = new frmAdministrarAlumno(0,true);
            DialogResult a = frmAdministrarAlumno.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSerializarMateria_Click(object sender, EventArgs e)
        {
            //JSON
            try
            {
                List<Alumno> alumnos = UsuarioDao.ListarAlumnosPorMateria(lstBxMaterias.Text);

                if (JSON.SerializarJSON(alumnos,lstBxMaterias.Text))
                {
                    MessageBox.Show("Se ha serializado correctamente.","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {

            }        
        }

        private void btnSerializarMateriaSeleccionadaJSON_Click(object sender, EventArgs e)
        {
            try
            {
                List<Alumno> alumnos = UsuarioDao.ListarAlumnosPorMateria(lstBxMaterias.Text);
                if (XML.SerializarXml(alumnos, lstBxMaterias.Text))
                {
                    MessageBox.Show("Se ha serializado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {

            }
        }
    }
}
