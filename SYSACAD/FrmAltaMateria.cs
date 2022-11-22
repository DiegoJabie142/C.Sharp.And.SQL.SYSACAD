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
    public partial class FrmAltaMateria : Form
    {
        public FrmAltaMateria()
        {
            InitializeComponent();

            List<string> list = MateriaDao.ListarNombreMaterias();

            foreach(var item in list)
            {
                cmbBoxCorrelativa.Items.Add(item.ToString());
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cuatrimestre cuatrimestre;
            
            if (rdBtnPrimerCuatrimestre.Checked == true)
            {
                cuatrimestre = Cuatrimestre.PrimerCuatrimestre;
            }
            else
            {
                cuatrimestre = Cuatrimestre.SegundoCuatrimestre;
            }

            if (cmbBoxCorrelativa.Text == "No tiene")
            {
                if(MateriaDao.CrearMateria(txtNombreMateria.Text, cuatrimestre, null))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ya existe una materia con el mismo nombre o los campos no fueron llenados apropiadamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if(MateriaDao.CrearMateria(txtNombreMateria.Text, cuatrimestre, cmbBoxCorrelativa.Text))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ya existe una materia con el mismo nombre o los campos no fueron llenados apropiadamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmbBoxCorrelativa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }
    }
}
