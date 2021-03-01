using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    /// <summary>
    /// Clase lista de usuarios.
    /// </summary>
    public class ListaUsuarios
    {
        private List<Usuario> listaUsuarios; // List que contendra los usuarios

        /// <summary>
        /// Crea una lista de usuarios.
        /// </summary>
        public ListaUsuarios()
        {
            this.listaUsuarios = new List<Usuario>();
        }

        /// <summary>
        /// Obtiene un usuario mediante un index.
        /// </summary>
        /// <returns>
        /// Usuario de la clase usuario.
        /// </returns>
        /// <param name="index">Un numero entero.</param>
        public Usuario getUsuario(int index)
        {
            return this.listaUsuarios[index];
        }

        /// <summary>
        /// Verifica si existe un usuario con un determinado Username.
        /// </summary>
        /// <returns>
        /// Booleano que verifica si existe el usuario.
        /// </returns>
        /// <param name="username">Un string.</param>
        public bool verificarUsuario(String username)
        {
            for (int i = 0; i < this.listaUsuarios.Count; i++)
            {
                if (this.listaUsuarios[i].getUsername().Equals(username))
                { // Si se encuentra el nombre
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Agrega un usuarios a la lista de usuarios
        /// </summary>
        /// <param name="usuario">Un usuario de la clase usuario.</param>
        public void agregarUsuario(Usuario usuario)
        {
            this.listaUsuarios.Add(usuario);
        }
        /// <summary>
        /// Verifica si existe un username con los datos dados
        /// </summary>
        /// <returns>
        /// Entero con el index del usuario.
        /// </returns>
        /// <param name="username">Un string.</param>
        /// <param name="pass">Un string.</param>
        public int autenticar(String username, String pass)
        {
            for (int i = 0; i < this.listaUsuarios.Count; i++)
            {
                //Caso que exista el username asociado a la contraseña
                if ((this.listaUsuarios[i].getUsername().Equals(username)) && (this.listaUsuarios[i].getPass().Equals(pass)))
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Busca un usuario mediante un username.
        /// </summary>
        /// <returns>
        /// Usuario de la clase usuario.
        /// </returns>
        /// <param name="username">Un string.</param>
        public Usuario getUsuarioUsername(String username)
        {
            for (int i = 0; i < this.listaUsuarios.Count; i++)
            {
                if (this.listaUsuarios[i].getUsername().Equals(username))
                { //Retornar el usuario ya que existe
                    return this.listaUsuarios[i];
                }
            }
            return null;
        }
    }
}
