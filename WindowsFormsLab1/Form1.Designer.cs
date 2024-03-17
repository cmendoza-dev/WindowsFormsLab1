namespace WindowsFormsLab1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumGuia = new System.Windows.Forms.TextBox();
            this.fecDoc = new System.Windows.Forms.DateTimePicker();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtTnM = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa de Transportes “FAST DRIVER”";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° de Guía: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha del documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre del Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción de la carga:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad de Toneladas Métricas:";
            // 
            // txtNumGuia
            // 
            this.txtNumGuia.Location = new System.Drawing.Point(146, 61);
            this.txtNumGuia.Name = "txtNumGuia";
            this.txtNumGuia.Size = new System.Drawing.Size(86, 20);
            this.txtNumGuia.TabIndex = 6;
            // 
            // fecDoc
            // 
            this.fecDoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecDoc.Location = new System.Drawing.Point(380, 60);
            this.fecDoc.Name = "fecDoc";
            this.fecDoc.Size = new System.Drawing.Size(99, 20);
            this.fecDoc.TabIndex = 7;
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(147, 98);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(332, 20);
            this.txtNomCliente.TabIndex = 8;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(44, 156);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(435, 20);
            this.txtDescrip.TabIndex = 9;
            // 
            // txtTnM
            // 
            this.txtTnM.Location = new System.Drawing.Point(210, 187);
            this.txtTnM.Name = "txtTnM";
            this.txtTnM.Size = new System.Drawing.Size(100, 20);
            this.txtTnM.TabIndex = 10;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(404, 245);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(314, 245);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 291);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTnM);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtNomCliente);
            this.Controls.Add(this.fecDoc);
            this.Controls.Add(this.txtNumGuia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Caso 1 - Lab01 Carlos Mendoza Solis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumGuia;
        private System.Windows.Forms.DateTimePicker fecDoc;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtTnM;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNuevo;
    }
}

