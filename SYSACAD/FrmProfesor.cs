using System;
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
    public partial class FrmProfesor : Form
    {
        private int dni;
        public FrmProfesor(Profesor profesor)
        {
            InitializeComponent();

            dni = profesor.DNI;

            foreach(var materia in MateriaDao.ListarMateriasActualesDeUnProfesor(profesor.DNI))
            {
                lstBxMaterias.Items.Add(materia);
            }

            grpBxCrearExamen.Visible = false;
            cmBxInstancias.Items.Add("Primer parcial");
            cmBxInstancias.Items.Add("Segundo parcial");
            btnCrearExamen.Visible = false;
            txBxNota.Visible = false;
            lblNota.Visible = false;
        }

        private void cmBxInstancias_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void lstBxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            txBxNota.Visible = false;
            lblNota.Visible = false;
            lblAlumnoSeleccionado.Visible = false;

            if (lstBxMaterias.SelectedItems.Count == 1)
            {
                lstBxAlumnos.Items.Clear();
                
                foreach(var item in MateriaDao.ListarAlumnosDeUnaMateria(lstBxMaterias.Text))
                {
                    lstBxAlumnos.Items.Add(item);
                }
                grpBxCrearExamen.Text = "Creación de examén para la materia " + lstBxMaterias.Text;
                grpBxCrearExamen.Visible = true;
            }
            else
            {
                grpBxCrearExamen.Visible = false;
            }
        }

        private void cmBxInstancias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmBxInstancias.Text == "Primer parcial" || cmBxInstancias.Text == "Segundo parcial")
            {
                btnCrearExamen.Visible = true;
            }
            else
            {
                btnCrearExamen.Visible = false;
            }
        }

        private void btnCrearExamen_Click(object sender, EventArgs e)
        {
            if(cmBxInstancias.Text == "Primer parcial")
            {
                MateriaDao.CrearInstanciaDeExamen(dni, lstBxMaterias.Text, 1);
            }
            else if(cmBxInstancias.Text == "Segundo parcial")
            {
                MateriaDao.CrearInstanciaDeExamen(dni, lstBxMaterias.Text, 2);
            }

            lstBxAlumnos_SelectedIndexChanged(sender, e);
        }

        private void lstBxAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txBxNota.Visible = false;
            lblNota.Visible = false;
            lstBxExamenes.Items.Clear();
            foreach(var materia in MateriaDao.ListarInstanciasDeUnProfesor(dni, lstBxMaterias.Text))
            {
                lstBxExamenes.Items.Add(materia);
            }

            try
            {
                lblAlumnoSeleccionado.Text = "Alumno seleccionado: " + UsuarioDao.ListarNombrePorDni(int.Parse(lstBxAlumnos.Text));
                lblAlumnoSeleccionado.Visible = true;
            }
            catch (Exception)
            {

            }
        }

        private void lstBxExamenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstBxAlumnos.Text != "")
                {
                    txBxNota.Visible = true;
                    lblNota.Visible = true;

                    int nota = MateriaDao.NotaDeUnAlumno(int.Parse(lstBxAlumnos.Text), lstBxMaterias.Text, lstBxExamenes.Text);

                    if (nota != -1)
                    {
                        txBxNota.Text = nota.ToString();
                    }
                    else
                    {
                        txBxNota.Text = "";
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void txBxNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void btnPonerNota_Click(object sender, EventArgs e)
        {
            if(txBxNota.Text != "")
            {
                int nota = int.Parse(txBxNota.Text);
 
                try
                {
                    if (nota <= 10 || nota >= 0)
                    {
                        MateriaDao.PonerNotaAlumno(int.Parse(lstBxAlumnos.Text), lstBxMaterias.Text, lstBxExamenes.Text, int.Parse(txBxNota.Text));
                        
                        if(MateriaDao.VerificarSiAprobo(int.Parse(lstBxAlumnos.Text), lstBxMaterias.Text))
                        {
                            MessageBox.Show("El alumno aprobó la materia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lstBxMaterias_SelectedIndexChanged(sender, e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La nota que quiere poner es invalida, la nota debe ser entre 0 y 10","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {

        }

        private void grpBxCrearExamen_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
