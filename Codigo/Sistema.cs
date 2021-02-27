using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    public class Sistema
    {
        private int IDgeneral;//ID unico e incremental
        private ListaUsuarios listaUsuarios;//lista de usuarios del sta
        private ListaPreguntas listaPreguntas;//lista de preguntas del stack
        private ListaEtiquetas listaEtiquetas;//lista etiquetas del stack
        private ListaRespuestas listaRespuestas;//lista respuestas del stack
        private int indexActivo;//index del usuario activo

        /*Permite crear un stack vacio*/
        public Sistema()
        {
            this.listaUsuarios = new ListaUsuarios();
            this.listaPreguntas = new ListaPreguntas();
            this.listaEtiquetas = new ListaEtiquetas();
            this.listaRespuestas = new ListaRespuestas();
            this.indexActivo = -1;
            this.IDgeneral = 1;
        }

        public ListaUsuarios GetListaUsuarios
        {
            get
            {
                return listaUsuarios;
            }
        }

        public ListaPreguntas GetListaPreguntas
        {
            get
            {
                return listaPreguntas;
            }
        }

        public ListaRespuestas GetListaRespuestas
        {
            get
            {
                return this.listaRespuestas;
            }
        }

        public ListaEtiquetas GetListaEtiquetas
        {
            get
            {
                return this.listaEtiquetas;
            }
        }

        public int getIndexActivo
        {
            get
            {
                return this.indexActivo;
            }
        }
        /*Permite registrar a un usuario en el stack
         @param username es el nombre de usuario 
         @param pass contrasena del usuario*/
        public bool Register(String username, String pass)
        {
            if (this.listaUsuarios.verificarUsuario(username) && username != "" && pass != "")
            {// Se verifica que el username no exista en la lista de usuarios
                this.listaUsuarios.agregarUsuario(new Usuario(username, pass));//Se crea y se agrega
                return true;
            }
            else
            {//caso que exista
                return false;
            }
        }

        public bool login(String usermane, String pass)
        {
            int index = this.listaUsuarios.autenticar(usermane, pass);//Se verifica que concida el username y pass
            if (index != -1)
            {
                this.indexActivo = index;//Se cambia el index al de usuario activo
                return true;
            }
            else
            {//Caso que no coincidan los datos, sigue siendo -1
                return false;
            }
        }

        public bool logout(String username, String pass)
        {
            //Se verifica que los datos sean del usuario activo
            if (this.listaUsuarios.getUsuario(this.indexActivo).getUsername().Equals(username)
                && this.listaUsuarios.getUsuario(this.indexActivo).getPass().Equals(pass))
            {
                this.indexActivo = -1;// se cambia index a desactivado
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ask(String titulo, ListaEtiquetas etiquetas, String contenido)
        {
            if (titulo != "" && contenido != "")
            {
                // Se crea la pregunta
                Pregunta pregunta = new Pregunta(this.IDgeneral, titulo, contenido, etiquetas, this.listaUsuarios.getUsuario(this.indexActivo).getUsername());
                this.listaPreguntas.agregarPregunta(pregunta);
                this.IDgeneral = this.IDgeneral + 1; // suma ID general
                return true;
            }
            else
            {
                return false;
            }
        }

        public void answer(int ID, String contenido)
        {
            Respuesta respuesta = new Respuesta(this.IDgeneral, contenido, this.listaUsuarios.getUsuario(this.indexActivo).getUsername(), ID);
            this.listaRespuestas.agregarRespuesta(respuesta);
            this.IDgeneral = this.IDgeneral + 1; //Aumenta ID general

        }

        public bool reward(int ID, int recompensa)
        {

            if (recompensa <= this.listaUsuarios.getUsuario(this.indexActivo).getReputacionRelativa())
            {
                //Caso que tenga suficiente reputacion
                Recompensa nuevaRecompensa = new Recompensa(recompensa, this.indexActivo);
                this.listaUsuarios.getUsuario(this.indexActivo).restarReputacionRelativa(recompensa); //Se resta a la relativa
                this.listaPreguntas.getPregunta(ID).getListaRecompensa().agregarRecompensa(nuevaRecompensa);
                return true;

            }
            else
            {
                return false;
            }
        }

        public void accept(int IDPregunta, int IDRespuesta)
        {
            //existe recompensa
            if (this.listaPreguntas.getPregunta(IDPregunta).getListaRecompensa().cantidadRecompensas() > 0 && !this.listaPreguntas.getPregunta(IDPregunta).getEstado())
            {
                int recompensaTotal = 0; //Suma de total
                //Cobrar recompensas en el arrayList de recompensas
                for (int i = 0; i < this.listaPreguntas.getPregunta(IDPregunta).getListaRecompensa().cantidadRecompensas(); i++)
                {
                    int recompensaCobrada = this.listaPreguntas.getPregunta(IDPregunta).getListaRecompensa().getRecompensa(i).getReputacion();
                    //Se busca a usuario que ofrecio recompensa
                    int indexOfrecido = this.listaPreguntas.getPregunta(IDPregunta).getListaRecompensa().getRecompensa(i).getUsuarioRecompensa();
                    recompensaTotal = recompensaTotal + recompensaCobrada; //Se suma recompensa 
                    this.listaUsuarios.getUsuario(indexOfrecido).restarReputacionAbsoluta(recompensaCobrada);//Restar a usuario
                    this.listaUsuarios.getUsuario(indexOfrecido).restarReputacionRelativa(recompensaCobrada);//Restar a usuario
                }
                //Se cambian los estados
                this.listaPreguntas.getPregunta(IDPregunta).setEstado(true);
                this.listaRespuestas.getRespuesta(IDRespuesta).setEstado(true);
                //Suma reputacion a usuario que respondio
                this.listaUsuarios.getUsuarioUsername(this.listaRespuestas.getRespuesta(IDRespuesta).getAutor()).sumarReputacionAbsoluta(recompensaTotal);
                this.listaUsuarios.getUsuarioUsername(this.listaRespuestas.getRespuesta(IDRespuesta).getAutor()).sumarReputacionRelativa(recompensaTotal);

            }
            else
            {//Caso que no haya recompensa
                this.listaPreguntas.getPregunta(IDPregunta).setEstado(true);
                this.listaRespuestas.getRespuesta(IDRespuesta).setEstado(true);
            }
            //Reputacion por aceptar
            this.listaUsuarios.getUsuarioUsername(this.GetListaRespuestas.getRespuesta(IDRespuesta).getAutor()).sumarReputacionAbsoluta(15);
            this.listaUsuarios.getUsuarioUsername(this.GetListaRespuestas.getRespuesta(IDRespuesta).getAutor()).sumarReputacionRelativa(15);
            this.listaUsuarios.getUsuario(this.indexActivo).sumarReputacionRelativa(2);
            this.listaUsuarios.getUsuario(this.indexActivo).sumarReputacionAbsoluta(2);
        }

        public void vote(int ID, bool opcion)
        {
            //Se verifica que existe ID pregunta
            if (this.listaPreguntas.verificarIDPregunta(ID))
            {
                if (this.listaPreguntas.getPregunta(ID).aumentarVoto(opcion))
                {
                    //Se suma reputacion segun enunciado
                    this.listaUsuarios.getUsuarioUsername(this.listaPreguntas.getPregunta(ID).getAutor()).sumarReputacionAbsoluta(10);
                    this.listaUsuarios.getUsuarioUsername(this.listaPreguntas.getPregunta(ID).getAutor()).sumarReputacionRelativa(10);
                    //Voto realizado positivo
                }
                else
                {
                    //Se resta reputacion segun enunciado
                    this.listaUsuarios.getUsuarioUsername(this.listaPreguntas.getPregunta(ID).getAutor()).restarReputacionAbsoluta(2);
                    this.listaUsuarios.getUsuarioUsername(this.listaPreguntas.getPregunta(ID).getAutor()).restarReputacionRelativa(2);
                    //Voto realizado negativo
                }


            }
            //O se verifica que existe ID respuesta
            else if (this.listaRespuestas.verificarID(ID))
            {//votar una respuesta

                if (this.listaRespuestas.getRespuesta(ID).aumentarVoto(opcion))
                {//votar positivamente
                    //Se suma reputacion segun enunciado
                    this.listaUsuarios.getUsuarioUsername(this.listaRespuestas.getRespuesta(ID).getAutor()).sumarReputacionAbsoluta(10);
                    this.listaUsuarios.getUsuarioUsername(this.listaRespuestas.getRespuesta(ID).getAutor()).sumarReputacionRelativa(10);
                    //Voto positivo realizado
                }
                else
                {//votar negativamente
                 //Se suma reputacion segun enunciado
                    this.listaUsuarios.getUsuarioUsername(this.listaRespuestas.getRespuesta(ID).getAutor()).restarReputacionAbsoluta(2);
                    this.listaUsuarios.getUsuarioUsername(this.listaRespuestas.getRespuesta(ID).getAutor()).restarReputacionRelativa(2);
                    this.listaUsuarios.getUsuario(this.indexActivo).restarReputacionAbsoluta(1);
                    this.listaUsuarios.getUsuario(this.indexActivo).restarReputacionRelativa(1);
                    //Voto negativo realizado
                }
            }

        }

        
    }
}
