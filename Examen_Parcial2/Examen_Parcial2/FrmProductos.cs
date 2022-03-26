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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        Productos producto = new Productos();
        BAProdcutos productosBD = new BAProdcutos();
        string operacion = string.Empty;

        private void bntagregar_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Agregar";
            
        }

        private void HabilitarControles()
        {
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            bntagregar.Enabled = false;   
            bntCambiar.Enabled = false;
            bntCancelar.Enabled = true;
            bntGuardar.Enabled = true;
        }

        private void DeshabilitarControles()
        {
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
            bntagregar.Enabled = true;
            bntCambiar.Enabled = true;
            bntCancelar.Enabled = false;
            bntGuardar.Enabled = false;
        }

        private void LimpiarControles()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            
        }


        private void bntGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    errorProvider1.SetError(txtCodigo, "Ingrese el Codigo");
                    txtCodigo.Focus();
                    return;

                }
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    errorProvider1.SetError(txtDescripcion, "Ingrese Descripcion");
                    txtDescripcion.Focus();
                    return;

                }
                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    errorProvider1.SetError(txtPrecio, "Ingrese Precio");
                    txtPrecio.Focus();
                    return;

                }


                producto.CodigoP = txtCodigo.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.Precio = Convert.ToDecimal(txtPrecio.Text);

                if (operacion == "Agregar")
                {
                    bool agregar = productosBD.AgregarProducto(producto);

                    if (agregar)
                    {
                        MessageBox.Show("Producto Agregado");
                        ListarProductos();
                        DeshabilitarControles();
                        LimpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("No se PUdo agregar el Producto");
                    }
                }
                else if(operacion == "Modificar")
                {
                    bool modificar = productosBD.AgregarProducto(producto);

                    if (modificar)
                    {
                        MessageBox.Show("Producto Modificado");
                        ListarProductos();
                        DeshabilitarControles();
                        LimpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("No se Pudo modificar el Producto");
                    }

                }
                
            }
            catch (Exception)
            {

                
            }
           
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            ListarProductos();

        }

        private void ListarProductos()
        {
            dataGridView1.DataSource = productosBD.ListarProductos();
        }

        private void bntCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = "Modificar";

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    txtCodigo.Text = dataGridView1.CurrentRow.Cells["CodigoP"].Value.ToString();
                    txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                    txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                    HabilitarControles();



                }

            }
            catch (Exception)
            {

            }
     

        }

        private void bntborrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool eliminar = productosBD.EliminarProducto(dataGridView1.CurrentRow.Cells["CodigoP"].Value.ToString());

                if (eliminar)
                {
                    MessageBox.Show("Producto eliminado");
                    ListarProductos();

                }
                else
                {
                    MessageBox.Show("No se Pudo eliminar el Producto");
                }
            }

        }
    }
}
