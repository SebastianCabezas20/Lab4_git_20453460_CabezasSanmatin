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
    public partial class Votar : Form
    {
        Sistema sistema;
        public Votar(Sistema sistem)
        {
            InitializeComponent();
            this.sistema = sistem;
        }

        private void Votar_Load(object sender, EventArgs e)
        {
            //Cargar preguntas
            for (int i = 0; i < sistema.GetListaPreguntas.cantidadPreguntas(); i++)
            {

                //NO ser del usuario
                if (!this.sistema.GetListaPreguntas.getPreguntaIndex(i).getAutor().Equals
                    (this.sistema.GetListaUsuarios.getUsuario(this.sistema.getIndexActivo).getUsername()))
                {
                    int indexData = dataGridViewVotar.Rows.Add();
                    dataGridViewVotar.Rows[indexData].Cells[0].Value = this.sistema.GetListaPreguntas.getPreguntaIndex(i).getContenido();
                    dataGridViewVotar.Rows[indexData].Cells[1].Value = "Pregunta";
                    dataGridViewVotar.Rows[indexData].Cells[2].Value = this.sistema.GetListaPreguntas.getPreguntaIndex(i).GetDate;
                    dataGridViewVotar.Rows[indexData].Cells[3].Value = this.sistema.GetListaPreguntas.getPreguntaIndex(i).getVotoPositivos;
                    dataGridViewVotar.Rows[indexData].Cells[4].Value = this.sistema.GetListaPreguntas.getPreguntaIndex(i).getVotoNegativos;
                    dataGridViewVotar.Rows[indexData].Cells[5].Value = "Positivo";
                    dataGridViewVotar.Rows[indexData].Cells[6].Value = "Negativo";
                    dataGridViewVotar.Rows[indexData].Cells[7].Value = this.sistema.GetListaPreguntas.getPreguntaIndex(i).getID();
                }
            }
            //Cargar respuestas
            for (int i = 0; i < sistema.GetListaRespuestas.cantidadRespuestas(); i++)
            {
                //NO ser del usuario y SI aceptada
                if (this.sistema.GetListaRespuestas.gerRespuetaIndex(i).getEstado() && !this.sistema.GetListaRespuestas.gerRespuetaIndex(i).getAutor().Equals
                    (this.sistema.GetListaUsuarios.getUsuario(this.sistema.getIndexActivo).getUsername()))
                {
                    int indexData = dataGridViewVotar.Rows.Add();
                    dataGridViewVotar.Rows[indexData].Cells[0].Value = this.sistema.GetListaRespuestas.gerRespuetaIndex(i).getContenido;
                    dataGridViewVotar.Rows[indexData].Cells[1].Value = "Respuesta";
                    dataGridViewVotar.Rows[indexData].Cells[2].Value = this.sistema.GetListaRespuestas.gerRespuetaIndex(i).GetDate;
                    dataGridViewVotar.Rows[indexData].Cells[3].Value = this.sistema.GetListaRespuestas.gerRespuetaIndex(i).getVotoPositivos;
                    dataGridViewVotar.Rows[indexData].Cells[4].Value = this.sistema.GetListaRespuestas.gerRespuetaIndex(i).getVotoNegativos;
                    dataGridViewVotar.Rows[indexData].Cells[5].Value = "Positivo";
                    dataGridViewVotar.Rows[indexData].Cells[6].Value = "Negativo";
                    dataGridViewVotar.Rows[indexData].Cells[7].Value = this.sistema.GetListaRespuestas.gerRespuetaIndex(i).getID();
                }
            }
            //Ordenar de forma ascendente
            dataGridViewVotar.Sort(dataGridViewVotar.Columns["ColumnFecha"], ListSortDirection.Ascending);
        }

        private void dataGridViewVotar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexColumna = e.ColumnIndex;
            int indexFila = e.RowIndex;
            //Positivo
            //Boton positivo
            if (indexFila >= 0 && indexColumna == 5)
            {
                sistema.vote(Convert.ToInt32(dataGridViewVotar.Rows[indexFila].Cells[7].Value), true);
                int cantidad = Convert.ToInt32(dataGridViewVotar.Rows[indexFila].Cells[3].Value);
                dataGridViewVotar.Rows[indexFila].Cells[3].Value = cantidad + 1;
            }
            //Negativo
            //Boton positivo
            else if (indexFila >= 0 && indexColumna == 6)
            {
                //Funcion vote y aumentar votos
                sistema.vote(Convert.ToInt32(dataGridViewVotar.Rows[indexFila].Cells[7].Value), false);
                int cantidad = Convert.ToInt32(dataGridViewVotar.Rows[indexFila].Cells[4].Value);
                dataGridViewVotar.Rows[indexFila].Cells[4].Value = cantidad + 1;
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
