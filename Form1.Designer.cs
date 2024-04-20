namespace CalculadoraGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.txtPrimerNumero = new System.Windows.Forms.TextBox();
            this.txtSegundoNumero = new System.Windows.Forms.TextBox();
            this.lblPrimerNumero = new System.Windows.Forms.Label();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDivision);
            this.groupBox2.Controls.Add(this.btnResta);
            this.groupBox2.Controls.Add(this.btnProducto);
            this.groupBox2.Controls.Add(this.btnSuma);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSegundoNumero);
            this.groupBox3.Controls.Add(this.lblPrimerNumero);
            this.groupBox3.Controls.Add(this.txtSegundoNumero);
            this.groupBox3.Controls.Add(this.txtPrimerNumero);
            this.groupBox3.Location = new System.Drawing.Point(12, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingreso datos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblResultado);
            this.groupBox4.Location = new System.Drawing.Point(204, 173);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(6, 19);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(94, 19);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 23);
            this.btnResta.TabIndex = 1;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(6, 55);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(75, 23);
            this.btnProducto.TabIndex = 1;
            this.btnProducto.Text = "*";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(94, 55);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 23);
            this.btnDivision.TabIndex = 0;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // txtPrimerNumero
            // 
            this.txtPrimerNumero.Location = new System.Drawing.Point(69, 34);
            this.txtPrimerNumero.Name = "txtPrimerNumero";
            this.txtPrimerNumero.Size = new System.Drawing.Size(100, 20);
            this.txtPrimerNumero.TabIndex = 0;
            // 
            // txtSegundoNumero
            // 
            this.txtSegundoNumero.Location = new System.Drawing.Point(69, 71);
            this.txtSegundoNumero.Name = "txtSegundoNumero";
            this.txtSegundoNumero.Size = new System.Drawing.Size(100, 20);
            this.txtSegundoNumero.TabIndex = 1;
            // 
            // lblPrimerNumero
            // 
            this.lblPrimerNumero.AutoSize = true;
            this.lblPrimerNumero.Location = new System.Drawing.Point(7, 37);
            this.lblPrimerNumero.Name = "lblPrimerNumero";
            this.lblPrimerNumero.Size = new System.Drawing.Size(57, 13);
            this.lblPrimerNumero.TabIndex = 2;
            this.lblPrimerNumero.Text = "1° Numero";
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Location = new System.Drawing.Point(10, 74);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(57, 13);
            this.lblSegundoNumero.TabIndex = 3;
            this.lblSegundoNumero.Text = "2° Número";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(16, 25);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(130, 52);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "CALCULADORA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(386, 353);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.Label lblPrimerNumero;
        private System.Windows.Forms.TextBox txtSegundoNumero;
        private System.Windows.Forms.TextBox txtPrimerNumero;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label2;
    }
}

