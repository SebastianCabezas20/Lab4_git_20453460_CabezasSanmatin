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
    public partial class RespuestasAccept : Form
    {
        private Sistema sistema;
        private int IDPregunta;
        public RespuestasAccept(int ID, Sistema sistem)
        {
            InitializeComponent();
            this.sistema = sistem;
            this.IDPregunta = ID;
        }
    }
}
