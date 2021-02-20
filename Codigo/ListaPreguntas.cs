using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    public class ListaPreguntas
    {
        List<Pregunta> preguntas;

        public ListaPreguntas()
        {
            this.preguntas = new List<Pregunta>();
        }
        /*
        Permite agregar pregunta a lista de preguntas*/
        public void agregarPregunta(Pregunta pregunta)
        {
            this.preguntas.Add(pregunta);
        }
        /*Permite obtener la cantidad de preguntas que hay en la lista
        @return cantidad de preguntas
        */
        public int cantidadPreguntas()
        {
            return this.preguntas.Count;
        }

        /*Permite verificar que existe ID 
        @param ID, ID a verificar
        @return boolean que indicara si se verifica*/
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
        /*Permite verificar que ID y username coinciden 
        @param ID, ID a verificar
        @param username, nombre de usuario a verificar
        @return boolean que indicara si se verifica*/
        public bool verificarUsername(int ID, String username)
        {
            if (this.getPregunta(ID).getAutor().Equals(username))
            { //caso que el autor sea el username
                return true;
            }
            return false;
        }
        /*Permite obtener pregunta de lista preguntas mediante ID 
         @param ID, ID a buscar
         @return Pregunta, clase pregunta que se buscaba*/
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
        /*Permite obtener pregunta de lista preguntas mediante index 
        @param index a buscar
        @return Pregunta, clase pregunta que se buscaba*/
        public Pregunta getPreguntaIndex(int index)
        {
            return this.preguntas[index];
        }

    }
}
