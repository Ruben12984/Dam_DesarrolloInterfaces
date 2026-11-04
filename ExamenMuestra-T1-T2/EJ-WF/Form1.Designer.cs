namespace EJ_WF
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumEdad = new System.Windows.Forms.NumericUpDown();
            this.object_e4e6bab3_1bdf_4de6_bfb8_52efd2aea52f = new System.Windows.Forms.Form();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rb5KM = new System.Windows.Forms.RadioButton();
            this.Rb10KM = new System.Windows.Forms.RadioButton();
            this.RbMeta = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.CbTalla = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.ChkSocio = new System.Windows.Forms.CheckBox();
            this.BtnResumen = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumEdad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(61, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARRERA POPULAR DE LUCENA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "EDAD";
            // 
            // NumEdad
            // 
            this.NumEdad.Location = new System.Drawing.Point(144, 184);
            this.NumEdad.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.NumEdad.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.NumEdad.Name = "NumEdad";
            this.NumEdad.Size = new System.Drawing.Size(120, 22);
            this.NumEdad.TabIndex = 3;
            this.NumEdad.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // object_e4e6bab3_1bdf_4de6_bfb8_52efd2aea52f
            // 
            this.object_e4e6bab3_1bdf_4de6_bfb8_52efd2aea52f.BackColor = System.Drawing.SystemColors.Control;
            this.object_e4e6bab3_1bdf_4de6_bfb8_52efd2aea52f.ClientSize = new System.Drawing.Size(800, 450);
            this.object_e4e6bab3_1bdf_4de6_bfb8_52efd2aea52f.Location = new System.Drawing.Point(19, 19);
            this.object_e4e6bab3_1bdf_4de6_bfb8_52efd2aea52f.Name = "object_e4e6bab3_1bdf_4de6_bfb8_52efd2aea52f";
            this.object_e4e6bab3_1bdf_4de6_bfb8_52efd2aea52f.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbMeta);
            this.groupBox1.Controls.Add(this.Rb10KM);
            this.groupBox1.Controls.Add(this.Rb5KM);
            this.groupBox1.Location = new System.Drawing.Point(64, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DISTANCIAS";
            // 
            // Rb5KM
            // 
            this.Rb5KM.AutoSize = true;
            this.Rb5KM.Location = new System.Drawing.Point(35, 45);
            this.Rb5KM.Name = "Rb5KM";
            this.Rb5KM.Size = new System.Drawing.Size(85, 20);
            this.Rb5KM.TabIndex = 0;
            this.Rb5KM.TabStop = true;
            this.Rb5KM.Text = "5 KM (8 $)";
            this.Rb5KM.UseVisualStyleBackColor = true;
            // 
            // Rb10KM
            // 
            this.Rb10KM.AutoSize = true;
            this.Rb10KM.Location = new System.Drawing.Point(199, 45);
            this.Rb10KM.Name = "Rb10KM";
            this.Rb10KM.Size = new System.Drawing.Size(99, 20);
            this.Rb10KM.TabIndex = 1;
            this.Rb10KM.TabStop = true;
            this.Rb10KM.Text = "10 KM (12 $)";
            this.Rb10KM.UseVisualStyleBackColor = true;
            // 
            // RbMeta
            // 
            this.RbMeta.AutoSize = true;
            this.RbMeta.Location = new System.Drawing.Point(342, 45);
            this.RbMeta.Name = "RbMeta";
            this.RbMeta.Size = new System.Drawing.Size(176, 20);
            this.RbMeta.TabIndex = 2;
            this.RbMeta.TabStop = true;
            this.RbMeta.Text = "MEDIA MARATON (18 $)";
            this.RbMeta.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "TALLA CAMISETAS";
            // 
            // CbTalla
            // 
            this.CbTalla.FormattingEnabled = true;
            this.CbTalla.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.CbTalla.Location = new System.Drawing.Point(215, 374);
            this.CbTalla.Name = "CbTalla";
            this.CbTalla.Size = new System.Drawing.Size(121, 24);
            this.CbTalla.TabIndex = 6;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(153, 133);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(217, 22);
            this.TxtNombre.TabIndex = 7;
            // 
            // ChkSocio
            // 
            this.ChkSocio.AutoSize = true;
            this.ChkSocio.Location = new System.Drawing.Point(64, 428);
            this.ChkSocio.Name = "ChkSocio";
            this.ChkSocio.Size = new System.Drawing.Size(169, 20);
            this.ChkSocio.TabIndex = 8;
            this.ChkSocio.Text = "SOCIO DEL CLUB (-3 $)";
            this.ChkSocio.UseVisualStyleBackColor = true;
            // 
            // BtnResumen
            // 
            this.BtnResumen.Location = new System.Drawing.Point(50, 489);
            this.BtnResumen.Name = "BtnResumen";
            this.BtnResumen.Size = new System.Drawing.Size(198, 61);
            this.BtnResumen.TabIndex = 9;
            this.BtnResumen.Text = "VER RESUMEN";
            this.BtnResumen.UseVisualStyleBackColor = true;
            this.BtnResumen.Click += new System.EventHandler(this.BtnResumen_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(550, 489);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(179, 61);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "GUARDAR INSCRIPCION";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 562);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnResumen);
            this.Controls.Add(this.ChkSocio);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.CbTalla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NumEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumEdad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumEdad;
        private System.Windows.Forms.Form object_e4e6bab3_1bdf_4de6_bfb8_52efd2aea52f;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbMeta;
        private System.Windows.Forms.RadioButton Rb10KM;
        private System.Windows.Forms.RadioButton Rb5KM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbTalla;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.CheckBox ChkSocio;
        private System.Windows.Forms.Button BtnResumen;
        private System.Windows.Forms.Button BtnGuardar;
    }
}

