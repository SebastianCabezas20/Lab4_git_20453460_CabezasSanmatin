using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    public class ListaRecompensas
    {
        private List<Recompensa> listaRecompensa; //ArrayList que almacenara las recompensas
        /*Construye una nueva lista de recompensas*/
        public ListaRecompensas()
        {
            this.listaRecompensa = new List<Recompensa>();
        }
        /*Permite agregar una recompensa a la lista de recompensas
        @param recompensa corresponde a un onjeto de clase Recompensa*/
        public void agregarRecompensa(Recompensa recompensa)
        {
            this.listaRecompensa.Add(recompensa);
        }
        /*Calcular la cantidad de recompensas en la lista
        @return cantidad de recompensas */
        public int cantidadRecompensas()
        {
            return this.listaRecompensa.Count;
        }
        /*Permite obtener una recompensa de la lista mediante su index
        @param index, correponde  al index de la pregunta a buscar
        @return objeto de clase Recompensa que corresponde a la recompensa en el index*/
        public Recompensa getRecompensa(int index)
        {
            return this.listaRecompensa[index];
        }
        /*Perimite sumar todas las recompensas
        @return cantidad total de recompensas en reputacion*/
        public int sumarRecompensas()
        {
            int total = 0; //Contador total
            for (int i = 0; i < this.listaRecompensa.Count; i++)
            {
                total = total + this.listaRecompensa[i].getReputacion(); //Sumar cada una de las recompensas
            }
            return total;
        }
    }
}
