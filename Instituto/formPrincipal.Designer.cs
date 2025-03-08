namespace Instituto
{
    partial class formPrincipal
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
            this.btnInscribirPostulante = new System.Windows.Forms.Button();
            this.btnEmitirComprobante = new System.Windows.Forms.Button();
            this.btnPagarCurso = new System.Windows.Forms.Button();
            this.btnAsignarCurso = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInscribirPostulante
            // 
            this.btnInscribirPostulante.Location = new System.Drawing.Point(62, 54);
            this.btnInscribirPostulante.Name = "btnInscribirPostulante";
            this.btnInscribirPostulante.Size = new System.Drawing.Size(134, 51);
            this.btnInscribirPostulante.TabIndex = 0;
            this.btnInscribirPostulante.Text = "Inscribir Postulante ";
            this.btnInscribirPostulante.UseVisualStyleBackColor = true;
            this.btnInscribirPostulante.Click += new System.EventHandler(this.btnInscribirPostulante_Click);
            // 
            // btnEmitirComprobante
            // 
            this.btnEmitirComprobante.Location = new System.Drawing.Point(240, 147);
            this.btnEmitirComprobante.Name = "btnEmitirComprobante";
            this.btnEmitirComprobante.Size = new System.Drawing.Size(117, 58);
            this.btnEmitirComprobante.TabIndex = 1;
            this.btnEmitirComprobante.Text = "Emitir Comprobante de Curso";
            this.btnEmitirComprobante.UseVisualStyleBackColor = true;
            // 
            // btnPagarCurso
            // 
            this.btnPagarCurso.Location = new System.Drawing.Point(62, 147);
            this.btnPagarCurso.Name = "btnPagarCurso";
            this.btnPagarCurso.Size = new System.Drawing.Size(134, 58);
            this.btnPagarCurso.TabIndex = 2;
            this.btnPagarCurso.Text = "Pagar Curso";
            this.btnPagarCurso.UseVisualStyleBackColor = true;
            // 
            // btnAsignarCurso
            // 
            this.btnAsignarCurso.Location = new System.Drawing.Point(240, 54);
            this.btnAsignarCurso.Name = "btnAsignarCurso";
            this.btnAsignarCurso.Size = new System.Drawing.Size(117, 51);
            this.btnAsignarCurso.TabIndex = 3;
            this.btnAsignarCurso.Text = "Asignar Curso";
            this.btnAsignarCurso.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(381, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(25, 12);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(29, 13);
            this.lblIngreso.TabIndex = 5;
            this.lblIngreso.Text = "ROL";
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 220);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsignarCurso);
            this.Controls.Add(this.btnPagarCurso);
            this.Controls.Add(this.btnEmitirComprobante);
            this.Controls.Add(this.btnInscribirPostulante);
            this.Name = "formPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInscribirPostulante;
        private System.Windows.Forms.Button btnEmitirComprobante;
        private System.Windows.Forms.Button btnPagarCurso;
        private System.Windows.Forms.Button btnAsignarCurso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblIngreso;
    }
}