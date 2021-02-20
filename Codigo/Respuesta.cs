using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
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

        /*Permite construir una respuesta
        @param IDGeneral ID de la respuesta
        @param contenido corresponde al contenido de la respuesta
        @param autor autor de la respuesta
        @param preguntaRespondida, ID de la pregunta a responder*/
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
        /*Permite obtener el ID de la respuesta
        @return ID de la respuesta que corresponde a un enntero*/
        public int getID()
        {
            return ID;
        }
        /*Permite obtener el estaod de la pregunta
        @return retorna el estado de la respuesta que en este caso es un boolean*/
        public bool getEstado()
        {
            return estado;
        }
        /*Permite cambiar el estado de la respuesta
        @param estado, corresponde al nuevo estado de la respuesta*/
        public void setEstado(bool estado)
        {
            this.estado = estado;
        }

        public String getContenido
        {
            get
            {
                return this.contenido;
            }
        }

        /*Permite obtener el ID de la pregunta respondida
        @return ID de pregunta respondida de la respuesta*/
        public int getPreguntaRespondida()
        {
            return preguntaRespondida;
        }
        /*Permite obtener el nombre del autor de la respuesta
        @return retorna el nombre del autor de la respuesta*/
        public String getAutor()
        {
            return autor;
        }

        public DateTime GetDate
        {
            get
            {
                return this.fecha;
            }
        }

        public int getVotoPositivos
        {
            get
            {
                return this.votosPositivos;
            }
        }

        public int getVotoNegativos
        {
            get
            {
                return this.votosNegativos;
            }
        }

        /*Permite aumentar el voto negativo o positivo
        @param opcion da a conocer si es negativo o positivo
        @return booleano que permite verificar el voto*/
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
