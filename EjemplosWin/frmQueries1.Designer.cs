﻿namespace EjemplosWin
{
    partial class frmQueries1
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
            this.grvResultados = new System.Windows.Forms.DataGridView();
            this.btnQuery1 = new System.Windows.Forms.Button();
            this.btnQuery2 = new System.Windows.Forms.Button();
            this.btnQuery4 = new System.Windows.Forms.Button();
            this.btnQuery3 = new System.Windows.Forms.Button();
            this.btnQuery5 = new System.Windows.Forms.Button();
            this.btnQuery6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // grvResultados
            // 
            this.grvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvResultados.Location = new System.Drawing.Point(42, 44);
            this.grvResultados.Name = "grvResultados";
            this.grvResultados.Size = new System.Drawing.Size(730, 374);
            this.grvResultados.TabIndex = 0;
            // 
            // btnQuery1
            // 
            this.btnQuery1.Location = new System.Drawing.Point(42, 442);
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(75, 23);
            this.btnQuery1.TabIndex = 1;
            this.btnQuery1.Text = "Query 1";
            this.btnQuery1.UseVisualStyleBackColor = true;
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // btnQuery2
            // 
            this.btnQuery2.Location = new System.Drawing.Point(123, 442);
            this.btnQuery2.Name = "btnQuery2";
            this.btnQuery2.Size = new System.Drawing.Size(75, 23);
            this.btnQuery2.TabIndex = 2;
            this.btnQuery2.Text = "Query 2";
            this.btnQuery2.UseVisualStyleBackColor = true;
            this.btnQuery2.Click += new System.EventHandler(this.btnQuery2_Click);
            // 
            // btnQuery4
            // 
            this.btnQuery4.Location = new System.Drawing.Point(285, 442);
            this.btnQuery4.Name = "btnQuery4";
            this.btnQuery4.Size = new System.Drawing.Size(75, 23);
            this.btnQuery4.TabIndex = 4;
            this.btnQuery4.Text = "Query 4";
            this.btnQuery4.UseVisualStyleBackColor = true;
            this.btnQuery4.Click += new System.EventHandler(this.btnQuery4_Click);
            // 
            // btnQuery3
            // 
            this.btnQuery3.Location = new System.Drawing.Point(204, 442);
            this.btnQuery3.Name = "btnQuery3";
            this.btnQuery3.Size = new System.Drawing.Size(75, 23);
            this.btnQuery3.TabIndex = 3;
            this.btnQuery3.Text = "Query 3";
            this.btnQuery3.UseVisualStyleBackColor = true;
            this.btnQuery3.Click += new System.EventHandler(this.btnQuery3_Click);
            // 
            // btnQuery5
            // 
            this.btnQuery5.Location = new System.Drawing.Point(366, 442);
            this.btnQuery5.Name = "btnQuery5";
            this.btnQuery5.Size = new System.Drawing.Size(75, 23);
            this.btnQuery5.TabIndex = 5;
            this.btnQuery5.Text = "Query 5";
            this.btnQuery5.UseVisualStyleBackColor = true;
            this.btnQuery5.Click += new System.EventHandler(this.btnQuery5_Click);
            // 
            // btnQuery6
            // 
            this.btnQuery6.Location = new System.Drawing.Point(447, 442);
            this.btnQuery6.Name = "btnQuery6";
            this.btnQuery6.Size = new System.Drawing.Size(75, 23);
            this.btnQuery6.TabIndex = 6;
            this.btnQuery6.Text = "Query 6";
            this.btnQuery6.UseVisualStyleBackColor = true;
            this.btnQuery6.Click += new System.EventHandler(this.btnQuery6_Click);
            // 
            // frmQueries1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.btnQuery6);
            this.Controls.Add(this.btnQuery5);
            this.Controls.Add(this.btnQuery4);
            this.Controls.Add(this.btnQuery3);
            this.Controls.Add(this.btnQuery2);
            this.Controls.Add(this.btnQuery1);
            this.Controls.Add(this.grvResultados);
            this.Name = "frmQueries1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQueries1";
            ((System.ComponentModel.ISupportInitialize)(this.grvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvResultados;
        private System.Windows.Forms.Button btnQuery1;
        private System.Windows.Forms.Button btnQuery2;
        private System.Windows.Forms.Button btnQuery4;
        private System.Windows.Forms.Button btnQuery3;
        private System.Windows.Forms.Button btnQuery5;
        private System.Windows.Forms.Button btnQuery6;
    }
}