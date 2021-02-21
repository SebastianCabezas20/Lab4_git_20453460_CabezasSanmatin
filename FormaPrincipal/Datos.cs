using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaPrincipal
{
    public partial class Datos : Form
    {
        private string username;
        private string pass;
        public Datos()
        {
            InitializeComponent();
        }

        public string getUser()
        {
            return this.username;
        }
        public string getPass()
        {
            return this.pass;
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            this.username = textBoxUser.Text;
            this.pass = textBoxPass.Text;
            this.Close();
        }
    

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
