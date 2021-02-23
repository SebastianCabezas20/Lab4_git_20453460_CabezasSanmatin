﻿using System;
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
    public partial class Respuestas : Form
    {
        private Sistema sistema;
        private int IDPregunta;

        public Respuestas(Sistema sistem,int ID)
        {
            InitializeComponent();
            this.IDPregunta = ID;
            this.sistema = sistem;
        }

        private void Respuestas_Load(object sender, EventArgs e)
        {
            //Datagridview, Cargar respuestas
            for (int i = 0; i < this.sistema.GetListaRespuestas.cantidadRespuestas(); i++)
            {
                if (this.sistema.GetListaRespuestas.verificarRespuesta(sistema.GetListaPreguntas.getPregunta(this.IDPregunta).getID(), i))
                {
                    int indexData = dataGridViewRespuestas.Rows.Add();
                    dataGridViewRespuestas.Rows[indexData].Cells[0].Value = sistema.GetListaRespuestas.gerRespuetaIndex(i).getContenido;
                    dataGridViewRespuestas.Rows[indexData].Cells[1].Value = sistema.GetListaRespuestas.gerRespuetaIndex(i).getAutor();
                    dataGridViewRespuestas.Rows[indexData].Cells[2].Value = sistema.GetListaRespuestas.gerRespuetaIndex(i).getID();
                    dataGridViewRespuestas.Rows[indexData].Cells[3].Value = sistema.GetListaRespuestas.gerRespuetaIndex(i).GetDate;
                    if (!sistema.GetListaRespuestas.gerRespuetaIndex(i).getEstado())
                    {
                        dataGridViewRespuestas.Rows[indexData].Cells[4].Value = "NO ACEPTADA";
                    }
                    else
                    {
                        dataGridViewRespuestas.Rows[indexData].Cells[4].Value = "ACEPTADA";
                    }

                }
            }

            int total = sistema.GetListaPreguntas.getPregunta(this.IDPregunta).getListaRecompensa().sumarRecompensas();
            labelCantidadRecompensa.Text = total.ToString();
        }

        private void buttonAgregarRespuesta_Click(object sender, EventArgs e)
        {
            if (textBoxContenidoRespuesta.Text != "")
            {
                //Agregar al data sin tener que ser aceptada?.
                sistema.answer(sistema.GetListaPreguntas.getPregunta(this.IDPregunta).getID(), textBoxContenidoRespuesta.Text);
                int index = sistema.GetListaRespuestas.cantidadRespuestas() - 1;
                int indexData = dataGridViewRespuestas.Rows.Add();
                dataGridViewRespuestas.Rows[indexData].Cells[0].Value = sistema.GetListaRespuestas.gerRespuetaIndex(index).getContenido;
                dataGridViewRespuestas.Rows[indexData].Cells[1].Value = sistema.GetListaRespuestas.gerRespuetaIndex(index).getAutor();
                dataGridViewRespuestas.Rows[indexData].Cells[2].Value = sistema.GetListaRespuestas.gerRespuetaIndex(index).getID();
                dataGridViewRespuestas.Rows[indexData].Cells[3].Value = sistema.GetListaRespuestas.gerRespuetaIndex(index).GetDate;
                dataGridViewRespuestas.Rows[indexData].Cells[4].Value = "NO ACEPTADA";
                textBoxContenidoRespuesta.Text = "";
            }
        }

        private void buttonAgregarRecompensa_Click(object sender, EventArgs e)
        {
            int recompensa = Convert.ToInt32(textBoxRecompensa.Text);
            if (recompensa > 0)
            {
                if (sistema.reward(sistema.GetListaPreguntas.getPregunta(this.IDPregunta).getID(), recompensa))
                {
                    MessageBox.Show("Recompensa agregada correctamente");
                    //Agregamos la recompensa visualmente
                    int total = Convert.ToInt32(labelCantidadRecompensa.Text);
                    labelCantidadRecompensa.Text = (total + recompensa).ToString();
                }
                else
                {
                    MessageBox.Show("No tiene suficiente reputacion");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un numero mayor que 0");
            }
            textBoxRecompensa.Text = "";
        }
    }
}
