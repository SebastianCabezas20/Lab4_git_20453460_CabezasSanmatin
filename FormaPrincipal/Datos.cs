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
    /// <summary>
    /// Clase del formulario de datos
    /// </summary>
    public partial class Datos : Form
    {
        private string username;
        private string pass;
        /// <summary>
        /// Crea el formulario
        /// </summary>
        public Datos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permite obtener el user 
        /// </summary>
        /// <returns>
        /// String con el user 
        /// </returns>
        public string getUser()
        {
            return this.username;
        }

        /// <summary>
        /// Permite obtener el pass 
        /// </summary>
        /// <returns>
        /// String con el pass
        /// </returns>
        public string getPass()
        {
            return this.pass;
        }

        /// <summary>
        /// Permite ingresar datos
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs</param>
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            this.username = textBoxUser.Text;
            this.pass = textBoxPass.Text;
            this.Close();
        }

        /// <summary>
        /// Permite cerrar el formulario
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
