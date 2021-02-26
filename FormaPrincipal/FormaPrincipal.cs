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
    public partial class FormaPrincipal : Form
    {
        Sistema sistema;
        public FormaPrincipal()
        {
            InitializeComponent();
            this.sistema = new Sistema();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Datos formDatos = new Datos();
            if(formDatos.ShowDialog() == DialogResult.OK)
            {
                if(sistema.login(formDatos.getUser(), formDatos.getUser()))
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
                }
                else
                {
                    MessageBox.Show("Error al autenticar");
                }
            }

        }

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

        //Logout
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


                }
                else
                {
                    MessageBox.Show("Error al cerrar sesion");
                }
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void buttonAceptarRespuestas_Click(object sender, EventArgs e)
        {
            Aceptar formaAceptar = new Aceptar(sistema);
            formaAceptar.ShowDialog();
            labelCantidadReputacion.Text = sistema.GetListaUsuarios.getUsuario(this.sistema.getIndexActivo).getReputacion().ToString();
            labelCantidadReputacionRelativa.Text = sistema.GetListaUsuarios.getUsuario(this.sistema.getIndexActivo).getReputacionRelativa().ToString();

        }

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

            //Agregar etiquetas
            sistema.GetListaEtiquetas.agregarEtiqueta(new Etiqueta("Java", "Descripcion de la etiqueta 1"));
            sistema.GetListaEtiquetas.agregarEtiqueta(new Etiqueta("C#", "Descripcion de la etiqueta 2"));
            sistema.GetListaEtiquetas.agregarEtiqueta(new Etiqueta("Python", "Descripcion de la etiqueta 3"));
            sistema.GetListaEtiquetas.agregarEtiqueta(new Etiqueta("Prolog", "Descripcion de la etiqueta 4"));
        }
    }
}
