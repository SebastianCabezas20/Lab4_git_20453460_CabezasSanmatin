using System;
using System.Windows.Forms;
using Codigo;

namespace FormaPrincipal
{
    /// <summary>
    /// Clase de la forma aceptar
    /// </summary>
    public partial class Aceptar : Form
    {
       
        Sistema sistema;
        /// <summary>
        /// Permite crear una forma aceptar
        /// </summary>
        /// <param name="sistem">Clase Sistema.</param>
        public Aceptar(Sistema sistem)
        {
            InitializeComponent();
            this.sistema = sistem;
        }

        /// <summary>
        /// Evento de hacer doble click en la celda 
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void dataGridViewPreguntasAccept_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;//Index de la fila click
            if (index >= 0)//Si no el titulo
            {
                //Convertir el ID de la pregunta
                int ID = Convert.ToInt32(dataGridViewPreguntasAccept.Rows[index].Cells[2].Value);
                RespuestasAccept formAceptar = new RespuestasAccept(ID, sistema);
                formAceptar.ShowDialog();
            }
        }

        /// <summary>
        /// Permite cargar las preguntas del usuario 
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void Aceptar_Load(object sender, EventArgs e)
        {
            int indexUsuario = this.sistema.getIndexActivo;//Index del usuario
            for (int i = 0; i < this.sistema.GetListaPreguntas.cantidadPreguntas(); i++)
            {
                //Si la pregunta es del usuario
                if (this.sistema.GetListaPreguntas.getPreguntaIndex(i).getAutor().Equals(
                    this.sistema.GetListaUsuarios.getUsuario(indexUsuario).getUsername()))
                {
                    //Se agrega pregunta
                    int indexData = dataGridViewPreguntasAccept.Rows.Add();
                    dataGridViewPreguntasAccept.Rows[indexData].Cells[0].Value = this.sistema.GetListaPreguntas.getPreguntaIndex(i).getTitulo();
                    dataGridViewPreguntasAccept.Rows[indexData].Cells[1].Value = this.sistema.GetListaPreguntas.getPreguntaIndex(i).getContenido();
                    dataGridViewPreguntasAccept.Rows[indexData].Cells[2].Value = this.sistema.GetListaPreguntas.getPreguntaIndex(i).getID();
                }

            }
        }

        /// <summary>
        /// Permite cerrar el formulario 
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
