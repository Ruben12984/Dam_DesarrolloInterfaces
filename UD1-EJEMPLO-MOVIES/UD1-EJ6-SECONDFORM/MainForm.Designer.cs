namespace UD1_EJ6_SECONDFORM
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbAlumnado = new System.Windows.Forms.RadioButton();
            this.RbProfesorado = new System.Windows.Forms.RadioButton();
            this.RbFamilias = new System.Windows.Forms.RadioButton();
            this.BtnNewForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(136, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "EJEMPLO DE VARIOS FORMULARIOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbFamilias);
            this.groupBox1.Controls.Add(this.RbProfesorado);
            this.groupBox1.Controls.Add(this.RbAlumnado);
            this.groupBox1.Location = new System.Drawing.Point(81, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VARIOS FORMULARIOS";
            // 
            // RbAlumnado
            // 
            this.RbAlumnado.AutoSize = true;
            this.RbAlumnado.Location = new System.Drawing.Point(31, 32);
            this.RbAlumnado.Name = "RbAlumnado";
            this.RbAlumnado.Size = new System.Drawing.Size(89, 20);
            this.RbAlumnado.TabIndex = 0;
            this.RbAlumnado.TabStop = true;
            this.RbAlumnado.Text = "Alumnado";
            this.RbAlumnado.UseVisualStyleBackColor = true;
            // 
            // RbProfesorado
            // 
            this.RbProfesorado.AutoSize = true;
            this.RbProfesorado.Location = new System.Drawing.Point(31, 74);
            this.RbProfesorado.Name = "RbProfesorado";
            this.RbProfesorado.Size = new System.Drawing.Size(103, 20);
            this.RbProfesorado.TabIndex = 1;
            this.RbProfesorado.TabStop = true;
            this.RbProfesorado.Text = "Profesorado";
            this.RbProfesorado.UseVisualStyleBackColor = true;
            // 
            // RbFamilias
            // 
            this.RbFamilias.AutoSize = true;
            this.RbFamilias.Location = new System.Drawing.Point(31, 122);
            this.RbFamilias.Name = "RbFamilias";
            this.RbFamilias.Size = new System.Drawing.Size(79, 20);
            this.RbFamilias.TabIndex = 2;
            this.RbFamilias.TabStop = true;
            this.RbFamilias.Text = "Familias";
            this.RbFamilias.UseVisualStyleBackColor = true;
            // 
            // BtnNewForm
            // 
            this.BtnNewForm.Location = new System.Drawing.Point(453, 166);
            this.BtnNewForm.Name = "BtnNewForm";
            this.BtnNewForm.Size = new System.Drawing.Size(219, 66);
            this.BtnNewForm.TabIndex = 2;
            this.BtnNewForm.Text = "Crear nueva ventana";
            this.BtnNewForm.UseVisualStyleBackColor = true;
            this.BtnNewForm.Click += new System.EventHandler(this.BtnNewForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnNewForm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "EMPLO FINAL TEMA 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbFamilias;
        private System.Windows.Forms.RadioButton RbProfesorado;
        private System.Windows.Forms.RadioButton RbAlumnado;
        private System.Windows.Forms.Button BtnNewForm;
    }
}

