﻿namespace WindowsFormsApp1
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
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcondicion = new System.Windows.Forms.TextBox();
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(111, 30);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(135, 26);
            this.txtnota1.TabIndex = 0;
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(111, 90);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(135, 26);
            this.txtnota2.TabIndex = 1;
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(111, 159);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(135, 26);
            this.txtnota3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nota 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota 3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(12, 213);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(155, 47);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "condición";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "el promedio es:";
            // 
            // txtcondicion
            // 
            this.txtcondicion.Location = new System.Drawing.Point(166, 355);
            this.txtcondicion.Name = "txtcondicion";
            this.txtcondicion.Size = new System.Drawing.Size(135, 26);
            this.txtcondicion.TabIndex = 8;
            // 
            // txtpromedio
            // 
            this.txtpromedio.Location = new System.Drawing.Point(166, 292);
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.Size = new System.Drawing.Size(135, 26);
            this.txtpromedio.TabIndex = 7;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(200, 213);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(101, 41);
            this.btnnuevo.TabIndex = 11;
            this.btnnuevo.Text = "limpiar";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 438);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcondicion);
            this.Controls.Add(this.txtpromedio);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcondicion;
        private System.Windows.Forms.TextBox txtpromedio;
        private System.Windows.Forms.Button btnnuevo;
    }
}

