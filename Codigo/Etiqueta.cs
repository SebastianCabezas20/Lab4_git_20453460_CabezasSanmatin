using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    /// <summary>
    /// Clase etiqueta
    /// </summary>
    public class Etiqueta
    {
        private String etiqueta;// Nombre de la etiqueta
        private String descripcion;//Descripcion de la etiqueta

        /// <summary>
        /// Crea una etiqueta con los datos dados
        /// </summary>
        /// <param name="etiqueta">String.</param>
        /// <param name="descripcion">String.</param>
        public Etiqueta(String etiqueta, String descripcion)
        {
            this.etiqueta = etiqueta;
            this.descripcion = descripcion;
        }
        /// <summary>
        /// Permite obtener el nombre de la etiqueta
        /// </summary>
        /// <returns>
        /// El string del nombre
        /// </returns>
        public String getEtiqueta()
        {
            return etiqueta;
        }
        /// <summary>
        /// Permite obtener la descripcion de la etiqueta
        /// </summary>
        /// <returns>
        /// El string de la descripcion de la etiqueta
        /// </returns>
        public String getDescripcion()
        {
            return descripcion;
        }

    }
}
