namespace EjemplosWin
{
    partial class frmQueries3
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
            this.tvrCasos = new System.Windows.Forms.TreeView();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.GrvResultados = new System.Windows.Forms.DataGridView();
            this.BtnInto = new System.Windows.Forms.Button();
            this.BtnJoin1 = new System.Windows.Forms.Button();
            this.BtnJoin2 = new System.Windows.Forms.Button();
            this.BtnSubQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // tvrCasos
            // 
            this.tvrCasos.Location = new System.Drawing.Point(60, 12);
            this.tvrCasos.Name = "tvrCasos";
            this.tvrCasos.Size = new System.Drawing.Size(380, 316);
            this.tvrCasos.TabIndex = 0;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(446, 12);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // GrvResultados
            // 
            this.GrvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvResultados.Location = new System.Drawing.Point(540, 17);
            this.GrvResultados.Name = "GrvResultados";
            this.GrvResultados.Size = new System.Drawing.Size(326, 311);
            this.GrvResultados.TabIndex = 2;
            // 
            // BtnInto
            // 
            this.BtnInto.Location = new System.Drawing.Point(872, 12);
            this.BtnInto.Name = "BtnInto";
            this.BtnInto.Size = new System.Drawing.Size(75, 23);
            this.BtnInto.TabIndex = 3;
            this.BtnInto.Text = "Into";
            this.BtnInto.UseVisualStyleBackColor = true;
            this.BtnInto.Click += new System.EventHandler(this.BtnInto_Click);
            // 
            // BtnJoin1
            // 
            this.BtnJoin1.Location = new System.Drawing.Point(872, 41);
            this.BtnJoin1.Name = "BtnJoin1";
            this.BtnJoin1.Size = new System.Drawing.Size(75, 23);
            this.BtnJoin1.TabIndex = 4;
            this.BtnJoin1.Text = "Join 1";
            this.BtnJoin1.UseVisualStyleBackColor = true;
            this.BtnJoin1.Click += new System.EventHandler(this.BtnJoin1_Click);
            // 
            // BtnJoin2
            // 
            this.BtnJoin2.Location = new System.Drawing.Point(872, 70);
            this.BtnJoin2.Name = "BtnJoin2";
            this.BtnJoin2.Size = new System.Drawing.Size(75, 23);
            this.BtnJoin2.TabIndex = 5;
            this.BtnJoin2.Text = "Join 2";
            this.BtnJoin2.UseVisualStyleBackColor = true;
            this.BtnJoin2.Click += new System.EventHandler(this.BtnJoin2_Click);
            // 
            // BtnSubQuery
            // 
            this.BtnSubQuery.Location = new System.Drawing.Point(872, 99);
            this.BtnSubQuery.Name = "BtnSubQuery";
            this.BtnSubQuery.Size = new System.Drawing.Size(75, 23);
            this.BtnSubQuery.TabIndex = 6;
            this.BtnSubQuery.Text = "SubQuery";
            this.BtnSubQuery.UseVisualStyleBackColor = true;
            this.BtnSubQuery.Click += new System.EventHandler(this.BtnSubQuery_Click);
            // 
            // frmQueries3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.BtnSubQuery);
            this.Controls.Add(this.BtnJoin2);
            this.Controls.Add(this.BtnJoin1);
            this.Controls.Add(this.BtnInto);
            this.Controls.Add(this.GrvResultados);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.tvrCasos);
            this.Name = "frmQueries3";
            this.Text = "frmQueries3";
            this.Load += new System.EventHandler(this.frmQueries3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvrCasos;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DataGridView GrvResultados;
        private System.Windows.Forms.Button BtnInto;
        private System.Windows.Forms.Button BtnJoin1;
        private System.Windows.Forms.Button BtnJoin2;
        private System.Windows.Forms.Button BtnSubQuery;
    }
}