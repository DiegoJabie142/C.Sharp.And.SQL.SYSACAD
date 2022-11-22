namespace SYSACAD
{
    partial class FrmProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesor));
            this.grpBxPonerNota = new System.Windows.Forms.GroupBox();
            this.lstBxMaterias = new System.Windows.Forms.ListBox();
            this.txBxNota = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnPonerNota = new System.Windows.Forms.Button();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lstBxExamenes = new System.Windows.Forms.ListBox();
            this.lblExamenes = new System.Windows.Forms.Label();
            this.lstBxAlumnos = new System.Windows.Forms.ListBox();
            this.grpBxCrearExamen = new System.Windows.Forms.GroupBox();
            this.lblInstancia = new System.Windows.Forms.Label();
            this.cmBxInstancias = new System.Windows.Forms.ComboBox();
            this.btnCrearExamen = new System.Windows.Forms.Button();
            this.lblFechaExamen = new System.Windows.Forms.Label();
            this.dateTimePickerExamen = new System.Windows.Forms.DateTimePicker();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblAlumnoSeleccionado = new System.Windows.Forms.Label();
            this.grpBxPonerNota.SuspendLayout();
            this.grpBxCrearExamen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxPonerNota
            // 
            this.grpBxPonerNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.grpBxPonerNota.Controls.Add(this.lstBxMaterias);
            this.grpBxPonerNota.Controls.Add(this.txBxNota);
            this.grpBxPonerNota.Controls.Add(this.lblNota);
            this.grpBxPonerNota.Controls.Add(this.btnPonerNota);
            this.grpBxPonerNota.Controls.Add(this.lblMaterias);
            this.grpBxPonerNota.Controls.Add(this.lblAlumnos);
            this.grpBxPonerNota.Controls.Add(this.lstBxExamenes);
            this.grpBxPonerNota.Controls.Add(this.lblExamenes);
            this.grpBxPonerNota.Controls.Add(this.lstBxAlumnos);
            this.grpBxPonerNota.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBxPonerNota.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBxPonerNota.Location = new System.Drawing.Point(226, 12);
            this.grpBxPonerNota.Name = "grpBxPonerNota";
            this.grpBxPonerNota.Size = new System.Drawing.Size(655, 289);
            this.grpBxPonerNota.TabIndex = 18;
            this.grpBxPonerNota.TabStop = false;
            this.grpBxPonerNota.Text = "Poner nota de examén";
            // 
            // lstBxMaterias
            // 
            this.lstBxMaterias.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBxMaterias.FormattingEnabled = true;
            this.lstBxMaterias.ItemHeight = 19;
            this.lstBxMaterias.Location = new System.Drawing.Point(29, 79);
            this.lstBxMaterias.Name = "lstBxMaterias";
            this.lstBxMaterias.Size = new System.Drawing.Size(193, 175);
            this.lstBxMaterias.TabIndex = 1;
            this.lstBxMaterias.SelectedIndexChanged += new System.EventHandler(this.lstBxMaterias_SelectedIndexChanged);
            // 
            // txBxNota
            // 
            this.txBxNota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBxNota.Location = new System.Drawing.Point(465, 162);
            this.txBxNota.Name = "txBxNota";
            this.txBxNota.PlaceholderText = "Escriba la nota...";
            this.txBxNota.Size = new System.Drawing.Size(159, 29);
            this.txBxNota.TabIndex = 15;
            this.txBxNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBxNota_KeyPress);
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.BackColor = System.Drawing.Color.Transparent;
            this.lblNota.ForeColor = System.Drawing.Color.Black;
            this.lblNota.Location = new System.Drawing.Point(465, 134);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(44, 25);
            this.lblNota.TabIndex = 12;
            this.lblNota.Text = "Nota";
            // 
            // btnPonerNota
            // 
            this.btnPonerNota.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPonerNota.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPonerNota.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPonerNota.Location = new System.Drawing.Point(465, 217);
            this.btnPonerNota.Name = "btnPonerNota";
            this.btnPonerNota.Size = new System.Drawing.Size(159, 37);
            this.btnPonerNota.TabIndex = 16;
            this.btnPonerNota.Text = "Poner nota";
            this.btnPonerNota.UseVisualStyleBackColor = false;
            this.btnPonerNota.Click += new System.EventHandler(this.btnPonerNota_Click);
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.BackColor = System.Drawing.Color.Transparent;
            this.lblMaterias.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaterias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaterias.Location = new System.Drawing.Point(29, 39);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(75, 25);
            this.lblMaterias.TabIndex = 0;
            this.lblMaterias.Text = "Materias";
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumnos.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlumnos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAlumnos.Location = new System.Drawing.Point(246, 39);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(73, 25);
            this.lblAlumnos.TabIndex = 2;
            this.lblAlumnos.Text = "Alumnos";
            // 
            // lstBxExamenes
            // 
            this.lstBxExamenes.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBxExamenes.FormattingEnabled = true;
            this.lstBxExamenes.ItemHeight = 19;
            this.lstBxExamenes.Location = new System.Drawing.Point(465, 79);
            this.lstBxExamenes.Name = "lstBxExamenes";
            this.lstBxExamenes.Size = new System.Drawing.Size(159, 42);
            this.lstBxExamenes.TabIndex = 14;
            this.lstBxExamenes.SelectedIndexChanged += new System.EventHandler(this.lstBxExamenes_SelectedIndexChanged);
            // 
            // lblExamenes
            // 
            this.lblExamenes.AutoSize = true;
            this.lblExamenes.BackColor = System.Drawing.Color.Transparent;
            this.lblExamenes.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExamenes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExamenes.Location = new System.Drawing.Point(465, 39);
            this.lblExamenes.Name = "lblExamenes";
            this.lblExamenes.Size = new System.Drawing.Size(83, 25);
            this.lblExamenes.TabIndex = 10;
            this.lblExamenes.Text = "Examenes";
            // 
            // lstBxAlumnos
            // 
            this.lstBxAlumnos.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBxAlumnos.FormattingEnabled = true;
            this.lstBxAlumnos.ItemHeight = 19;
            this.lstBxAlumnos.Location = new System.Drawing.Point(246, 79);
            this.lstBxAlumnos.Name = "lstBxAlumnos";
            this.lstBxAlumnos.Size = new System.Drawing.Size(189, 175);
            this.lstBxAlumnos.TabIndex = 3;
            this.lstBxAlumnos.SelectedIndexChanged += new System.EventHandler(this.lstBxAlumnos_SelectedIndexChanged);
            // 
            // grpBxCrearExamen
            // 
            this.grpBxCrearExamen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.grpBxCrearExamen.Controls.Add(this.lblInstancia);
            this.grpBxCrearExamen.Controls.Add(this.cmBxInstancias);
            this.grpBxCrearExamen.Controls.Add(this.btnCrearExamen);
            this.grpBxCrearExamen.Controls.Add(this.lblFechaExamen);
            this.grpBxCrearExamen.Controls.Add(this.dateTimePickerExamen);
            this.grpBxCrearExamen.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBxCrearExamen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBxCrearExamen.Location = new System.Drawing.Point(226, 369);
            this.grpBxCrearExamen.Name = "grpBxCrearExamen";
            this.grpBxCrearExamen.Size = new System.Drawing.Size(655, 125);
            this.grpBxCrearExamen.TabIndex = 19;
            this.grpBxCrearExamen.TabStop = false;
            this.grpBxCrearExamen.Text = "Creación de exámen";
            this.grpBxCrearExamen.Enter += new System.EventHandler(this.grpBxCrearExamen_Enter);
            // 
            // lblInstancia
            // 
            this.lblInstancia.AutoSize = true;
            this.lblInstancia.BackColor = System.Drawing.Color.Transparent;
            this.lblInstancia.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInstancia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInstancia.Location = new System.Drawing.Point(298, 33);
            this.lblInstancia.Name = "lblInstancia";
            this.lblInstancia.Size = new System.Drawing.Size(203, 23);
            this.lblInstancia.TabIndex = 10;
            this.lblInstancia.Text = "Seleccione la instacia a crear: ";
            // 
            // cmBxInstancias
            // 
            this.cmBxInstancias.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmBxInstancias.FormattingEnabled = true;
            this.cmBxInstancias.Location = new System.Drawing.Point(298, 67);
            this.cmBxInstancias.Name = "cmBxInstancias";
            this.cmBxInstancias.Size = new System.Drawing.Size(229, 27);
            this.cmBxInstancias.TabIndex = 9;
            this.cmBxInstancias.SelectedIndexChanged += new System.EventHandler(this.cmBxInstancias_SelectedIndexChanged);
            this.cmBxInstancias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmBxInstancias_KeyPress);
            // 
            // btnCrearExamen
            // 
            this.btnCrearExamen.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCrearExamen.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearExamen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCrearExamen.Location = new System.Drawing.Point(547, 54);
            this.btnCrearExamen.Name = "btnCrearExamen";
            this.btnCrearExamen.Size = new System.Drawing.Size(87, 40);
            this.btnCrearExamen.TabIndex = 8;
            this.btnCrearExamen.Text = "Crear";
            this.btnCrearExamen.UseVisualStyleBackColor = false;
            this.btnCrearExamen.Click += new System.EventHandler(this.btnCrearExamen_Click);
            // 
            // lblFechaExamen
            // 
            this.lblFechaExamen.AutoSize = true;
            this.lblFechaExamen.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaExamen.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaExamen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechaExamen.Location = new System.Drawing.Point(29, 33);
            this.lblFechaExamen.Name = "lblFechaExamen";
            this.lblFechaExamen.Size = new System.Drawing.Size(206, 23);
            this.lblFechaExamen.TabIndex = 6;
            this.lblFechaExamen.Text = "Seleccione la fecha de exámen:";
            // 
            // dateTimePickerExamen
            // 
            this.dateTimePickerExamen.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerExamen.Location = new System.Drawing.Point(29, 67);
            this.dateTimePickerExamen.Name = "dateTimePickerExamen";
            this.dateTimePickerExamen.Size = new System.Drawing.Size(242, 27);
            this.dateTimePickerExamen.TabIndex = 7;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 447);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(130, 43);
            this.btnCerrarSesion.TabIndex = 20;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblAlumnoSeleccionado
            // 
            this.lblAlumnoSeleccionado.AutoSize = true;
            this.lblAlumnoSeleccionado.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumnoSeleccionado.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlumnoSeleccionado.Location = new System.Drawing.Point(226, 319);
            this.lblAlumnoSeleccionado.Name = "lblAlumnoSeleccionado";
            this.lblAlumnoSeleccionado.Size = new System.Drawing.Size(164, 25);
            this.lblAlumnoSeleccionado.TabIndex = 27;
            this.lblAlumnoSeleccionado.Text = "Alumno seleccionado:";
            this.lblAlumnoSeleccionado.Visible = false;
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(891, 500);
            this.Controls.Add(this.lblAlumnoSeleccionado);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.grpBxCrearExamen);
            this.Controls.Add(this.grpBxPonerNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesor - ";
            this.Load += new System.EventHandler(this.FrmProfesor_Load);
            this.grpBxPonerNota.ResumeLayout(false);
            this.grpBxPonerNota.PerformLayout();
            this.grpBxCrearExamen.ResumeLayout(false);
            this.grpBxCrearExamen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxPonerNota;
        private System.Windows.Forms.ListBox lstBxMaterias;
        private System.Windows.Forms.TextBox txBxNota;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnPonerNota;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.ListBox lstBxExamenes;
        private System.Windows.Forms.Label lblExamenes;
        private System.Windows.Forms.ListBox lstBxAlumnos;
        private System.Windows.Forms.GroupBox grpBxCrearExamen;
        private System.Windows.Forms.Label lblInstancia;
        private System.Windows.Forms.ComboBox cmBxInstancias;
        private System.Windows.Forms.Button btnCrearExamen;
        private System.Windows.Forms.Label lblFechaExamen;
        private System.Windows.Forms.DateTimePicker dateTimePickerExamen;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblAlumnoSeleccionado;
    }
}