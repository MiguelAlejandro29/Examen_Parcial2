﻿namespace Examen_Parcial2
{
    partial class FrmPedidos
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
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.bntCancelarP = new System.Windows.Forms.Button();
            this.bntborrarP = new System.Windows.Forms.Button();
            this.bntCambiarP = new System.Windows.Forms.Button();
            this.bntagregarP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpedido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbproducto = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(103, 99);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(302, 20);
            this.txtprecio.TabIndex = 22;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(102, 128);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(302, 20);
            this.txtcantidad.TabIndex = 21;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(103, 47);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(302, 20);
            this.txtcliente.TabIndex = 20;
            // 
            // bntCancelarP
            // 
            this.bntCancelarP.Location = new System.Drawing.Point(305, 168);
            this.bntCancelarP.Name = "bntCancelarP";
            this.bntCancelarP.Size = new System.Drawing.Size(75, 23);
            this.bntCancelarP.TabIndex = 19;
            this.bntCancelarP.Text = "Cancelar";
            this.bntCancelarP.UseVisualStyleBackColor = true;
            // 
            // bntborrarP
            // 
            this.bntborrarP.Location = new System.Drawing.Point(223, 168);
            this.bntborrarP.Name = "bntborrarP";
            this.bntborrarP.Size = new System.Drawing.Size(75, 23);
            this.bntborrarP.TabIndex = 18;
            this.bntborrarP.Text = "Borrar";
            this.bntborrarP.UseVisualStyleBackColor = true;
            // 
            // bntCambiarP
            // 
            this.bntCambiarP.Location = new System.Drawing.Point(142, 168);
            this.bntCambiarP.Name = "bntCambiarP";
            this.bntCambiarP.Size = new System.Drawing.Size(75, 23);
            this.bntCambiarP.TabIndex = 17;
            this.bntCambiarP.Text = "Modificar";
            this.bntCambiarP.UseVisualStyleBackColor = true;
            // 
            // bntagregarP
            // 
            this.bntagregarP.Location = new System.Drawing.Point(61, 168);
            this.bntagregarP.Name = "bntagregarP";
            this.bntagregarP.Size = new System.Drawing.Size(75, 23);
            this.bntagregarP.TabIndex = 16;
            this.bntagregarP.Text = "Agregar";
            this.bntagregarP.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Precio:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre Cliente:";
            // 
            // txtpedido
            // 
            this.txtpedido.Location = new System.Drawing.Point(102, 21);
            this.txtpedido.Name = "txtpedido";
            this.txtpedido.Size = new System.Drawing.Size(302, 20);
            this.txtpedido.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Pedido #";
            // 
            // cbproducto
            // 
            this.cbproducto.FormattingEnabled = true;
            this.cbproducto.Location = new System.Drawing.Point(103, 74);
            this.cbproducto.Name = "cbproducto";
            this.cbproducto.Size = new System.Drawing.Size(301, 21);
            this.cbproducto.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 137);
            this.dataGridView1.TabIndex = 27;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 350);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbproducto);
            this.Controls.Add(this.txtpedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.bntCancelarP);
            this.Controls.Add(this.bntborrarP);
            this.Controls.Add(this.bntCambiarP);
            this.Controls.Add(this.bntagregarP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPedidos";
            this.Text = "FrmPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Button bntCancelarP;
        private System.Windows.Forms.Button bntborrarP;
        private System.Windows.Forms.Button bntCambiarP;
        private System.Windows.Forms.Button bntagregarP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbproducto;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}