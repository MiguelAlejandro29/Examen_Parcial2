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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
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
            // 
            // bntCambiar
            // 
            this.bntCambiar.Location = new System.Drawing.Point(279, 80);
            this.bntCambiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntCambiar.Name = "bntCambiar";
            this.bntCambiar.Size = new System.Drawing.Size(100, 28);
            this.bntCambiar.TabIndex = 5;
            this.bntCambiar.Text = "Modificar";
            this.bntCambiar.UseVisualStyleBackColor = true;
            // 
            // bntborrar
            // 
            this.bntborrar.Location = new System.Drawing.Point(279, 44);
            this.bntborrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntborrar.Name = "bntborrar";
            this.bntborrar.Size = new System.Drawing.Size(100, 28);
            this.bntborrar.TabIndex = 6;
            this.bntborrar.Text = "Borrar";
            this.bntborrar.UseVisualStyleBackColor = true;
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(279, 116);
            this.bntCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(100, 28);
            this.bntCancelar.TabIndex = 7;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(97, 25);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(170, 22);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(97, 87);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(170, 22);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(97, 57);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(170, 22);
            this.txtDescripcion.TabIndex = 11;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 172);
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
    }
}