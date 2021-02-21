using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    public class ListaUsuarios
    {
        private List<Usuario> listaUsuarios; // ArrayList que contendra los usuarios
        /*Crea una lista de usuarios*/
        public ListaUsuarios()
        {
            this.listaUsuarios = new List<Usuario>();
        }
        /*
        Permite obtener un usuario de la lista mediante su index
        @param index, numero del index del usuario
        @return Usuario del index*/
        public Usuario getUsuario(int index)
        {
            return this.listaUsuarios[index];
        }
        /*
        Permite verificar que no exista username ingresado
        @param username, nombre de usuario a verificar
        @return boolean que indica si se verifica o no*/
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
        /*
        Permite agregar un usuario a la lista
        @param usuario, clase de usuario que se quiere agregar*/
        public void agregarUsuario(Usuario usuario)
        {
            this.listaUsuarios.Add(usuario);
        }
        /*
        Permite obtener verificar si conciden los datos a un usuario
        @param username, nombre de usuario a verificar
        @param pass, contraseña de usuario a verificar
        @return Retorna el index de usuario verificado*/
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
        /*
        Permite obtener un usuario de la lista mediante su nombre
        @param username, useriname que sera buscado
        @return Usuario del username*/
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
