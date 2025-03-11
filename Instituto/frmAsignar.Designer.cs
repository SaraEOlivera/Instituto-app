namespace Instituto
{
    partial class frmAsignar
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
            this.dtgvCurso = new System.Windows.Forms.DataGridView();
            this.lblTituloAsignar = new System.Windows.Forms.Label();
            this.NumCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCurso
            // 
            this.dtgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumCurso,
            this.Nombre,
            this.cupo,
            this.precio});
            this.dtgvCurso.Location = new System.Drawing.Point(46, 60);
            this.dtgvCurso.Name = "dtgvCurso";
            this.dtgvCurso.Size = new System.Drawing.Size(445, 175);
            this.dtgvCurso.TabIndex = 0;
            // 
            // lblTituloAsignar
            // 
            this.lblTituloAsignar.AutoSize = true;
            this.lblTituloAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAsignar.Location = new System.Drawing.Point(172, 14);
            this.lblTituloAsignar.Name = "lblTituloAsignar";
            this.lblTituloAsignar.Size = new System.Drawing.Size(167, 18);
            this.lblTituloAsignar.TabIndex = 1;
            this.lblTituloAsignar.Text = "Lista de cursos vigentes";
            // 
            // NumCurso
            // 
            this.NumCurso.HeaderText = "Numero del Curso";
            this.NumCurso.Name = "NumCurso";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // cupo
            // 
            this.cupo.HeaderText = "Cupo";
            this.cupo.Name = "cupo";
            // 
            // precio
            // 
            this.precio.HeaderText = "Valor";
            this.precio.Name = "precio";
            // 
            // frmAsignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 260);
            this.Controls.Add(this.lblTituloAsignar);
            this.Controls.Add(this.dtgvCurso);
            this.Name = "frmAsignar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Curso";
            this.Load += new System.EventHandler(this.frmAsignar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCurso;
        private System.Windows.Forms.Label lblTituloAsignar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}