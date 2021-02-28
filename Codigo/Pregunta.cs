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

        /*
        Constructor de una pregunta
        @param ID, ID de la pregunta
        @param titulo, String que contiene el titulo de la pregunta
        @param contenido String que contiene el contenido de la pregunta
        @param etiqeutas se refiere a la clase ListaEtiquetas
        @param autor corresponde al autor de la pregunta*/
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
            this.estado = false;
        }

        /*Permite obtener el autor e la pregunta
         @return retorna el nombre del usuario*/
        public String getAutor()
        {
            return autor;
        }

        public string getTitulo()
        {
            return this.titulo;
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

        public ListaEtiquetas GetListaEtiquetas
        {
            get
            {
                return this.listaEtiqueta;
            }
        }

        public string getContenido()
        {
            return this.contenido;
        }
        /*Permite obtener el estado de la pregunta
        @return retorna el estado de la pregunta que corresponde a un boolean*/
        public bool getEstado()
        {
            return estado;
        }
        /*Permite cambiar el estaod de la pregunta
        @param estado corresponde a un booleano que sera el nuevo estado
        */
        public void setEstado(bool estado)
        {
            this.estado = estado;
        }
        /*Permite obtener la lista de recompensas de la pregunta
        @return retorna la clase lista de recompensas*/
        public ListaRecompensas getListaRecompensa()
        {
            return listaRecompensa;
        }

        /*Permite obtener el id de la pregunta
        @return retorna el numero del ID*/
        public int getID()
        {
            return ID;
        }

        

        /*Permite obtener aumentar la cantidad de votos, se negativo o positivo
         @return retorna una confirmacion en booleano*/
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

