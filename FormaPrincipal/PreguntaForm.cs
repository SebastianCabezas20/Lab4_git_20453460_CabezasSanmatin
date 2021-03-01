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
    /// <summary>
    /// Clase formulario de informacion de la pregunta
    /// </summary>
    public partial class PreguntaForm : Form
    {
        Sistema sistema;
        private string titulo;
        private string contenido;
        private ListaEtiquetas listaEtiquetas;

        /// <summary>
        /// Permite crear un formulario para la informacion de los datos
        /// </summary>
        /// <param name="sis">Sistema.</param>
        public PreguntaForm(Sistema sis)
        {
            InitializeComponent();
            this.sistema = sis;
            this.listaEtiquetas = new ListaEtiquetas();

        }

        /// <summary>
        /// Permite obtener el titulo de la pregunta
        /// </summary>
        /// <returns>
        /// String con el titulo de la pregunta
        /// </returns>
        public string getTitulo()
        {
            return titulo;
        }

        /// <summary>
        /// Permite obtener el contenido de la pregunta
        /// </summary>
        /// <returns>
        /// String con el contenido de la pregunta
        /// </returns>
        public string getContenido()
        {
            return contenido;
        }

        /// <summary>
        /// Permite obtener la lista de etiquetas
        /// </summary>
        /// <returns>
        /// Clase lista de etiquetas 
        /// </returns>
        public ListaEtiquetas getListaEtiquetas
        {
            get
            {
                return this.listaEtiquetas;
            }
        }

        /// <summary>
        /// Permite cerrar la forma
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Permite aceptar la informacion
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.titulo = textBoxTitulo.Text;
            this.contenido = textBoxPregunta.Text;
            for (int i = 0; i < checkedListBoxEtiquetas.Items.Count; i++)
            {
                if (checkedListBoxEtiquetas.GetItemChecked(i))
                {
                    this.listaEtiquetas.agregarEtiqueta(sistema.GetListaEtiquetas.getEtiqueta(i));
                }
            }
            Close();
        }

        /// <summary>
        /// Accion de checked de la list box de etiquetas
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void checkedListBoxEtiquetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBoxEtiquetas.SelectedIndex;
            labelDescripcion.Text = sistema.GetListaEtiquetas.getEtiqueta(index).getDescripcion();
        }

        /// <summary>
        /// Permite cargar etiquetas y labels
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void PreguntaForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.sistema.GetListaEtiquetas.cantidadEtiquetas(); i++)
            {
                checkedListBoxEtiquetas.Items.Add(this.sistema.GetListaEtiquetas.getEtiqueta(i).getEtiqueta(), false);

            }
            labelDescripcion.Text = "";
        }

        /// <summary>
        /// Permite agregar una etiqueta a la lista de etiquetas
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void buttonAgregarEtiqueta_Click(object sender, EventArgs e)
        {
            if (textBoxDescripcion.Text != "" && textBoxNombre.Text != "")
            {
                sistema.GetListaEtiquetas.agregarEtiqueta(new Etiqueta(textBoxNombre.Text,textBoxDescripcion.Text));
                checkedListBoxEtiquetas.Items.Add(textBoxNombre.Text,false);
                MessageBox.Show("Etiqueta agregada");

            }
            else
            {
                MessageBox.Show("Completar informacion");
            }
        }
    }
}
