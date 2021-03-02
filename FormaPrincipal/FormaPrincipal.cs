using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codigo;

namespace FormaPrincipal
{
    /// <summary>
    /// Clase formulario principal
    /// </summary>
    public partial class FormaPrincipal : Form
    {
        Sistema sistema;
        /// <summary>
        /// Crea un formulario principal
        /// </summary>
        public FormaPrincipal()
        {
            InitializeComponent();
            this.sistema = new Sistema();
        }

        /// <summary>
        /// Permite autenticar a un usuario
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Datos formDatos = new Datos();
            if(formDatos.ShowDialog() == DialogResult.OK)
            {
                if(sistema.login(formDatos.getUser(), formDatos.getPass()))
                {
                    MessageBox.Show("Autenticado");
                    buttonLogin.Hide();
                    buttonRegister.Hide();
                    buttonLogout.Show();
                    buttonAgregarPregunta.Show();
                    buttonAceptarRespuestas.Show();
                    labelReputacion.Show();
                    labelReputacionRelativa.Show();
                    labelCantidadReputacionRelativa.Show();
                    labelCantidadReputacion.Show();
                    labelCantidadReputacionRelativa.Text = sistema.GetListaUsuarios.getUsuario(this.sistema.getIndexActivo).getReputacionRelativa().ToString();
                    labelCantidadReputacion.Text = sistema.GetListaUsuarios.getUsuario(this.sistema.getIndexActivo).getReputacion().ToString();
                    labelNombreUser.Text = "Bienvenido " + sistema.GetListaUsuarios.getUsuario(sistema.getIndexActivo).getUsername();
                    buttonVotar.Show();
                }
                else
                {
                    MessageBox.Show("Error al autenticar");
                }
            }

        }

        /// <summary>
        /// Permite registrar a un usuario
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Datos formRegister = new Datos();
            if (formRegister.ShowDialog() == DialogResult.OK)
            {
                if (sistema.Register(formRegister.getUser(), formRegister.getPass()))
                {
                    MessageBox.Show("Se agrego correctamente");

                    
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        /// <summary>
        /// Permite cerrar sesion
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            Datos formLogout = new Datos();
            if (formLogout.ShowDialog() == DialogResult.OK)
            {
                if (sistema.logout(formLogout.getUser(), formLogout.getPass()))
                {
                    MessageBox.Show("Sesion cerrada con exito");
                    buttonLogin.Show();
                    buttonRegister.Show();
                    buttonLogout.Hide();
                    buttonAgregarPregunta.Hide();
                    buttonAceptarRespuestas.Hide();
                    labelReputacion.Hide();
                    labelCantidadReputacion.Hide();
                    labelReputacionRelativa.Hide();
                    labelCantidadReputacionRelativa.Hide();
                    labelNombreUser.Text = "";
                    buttonVotar.Hide();


                }
                else
                {
                    MessageBox.Show("Error al cerrar sesion");
                }
            }
        }

        /// <summary>
        /// Permite salir de la aplicacion
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Permite agregar una pregunta
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void buttonAgregarPregunta_Click(object sender, EventArgs e)
        {
            PreguntaForm preguntaForm = new PreguntaForm(sistema);

            if (preguntaForm.ShowDialog() == DialogResult.OK)
            {
                if (sistema.ask(preguntaForm.getTitulo(), preguntaForm.getListaEtiquetas, preguntaForm.getContenido()))
                {
                    //Guardar la ultima pregunta de la lista en el datagridview
                    int index = dataGridViewPreguntas.Rows.Add();
                    dataGridViewPreguntas.Rows[index].Cells[0].Value = sistema.GetListaPreguntas.getPreguntaIndex(index).getTitulo();
                    dataGridViewPreguntas.Rows[index].Cells[1].Value = sistema.GetListaPreguntas.getPreguntaIndex(index).getContenido();
                    dataGridViewPreguntas.Rows[index].Cells[2].Value = sistema.GetListaPreguntas.getPreguntaIndex(index).getID();
                    dataGridViewPreguntas.Rows[index].Cells[3].Value = sistema.GetListaPreguntas.getPreguntaIndex(index).GetDate;
                    dataGridViewPreguntas.Rows[index].Cells[4].Value = sistema.GetListaPreguntas.getPreguntaIndex(index).getAutor();

                    MessageBox.Show("Pregunta realizada con exito");
                }
                else
                {
                    MessageBox.Show("Error al completar el formulario");
                }
            }
        }

        /// <summary>
        /// Evento de realizar doble click en una celda
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void dataGridViewPreguntas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && sistema.getIndexActivo != -1)
            {

                int ID = Convert.ToInt32(dataGridViewPreguntas.Rows[index].Cells[2].Value);//Conseguir el ID de la pregunta
                Respuestas formRespuestas = new Respuestas(sistema, ID);//Forma de la pregunta
                formRespuestas.ShowDialog();//Mostrar
                labelCantidadReputacion.Text = sistema.GetListaUsuarios.getUsuario(this.sistema.getIndexActivo).getReputacion().ToString();
                labelCantidadReputacionRelativa.Text = sistema.GetListaUsuarios.getUsuario(this.sistema.getIndexActivo).getReputacionRelativa().ToString();
            }
            

        }

        /// <summary>
        /// Permite aceptar respuestas
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void buttonAceptarRespuestas_Click(object sender, EventArgs e)
        {
            Aceptar formaAceptar = new Aceptar(sistema);
            formaAceptar.ShowDialog();
            labelCantidadReputacion.Text = sistema.GetListaUsuarios.getUsuario(this.sistema.getIndexActivo).getReputacion().ToString();
            labelCantidadReputacionRelativa.Text = sistema.GetListaUsuarios.getUsuario(this.sistema.getIndexActivo).getReputacionRelativa().ToString();

        }

        /// <summary>
        /// Permite cargar labels y botones
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void FormaPrincipal_Load(object sender, EventArgs e)
        {
            //Ocultar botones
            labelNombreUser.Text = "";
            buttonLogout.Hide();
            buttonAgregarPregunta.Hide();
            buttonAceptarRespuestas.Hide();
            labelReputacion.Hide();
            labelCantidadReputacion.Hide();
            labelCantidadReputacionRelativa.Hide();
            labelReputacionRelativa.Hide();
            buttonVotar.Hide();

            sistema.Register("user1", "pass1");
            sistema.Register("user2", "pass2");
            sistema.Register("user3", "pass3");


            ListaEtiquetas etiquetas = new ListaEtiquetas();
            etiquetas.agregarEtiqueta(new Etiqueta("C#", "Descripcion de etiqueta 1"));
            etiquetas.agregarEtiqueta(new Etiqueta("Python", "Descripcion de etiqueta 2"));
            //Agregar preguntas
            sistema.login("user1", "pass1");
            sistema.ask("Titulo de pregunta 1", etiquetas, "Contenido de pregunta1");
            sistema.login("user2", "pass2");
            sistema.ask("Titulo de pregunta 2", etiquetas, "contenido de pregunta2");
            sistema.login("user3", "pass3");
            sistema.ask("Titulo de la pregunta 3", etiquetas, "contenido de pregunta 3");
            sistema.logout("user3", "pass3");

            //Agregar etiquetas
            sistema.GetListaEtiquetas.agregarEtiqueta(new Etiqueta("Java", "Descripcion de la etiqueta 1"));
            sistema.GetListaEtiquetas.agregarEtiqueta(new Etiqueta("C#", "Descripcion de la etiqueta 2"));
            sistema.GetListaEtiquetas.agregarEtiqueta(new Etiqueta("Python", "Descripcion de la etiqueta 3"));
            sistema.GetListaEtiquetas.agregarEtiqueta(new Etiqueta("Prolog", "Descripcion de la etiqueta 4"));

            //Se cargan las etiquetas
            for (int i = 0; i < sistema.GetListaPreguntas.cantidadPreguntas(); i++)
            {
                int index = dataGridViewPreguntas.Rows.Add();
                dataGridViewPreguntas.Rows[index].Cells[0].Value = sistema.GetListaPreguntas.getPreguntaIndex(index).getTitulo();
                dataGridViewPreguntas.Rows[index].Cells[1].Value = sistema.GetListaPreguntas.getPreguntaIndex(index).getContenido();
                dataGridViewPreguntas.Rows[index].Cells[2].Value = sistema.GetListaPreguntas.getPreguntaIndex(index).getID();
                dataGridViewPreguntas.Rows[index].Cells[3].Value = sistema.GetListaPreguntas.getPreguntaIndex(index).GetDate;
                dataGridViewPreguntas.Rows[index].Cells[4].Value = sistema.GetListaPreguntas.getPreguntaIndex(index).getAutor();


            }

        }

        /// <summary>
        /// Permite votar 
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">eventArgs.</param>
        private void buttonVotar_Click(object sender, EventArgs e)
        {
            Votar formVotar = new Votar(sistema);
            formVotar.ShowDialog();
            labelCantidadReputacion.Text = sistema.GetListaUsuarios.getUsuario(this.sistema.getIndexActivo).getReputacion().ToString();
            labelCantidadReputacionRelativa.Text = sistema.GetListaUsuarios.getUsuario(this.sistema.getIndexActivo).getReputacionRelativa().ToString();
        }
    }
}
