namespace EjemplosWin
{
    partial class frmXML
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.RbM = new System.Windows.Forms.RadioButton();
            this.RbF = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.BtnArchivo2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(28, 85);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(760, 270);
            this.dgvDatos.TabIndex = 0;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(28, 361);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(109, 361);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 2;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // RbM
            // 
            this.RbM.AutoSize = true;
            this.RbM.Checked = true;
            this.RbM.Location = new System.Drawing.Point(206, 362);
            this.RbM.Name = "RbM";
            this.RbM.Size = new System.Drawing.Size(34, 17);
            this.RbM.TabIndex = 3;
            this.RbM.TabStop = true;
            this.RbM.Text = "M";
            this.RbM.UseVisualStyleBackColor = true;
            // 
            // RbF
            // 
            this.RbF.AutoSize = true;
            this.RbF.Location = new System.Drawing.Point(206, 385);
            this.RbF.Name = "RbF";
            this.RbF.Size = new System.Drawing.Size(31, 17);
            this.RbF.TabIndex = 4;
            this.RbF.Text = "F";
            this.RbF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar:";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(71, 57);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.TxtBusqueda.TabIndex = 6;
            // 
            // BtnArchivo2
            // 
            this.BtnArchivo2.Location = new System.Drawing.Point(262, 362);
            this.BtnArchivo2.Name = "BtnArchivo2";
            this.BtnArchivo2.Size = new System.Drawing.Size(75, 23);
            this.BtnArchivo2.TabIndex = 7;
            this.BtnArchivo2.Text = "Archivo 2";
            this.BtnArchivo2.UseVisualStyleBackColor = true;
            this.BtnArchivo2.Click += new System.EventHandler(this.BtnArchivo2_Click);
            // 
            // frmXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnArchivo2);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RbF);
            this.Controls.Add(this.RbM);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frmXML";
            this.Text = "frmXML";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.RadioButton RbM;
        private System.Windows.Forms.RadioButton RbF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Button BtnArchivo2;
    }
}