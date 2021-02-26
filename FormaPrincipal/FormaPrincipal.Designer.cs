
namespace FormaPrincipal
{
    partial class FormaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNombreUser = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.dataGridViewPreguntas = new System.Windows.Forms.DataGridView();
            this.ColumnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonAgregarPregunta = new System.Windows.Forms.Button();
            this.buttonAceptarRespuestas = new System.Windows.Forms.Button();
            this.labelReputacion = new System.Windows.Forms.Label();
            this.labelReputacionRelativa = new System.Windows.Forms.Label();
            this.labelCantidadReputacion = new System.Windows.Forms.Label();
            this.labelCantidadReputacionRelativa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(276, 29);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(227, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "SISTEMA DE PREGUNTAS Y RESPUESTAS";
            // 
            // labelNombreUser
            // 
            this.labelNombreUser.AutoSize = true;
            this.labelNombreUser.Location = new System.Drawing.Point(232, 78);
            this.labelNombreUser.Name = "labelNombreUser";
            this.labelNombreUser.Size = new System.Drawing.Size(35, 13);
            this.labelNombreUser.TabIndex = 3;
            this.labelNombreUser.Text = "label4";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(30, 29);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(30, 68);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(30, 108);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewPreguntas
            // 
            this.dataGridViewPreguntas.AllowUserToAddRows = false;
            this.dataGridViewPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitulo,
            this.ColumnContenido,
            this.ColumnID,
            this.ColumnFecha,
            this.ColumnAutor});
            this.dataGridViewPreguntas.Location = new System.Drawing.Point(178, 126);
            this.dataGridViewPreguntas.MultiSelect = false;
            this.dataGridViewPreguntas.Name = "dataGridViewPreguntas";
            this.dataGridViewPreguntas.ReadOnly = true;
            this.dataGridViewPreguntas.Size = new System.Drawing.Size(540, 150);
            this.dataGridViewPreguntas.TabIndex = 7;
            this.dataGridViewPreguntas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPreguntas_CellDoubleClick);
            // 
            // ColumnTitulo
            // 
            this.ColumnTitulo.HeaderText = "Titulo";
            this.ColumnTitulo.Name = "ColumnTitulo";
            this.ColumnTitulo.ReadOnly = true;
            // 
            // ColumnContenido
            // 
            this.ColumnContenido.HeaderText = "Contenido";
            this.ColumnContenido.Name = "ColumnContenido";
            this.ColumnContenido.ReadOnly = true;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // ColumnAutor
            // 
            this.ColumnAutor.HeaderText = "Autor";
            this.ColumnAutor.Name = "ColumnAutor";
            this.ColumnAutor.ReadOnly = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(590, 18);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 8;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonAgregarPregunta
            // 
            this.buttonAgregarPregunta.Location = new System.Drawing.Point(107, 340);
            this.buttonAgregarPregunta.Name = "buttonAgregarPregunta";
            this.buttonAgregarPregunta.Size = new System.Drawing.Size(124, 23);
            this.buttonAgregarPregunta.TabIndex = 9;
            this.buttonAgregarPregunta.Text = "Agregar pregunta";
            this.buttonAgregarPregunta.UseVisualStyleBackColor = true;
            this.buttonAgregarPregunta.Click += new System.EventHandler(this.buttonAgregarPregunta_Click);
            // 
            // buttonAceptarRespuestas
            // 
            this.buttonAceptarRespuestas.Location = new System.Drawing.Point(321, 340);
            this.buttonAceptarRespuestas.Name = "buttonAceptarRespuestas";
            this.buttonAceptarRespuestas.Size = new System.Drawing.Size(135, 23);
            this.buttonAceptarRespuestas.TabIndex = 10;
            this.buttonAceptarRespuestas.Text = "Aceptar respuestas";
            this.buttonAceptarRespuestas.UseVisualStyleBackColor = true;
            this.buttonAceptarRespuestas.Click += new System.EventHandler(this.buttonAceptarRespuestas_Click);
            // 
            // labelReputacion
            // 
            this.labelReputacion.AutoSize = true;
            this.labelReputacion.Location = new System.Drawing.Point(557, 68);
            this.labelReputacion.Name = "labelReputacion";
            this.labelReputacion.Size = new System.Drawing.Size(80, 13);
            this.labelReputacion.TabIndex = 11;
            this.labelReputacion.Text = "REPUTACION:";
            // 
            // labelReputacionRelativa
            // 
            this.labelReputacionRelativa.AutoSize = true;
            this.labelReputacionRelativa.Location = new System.Drawing.Point(502, 91);
            this.labelReputacionRelativa.Name = "labelReputacionRelativa";
            this.labelReputacionRelativa.Size = new System.Drawing.Size(135, 13);
            this.labelReputacionRelativa.TabIndex = 12;
            this.labelReputacionRelativa.Text = "REPUTACION RELATIVA:";
            // 
            // labelCantidadReputacion
            // 
            this.labelCantidadReputacion.AutoSize = true;
            this.labelCantidadReputacion.Location = new System.Drawing.Point(644, 68);
            this.labelCantidadReputacion.Name = "labelCantidadReputacion";
            this.labelCantidadReputacion.Size = new System.Drawing.Size(35, 13);
            this.labelCantidadReputacion.TabIndex = 13;
            this.labelCantidadReputacion.Text = "label3";
            // 
            // labelCantidadReputacionRelativa
            // 
            this.labelCantidadReputacionRelativa.AutoSize = true;
            this.labelCantidadReputacionRelativa.Location = new System.Drawing.Point(644, 91);
            this.labelCantidadReputacionRelativa.Name = "labelCantidadReputacionRelativa";
            this.labelCantidadReputacionRelativa.Size = new System.Drawing.Size(35, 13);
            this.labelCantidadReputacionRelativa.TabIndex = 14;
            this.labelCantidadReputacionRelativa.Text = "label4";
            // 
            // FormaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCantidadReputacionRelativa);
            this.Controls.Add(this.labelCantidadReputacion);
            this.Controls.Add(this.labelReputacionRelativa);
            this.Controls.Add(this.labelReputacion);
            this.Controls.Add(this.buttonAceptarRespuestas);
            this.Controls.Add(this.buttonAgregarPregunta);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.dataGridViewPreguntas);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelNombreUser);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormaPrincipal";
            this.Text = "Forma Principal";
            this.Load += new System.EventHandler(this.FormaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNombreUser;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.DataGridView dataGridViewPreguntas;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonAgregarPregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAutor;
        private System.Windows.Forms.Button buttonAceptarRespuestas;
        private System.Windows.Forms.Label labelReputacion;
        private System.Windows.Forms.Label labelReputacionRelativa;
        private System.Windows.Forms.Label labelCantidadReputacion;
        private System.Windows.Forms.Label labelCantidadReputacionRelativa;
    }
}

