using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    /// <summary>
    /// Clase lista de recompensas
    /// </summary>
    public class ListaRecompensas
    {
        private List<Recompensa> listaRecompensa; //ArrayList que almacenara las recompensas

        /// <summary>
        /// Crea una lista de recompensas
        /// </summary>
        public ListaRecompensas()
        {
            this.listaRecompensa = new List<Recompensa>();
        }

        /// <summary>
        /// Agrega una recompensa en la lista de recompensa.
        /// </summary>
        /// <param name="recompensa">Recompensa de la clase recompensa.</param>
        public void agregarRecompensa(Recompensa recompensa)
        {
            this.listaRecompensa.Add(recompensa);
        }

        /// <summary>
        /// Obtiene la cantidad de recompensas de la lista
        /// </summary>
        /// <returns>
        /// Numero con la cantidad de recompensas.
        /// </returns>
        public int cantidadRecompensas()
        {
            return this.listaRecompensa.Count;
        }

        /// <summary>
        /// Obtiene una recompensa mediante un index.
        /// </summary>
        /// <returns>
        /// Recompensa de la clase recompensa.
        /// </returns>
        /// <param name="index">Numero que corresponde al index.</param>
        public Recompensa getRecompensa(int index)
        {
            return this.listaRecompensa[index];
        }

        /// <summary>
        /// Suma las cantidades(valores) de todas las recompensas de la lista.
        /// </summary>
        /// <returns>
        /// Numero con la suma total de la cantidad(valor) de recompensas.
        /// </returns>
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
