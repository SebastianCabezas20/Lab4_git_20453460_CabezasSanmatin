using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    public class ListaRespuestas
    {
        private List<Respuesta> listaRespuesta; // ArrayList que almacenara las respuestas
        /*Constructor de lista respuestas*/
        public ListaRespuestas()
        {
            this.listaRespuesta = new List<Respuesta>();
        }
        /*Permite agregar una respuesta a la lista de respuestas
        @param respuesta corresponde a una objeto de la clase Respuesta*/
        public void agregarRespuesta(Respuesta respuesta)
        {
            this.listaRespuesta.Add(respuesta);
        }
        /*Permite obtener la cantidad total de respuestas
        @return retorna el numero de respuestas*/
        public int cantidadRespuestas()
        {
            return this.listaRespuesta.Count;
        }
        /*Permite obtener una respuesta en base a su ID
        @param ID corresponde al ID buscado
        @return retorna un objeto de la clase Respuesta*/
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

        public Respuesta gerRespuetaIndex(int index)
        {
            return this.listaRespuesta[index];
        }

        /*Permite verificar si existe ID en la lista de respuestas
        @param ID corresponde al ID buscado
        @return retorna un booleano que indica si existe ID*/
        public bool verificarID(int ID)
        {
            for (int i = 0; i < this.listaRespuesta.Count; i++)
            {
                if (this.listaRespuesta[i].getID() == ID)
                { // Si existe ID
                    return true;
                }
            }
            return false;
        }
        /*Permite imprimir respuesta de una determinada pregunta siempre que no este aceptada
        @param ID corresponde al ID de la pregunta */
        public bool verificarRespuesta(int IDPregunta, int index)
        {
            // Si tiene el ID de la pregunta buscada y el estado es aceptada-------------------
            if (this.listaRespuesta[index].getPreguntaRespondida() == IDPregunta)
            {
                return true;
            }
            return false;
        }


        public bool verificarRespuestaNoAceptada(int IDPregunta, int index)
        {
            // Si tiene el ID de la pregunta buscada y el estado es aceptada
            if (this.listaRespuesta[index].getPreguntaRespondida() == IDPregunta && !this.listaRespuesta[index].getEstado())
            {
                return true;
            }
            return false;
        }

        /*Permite imprimir las respuestas que no sean de un usuario pero si de un ID pregunta determinado
        @param IDPregunta ID de la pregunta buscada
        @param username corresponde al nombre del usuario evitado*/
        public void imprimirRespuestasNoUser(int IDPregunta, String username)
        {
            int respuestas = 0; // Cantidad de respuestas en total
            for (int i = 0; i < this.listaRespuesta.Count; i++)
            {
                //Si la respuesta es igual al ID de la pregunta y a sido aceptada y el autor no coincide con el username
                if (this.listaRespuesta[i].getPreguntaRespondida() == IDPregunta && this.listaRespuesta[i].getEstado() && !this.listaRespuesta[i].getAutor().Equals(username))
                {
                    respuestas++; //Sumamos cantidad de respuestas

                }
            }
            if (respuestas == 0)
            { // caso que no se encuentren respuestas para votar
            }
        }
        /*permite imprimir todas las respuestas de una determinada pregunta
        @param ID corresponde al ID de la pregunta*/
        public void imprimirTotalRespuestas(int IDPregunta)
        {
            for (int i = 0; i < this.listaRespuesta.Count; i++)
            {
                if (this.listaRespuesta[i].getPreguntaRespondida() == IDPregunta)
                { //Se comprueba que sea de la pregunta

                }
            }
        }
    }
}
