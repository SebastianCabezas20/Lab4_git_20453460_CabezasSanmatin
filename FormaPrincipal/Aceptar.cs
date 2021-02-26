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
    public partial class Aceptar : Form
    {
        Sistema sistema;
        public Aceptar(Sistema sistem)
        {
            InitializeComponent();
            this.sistema = sistem;
        }

        private void dataGridViewPreguntasAccept_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;//Index de la fila click
            if (index >= 0)
            {
                int ID = Convert.ToInt32(dataGridViewPreguntasAccept.Rows[index].Cells[2].Value);
                RespuestasAccept formAceptar = new RespuestasAccept(ID, sistema);
                formAceptar.ShowDialog();
            }
        }

        private void Aceptar_Load(object sender, EventArgs e)
        {
            int indexUsuario = this.sistema.getIndexActivo;
            for (int i = 0; i < this.sistema.GetListaPreguntas.cantidadPreguntas(); i++)
            {
                //Si la pregunta es del usuario
                if (this.sistema.GetListaPreguntas.getPreguntaIndex(i).getAutor().Equals(
                    this.sistema.GetListaUsuarios.getUsuario(indexUsuario).getUsername()))
                {
                    int indexData = dataGridViewPreguntasAccept.Rows.Add();
                    dataGridViewPreguntasAccept.Rows[indexData].Cells[0].Value = this.sistema.GetListaPreguntas.getPreguntaIndex(i).getTitulo();
                    dataGridViewPreguntasAccept.Rows[indexData].Cells[1].Value = this.sistema.GetListaPreguntas.getPreguntaIndex(i).getContenido();
                    dataGridViewPreguntasAccept.Rows[indexData].Cells[2].Value = this.sistema.GetListaPreguntas.getPreguntaIndex(i).getID();
                }

            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
