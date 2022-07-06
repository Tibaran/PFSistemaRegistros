
namespace ProyectoFinal.Forms
{
    partial class FormDetalles
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtIdEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDetallesHead = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.gboxEntrada = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gboxPersona = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.lblTitleDetalles = new System.Windows.Forms.Label();
            this.panelDetallesHead.SuspendLayout();
            this.gboxEntrada.SuspendLayout();
            this.gboxPersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(226, 387);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 35);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtIdEntrada
            // 
            this.txtIdEntrada.Location = new System.Drawing.Point(9, 42);
            this.txtIdEntrada.Name = "txtIdEntrada";
            this.txtIdEntrada.ReadOnly = true;
            this.txtIdEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtIdEntrada.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id de Entrada";
            // 
            // panelDetallesHead
            // 
            this.panelDetallesHead.BackColor = System.Drawing.Color.Transparent;
            this.panelDetallesHead.Controls.Add(this.lblTitleDetalles);
            this.panelDetallesHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetallesHead.Location = new System.Drawing.Point(0, 0);
            this.panelDetallesHead.Name = "panelDetallesHead";
            this.panelDetallesHead.Size = new System.Drawing.Size(526, 60);
            this.panelDetallesHead.TabIndex = 3;
            this.panelDetallesHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDetallesHead_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(125, 92);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 5;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(9, 92);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 6;
            // 
            // gboxEntrada
            // 
            this.gboxEntrada.Controls.Add(this.label5);
            this.gboxEntrada.Controls.Add(this.txtMotivo);
            this.gboxEntrada.Controls.Add(this.txtDestino);
            this.gboxEntrada.Controls.Add(this.label4);
            this.gboxEntrada.Controls.Add(this.label3);
            this.gboxEntrada.Controls.Add(this.label1);
            this.gboxEntrada.Controls.Add(this.txtFecha);
            this.gboxEntrada.Controls.Add(this.txtIdEntrada);
            this.gboxEntrada.Controls.Add(this.txtHora);
            this.gboxEntrada.Controls.Add(this.label2);
            this.gboxEntrada.Location = new System.Drawing.Point(12, 66);
            this.gboxEntrada.Name = "gboxEntrada";
            this.gboxEntrada.Size = new System.Drawing.Size(297, 315);
            this.gboxEntrada.TabIndex = 7;
            this.gboxEntrada.TabStop = false;
            this.gboxEntrada.Text = "Detalles de Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(12, 145);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(279, 20);
            this.txtDestino.TabIndex = 9;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(12, 193);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(279, 96);
            this.txtMotivo.TabIndex = 10;
            this.txtMotivo.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Motivo";
            // 
            // gboxPersona
            // 
            this.gboxPersona.Controls.Add(this.txtSexo);
            this.gboxPersona.Controls.Add(this.label10);
            this.gboxPersona.Controls.Add(this.txtEdad);
            this.gboxPersona.Controls.Add(this.label9);
            this.gboxPersona.Controls.Add(this.txtDni);
            this.gboxPersona.Controls.Add(this.label8);
            this.gboxPersona.Controls.Add(this.txtApellido);
            this.gboxPersona.Controls.Add(this.label7);
            this.gboxPersona.Controls.Add(this.txtNombre);
            this.gboxPersona.Controls.Add(this.label6);
            this.gboxPersona.Location = new System.Drawing.Point(318, 66);
            this.gboxPersona.Name = "gboxPersona";
            this.gboxPersona.Size = new System.Drawing.Size(192, 315);
            this.gboxPersona.TabIndex = 8;
            this.gboxPersona.TabStop = false;
            this.gboxPersona.Text = "Detalles del Ingresante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(10, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(148, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(10, 92);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(148, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(10, 145);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(119, 20);
            this.txtDni.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(10, 194);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(50, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Sexo";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(78, 193);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(51, 20);
            this.txtSexo.TabIndex = 9;
            // 
            // lblTitleDetalles
            // 
            this.lblTitleDetalles.AutoSize = true;
            this.lblTitleDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDetalles.ForeColor = System.Drawing.Color.White;
            this.lblTitleDetalles.Location = new System.Drawing.Point(242, 20);
            this.lblTitleDetalles.Name = "lblTitleDetalles";
            this.lblTitleDetalles.Size = new System.Drawing.Size(67, 20);
            this.lblTitleDetalles.TabIndex = 0;
            this.lblTitleDetalles.Text = "Detalles";
            // 
            // FormDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 431);
            this.Controls.Add(this.gboxPersona);
            this.Controls.Add(this.gboxEntrada);
            this.Controls.Add(this.panelDetallesHead);
            this.Controls.Add(this.btnSalir);
            this.Name = "FormDetalles";
            this.Text = "FormDetalles";
            this.Load += new System.EventHandler(this.FormDetalles_Load);
            this.panelDetallesHead.ResumeLayout(false);
            this.panelDetallesHead.PerformLayout();
            this.gboxEntrada.ResumeLayout(false);
            this.gboxEntrada.PerformLayout();
            this.gboxPersona.ResumeLayout(false);
            this.gboxPersona.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtIdEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDetallesHead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.GroupBox gboxEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtMotivo;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gboxPersona;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTitleDetalles;
    }
}