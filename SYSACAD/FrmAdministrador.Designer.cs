namespace SYSACAD
{
    partial class FrmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrador));
            this.btnAltaUsuario = new System.Windows.Forms.Button();
            this.btnAltaMateria = new System.Windows.Forms.Button();
            this.grpBxAsignacionProfesores = new System.Windows.Forms.GroupBox();
            this.lstBxProfesoresDisponibles = new System.Windows.Forms.ListBox();
            this.lstBxMaterias = new System.Windows.Forms.ListBox();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.lstBxProfesoresActuales = new System.Windows.Forms.ListBox();
            this.btnEliminarProfesor = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblProfesoresDisponibles = new System.Windows.Forms.Label();
            this.lblProfesoresActuales = new System.Windows.Forms.Label();
            this.grpBxAsignacionEstadoMateria = new System.Windows.Forms.GroupBox();
            this.grpBxEstadoMateria = new System.Windows.Forms.GroupBox();
            this.rdBtnLibre = new System.Windows.Forms.RadioButton();
            this.rdBtnRegular = new System.Windows.Forms.RadioButton();
            this.lstBxMateriasDelAlumno = new System.Windows.Forms.ListBox();
            this.lblMateriasDelAlumno = new System.Windows.Forms.Label();
            this.lstBxAlumnos = new System.Windows.Forms.ListBox();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.btnInscribirAlumnoEnMateria = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnSerializarMateriaXML = new System.Windows.Forms.Button();
            this.btnSerializarMateriaSeleccionadaJSON = new System.Windows.Forms.Button();
            this.grpBxAsignacionProfesores.SuspendLayout();
            this.grpBxAsignacionEstadoMateria.SuspendLayout();
            this.grpBxEstadoMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAltaUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAltaUsuario.Location = new System.Drawing.Point(12, 606);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(120, 45);
            this.btnAltaUsuario.TabIndex = 1;
            this.btnAltaUsuario.Text = "Alta Usuario";
            this.btnAltaUsuario.UseVisualStyleBackColor = false;
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // btnAltaMateria
            // 
            this.btnAltaMateria.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAltaMateria.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaMateria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAltaMateria.Location = new System.Drawing.Point(149, 606);
            this.btnAltaMateria.Name = "btnAltaMateria";
            this.btnAltaMateria.Size = new System.Drawing.Size(120, 45);
            this.btnAltaMateria.TabIndex = 3;
            this.btnAltaMateria.Text = "Alta Materia";
            this.btnAltaMateria.UseVisualStyleBackColor = false;
            this.btnAltaMateria.Click += new System.EventHandler(this.btnAltaMateria_Click);
            // 
            // grpBxAsignacionProfesores
            // 
            this.grpBxAsignacionProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.grpBxAsignacionProfesores.Controls.Add(this.lstBxProfesoresDisponibles);
            this.grpBxAsignacionProfesores.Controls.Add(this.lstBxMaterias);
            this.grpBxAsignacionProfesores.Controls.Add(this.lblMaterias);
            this.grpBxAsignacionProfesores.Controls.Add(this.lstBxProfesoresActuales);
            this.grpBxAsignacionProfesores.Controls.Add(this.btnEliminarProfesor);
            this.grpBxAsignacionProfesores.Controls.Add(this.btnAgregar);
            this.grpBxAsignacionProfesores.Controls.Add(this.lblProfesoresDisponibles);
            this.grpBxAsignacionProfesores.Controls.Add(this.lblProfesoresActuales);
            this.grpBxAsignacionProfesores.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBxAsignacionProfesores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBxAsignacionProfesores.Location = new System.Drawing.Point(463, 12);
            this.grpBxAsignacionProfesores.Name = "grpBxAsignacionProfesores";
            this.grpBxAsignacionProfesores.Size = new System.Drawing.Size(648, 311);
            this.grpBxAsignacionProfesores.TabIndex = 16;
            this.grpBxAsignacionProfesores.TabStop = false;
            this.grpBxAsignacionProfesores.Text = "Asignación de profesores";
            // 
            // lstBxProfesoresDisponibles
            // 
            this.lstBxProfesoresDisponibles.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBxProfesoresDisponibles.FormattingEnabled = true;
            this.lstBxProfesoresDisponibles.ItemHeight = 19;
            this.lstBxProfesoresDisponibles.Location = new System.Drawing.Point(438, 72);
            this.lstBxProfesoresDisponibles.Name = "lstBxProfesoresDisponibles";
            this.lstBxProfesoresDisponibles.Size = new System.Drawing.Size(186, 175);
            this.lstBxProfesoresDisponibles.TabIndex = 8;
            this.lstBxProfesoresDisponibles.SelectedIndexChanged += new System.EventHandler(this.lstBxProfesoresDisponibles_SelectedIndexChanged);
            // 
            // lstBxMaterias
            // 
            this.lstBxMaterias.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBxMaterias.FormattingEnabled = true;
            this.lstBxMaterias.ItemHeight = 19;
            this.lstBxMaterias.Location = new System.Drawing.Point(12, 72);
            this.lstBxMaterias.Name = "lstBxMaterias";
            this.lstBxMaterias.Size = new System.Drawing.Size(186, 175);
            this.lstBxMaterias.TabIndex = 5;
            this.lstBxMaterias.SelectedIndexChanged += new System.EventHandler(this.lstBxMaterias_SelectedIndexChanged);
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.BackColor = System.Drawing.Color.Transparent;
            this.lblMaterias.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaterias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaterias.Location = new System.Drawing.Point(12, 35);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(75, 25);
            this.lblMaterias.TabIndex = 6;
            this.lblMaterias.Text = "Materias";
            // 
            // lstBxProfesoresActuales
            // 
            this.lstBxProfesoresActuales.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBxProfesoresActuales.FormattingEnabled = true;
            this.lstBxProfesoresActuales.ItemHeight = 19;
            this.lstBxProfesoresActuales.Location = new System.Drawing.Point(223, 72);
            this.lstBxProfesoresActuales.Name = "lstBxProfesoresActuales";
            this.lstBxProfesoresActuales.Size = new System.Drawing.Size(186, 175);
            this.lstBxProfesoresActuales.TabIndex = 7;
            this.lstBxProfesoresActuales.SelectedIndexChanged += new System.EventHandler(this.lstBxProfesoresActuales_SelectedIndexChanged);
            // 
            // btnEliminarProfesor
            // 
            this.btnEliminarProfesor.BackColor = System.Drawing.Color.LightGray;
            this.btnEliminarProfesor.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarProfesor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarProfesor.Location = new System.Drawing.Point(270, 259);
            this.btnEliminarProfesor.Name = "btnEliminarProfesor";
            this.btnEliminarProfesor.Size = new System.Drawing.Size(75, 31);
            this.btnEliminarProfesor.TabIndex = 11;
            this.btnEliminarProfesor.Text = "Eliminar";
            this.btnEliminarProfesor.UseVisualStyleBackColor = false;
            this.btnEliminarProfesor.Visible = false;
            this.btnEliminarProfesor.Click += new System.EventHandler(this.btnEliminarProfesor_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAgregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(498, 259);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 31);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblProfesoresDisponibles
            // 
            this.lblProfesoresDisponibles.AutoSize = true;
            this.lblProfesoresDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.lblProfesoresDisponibles.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProfesoresDisponibles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProfesoresDisponibles.Location = new System.Drawing.Point(438, 35);
            this.lblProfesoresDisponibles.Name = "lblProfesoresDisponibles";
            this.lblProfesoresDisponibles.Size = new System.Drawing.Size(169, 25);
            this.lblProfesoresDisponibles.TabIndex = 10;
            this.lblProfesoresDisponibles.Text = "Profesores disponibles";
            // 
            // lblProfesoresActuales
            // 
            this.lblProfesoresActuales.AutoSize = true;
            this.lblProfesoresActuales.BackColor = System.Drawing.Color.Transparent;
            this.lblProfesoresActuales.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProfesoresActuales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProfesoresActuales.Location = new System.Drawing.Point(223, 35);
            this.lblProfesoresActuales.Name = "lblProfesoresActuales";
            this.lblProfesoresActuales.Size = new System.Drawing.Size(153, 25);
            this.lblProfesoresActuales.TabIndex = 9;
            this.lblProfesoresActuales.Text = "Profesores actuales";
            // 
            // grpBxAsignacionEstadoMateria
            // 
            this.grpBxAsignacionEstadoMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.grpBxAsignacionEstadoMateria.Controls.Add(this.grpBxEstadoMateria);
            this.grpBxAsignacionEstadoMateria.Controls.Add(this.lstBxMateriasDelAlumno);
            this.grpBxAsignacionEstadoMateria.Controls.Add(this.lblMateriasDelAlumno);
            this.grpBxAsignacionEstadoMateria.Controls.Add(this.lstBxAlumnos);
            this.grpBxAsignacionEstadoMateria.Controls.Add(this.lblAlumnos);
            this.grpBxAsignacionEstadoMateria.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBxAsignacionEstadoMateria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBxAsignacionEstadoMateria.Location = new System.Drawing.Point(463, 358);
            this.grpBxAsignacionEstadoMateria.Name = "grpBxAsignacionEstadoMateria";
            this.grpBxAsignacionEstadoMateria.Size = new System.Drawing.Size(648, 293);
            this.grpBxAsignacionEstadoMateria.TabIndex = 17;
            this.grpBxAsignacionEstadoMateria.TabStop = false;
            this.grpBxAsignacionEstadoMateria.Text = "Asignación de estado materia";
            // 
            // grpBxEstadoMateria
            // 
            this.grpBxEstadoMateria.BackColor = System.Drawing.Color.LightGray;
            this.grpBxEstadoMateria.Controls.Add(this.rdBtnLibre);
            this.grpBxEstadoMateria.Controls.Add(this.rdBtnRegular);
            this.grpBxEstadoMateria.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBxEstadoMateria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBxEstadoMateria.Location = new System.Drawing.Point(438, 77);
            this.grpBxEstadoMateria.Name = "grpBxEstadoMateria";
            this.grpBxEstadoMateria.Size = new System.Drawing.Size(186, 175);
            this.grpBxEstadoMateria.TabIndex = 17;
            this.grpBxEstadoMateria.TabStop = false;
            this.grpBxEstadoMateria.Text = "Estado materia";
            this.grpBxEstadoMateria.Visible = false;
            // 
            // rdBtnLibre
            // 
            this.rdBtnLibre.AutoSize = true;
            this.rdBtnLibre.Location = new System.Drawing.Point(6, 127);
            this.rdBtnLibre.Name = "rdBtnLibre";
            this.rdBtnLibre.Size = new System.Drawing.Size(60, 27);
            this.rdBtnLibre.TabIndex = 1;
            this.rdBtnLibre.TabStop = true;
            this.rdBtnLibre.Text = "Libre";
            this.rdBtnLibre.UseVisualStyleBackColor = true;
            this.rdBtnLibre.CheckedChanged += new System.EventHandler(this.rdBtnLibre_CheckedChanged);
            // 
            // rdBtnRegular
            // 
            this.rdBtnRegular.AutoSize = true;
            this.rdBtnRegular.Location = new System.Drawing.Point(6, 50);
            this.rdBtnRegular.Name = "rdBtnRegular";
            this.rdBtnRegular.Size = new System.Drawing.Size(78, 27);
            this.rdBtnRegular.TabIndex = 0;
            this.rdBtnRegular.TabStop = true;
            this.rdBtnRegular.Text = "Regular";
            this.rdBtnRegular.UseVisualStyleBackColor = true;
            this.rdBtnRegular.CheckedChanged += new System.EventHandler(this.rdBtnRegular_CheckedChanged);
            // 
            // lstBxMateriasDelAlumno
            // 
            this.lstBxMateriasDelAlumno.BackColor = System.Drawing.Color.White;
            this.lstBxMateriasDelAlumno.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBxMateriasDelAlumno.FormattingEnabled = true;
            this.lstBxMateriasDelAlumno.ItemHeight = 19;
            this.lstBxMateriasDelAlumno.Location = new System.Drawing.Point(223, 77);
            this.lstBxMateriasDelAlumno.Name = "lstBxMateriasDelAlumno";
            this.lstBxMateriasDelAlumno.Size = new System.Drawing.Size(186, 175);
            this.lstBxMateriasDelAlumno.TabIndex = 16;
            this.lstBxMateriasDelAlumno.SelectedIndexChanged += new System.EventHandler(this.lstBxMateriasDelAlumno_SelectedIndexChanged);
            // 
            // lblMateriasDelAlumno
            // 
            this.lblMateriasDelAlumno.AutoSize = true;
            this.lblMateriasDelAlumno.BackColor = System.Drawing.Color.Transparent;
            this.lblMateriasDelAlumno.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMateriasDelAlumno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMateriasDelAlumno.Location = new System.Drawing.Point(223, 36);
            this.lblMateriasDelAlumno.Name = "lblMateriasDelAlumno";
            this.lblMateriasDelAlumno.Size = new System.Drawing.Size(157, 25);
            this.lblMateriasDelAlumno.TabIndex = 15;
            this.lblMateriasDelAlumno.Text = "Materias del alumno";
            // 
            // lstBxAlumnos
            // 
            this.lstBxAlumnos.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBxAlumnos.FormattingEnabled = true;
            this.lstBxAlumnos.ItemHeight = 19;
            this.lstBxAlumnos.Location = new System.Drawing.Point(12, 77);
            this.lstBxAlumnos.Name = "lstBxAlumnos";
            this.lstBxAlumnos.Size = new System.Drawing.Size(186, 175);
            this.lstBxAlumnos.TabIndex = 14;
            this.lstBxAlumnos.SelectedIndexChanged += new System.EventHandler(this.lstBxAlumnos_SelectedIndexChanged);
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumnos.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlumnos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAlumnos.Location = new System.Drawing.Point(12, 36);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(73, 25);
            this.lblAlumnos.TabIndex = 13;
            this.lblAlumnos.Text = "Alumnos";
            // 
            // btnInscribirAlumnoEnMateria
            // 
            this.btnInscribirAlumnoEnMateria.BackColor = System.Drawing.Color.DarkOrange;
            this.btnInscribirAlumnoEnMateria.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInscribirAlumnoEnMateria.Location = new System.Drawing.Point(12, 510);
            this.btnInscribirAlumnoEnMateria.Name = "btnInscribirAlumnoEnMateria";
            this.btnInscribirAlumnoEnMateria.Size = new System.Drawing.Size(118, 63);
            this.btnInscribirAlumnoEnMateria.TabIndex = 18;
            this.btnInscribirAlumnoEnMateria.Text = "Inscribir Alumno En Materia";
            this.btnInscribirAlumnoEnMateria.UseVisualStyleBackColor = false;
            this.btnInscribirAlumnoEnMateria.Click += new System.EventHandler(this.btnInscribirAlumnoEnMateria_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.Location = new System.Drawing.Point(289, 610);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(139, 41);
            this.btnCerrarSesion.TabIndex = 20;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnSerializarMateriaXML
            // 
            this.btnSerializarMateriaXML.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSerializarMateriaXML.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSerializarMateriaXML.Location = new System.Drawing.Point(151, 510);
            this.btnSerializarMateriaXML.Name = "btnSerializarMateriaXML";
            this.btnSerializarMateriaXML.Size = new System.Drawing.Size(118, 63);
            this.btnSerializarMateriaXML.TabIndex = 21;
            this.btnSerializarMateriaXML.Text = "Serializar Materia Seleccionada XML";
            this.btnSerializarMateriaXML.UseVisualStyleBackColor = false;
            this.btnSerializarMateriaXML.Click += new System.EventHandler(this.btnSerializarMateria_Click);
            // 
            // btnSerializarMateriaSeleccionadaJSON
            // 
            this.btnSerializarMateriaSeleccionadaJSON.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSerializarMateriaSeleccionadaJSON.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSerializarMateriaSeleccionadaJSON.Location = new System.Drawing.Point(289, 510);
            this.btnSerializarMateriaSeleccionadaJSON.Name = "btnSerializarMateriaSeleccionadaJSON";
            this.btnSerializarMateriaSeleccionadaJSON.Size = new System.Drawing.Size(118, 63);
            this.btnSerializarMateriaSeleccionadaJSON.TabIndex = 22;
            this.btnSerializarMateriaSeleccionadaJSON.Text = "Serializar Materia Seleccionada JSON";
            this.btnSerializarMateriaSeleccionadaJSON.UseVisualStyleBackColor = false;
            this.btnSerializarMateriaSeleccionadaJSON.Click += new System.EventHandler(this.btnSerializarMateriaSeleccionadaJSON_Click);
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1130, 671);
            this.Controls.Add(this.btnSerializarMateriaSeleccionadaJSON);
            this.Controls.Add(this.btnSerializarMateriaXML);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnInscribirAlumnoEnMateria);
            this.Controls.Add(this.grpBxAsignacionEstadoMateria);
            this.Controls.Add(this.grpBxAsignacionProfesores);
            this.Controls.Add(this.btnAltaMateria);
            this.Controls.Add(this.btnAltaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdministrador";
            this.Text = "FrmAdministrador";
            this.grpBxAsignacionProfesores.ResumeLayout(false);
            this.grpBxAsignacionProfesores.PerformLayout();
            this.grpBxAsignacionEstadoMateria.ResumeLayout(false);
            this.grpBxAsignacionEstadoMateria.PerformLayout();
            this.grpBxEstadoMateria.ResumeLayout(false);
            this.grpBxEstadoMateria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaUsuario;
        private System.Windows.Forms.Button btnAltaMateria;
        private System.Windows.Forms.GroupBox grpBxAsignacionProfesores;
        private System.Windows.Forms.ListBox lstBxProfesoresDisponibles;
        private System.Windows.Forms.ListBox lstBxMaterias;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.ListBox lstBxProfesoresActuales;
        private System.Windows.Forms.Button btnEliminarProfesor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblProfesoresDisponibles;
        private System.Windows.Forms.Label lblProfesoresActuales;
        private System.Windows.Forms.GroupBox grpBxAsignacionEstadoMateria;
        private System.Windows.Forms.GroupBox grpBxEstadoMateria;
        private System.Windows.Forms.RadioButton rdBtnLibre;
        private System.Windows.Forms.RadioButton rdBtnRegular;
        private System.Windows.Forms.ListBox lstBxMateriasDelAlumno;
        private System.Windows.Forms.Label lblMateriasDelAlumno;
        private System.Windows.Forms.ListBox lstBxAlumnos;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Button btnInscribirAlumnoEnMateria;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnSerializarMateriaXML;
        private System.Windows.Forms.Button btnSerializarMateriaSeleccionadaJSON;
    }
}