using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    /// <summary>
    /// Clase recompensa
    /// </summary>
    public class Recompensa
    {
        private int reputacion;// Cantidad de recompensa en reputacion
        private int usuarioRecompensa;// Index del usuario que ofrecio recompemsa

        /// <summary>
        /// Crea una recompensa.
        /// </summary>
        /// <param name="reputacion">Un numero entero.</param>
        /// <param name="usuarioRecompensa">Un numero entero.</param>
        public Recompensa(int reputacion, int usuarioRecompensa)
        {
            this.reputacion = reputacion;
            this.usuarioRecompensa = usuarioRecompensa;
        }

        /// <summary>
        /// Permite obtener el valor de la recompensa.
        /// </summary>
        /// <returns>
        /// Numero con el valor de la reputacion.
        /// </returns>
        public int getReputacion()
        {
            return reputacion;
        }

        /// <summary>
        /// Permite obtener el index del usuario que otorgo la recompensa.
        /// </summary>
        /// <returns>
        /// Numero con el index del usuario.
        /// </returns>
        public int getUsuarioRecompensa()
        {
            return usuarioRecompensa;
        }
    }
}
