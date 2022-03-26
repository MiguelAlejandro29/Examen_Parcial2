namespace Examen_Parcial2
{
    partial class FrmProductos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntagregar = new System.Windows.Forms.Button();
            this.bntCambiar = new System.Windows.Forms.Button();
            this.bntborrar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.bntGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // bntagregar
            // 
            this.bntagregar.Location = new System.Drawing.Point(279, 6);
            this.bntagregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntagregar.Name = "bntagregar";
            this.bntagregar.Size = new System.Drawing.Size(100, 28);
            this.bntagregar.TabIndex = 4;
            this.bntagregar.Text = "Agregar";
            this.bntagregar.UseVisualStyleBackColor = true;
            this.bntagregar.Click += new System.EventHandler(this.bntagregar_Click);
            // 
            // bntCambiar
            // 
            this.bntCambiar.Location = new System.Drawing.Point(280, 111);
            this.bntCambiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntCambiar.Name = "bntCambiar";
            this.bntCambiar.Size = new System.Drawing.Size(100, 28);
            this.bntCambiar.TabIndex = 5;
            this.bntCambiar.Text = "Modificar";
            this.bntCambiar.UseVisualStyleBackColor = true;
            this.bntCambiar.Click += new System.EventHandler(this.bntCambiar_Click);
            // 
            // bntborrar
            // 
            this.bntborrar.Location = new System.Drawing.Point(280, 75);
            this.bntborrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntborrar.Name = "bntborrar";
            this.bntborrar.Size = new System.Drawing.Size(100, 28);
            this.bntborrar.TabIndex = 6;
            this.bntborrar.Text = "Borrar";
            this.bntborrar.UseVisualStyleBackColor = true;
            this.bntborrar.Click += new System.EventHandler(this.bntborrar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Enabled = false;
            this.bntCancelar.Location = new System.Drawing.Point(280, 147);
            this.bntCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(100, 28);
            this.bntCancelar.TabIndex = 7;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(98, 44);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(170, 22);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(98, 106);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(170, 22);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(98, 76);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(170, 22);
            this.txtDescripcion.TabIndex = 11;
            // 
            // bntGuardar
            // 
            this.bntGuardar.Enabled = false;
            this.bntGuardar.Location = new System.Drawing.Point(280, 42);
            this.bntGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.bntGuardar.Name = "bntGuardar";
            this.bntGuardar.Size = new System.Drawing.Size(100, 28);
            this.bntGuardar.TabIndex = 12;
            this.bntGuardar.Text = "Guardar";
            this.bntGuardar.UseVisualStyleBackColor = true;
            this.bntGuardar.Click += new System.EventHandler(this.bntGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(354, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 342);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bntGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.bntborrar);
            this.Controls.Add(this.bntCambiar);
            this.Controls.Add(this.bntagregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntagregar;
        private System.Windows.Forms.Button bntCambiar;
        private System.Windows.Forms.Button bntborrar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button bntGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}