namespace EjemplosWin
{
    partial class frmQueries2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMayores = new System.Windows.Forms.TextBox();
            this.btnProcesar1 = new System.Windows.Forms.Button();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbEnteros = new System.Windows.Forms.RadioButton();
            this.rbStrings = new System.Windows.Forms.RadioButton();
            this.btnProcesar2 = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConstantes = new System.Windows.Forms.TextBox();
            this.btnProcesar3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numeros Mayores A:";
            // 
            // txtMayores
            // 
            this.txtMayores.Location = new System.Drawing.Point(180, 23);
            this.txtMayores.Name = "txtMayores";
            this.txtMayores.Size = new System.Drawing.Size(74, 20);
            this.txtMayores.TabIndex = 1;
            // 
            // btnProcesar1
            // 
            this.btnProcesar1.Location = new System.Drawing.Point(713, 12);
            this.btnProcesar1.Name = "btnProcesar1";
            this.btnProcesar1.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar1.TabIndex = 2;
            this.btnProcesar1.Text = "Procesar";
            this.btnProcesar1.UseVisualStyleBackColor = true;
            this.btnProcesar1.Click += new System.EventHandler(this.btnProcesar1_Click);
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(180, 49);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(386, 20);
            this.txtResultados.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultado:";
            // 
            // rbEnteros
            // 
            this.rbEnteros.AutoSize = true;
            this.rbEnteros.Location = new System.Drawing.Point(57, 86);
            this.rbEnteros.Name = "rbEnteros";
            this.rbEnteros.Size = new System.Drawing.Size(61, 17);
            this.rbEnteros.TabIndex = 5;
            this.rbEnteros.TabStop = true;
            this.rbEnteros.Text = "Enteros";
            this.rbEnteros.UseVisualStyleBackColor = true;
            // 
            // rbStrings
            // 
            this.rbStrings.AutoSize = true;
            this.rbStrings.Location = new System.Drawing.Point(135, 86);
            this.rbStrings.Name = "rbStrings";
            this.rbStrings.Size = new System.Drawing.Size(57, 17);
            this.rbStrings.TabIndex = 6;
            this.rbStrings.TabStop = true;
            this.rbStrings.Text = "Strings";
            this.rbStrings.UseVisualStyleBackColor = true;
            // 
            // btnProcesar2
            // 
            this.btnProcesar2.Location = new System.Drawing.Point(491, 86);
            this.btnProcesar2.Name = "btnProcesar2";
            this.btnProcesar2.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar2.TabIndex = 7;
            this.btnProcesar2.Text = "Procesar";
            this.btnProcesar2.UseVisualStyleBackColor = true;
            this.btnProcesar2.Click += new System.EventHandler(this.btnProcesar2_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(53, 122);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(325, 173);
            this.lstResultados.TabIndex = 8;
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(180, 333);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(386, 20);
            this.txtFrase.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Frase:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Constantes:";
            // 
            // txtConstantes
            // 
            this.txtConstantes.Location = new System.Drawing.Point(180, 387);
            this.txtConstantes.Name = "txtConstantes";
            this.txtConstantes.Size = new System.Drawing.Size(198, 20);
            this.txtConstantes.TabIndex = 12;
            // 
            // btnProcesar3
            // 
            this.btnProcesar3.Location = new System.Drawing.Point(713, 415);
            this.btnProcesar3.Name = "btnProcesar3";
            this.btnProcesar3.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar3.TabIndex = 13;
            this.btnProcesar3.Text = "Procesar";
            this.btnProcesar3.UseVisualStyleBackColor = true;
            this.btnProcesar3.Click += new System.EventHandler(this.btnProcesar3_Click);
            // 
            // frmQueries2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcesar3);
            this.Controls.Add(this.txtConstantes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnProcesar2);
            this.Controls.Add(this.rbStrings);
            this.Controls.Add(this.rbEnteros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.btnProcesar1);
            this.Controls.Add(this.txtMayores);
            this.Controls.Add(this.label1);
            this.Name = "frmQueries2";
            this.Text = "frmQueries2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMayores;
        private System.Windows.Forms.Button btnProcesar1;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbEnteros;
        private System.Windows.Forms.RadioButton rbStrings;
        private System.Windows.Forms.Button btnProcesar2;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConstantes;
        private System.Windows.Forms.Button btnProcesar3;
    }
}