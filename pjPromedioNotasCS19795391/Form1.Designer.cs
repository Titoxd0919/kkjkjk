namespace pjPromedioNotasCS19795391
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
            this.Nombre = new System.Windows.Forms.TextBox();
            this.procesar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Promedio = new System.Windows.Forms.Label();
            this.NotaBaja = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Condicion = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nota4 = new System.Windows.Forms.TextBox();
            this.nota3 = new System.Windows.Forms.TextBox();
            this.nota2 = new System.Windows.Forms.TextBox();
            this.nota1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE PROMEDIOS DE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE DEL ALUMNO";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(28, 97);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(278, 20);
            this.Nombre.TabIndex = 2;
            // 
            // procesar
            // 
            this.procesar.Location = new System.Drawing.Point(28, 123);
            this.procesar.Name = "procesar";
            this.procesar.Size = new System.Drawing.Size(136, 34);
            this.procesar.TabIndex = 3;
            this.procesar.Text = "PROCESAR";
            this.procesar.UseVisualStyleBackColor = true;
            this.procesar.Click += new System.EventHandler(this.procesar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(170, 123);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(136, 34);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "PROMEDIO DE NOTAS";
            // 
            // Promedio
            // 
            this.Promedio.AutoSize = true;
            this.Promedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Promedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Promedio.Location = new System.Drawing.Point(64, 231);
            this.Promedio.Name = "Promedio";
            this.Promedio.Size = new System.Drawing.Size(82, 18);
            this.Promedio.TabIndex = 6;
            this.Promedio.Text = "lblPromedio";
            // 
            // NotaBaja
            // 
            this.NotaBaja.AutoSize = true;
            this.NotaBaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaBaja.Location = new System.Drawing.Point(257, 231);
            this.NotaBaja.Name = "NotaBaja";
            this.NotaBaja.Size = new System.Drawing.Size(77, 18);
            this.NotaBaja.TabIndex = 7;
            this.NotaBaja.Text = "lblMasBaja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(239, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "NOTA MAS BAJA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "CONDICION";
            // 
            // Condicion
            // 
            this.Condicion.AutoSize = true;
            this.Condicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Condicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Condicion.Location = new System.Drawing.Point(439, 231);
            this.Condicion.Name = "Condicion";
            this.Condicion.Size = new System.Drawing.Size(83, 18);
            this.Condicion.TabIndex = 10;
            this.Condicion.Text = "lblCondicion";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nota4);
            this.groupBox1.Controls.Add(this.nota3);
            this.groupBox1.Controls.Add(this.nota2);
            this.groupBox1.Controls.Add(this.nota1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(404, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE NOTAS";
            // 
            // nota4
            // 
            this.nota4.Location = new System.Drawing.Point(238, 64);
            this.nota4.Name = "nota4";
            this.nota4.Size = new System.Drawing.Size(49, 20);
            this.nota4.TabIndex = 19;
            // 
            // nota3
            // 
            this.nota3.Location = new System.Drawing.Point(163, 64);
            this.nota3.Name = "nota3";
            this.nota3.Size = new System.Drawing.Size(49, 20);
            this.nota3.TabIndex = 18;
            // 
            // nota2
            // 
            this.nota2.Location = new System.Drawing.Point(85, 64);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(49, 20);
            this.nota2.TabIndex = 17;
            // 
            // nota1
            // 
            this.nota1.Location = new System.Drawing.Point(9, 64);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(49, 20);
            this.nota1.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(235, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 18);
            this.label12.TabIndex = 16;
            this.label12.Text = "NOTA 4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(160, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "NOTA 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(82, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "NOTA 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "NOTA 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 339);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Condicion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NotaBaja);
            this.Controls.Add(this.Promedio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.procesar);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Button procesar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Promedio;
        private System.Windows.Forms.Label NotaBaja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Condicion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nota1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nota4;
        private System.Windows.Forms.TextBox nota3;
        private System.Windows.Forms.TextBox nota2;
    }
}

