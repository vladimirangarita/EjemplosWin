namespace EjemplosWin
{
    partial class frmMenu
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
            this.lblExtenciones = new System.Windows.Forms.LinkLabel();
            this.llbQueries1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblExtenciones
            // 
            this.lblExtenciones.AutoSize = true;
            this.lblExtenciones.Location = new System.Drawing.Point(327, 59);
            this.lblExtenciones.Name = "lblExtenciones";
            this.lblExtenciones.Size = new System.Drawing.Size(65, 13);
            this.lblExtenciones.TabIndex = 0;
            this.lblExtenciones.TabStop = true;
            this.lblExtenciones.Text = "Extenciones";
            this.lblExtenciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExtenciones_LinkClicked);
            // 
            // llbQueries1
            // 
            this.llbQueries1.AutoSize = true;
            this.llbQueries1.Location = new System.Drawing.Point(327, 93);
            this.llbQueries1.Name = "llbQueries1";
            this.llbQueries1.Size = new System.Drawing.Size(52, 13);
            this.llbQueries1.TabIndex = 1;
            this.llbQueries1.TabStop = true;
            this.llbQueries1.Text = "Queries 1";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llbQueries1);
            this.Controls.Add(this.lblExtenciones);
            this.Name = "frmMenu";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblExtenciones;
        private System.Windows.Forms.LinkLabel llbQueries1;
    }
}

