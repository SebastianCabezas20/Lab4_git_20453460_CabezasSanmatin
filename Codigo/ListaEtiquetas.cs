using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    /// <summary>
    /// Clase de la lista de etiquetas
    /// </summary>
    public class ListaEtiquetas
    {
        List<Etiqueta> listaEtiquetas; //List que contendra las Etiquetas

        /// <summary>
        /// Crea una lista con etiquetas
        /// </summary>
        public ListaEtiquetas()
        {
            this.listaEtiquetas = new List<Etiqueta>();
        }

        /// <summary>
        /// Agrega una etiqueta a la lista de etiquetas.
        /// </summary>
        /// <param name="etiqueta">Clase etiqueta</param>
        public void agregarEtiqueta(Etiqueta etiqueta)
        {
            this.listaEtiquetas.Add(etiqueta);
        }

        /// <summary>
        /// Obtener la cantidad de etiquetas que contiene la lista
        /// </summary>
        /// <returns>
        /// Numero con la cantidad de etiquetas
        /// </returns>
        public int cantidadEtiquetas()
        {
            return this.listaEtiquetas.Count;
        }
        /// <summary>
        /// Mediante un index, se obtiene una etiqueta
        /// </summary>
        /// <returns>
        /// Clase etiqueta
        /// </returns>
        /// <param name="index">Un numero entero.</param>
        public Etiqueta getEtiqueta(int index)
        {
            return this.listaEtiquetas[index];
        }
    }
}
