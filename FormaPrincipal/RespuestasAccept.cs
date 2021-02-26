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
    public partial class RespuestasAccept : Form
    {
        private Sistema sistema;
        private int IDPregunta;
        public RespuestasAccept(int ID, Sistema sistem)
        {
            InitializeComponent();
            this.sistema = sistem;
            this.IDPregunta = ID;
        }

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
            }
            //ADv lal Vis
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
