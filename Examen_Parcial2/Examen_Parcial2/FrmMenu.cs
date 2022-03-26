using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen_Parcial2
{
    public partial class FrmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        FrmProductos frmProductos = null;
        FrmPedidos frmPedidos = null;



        private void ProductosbntTool_Click(object sender, EventArgs e)
        {
            if (frmProductos == null)
            {
                FrmProductos frmProductos = new FrmProductos();
                frmProductos.MdiParent = this;
                frmProductos.Show();
            }
            else
            {
                frmProductos.Activate();

            }

        }

        private void PedidosbntTool_Click(object sender, EventArgs e)
        {
            if (frmProductos == null)
            {
                FrmPedidos frmPedidos = new FrmPedidos();
                frmPedidos.MdiParent = this;
                frmPedidos.Show();
            }
            else
            {
                frmPedidos.Activate();

            }

        }

        private void toolStripTabItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
