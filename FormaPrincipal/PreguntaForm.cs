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
    public partial class PreguntaForm : Form
    {
        Sistema sistema;
        private string titulo;
        private string contenido;
        private ListaEtiquetas listaEtiquetas;

        public PreguntaForm(Sistema sis)
        {
            InitializeComponent();
            this.sistema = sis;
            this.listaEtiquetas = new ListaEtiquetas();

        }

        public string getTitulo()
        {
            return titulo;
        }

        public string getContenido()
        {
            return contenido;
        }

        public ListaEtiquetas getListaEtiquetas
        {
            get
            {
                return this.listaEtiquetas;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        private void checkedListBoxEtiquetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBoxEtiquetas.SelectedIndex;
            labelDescripcion.Text = sistema.GetListaEtiquetas.getEtiqueta(index).getDescripcion();
        }

        private void PreguntaForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.sistema.GetListaEtiquetas.cantidadEtiquetas(); i++)
            {
                checkedListBoxEtiquetas.Items.Add(this.sistema.GetListaEtiquetas.getEtiqueta(i).getEtiqueta(), false);

            }
        }
    }
}
