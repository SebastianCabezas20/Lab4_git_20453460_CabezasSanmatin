using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    /// <summary>
    /// Clase respuesta.
    /// </summary>
    public class Respuesta
    {
        private int ID; //ID unico 
        private String contenido; //Contenido de la respuesta
        private String autor; ///autor de la respuesta
        private DateTime fecha; // Fecha de publicacion
        private int preguntaRespondida; // ID de pregunta respondida
        private bool estado;//No aceptado
        private int votosPositivos; //votos
        private int votosNegativos;

        /// <summary>
        /// Crea una respuesta
        /// </summary>
        /// <param name="IDGeneral">Un numero entero.</param>
        /// <param name="contenido">String.</param>
        /// <param name="autor">String.</param>
        /// <param name="preguntaRespondida">Un numero entero.</param>
        public Respuesta(int IDGeneral, String contenido, String autor, int preguntaRespondida)
        {
            this.votosPositivos = 0;
            this.votosNegativos = 0;
            this.ID = IDGeneral;
            this.contenido = contenido;
            this.estado = false; //Primeramente esta sin aceptar
            this.autor = autor;
            this.fecha = DateTime.Today.AddDays(2 + this.ID);
            this.preguntaRespondida = preguntaRespondida;
        }

        /// <summary>
        /// Permite obtener el ID de la respuesta.
        /// </summary>
        /// <returns>
        /// Numero con el ID de la respuesta.
        /// </returns>
        public int getID()
        {
            return ID;
        }

        /// <summary>
        /// Permite obtener el estado de la respuesta.
        /// </summary>
        /// <returns>
        /// Booleano que permite obtener el estado.
        /// </returns>
        public bool getEstado()
        {
            return estado;
        }

        /// <summary>
        /// Permite cambiar el estado de la respuesta
        /// </summary>
        /// <param name="estado">Booleano.</param>
        public void setEstado(bool estado)
        {
            this.estado = estado;
        }

        /// <summary>
        /// Permite obtener el contenido de la pregunta.
        /// </summary>
        /// <returns>
        /// String con el contenido de la respuesta.
        /// </returns>
        public String getContenido
        {
            get
            {
                return this.contenido;
            }
        }

        /// <summary>
        /// Permite obtener el ID de la pregunta respondida.
        /// </summary>
        /// <returns>
        /// Entero con el ID de la pregunta.
        /// </returns>
        public int getPreguntaRespondida()
        {
            return preguntaRespondida;
        }

        /// <summary>
        /// Permite obtener el autor de la respuesta
        /// </summary>
        /// <returns>
        /// String con el autor de la respuesta.
        /// </returns>
        public String getAutor()
        {
            return autor;
        }

        /// <summary>
        /// Permite obtener la fechad de la respuesta.
        /// </summary>
        /// <returns>
        /// String fecha de la respuesta.
        /// </returns>
        public String GetDate
        {
            get
            {
                return this.fecha.ToShortDateString();
            }
        }

        /// <summary>
        /// Permite obtener la cantidad de votos positivos.
        /// </summary>
        /// <returns>
        /// Entero con la cantidad de votos positivos de la respuesta.
        /// </returns>
        public int getVotoPositivos
        {
            get
            {
                return this.votosPositivos;
            }
        }

        /// <summary>
        /// Permite obtener la cantidad de votos negativos.
        /// </summary>
        /// <returns>
        /// Entero con la cantidad de votos negativos de la respuesta.
        /// </returns>
        public int getVotoNegativos
        {
            get
            {
                return this.votosNegativos;
            }
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
