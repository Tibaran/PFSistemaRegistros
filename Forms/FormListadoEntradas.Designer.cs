
namespace ProyectoFinal.Forms
{
    partial class FormListadoEntradas
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
            this.gvEntradasListado = new System.Windows.Forms.DataGridView();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaBusqueda = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdEntrada = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntradasListado)).BeginInit();
            this.SuspendLayout();
            // 
            // gvEntradasListado
            // 
            this.gvEntradasListado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvEntradasListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEntradasListado.Location = new System.Drawing.Point(23, 80);
            this.gvEntradasListado.Name = "gvEntradasListado";
            this.gvEntradasListado.Size = new System.Drawing.Size(754, 339);
            this.gvEntradasListado.TabIndex = 0;
            this.gvEntradasListado.SelectionChanged += new System.EventHandler(this.gvEntradasListado_SelectionChanged);
            // 
            // btnDetalles
            // 
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles.Location = new System.Drawing.Point(143, 32);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(134, 28);
            this.btnDetalles.TabIndex = 1;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(643, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(134, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(526, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha";
            // 
            // dtpFechaBusqueda
            // 
            this.dtpFechaBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaBusqueda.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaBusqueda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaBusqueda.Location = new System.Drawing.Point(529, 34);
            this.dtpFechaBusqueda.Name = "dtpFechaBusqueda";
            this.dtpFechaBusqueda.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaBusqueda.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id de entrada";
            // 
            // txtIdEntrada
            // 
            this.txtIdEntrada.Location = new System.Drawing.Point(23, 34);
            this.txtIdEntrada.Name = "txtIdEntrada";
            this.txtIdEntrada.ReadOnly = true;
            this.txtIdEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtIdEntrada.TabIndex = 7;
            // 
            // FormListadoEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.txtIdEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.gvEntradasListado);
            this.Name = "FormListadoEntradas";
            this.Text = "Listado de Entradas";
            this.Load += new System.EventHandler(this.FormListadoEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEntradasListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvEntradasListado;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdEntrada;
    }
}