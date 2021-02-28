
namespace FormaPrincipal
{
    partial class PreguntaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBoxEtiquetas = new System.Windows.Forms.CheckedListBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelPregunta = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxPregunta = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelTituloEtiquetas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombreEtiquetas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAgregarEtiqueta = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkedListBoxEtiquetas
            // 
            this.checkedListBoxEtiquetas.FormattingEnabled = true;
            this.checkedListBoxEtiquetas.Location = new System.Drawing.Point(368, 85);
            this.checkedListBoxEtiquetas.Name = "checkedListBoxEtiquetas";
            this.checkedListBoxEtiquetas.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxEtiquetas.TabIndex = 0;
            this.checkedListBoxEtiquetas.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxEtiquetas_SelectedIndexChanged);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(70, 79);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(36, 13);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Titulo:";
            // 
            // labelPregunta
            // 
            this.labelPregunta.AutoSize = true;
            this.labelPregunta.Location = new System.Drawing.Point(53, 119);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(53, 13);
            this.labelPregunta.TabIndex = 2;
            this.labelPregunta.Text = "Pregunta:";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(112, 79);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(231, 20);
            this.textBoxTitulo.TabIndex = 3;
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.Location = new System.Drawing.Point(112, 116);
            this.textBoxPregunta.Multiline = true;
            this.textBoxPregunta.Name = "textBoxPregunta";
            this.textBoxPregunta.Size = new System.Drawing.Size(231, 57);
            this.textBoxPregunta.TabIndex = 4;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAceptar.Location = new System.Drawing.Point(110, 208);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 5;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(242, 207);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(426, 202);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(35, 13);
            this.labelDescripcion.TabIndex = 7;
            this.labelDescripcion.Text = "label1";
            // 
            // labelTituloEtiquetas
            // 
            this.labelTituloEtiquetas.AutoSize = true;
            this.labelTituloEtiquetas.Location = new System.Drawing.Point(368, 66);
            this.labelTituloEtiquetas.Name = "labelTituloEtiquetas";
            this.labelTituloEtiquetas.Size = new System.Drawing.Size(68, 13);
            this.labelTituloEtiquetas.TabIndex = 8;
            this.labelTituloEtiquetas.Text = "ETIQUETAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "AGREGAR ETIQUETA";
            // 
            // labelNombreEtiquetas
            // 
            this.labelNombreEtiquetas.AutoSize = true;
            this.labelNombreEtiquetas.Location = new System.Drawing.Point(576, 113);
            this.labelNombreEtiquetas.Name = "labelNombreEtiquetas";
            this.labelNombreEtiquetas.Size = new System.Drawing.Size(88, 13);
            this.labelNombreEtiquetas.TabIndex = 10;
            this.labelNombreEtiquetas.Text = "Nombre etiqueta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripcion :";
            // 
            // buttonAgregarEtiqueta
            // 
            this.buttonAgregarEtiqueta.Location = new System.Drawing.Point(656, 197);
            this.buttonAgregarEtiqueta.Name = "buttonAgregarEtiqueta";
            this.buttonAgregarEtiqueta.Size = new System.Drawing.Size(141, 23);
            this.buttonAgregarEtiqueta.TabIndex = 12;
            this.buttonAgregarEtiqueta.Text = "Agregar etiqueta";
            this.buttonAgregarEtiqueta.UseVisualStyleBackColor = true;
            this.buttonAgregarEtiqueta.Click += new System.EventHandler(this.buttonAgregarEtiqueta_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(667, 110);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 13;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(667, 143);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescripcion.TabIndex = 14;
            // 
            // PreguntaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 323);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonAgregarEtiqueta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNombreEtiquetas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTituloEtiquetas);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxPregunta);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelPregunta);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.checkedListBoxEtiquetas);
            this.Name = "PreguntaForm";
            this.Text = "PreguntaForm";
            this.Load += new System.EventHandler(this.PreguntaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxEtiquetas;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxPregunta;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelTituloEtiquetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombreEtiquetas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAgregarEtiqueta;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
    }
}