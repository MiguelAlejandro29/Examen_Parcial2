using DatosMysql.Accesos;
using DatosMysql.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Parcial2
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        Pedidos pedidos = new Pedidos();
        PedidosBD pedidosBD = new PedidosBD();
        string operacion = string.Empty;


        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            ListarPedido();

        }
      

        private void ListarPedido()
        {
            dataGridView1.DataSource = pedidosBD.ListaPedido();
        }


        private void bntagregarP_Click(object sender, EventArgs e)
        {
            Hablitarcontroles();
            operacion = "Agregar";
        }

        private void Hablitarcontroles()
        {
            txtcliente.Enabled = true;
            txtpedido.Enabled = true;
            txtprecio.Enabled = true;
            txtcantidad.Enabled = true;
            cbproducto.Enabled = true;

            bntagregarP.Enabled = false;
            bntAceptar.Enabled = true;
            bntCancelarP.Enabled = true;
            bntBorrar.Enabled = false;
            bntCambiarP.Enabled = false;
        }

        private void Deshablitarcontroles()
        {
            txtcliente.Enabled = false;
            txtpedido.Enabled = false;
            txtprecio.Enabled = false;
            txtcantidad.Enabled = false;
            cbproducto.Enabled = false;

            bntagregarP.Enabled = true;
            bntAceptar.Enabled = false;
            bntCancelarP.Enabled = false;
            bntBorrar.Enabled = true;
            bntCambiarP.Enabled = true;
        }

        private void Limpiarcontroles()
        {
            txtcliente.Clear();
            txtpedido.Clear();
            txtprecio.Clear();
            txtcantidad.Clear();
            cbproducto.Text = string.Empty;
    
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bntAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtcliente.Text))
                {
                    errorProvider1.SetError(txtcliente, "Ingrese el Nombre del Cliente");
                    txtcliente.Focus();
                    return;

                }
                if (string.IsNullOrEmpty(txtcantidad.Text))
                {
                    errorProvider1.SetError(txtcantidad, "Ingrese Cantidad");
                    txtcantidad.Focus();
                    return;

                }
                if (string.IsNullOrEmpty(txtprecio.Text))
                {
                    errorProvider1.SetError(txtprecio, "Ingrese Precio");
                    txtprecio.Focus();
                    return;

                }
                if (string.IsNullOrEmpty(cbproducto.Text))
                {
                    errorProvider1.SetError(cbproducto, "Seleccione el Producto que desea");
                    cbproducto.Focus();
                    return;

                }

                pedidos.Producto = cbproducto.Text;
                pedidos.Nombre_Cliente = txtcliente.Text;
                pedidos.Cantidad = Convert.ToInt32(txtcantidad.Text);
                pedidos.Precio = Convert.ToDecimal(txtprecio.Text);

                if (operacion == "Agregar")
                {
                    bool inserto = pedidosBD.InsertarPedido(pedidos);

                    if (inserto)
                    {
                        MessageBox.Show("Pedido Agregado");
                        ListarPedido();
                        Deshablitarcontroles();
                        Limpiarcontroles();
                    }
                    else
                    {
                        MessageBox.Show("No se Pudo agregar el Pedido");
                    }
                }
                else if (operacion == "Modificar")
                {
                    bool modificar = pedidosBD.ModificarPedido(pedidos);
                    
                    if (modificar)
                    {
                        MessageBox.Show("Pedido Modificado");
                        ListarPedido();
                        Deshablitarcontroles();
                        Limpiarcontroles();
                    }
                    else
                    {
                        MessageBox.Show("No se Pudo modificarr el Pedido");
                    }
                }
                
            }
            catch (Exception)
            {

                
            }
            

        }

        private void bntCambiarP_Click(object sender, EventArgs e)
        {
            
            operacion = "Modificar";

            if(dataGridView1.SelectedRows.Count > 0)
            {
                cbproducto.Text = dataGridView1.CurrentRow.Cells["Producto"].Value.ToString();
                txtcliente.Text = dataGridView1.CurrentRow.Cells["Nombre_Cliente"].Value.ToString();
                txtcantidad.Text= dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
                txtprecio.Text= dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                Hablitarcontroles();


            }
        }

        private void bntBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               bool eliminar  = pedidosBD.EliminarPedido(dataGridView1.CurrentRow.Cells["Nombre_Cliente"].Value.ToString());

                if (eliminar)
                {
                    MessageBox.Show("Pedido eliminado");
                    ListarPedido();
                    
                }
                else
                {
                    MessageBox.Show("No se Pudo eliminar el Pedido");
                }
            }



            }
    }
}
