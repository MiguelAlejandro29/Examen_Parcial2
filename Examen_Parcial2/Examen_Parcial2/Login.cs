using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatosMysql;
using DatosMysql.Accesos;
using DatosMysql.Entidades;

namespace Examen_Parcial2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntlogin_Click(object sender, EventArgs e)
        {
            BaseDatos basedatos = new BaseDatos();  
            Usuarios usuarios = new Usuarios();

            usuarios = basedatos.Login(txtusuario.Text, txtContraseña.Text);


            if(usuarios == null)
            {
                MessageBox.Show("Usuario/Contraseña incorrecto");
                return;
            }   
            
            FrmMenu frmMenu = new FrmMenu();    
            frmMenu.ShowDialog();
            this.Hide();
        }
    }
}
