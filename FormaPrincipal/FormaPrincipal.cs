using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codigo;

namespace FormaPrincipal
{
    public partial class FormaPrincipal : Form
    {
        Sistema sistema;
        public FormaPrincipal()
        {
            InitializeComponent();
            this.sistema = new Sistema();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Datos formDatos = new Datos();
            if(formDatos.ShowDialog() == DialogResult.OK)
            {
                if(sistema.login(formDatos.getUser(), formDatos.getUser()))
                {
                    MessageBox.Show("Autenticado con exito");
                    labelNombreUser.Text = this.sistema.GetListaUsuarios.getUsuario(this.sistema.getIndexActivo).getUsername();
                }
                else
                {
                    MessageBox.Show("Error al autenticar");
                }
            }

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Datos formRegister = new Datos();
            if (formRegister.ShowDialog() == DialogResult.OK)
            {
                if (sistema.Register(formRegister.getUser(), formRegister.getPass()))
                {
                    MessageBox.Show("Se agrego correctamente");
                    
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Datos formLogout = new Datos();
            if (formLogout.ShowDialog() == DialogResult.OK)
            {
                if (sistema.logout(formLogout.getUser(), formLogout.getPass()))
                {
                    MessageBox.Show("Sesion cerrada con exito");
                    labelNombreUser.Hide();
                }
                else
                {
                    MessageBox.Show("Error al cerrar sesion");
                }
            }
        }
    }
}
