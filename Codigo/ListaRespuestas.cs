using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    /// <summary>
    /// Clase lista de respuestas.
    /// </summary>
    public class ListaRespuestas
    {
        private List<Respuesta> listaRespuesta; // ArrayList que almacenara las respuestas
        /// <summary>
        /// Crea una lista de respuestas.
        /// </summary>
        public ListaRespuestas()
        {
            this.listaRespuesta = new List<Respuesta>();
        }

        /// <summary>
        /// Agrega una respuesta a la lista de respuestas.
        /// </summary>
        /// <param name="respuesta">Respuesta de la clase respuesta.</param>
        public void agregarRespuesta(Respuesta respuesta)
        {
            this.listaRespuesta.Add(respuesta);
        }

        /// <summary>
        /// Obtiene la cantidad de respuesta de la lista.
        /// </summary>
        /// <returns>
        /// Numero con la cantidad de respuestas.
        /// </returns>
        public int cantidadRespuestas()
        {
            return this.listaRespuesta.Count;
        }

        /// <summary>
        /// Busca un respuesta mediante el ID.
        /// </summary>
        /// <returns>
        /// Una respuesta de la clase respuesta.
        /// </returns>
        /// <param name="ID">Un numero entero.</param>
        public Respuesta getRespuesta(int ID)
        {
            for (int i = 0; i < this.listaRespuesta.Count; i++)
            {
                if (this.listaRespuesta[i].getID() == ID)
                { //Si coincide el ID se retorna la respuesta
                    return this.listaRespuesta[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Obtener una respuesta mediante el index
        /// </summary>
        /// <returns>
        /// Respuesta de al clase respuesta.
        /// </returns>
        /// <param name="index">Un numero entero.</param>
        public Respuesta gerRespuetaIndex(int index)
        {
            return this.listaRespuesta[index];
        }

        /// <summary>
        /// Verifica si existe el ID en la lista de respuesta
        /// </summary>
        /// <returns>
        /// booleano el cual verifica la situacion.
        /// </returns>
        /// <param name="ID">Un numero entero.</param>
        public bool verificarID(int ID)
        {
            //Busca en la lista
            for (int i = 0; i < this.listaRespuesta.Count; i++)
            {
                if (this.listaRespuesta[i].getID() == ID)
                { // Si existe ID
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica si la respuesta es de una pregunta dada
        /// </summary>
        /// <returns>
        /// Booleano que indica si es de la pregunta.
        /// </returns>
        /// <param name="IDPregunta">Un numero entero.</param>
        /// <param name="index">Un numero entero.</param>
        public bool verificarRespuesta(int IDPregunta, int index)
        {
            // Si tiene el ID de la pregunta buscada y el estado es aceptada-------------------
            if (this.listaRespuesta[index].getPreguntaRespondida() == IDPregunta)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verificar si la respuesta es de la pregunta y esta aceptada.
        /// </summary>
        /// <returns>
        /// Booleano que verifica si es de la pregunta y esta aceptada.
        /// </returns>
        /// <param name="IDPregunta">Un numero entero.</param>
        /// <param name="index">Un numero entero.</param>
        public bool verificarRespuestaNoAceptada(int IDPregunta, int index)
        {
            // Si tiene el ID de la pregunta buscada y el estado es aceptada
            if (this.listaRespuesta[index].getPreguntaRespondida() == IDPregunta && !this.listaRespuesta[index].getEstado())
            {
                return true;
            }
            return false;
        }

        
    }
}
