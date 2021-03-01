using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    public class Pregunta
    {
        private int ID;// ID unico
        private String titulo;
        private String contenido;
        private DateTime fecha;
        private String autor;
        private ListaRecompensas listaRecompensa;
        private ListaEtiquetas listaEtiqueta;
        private bool estado;//Si existen preguntas aceptadas
        private int votosPositivos;
        private int votosNegativos;

        /// <summary>
        /// Crea una pregunta
        /// </summary>
        /// <param name="ID">Un numero entero.</param>
        /// <param name="titulo">String.</param>
        /// <param name="contenido">String.</param>
        /// <param name="etiquetas">Una lista de etiquetas (clase etiqueta).</param>
        /// <param name="autor">String.</param>
        public Pregunta(int ID, String titulo, String contenido, ListaEtiquetas etiquetas, String autor)
        {
            this.votosPositivos = 0;
            this.votosNegativos = 0;
            this.ID = ID;
            this.titulo = titulo;
            this.contenido = contenido;
            this.fecha = DateTime.Today.AddDays(this.ID);
            this.listaRecompensa = new ListaRecompensas();
            this.listaEtiqueta = etiquetas;
            this.autor = autor;
            this.estado = false;//Sin preguntas aceptadas
        }

        /// <summary>
        /// Obtener el autor de la pregunta
        /// </summary>
        /// <returns>
        /// String con el nombre del autor.
        /// </returns>
        public String getAutor()
        {
            return autor;
        }

        /// <summary>
        /// Obtener el titulo de la pregunta
        /// </summary>
        /// <returns>
        /// String con el titulo de la pregunta.
        /// </returns>
        public string getTitulo()
        {
            return this.titulo;
        }

        /// <summary>
        /// Obtener la fecha de la pregunta
        /// </summary>
        /// <returns>
        /// Date con la fecha de la pregunta.
        /// </returns>
        public DateTime GetDate
        {
            get
            {
                return this.fecha;
            }
        }

        /// <summary>
        /// Obtener los votos positivos de la pregunta
        /// </summary>
        /// <returns>
        /// Numero con la cantidad de votos positivos.
        /// </returns>
        public int getVotoPositivos
        {
            get
            {
                return this.votosPositivos;
            }
        }

        /// <summary>
        /// Obtener los votos negativos de la pregunta
        /// </summary>
        /// <returns>
        /// Numero con la cantidad de votos negativos.
        /// </returns>
        public int getVotoNegativos
        {
            get
            {
                return this.votosNegativos;
            }
        }

        /// <summary>
        /// Obtener la lista de etiquetas
        /// </summary>
        /// <returns>
        /// Clase lista de etiquetas.
        /// </returns>
        public ListaEtiquetas GetListaEtiquetas
        {
            get
            {
                return this.listaEtiqueta;
            }
        }

        /// <summary>
        /// Obtener el contenido de la pregunta
        /// </summary>
        /// <returns>
        /// String con el contenido de la pregunta.
        /// </returns>
        public string getContenido()
        {
            return this.contenido;
        }

        /// <summary>
        /// Obtener el estado de la pregunta
        /// </summary>
        /// <returns>
        /// Booleano con el estado de la pregunta.
        /// </returns>
        public bool getEstado()
        {
            return estado;
        }

        /// <summary>
        /// Permite cambiar el estado de la pregunta
        /// </summary>
        /// <param name="estado">Booleano.</param>
        public void setEstado(bool estado)
        {
            this.estado = estado;
        }

        /// <summary>
        /// Permite obtener la lista recompensas.
        /// </summary>
        /// <returns>
        /// Clase lista de recompensas.
        /// </returns>
        public ListaRecompensas getListaRecompensa()
        {
            return listaRecompensa;
        }

        /// <summary>
        /// Permite obtener el ID de la pregunta
        /// </summary>
        /// <returns>
        /// Entero con el ID de la pregunta.
        /// </returns>
        public int getID()
        {
            return ID;
        }

        /// <summary>
        /// Permite aumentar votos
        /// </summary>
        /// <returns>
        /// booleano que permite saber si fue positivo o negativo.
        /// </returns>
        /// <param name="opcion">Booleano.</param>
        public bool aumentarVoto(bool opcion)
        {
            if (opcion)
            {
                this.votosPositivos++;
                return true;
            }
            else
            {
                this.votosNegativos++;
                return false;
            }
        }

    }
}

