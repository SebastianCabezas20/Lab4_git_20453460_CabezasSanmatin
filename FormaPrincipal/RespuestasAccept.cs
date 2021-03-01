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
    /// Clase del formulario de respuestas a aceptar
    /// </summary>
    public partial class RespuestasAccept : Form
    {
        private Sistema sistema;
        private int IDPregunta;
        /// <summary>
        /// Permite crear el formulario
        /// </summary>
        /// <param name="ID">Numero entero.</param>
        /// <param name="sistem">Clase sistema.</param>
        public RespuestasAccept(int ID, Sistema sistem)
        {
            InitializeComponent();
            this.sistema = sistem;
            this.IDPregunta = ID;
        }

        /// <summary>
        /// Accion de click al boton de aceptar
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void dataGridViewRespuestas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexFila = e.RowIndex;//Index de la fila   
            int indexColumna = e.ColumnIndex; //index de la columna
            if (indexFila >= 0 && indexColumna == 3)//Si no es el titulo y es el boton
            {
                //Recuperar el ID
                int IDRespuesta = Convert.ToInt32(dataGridViewRespuestas.Rows[indexFila].Cells[2].Value);
                sistema.accept(this.IDPregunta, IDRespuesta);//Aceptamos mediante el metodo
                MessageBox.Show("Respuesta aceptada");
                dataGridViewRespuestas.Rows.RemoveAt(indexFila);//Removemos

            }

        }

        /// <summary>
        /// Permite cargar las respuesta para aceptar
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void RespuestasAccept_Load(object sender, EventArgs e)
        {
            int mostrar = 0;
            for (int i = 0; i < sistema.GetListaRespuestas.cantidadRespuestas(); i++)
            {
                if (sistema.GetListaRespuestas.verificarRespuestaNoAceptada(IDPregunta, i))
                {
                    int indexData = dataGridViewRespuestas.Rows.Add();
                    dataGridViewRespuestas.Rows[indexData].Cells[0].Value = this.sistema.GetListaRespuestas.gerRespuetaIndex(i).getContenido;
                    dataGridViewRespuestas.Rows[indexData].Cells[1].Value = this.sistema.GetListaRespuestas.gerRespuetaIndex(i).getAutor();
                    dataGridViewRespuestas.Rows[indexData].Cells[2].Value = this.sistema.GetListaRespuestas.gerRespuetaIndex(i).getID();
                    dataGridViewRespuestas.Rows[indexData].Cells[3].Value = "Aceptar";
                    mostrar = 1;

                }
            }
            if (mostrar == 0)
            {
                dataGridViewRespuestas.Hide();
                labelAviso.Text = "NO TIENE PREGUNTAS PENDIENTES";
            }
            else
            {
                labelAviso.Hide();
            }
            
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
