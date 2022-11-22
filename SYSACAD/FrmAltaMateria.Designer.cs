namespace SYSACAD
{
    partial class FrmAltaMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaMateria));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpBxCuatrimestre = new System.Windows.Forms.GroupBox();
            this.rdBtnSegundoCuatrimestre = new System.Windows.Forms.RadioButton();
            this.rdBtnPrimerCuatrimestre = new System.Windows.Forms.RadioButton();
            this.cmbBoxCorrelativa = new System.Windows.Forms.ComboBox();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.lblCorrelativa = new System.Windows.Forms.Label();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.grpBxCuatrimestre.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(162, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAceptar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(26, 380);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 35);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grpBxCuatrimestre
            // 
            this.grpBxCuatrimestre.Controls.Add(this.rdBtnSegundoCuatrimestre);
            this.grpBxCuatrimestre.Controls.Add(this.rdBtnPrimerCuatrimestre);
            this.grpBxCuatrimestre.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBxCuatrimestre.Location = new System.Drawing.Point(26, 113);
            this.grpBxCuatrimestre.Name = "grpBxCuatrimestre";
            this.grpBxCuatrimestre.Size = new System.Drawing.Size(211, 114);
            this.grpBxCuatrimestre.TabIndex = 11;
            this.grpBxCuatrimestre.TabStop = false;
            this.grpBxCuatrimestre.Text = "Cuatrimestre";
            // 
            // rdBtnSegundoCuatrimestre
            // 
            this.rdBtnSegundoCuatrimestre.AutoSize = true;
            this.rdBtnSegundoCuatrimestre.Location = new System.Drawing.Point(6, 56);
            this.rdBtnSegundoCuatrimestre.Name = "rdBtnSegundoCuatrimestre";
            this.rdBtnSegundoCuatrimestre.Size = new System.Drawing.Size(144, 23);
            this.rdBtnSegundoCuatrimestre.TabIndex = 1;
            this.rdBtnSegundoCuatrimestre.Text = "Segundo cuatrimestre";
            this.rdBtnSegundoCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // rdBtnPrimerCuatrimestre
            // 
            this.rdBtnPrimerCuatrimestre.AutoSize = true;
            this.rdBtnPrimerCuatrimestre.Checked = true;
            this.rdBtnPrimerCuatrimestre.Location = new System.Drawing.Point(6, 31);
            this.rdBtnPrimerCuatrimestre.Name = "rdBtnPrimerCuatrimestre";
            this.rdBtnPrimerCuatrimestre.Size = new System.Drawing.Size(135, 23);
            this.rdBtnPrimerCuatrimestre.TabIndex = 0;
            this.rdBtnPrimerCuatrimestre.TabStop = true;
            this.rdBtnPrimerCuatrimestre.Text = "Primer cuatrimestre";
            this.rdBtnPrimerCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // cmbBoxCorrelativa
            // 
            this.cmbBoxCorrelativa.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBoxCorrelativa.FormattingEnabled = true;
            this.cmbBoxCorrelativa.Location = new System.Drawing.Point(26, 297);
            this.cmbBoxCorrelativa.Name = "cmbBoxCorrelativa";
            this.cmbBoxCorrelativa.Size = new System.Drawing.Size(211, 27);
            this.cmbBoxCorrelativa.TabIndex = 10;
            this.cmbBoxCorrelativa.Text = "No tiene";
            this.cmbBoxCorrelativa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBoxCorrelativa_KeyPress);
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreMateria.Location = new System.Drawing.Point(26, 52);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.PlaceholderText = "Ingrese nombre de la materia...";
            this.txtNombreMateria.Size = new System.Drawing.Size(211, 27);
            this.txtNombreMateria.TabIndex = 9;
            // 
            // lblCorrelativa
            // 
            this.lblCorrelativa.AutoSize = true;
            this.lblCorrelativa.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCorrelativa.Location = new System.Drawing.Point(26, 258);
            this.lblCorrelativa.Name = "lblCorrelativa";
            this.lblCorrelativa.Size = new System.Drawing.Size(72, 21);
            this.lblCorrelativa.TabIndex = 8;
            this.lblCorrelativa.Text = "Correlativa";
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreMateria.Location = new System.Drawing.Point(26, 18);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(54, 21);
            this.lblNombreMateria.TabIndex = 7;
            this.lblNombreMateria.Text = "Nombre";
            // 
            // FrmAltaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(291, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpBxCuatrimestre);
            this.Controls.Add(this.cmbBoxCorrelativa);
            this.Controls.Add(this.txtNombreMateria);
            this.Controls.Add(this.lblCorrelativa);
            this.Controls.Add(this.lblNombreMateria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAltaMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta materia";
            this.grpBxCuatrimestre.ResumeLayout(false);
            this.grpBxCuatrimestre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grpBxCuatrimestre;
        private System.Windows.Forms.RadioButton rdBtnSegundoCuatrimestre;
        private System.Windows.Forms.RadioButton rdBtnPrimerCuatrimestre;
        private System.Windows.Forms.ComboBox cmbBoxCorrelativa;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label lblCorrelativa;
        private System.Windows.Forms.Label lblNombreMateria;
    }
}