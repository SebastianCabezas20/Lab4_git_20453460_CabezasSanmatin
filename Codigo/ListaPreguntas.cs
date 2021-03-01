using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    /// <summary>
    /// Clase lista de preguntas
    /// </summary>
    public class ListaPreguntas
    {
        List<Pregunta> preguntas;

        /// <summary>
        /// Crea una lista preguntas
        /// </summary>
        public ListaPreguntas()
        {
            this.preguntas = new List<Pregunta>();
        }

        /// <summary>
        /// Agrega una pregunta a la lista de preguntas
        /// </summary>
        /// <param name="pregunta">Clase pregunta.</param>
        public void agregarPregunta(Pregunta pregunta)
        {
            this.preguntas.Add(pregunta);
        }

        /// <summary>
        /// Se obtiene la cantidad de preguntas de la lista.
        /// </summary>
        /// <returns>
        /// Retorna un numero con la cantidad de preguntas
        /// </returns>
        public int cantidadPreguntas()
        {
            return this.preguntas.Count;
        }

        /// <summary>
        /// Verifica si el id esta en la lista de preguntas.
        /// </summary>
        /// <returns>
        /// booleano que indica si existe el ID
        /// </returns>
        /// <param name="ID">Un numero entero que corresponde al ID.</param>
        public bool verificarIDPregunta(int ID)
        {
            for (int i = 0; i < this.preguntas.Count; i++)
            {
                if (this.preguntas[i].getID() == ID)
                {//Caso que incidan los IDs
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Busca una pregunta mediante un ID.
        /// </summary>
        /// <returns>
        /// Clase pregunta.
        /// </returns>
        /// <param name="ID">Un entero que corresponde a un ID.</param>
        public Pregunta getPregunta(int ID)
        {
            for (int i = 0; i < this.preguntas.Count; i++)
            {
                if (this.preguntas[i].getID() == ID)
                { //caso que coincidan los IDs
                    return this.preguntas[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Obtiene una pregunta mediante el index
        /// </summary>
        /// <returns>
        /// Clase pregunta 
        /// </returns>
        /// <param name="index">Numero entero que corresponde al index.</param>
        public Pregunta getPreguntaIndex(int index)
        {
            return this.preguntas[index];
        }

    }
}
