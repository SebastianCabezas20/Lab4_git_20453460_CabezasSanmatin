using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    /// <summary>
    /// Clase usuario
    /// </summary>
    public class Usuario
    {
        private string username; //Nombre del usuario
        private string pass; // Contraseña del usuario
        private int reputacion; //reputacion real 
        private int reputacionRelativa; //Reputacion que ayudara a controlar la cantidad de recompensas

        /// <summary>
        /// Permite crear un usuario
        /// </summary>
        /// <param name="username">String.</param>
        /// <param name="pass">String.</param>
        public Usuario(string username, string pass)
        {
            this.username = username;
            this.pass = pass;
            this.reputacion = 1000;
            this.reputacionRelativa = 1000;
        }

        /// <summary>
        /// Permite obtener el nombre de usuario
        /// </summary>
        /// <returns>
        /// String corresponde al username.
        /// </returns>
        public string getUsername()
        {
            return username;
        }

        /// <summary>
        /// Permite obtener el pass del usuario
        /// </summary>
        /// <returns>
        /// String que corresponde al pass.
        /// </returns>
        public String getPass()
        {
            return pass;
        }

        /// <summary>
        /// Permite obtener la reputacion del usuario
        /// </summary>
        /// <returns>
        /// Numero que corresponde a la reputacion.
        /// </returns>
        public int getReputacion()
        {
            return reputacion;
        }

        /// <summary>
        /// Permite obtener la reputacion relativa
        /// </summary>
        /// <returns>
        /// Entero con la reputacion relativa
        /// </returns>
        public int getReputacionRelativa()
        {
            return reputacionRelativa;
        }

        /// <summary>
        /// Permite agregar restar a la reputacion relativa
        /// </summary>
        /// <param name="Reputacion">Entero.</param>
        public void restarReputacionRelativa(int Reputacion)
        {
            this.reputacionRelativa = this.reputacionRelativa - Reputacion;
        }

        /// <summary>
        /// Permite agregar restar a la reputacion obsoluta
        /// </summary>
        /// <param name="Reputacion">Entero.</param>
        public void restarReputacionAbsoluta(int Reputacion)
        {
            this.reputacion = this.reputacion - Reputacion;
        }

        /// <summary>
        /// Permite agregar sumar a la reputacion absoluta
        /// </summary>
        /// <param name="Reputacion">Entero.</param>
        public void sumarReputacionAbsoluta(int Reputacion)
        {
            this.reputacion = this.reputacion + Reputacion;
        }

        /// <summary>
        /// Permite agregar restar a la reputacion relativa
        /// </summary>
        /// <param name="Reputacion">Entero.</param>
        public void sumarReputacionRelativa(int Reputacion)
        {
            this.reputacionRelativa = this.reputacionRelativa + Reputacion;
        }
        
    }
}
