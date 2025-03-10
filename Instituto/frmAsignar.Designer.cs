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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCurso
            // 
            this.dtgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCurso.Location = new System.Drawing.Point(171, 60);
            this.dtgvCurso.Name = "dtgvCurso";
            this.dtgvCurso.Size = new System.Drawing.Size(240, 150);
            this.dtgvCurso.TabIndex = 0;
            // 
            // frmAsignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 260);
            this.Controls.Add(this.dtgvCurso);
            this.Name = "frmAsignar";
            this.Text = "frmAsignar";
            this.Load += new System.EventHandler(this.frmAsignar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCurso;
    }
}