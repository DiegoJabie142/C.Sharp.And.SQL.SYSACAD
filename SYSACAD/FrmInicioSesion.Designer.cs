namespace SYSACAD
{
    partial class FrmInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioSesion));
            this.btnOpciones = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.btnProfesorPrLb = new System.Windows.Forms.Button();
            this.btnAlumnoPrgLb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpciones
            // 
            this.btnOpciones.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOpciones.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpciones.Location = new System.Drawing.Point(460, 372);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(122, 35);
            this.btnOpciones.TabIndex = 16;
            this.btnOpciones.Text = "Opciones";
            this.btnOpciones.UseVisualStyleBackColor = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txtContraseña.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseña.Location = new System.Drawing.Point(463, 322);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(273, 25);
            this.txtContraseña.TabIndex = 15;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDNI.Location = new System.Drawing.Point(463, 248);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(273, 25);
            this.txtDNI.TabIndex = 14;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.DarkOrange;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIniciarSesion.Location = new System.Drawing.Point(612, 372);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(121, 35);
            this.btnIniciarSesion.TabIndex = 13;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(460, 290);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(98, 19);
            this.lblContraseña.TabIndex = 12;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(460, 217);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(37, 19);
            this.lblDni.TabIndex = 11;
            this.lblDni.Text = "DNI";
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdministrador.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdministrador.ForeColor = System.Drawing.Color.White;
            this.btnAdministrador.Location = new System.Drawing.Point(535, 12);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(198, 31);
            this.btnAdministrador.TabIndex = 17;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = false;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // btnProfesorPrLb
            // 
            this.btnProfesorPrLb.BackColor = System.Drawing.Color.DarkGray;
            this.btnProfesorPrLb.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfesorPrLb.Location = new System.Drawing.Point(12, 12);
            this.btnProfesorPrLb.Name = "btnProfesorPrLb";
            this.btnProfesorPrLb.Size = new System.Drawing.Size(254, 31);
            this.btnProfesorPrLb.TabIndex = 18;
            this.btnProfesorPrLb.Text = "Profesor - Pedro";
            this.btnProfesorPrLb.UseVisualStyleBackColor = false;
            this.btnProfesorPrLb.Click += new System.EventHandler(this.btnProfesorPrLb_Click);
            // 
            // btnAlumnoPrgLb
            // 
            this.btnAlumnoPrgLb.BackColor = System.Drawing.Color.Bisque;
            this.btnAlumnoPrgLb.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlumnoPrgLb.Location = new System.Drawing.Point(272, 12);
            this.btnAlumnoPrgLb.Name = "btnAlumnoPrgLb";
            this.btnAlumnoPrgLb.Size = new System.Drawing.Size(254, 31);
            this.btnAlumnoPrgLb.TabIndex = 19;
            this.btnAlumnoPrgLb.Text = "Alumno (Roberto Rodríguez)";
            this.btnAlumnoPrgLb.UseVisualStyleBackColor = false;
            this.btnAlumnoPrgLb.Click += new System.EventHandler(this.btnAlumnoPrgLb_Click);
            // 
            // FrmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SYSACAD.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(748, 419);
            this.Controls.Add(this.btnAlumnoPrgLb);
            this.Controls.Add(this.btnProfesorPrLb);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.btnOpciones);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicioSesion";
            this.Text = "SISTEMA UTN FRA - Inicio de sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpciones;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button btnProfesorPrLb;
        private System.Windows.Forms.Button btnAlumnoPrgLb;
    }
}
