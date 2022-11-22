namespace SYSACAD
{
    partial class frmAdministrarAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrarAlumno));
            this.lblMateriasAprobadas = new System.Windows.Forms.Label();
            this.lstBxMateriasAprobadas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMateriasActuales = new System.Windows.Forms.Label();
            this.lstBxMateriasDeLaCarrera = new System.Windows.Forms.ListBox();
            this.lstBxMateriasActuales = new System.Windows.Forms.ListBox();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lstBxAlumnos = new System.Windows.Forms.ListBox();
            this.lblMateriaSeleccionada = new System.Windows.Forms.Label();
            this.lblMateriaAAsignar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblAlumnoSeleccionado = new System.Windows.Forms.Label();
            this.lblEstadoMateria = new System.Windows.Forms.Label();
            this.lblNotaSegundoParcial = new System.Windows.Forms.Label();
            this.lblNotaPrimerParcial = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnDarAsistencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMateriasAprobadas
            // 
            this.lblMateriasAprobadas.AutoSize = true;
            this.lblMateriasAprobadas.BackColor = System.Drawing.Color.Transparent;
            this.lblMateriasAprobadas.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMateriasAprobadas.Location = new System.Drawing.Point(441, 37);
            this.lblMateriasAprobadas.Name = "lblMateriasAprobadas";
            this.lblMateriasAprobadas.Size = new System.Drawing.Size(153, 25);
            this.lblMateriasAprobadas.TabIndex = 18;
            this.lblMateriasAprobadas.Text = "Materias Aprobadas";
            // 
            // lstBxMateriasAprobadas
            // 
            this.lstBxMateriasAprobadas.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBxMateriasAprobadas.FormattingEnabled = true;
            this.lstBxMateriasAprobadas.ItemHeight = 18;
            this.lstBxMateriasAprobadas.Location = new System.Drawing.Point(441, 74);
            this.lstBxMateriasAprobadas.Name = "lstBxMateriasAprobadas";
            this.lstBxMateriasAprobadas.Size = new System.Drawing.Size(204, 184);
            this.lstBxMateriasAprobadas.TabIndex = 17;
            this.lstBxMateriasAprobadas.SelectedIndexChanged += new System.EventHandler(this.lstBxMateriasAprobadas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(663, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Materias de la carrera";
            // 
            // lblMateriasActuales
            // 
            this.lblMateriasActuales.AutoSize = true;
            this.lblMateriasActuales.BackColor = System.Drawing.Color.Transparent;
            this.lblMateriasActuales.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMateriasActuales.Location = new System.Drawing.Point(216, 37);
            this.lblMateriasActuales.Name = "lblMateriasActuales";
            this.lblMateriasActuales.Size = new System.Drawing.Size(141, 25);
            this.lblMateriasActuales.TabIndex = 15;
            this.lblMateriasActuales.Text = "Materias Actuales";
            // 
            // lstBxMateriasDeLaCarrera
            // 
            this.lstBxMateriasDeLaCarrera.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBxMateriasDeLaCarrera.FormattingEnabled = true;
            this.lstBxMateriasDeLaCarrera.ItemHeight = 18;
            this.lstBxMateriasDeLaCarrera.Location = new System.Drawing.Point(663, 74);
            this.lstBxMateriasDeLaCarrera.Name = "lstBxMateriasDeLaCarrera";
            this.lstBxMateriasDeLaCarrera.Size = new System.Drawing.Size(195, 184);
            this.lstBxMateriasDeLaCarrera.TabIndex = 14;
            this.lstBxMateriasDeLaCarrera.SelectedIndexChanged += new System.EventHandler(this.lstBxMateriasDeLaCarrera_SelectedIndexChanged);
            // 
            // lstBxMateriasActuales
            // 
            this.lstBxMateriasActuales.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBxMateriasActuales.FormattingEnabled = true;
            this.lstBxMateriasActuales.ItemHeight = 18;
            this.lstBxMateriasActuales.Location = new System.Drawing.Point(216, 74);
            this.lstBxMateriasActuales.Name = "lstBxMateriasActuales";
            this.lstBxMateriasActuales.Size = new System.Drawing.Size(204, 94);
            this.lstBxMateriasActuales.TabIndex = 13;
            this.lstBxMateriasActuales.SelectedIndexChanged += new System.EventHandler(this.lstBxMateriasActuales_SelectedIndexChanged);
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumnos.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlumnos.Location = new System.Drawing.Point(12, 192);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(73, 25);
            this.lblAlumnos.TabIndex = 12;
            this.lblAlumnos.Text = "Alumnos";
            // 
            // lstBxAlumnos
            // 
            this.lstBxAlumnos.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBxAlumnos.FormattingEnabled = true;
            this.lstBxAlumnos.ItemHeight = 18;
            this.lstBxAlumnos.Location = new System.Drawing.Point(8, 235);
            this.lstBxAlumnos.Name = "lstBxAlumnos";
            this.lstBxAlumnos.Size = new System.Drawing.Size(176, 166);
            this.lstBxAlumnos.TabIndex = 11;
            this.lstBxAlumnos.SelectedIndexChanged += new System.EventHandler(this.lstBxAlumnos_SelectedIndexChanged);
            // 
            // lblMateriaSeleccionada
            // 
            this.lblMateriaSeleccionada.AutoSize = true;
            this.lblMateriaSeleccionada.BackColor = System.Drawing.Color.Transparent;
            this.lblMateriaSeleccionada.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMateriaSeleccionada.Location = new System.Drawing.Point(683, 376);
            this.lblMateriaSeleccionada.Name = "lblMateriaSeleccionada";
            this.lblMateriaSeleccionada.Size = new System.Drawing.Size(201, 25);
            this.lblMateriaSeleccionada.TabIndex = 21;
            this.lblMateriaSeleccionada.Text = "ACA APARECERÁ LA MATERIA";
            this.lblMateriaSeleccionada.Visible = false;
            // 
            // lblMateriaAAsignar
            // 
            this.lblMateriaAAsignar.AutoSize = true;
            this.lblMateriaAAsignar.BackColor = System.Drawing.Color.Transparent;
            this.lblMateriaAAsignar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMateriaAAsignar.Location = new System.Drawing.Point(534, 376);
            this.lblMateriaAAsignar.Name = "lblMateriaAAsignar";
            this.lblMateriaAAsignar.Size = new System.Drawing.Size(143, 25);
            this.lblMateriaAAsignar.TabIndex = 20;
            this.lblMateriaAAsignar.Text = "Materia a agregar:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAgregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(609, 431);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 39);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 431);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(139, 41);
            this.btnCerrarSesion.TabIndex = 22;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblAlumnoSeleccionado
            // 
            this.lblAlumnoSeleccionado.AutoSize = true;
            this.lblAlumnoSeleccionado.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumnoSeleccionado.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlumnoSeleccionado.Location = new System.Drawing.Point(216, 405);
            this.lblAlumnoSeleccionado.Name = "lblAlumnoSeleccionado";
            this.lblAlumnoSeleccionado.Size = new System.Drawing.Size(69, 25);
            this.lblAlumnoSeleccionado.TabIndex = 28;
            this.lblAlumnoSeleccionado.Text = "Alumno:";
            this.lblAlumnoSeleccionado.Visible = false;
            // 
            // lblEstadoMateria
            // 
            this.lblEstadoMateria.AutoSize = true;
            this.lblEstadoMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoMateria.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoMateria.Location = new System.Drawing.Point(216, 364);
            this.lblEstadoMateria.Name = "lblEstadoMateria";
            this.lblEstadoMateria.Size = new System.Drawing.Size(123, 25);
            this.lblEstadoMateria.TabIndex = 29;
            this.lblEstadoMateria.Text = "Estado materia:";
            this.lblEstadoMateria.Visible = false;
            // 
            // lblNotaSegundoParcial
            // 
            this.lblNotaSegundoParcial.AutoSize = true;
            this.lblNotaSegundoParcial.BackColor = System.Drawing.Color.Transparent;
            this.lblNotaSegundoParcial.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotaSegundoParcial.Location = new System.Drawing.Point(216, 319);
            this.lblNotaSegundoParcial.Name = "lblNotaSegundoParcial";
            this.lblNotaSegundoParcial.Size = new System.Drawing.Size(164, 25);
            this.lblNotaSegundoParcial.TabIndex = 30;
            this.lblNotaSegundoParcial.Text = "Nota segundo parcial:";
            this.lblNotaSegundoParcial.Visible = false;
            // 
            // lblNotaPrimerParcial
            // 
            this.lblNotaPrimerParcial.AutoSize = true;
            this.lblNotaPrimerParcial.BackColor = System.Drawing.Color.Transparent;
            this.lblNotaPrimerParcial.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotaPrimerParcial.Location = new System.Drawing.Point(216, 285);
            this.lblNotaPrimerParcial.Name = "lblNotaPrimerParcial";
            this.lblNotaPrimerParcial.Size = new System.Drawing.Size(153, 25);
            this.lblNotaPrimerParcial.TabIndex = 31;
            this.lblNotaPrimerParcial.Text = "Nota primer parcial:";
            this.lblNotaPrimerParcial.Visible = false;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblMateria.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMateria.Location = new System.Drawing.Point(216, 249);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(71, 25);
            this.lblMateria.TabIndex = 32;
            this.lblMateria.Text = "Materia:";
            this.lblMateria.Visible = false;
            // 
            // btnDarAsistencia
            // 
            this.btnDarAsistencia.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDarAsistencia.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDarAsistencia.Location = new System.Drawing.Point(216, 449);
            this.btnDarAsistencia.Name = "btnDarAsistencia";
            this.btnDarAsistencia.Size = new System.Drawing.Size(204, 39);
            this.btnDarAsistencia.TabIndex = 33;
            this.btnDarAsistencia.Text = "Asistencia: ";
            this.btnDarAsistencia.UseVisualStyleBackColor = false;
            this.btnDarAsistencia.Visible = false;
            this.btnDarAsistencia.Click += new System.EventHandler(this.btnDarAsistencia_Click);
            // 
            // frmAdministrarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(883, 500);
            this.Controls.Add(this.btnDarAsistencia);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblNotaPrimerParcial);
            this.Controls.Add(this.lblNotaSegundoParcial);
            this.Controls.Add(this.lblEstadoMateria);
            this.Controls.Add(this.lblAlumnoSeleccionado);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblMateriaSeleccionada);
            this.Controls.Add(this.lblMateriaAAsignar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblMateriasAprobadas);
            this.Controls.Add(this.lstBxMateriasAprobadas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMateriasActuales);
            this.Controls.Add(this.lstBxMateriasDeLaCarrera);
            this.Controls.Add(this.lstBxMateriasActuales);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.lstBxAlumnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdministrarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menú - Administrar alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMateriasAprobadas;
        private System.Windows.Forms.ListBox lstBxMateriasAprobadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMateriasActuales;
        private System.Windows.Forms.ListBox lstBxMateriasDeLaCarrera;
        private System.Windows.Forms.ListBox lstBxMateriasActuales;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.ListBox lstBxAlumnos;
        private System.Windows.Forms.Label lblMateriaSeleccionada;
        private System.Windows.Forms.Label lblMateriaAAsignar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblAlumnoSeleccionado;
        private System.Windows.Forms.Label lblEstadoMateria;
        private System.Windows.Forms.Label lblNotaSegundoParcial;
        private System.Windows.Forms.Label lblNotaPrimerParcial;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Button btnDarAsistencia;
    }
}