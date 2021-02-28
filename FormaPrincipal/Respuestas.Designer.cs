
namespace FormaPrincipal
{
    partial class Respuestas
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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroupEtiquetas", System.Windows.Forms.HorizontalAlignment.Left);
            this.dataGridViewRespuestas = new System.Windows.Forms.DataGridView();
            this.buttonAgregarRespuesta = new System.Windows.Forms.Button();
            this.textBoxContenidoRespuesta = new System.Windows.Forms.TextBox();
            this.buttonAgregarRecompensa = new System.Windows.Forms.Button();
            this.textBoxRecompensa = new System.Windows.Forms.TextBox();
            this.labelTituloRecompensa = new System.Windows.Forms.Label();
            this.labelCantidadRecompensa = new System.Windows.Forms.Label();
            this.labelTituloPregunta = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCantidadLikes = new System.Windows.Forms.Label();
            this.labelCantidadDislike = new System.Windows.Forms.Label();
            this.listViewEtiquetas = new System.Windows.Forms.ListView();
            this.labelContenidoPregunta = new System.Windows.Forms.Label();
            this.ColumnContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRespuestas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRespuestas
            // 
            this.dataGridViewRespuestas.AllowUserToAddRows = false;
            this.dataGridViewRespuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRespuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnContenido,
            this.ColumnAutor,
            this.ColumnID,
            this.ColumnFecha,
            this.ColumnEstado});
            this.dataGridViewRespuestas.Location = new System.Drawing.Point(147, 241);
            this.dataGridViewRespuestas.MultiSelect = false;
            this.dataGridViewRespuestas.Name = "dataGridViewRespuestas";
            this.dataGridViewRespuestas.ReadOnly = true;
            this.dataGridViewRespuestas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRespuestas.Size = new System.Drawing.Size(588, 150);
            this.dataGridViewRespuestas.TabIndex = 0;
            // 
            // buttonAgregarRespuesta
            // 
            this.buttonAgregarRespuesta.Location = new System.Drawing.Point(91, 419);
            this.buttonAgregarRespuesta.Name = "buttonAgregarRespuesta";
            this.buttonAgregarRespuesta.Size = new System.Drawing.Size(135, 23);
            this.buttonAgregarRespuesta.TabIndex = 1;
            this.buttonAgregarRespuesta.Text = "Agregar respuesta";
            this.buttonAgregarRespuesta.UseVisualStyleBackColor = true;
            this.buttonAgregarRespuesta.Click += new System.EventHandler(this.buttonAgregarRespuesta_Click);
            // 
            // textBoxContenidoRespuesta
            // 
            this.textBoxContenidoRespuesta.Location = new System.Drawing.Point(91, 448);
            this.textBoxContenidoRespuesta.Name = "textBoxContenidoRespuesta";
            this.textBoxContenidoRespuesta.Size = new System.Drawing.Size(251, 20);
            this.textBoxContenidoRespuesta.TabIndex = 2;
            // 
            // buttonAgregarRecompensa
            // 
            this.buttonAgregarRecompensa.Location = new System.Drawing.Point(458, 418);
            this.buttonAgregarRecompensa.Name = "buttonAgregarRecompensa";
            this.buttonAgregarRecompensa.Size = new System.Drawing.Size(153, 23);
            this.buttonAgregarRecompensa.TabIndex = 3;
            this.buttonAgregarRecompensa.Text = "Agregar recompensa";
            this.buttonAgregarRecompensa.UseVisualStyleBackColor = true;
            this.buttonAgregarRecompensa.Click += new System.EventHandler(this.buttonAgregarRecompensa_Click);
            // 
            // textBoxRecompensa
            // 
            this.textBoxRecompensa.Location = new System.Drawing.Point(458, 447);
            this.textBoxRecompensa.Name = "textBoxRecompensa";
            this.textBoxRecompensa.Size = new System.Drawing.Size(153, 20);
            this.textBoxRecompensa.TabIndex = 4;
            this.textBoxRecompensa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTituloRecompensa
            // 
            this.labelTituloRecompensa.AutoSize = true;
            this.labelTituloRecompensa.Location = new System.Drawing.Point(664, 428);
            this.labelTituloRecompensa.Name = "labelTituloRecompensa";
            this.labelTituloRecompensa.Size = new System.Drawing.Size(85, 13);
            this.labelTituloRecompensa.TabIndex = 5;
            this.labelTituloRecompensa.Text = "RECOMPENSA:";
            // 
            // labelCantidadRecompensa
            // 
            this.labelCantidadRecompensa.AutoSize = true;
            this.labelCantidadRecompensa.Location = new System.Drawing.Point(755, 428);
            this.labelCantidadRecompensa.Name = "labelCantidadRecompensa";
            this.labelCantidadRecompensa.Size = new System.Drawing.Size(35, 13);
            this.labelCantidadRecompensa.TabIndex = 6;
            this.labelCantidadRecompensa.Text = "label2";
            // 
            // labelTituloPregunta
            // 
            this.labelTituloPregunta.AutoSize = true;
            this.labelTituloPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloPregunta.Location = new System.Drawing.Point(57, 20);
            this.labelTituloPregunta.Name = "labelTituloPregunta";
            this.labelTituloPregunta.Size = new System.Drawing.Size(57, 20);
            this.labelTituloPregunta.TabIndex = 7;
            this.labelTituloPregunta.Text = "label1";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.Location = new System.Drawing.Point(29, 108);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(45, 16);
            this.labelAutor.TabIndex = 8;
            this.labelAutor.Text = "label2";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(29, 151);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(45, 16);
            this.labelFecha.TabIndex = 9;
            this.labelFecha.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "LIKE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "DISLIKE:";
            // 
            // labelCantidadLikes
            // 
            this.labelCantidadLikes.AutoSize = true;
            this.labelCantidadLikes.Location = new System.Drawing.Point(91, 259);
            this.labelCantidadLikes.Name = "labelCantidadLikes";
            this.labelCantidadLikes.Size = new System.Drawing.Size(35, 13);
            this.labelCantidadLikes.TabIndex = 12;
            this.labelCantidadLikes.Text = "label3";
            // 
            // labelCantidadDislike
            // 
            this.labelCantidadDislike.AutoSize = true;
            this.labelCantidadDislike.Location = new System.Drawing.Point(94, 287);
            this.labelCantidadDislike.Name = "labelCantidadDislike";
            this.labelCantidadDislike.Size = new System.Drawing.Size(35, 13);
            this.labelCantidadDislike.TabIndex = 13;
            this.labelCantidadDislike.Text = "label4";
            // 
            // listViewEtiquetas
            // 
            listViewGroup2.Header = "ListViewGroupEtiquetas";
            listViewGroup2.Name = "Etiquetas";
            this.listViewEtiquetas.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listViewEtiquetas.HideSelection = false;
            this.listViewEtiquetas.Location = new System.Drawing.Point(147, 182);
            this.listViewEtiquetas.Name = "listViewEtiquetas";
            this.listViewEtiquetas.Size = new System.Drawing.Size(543, 53);
            this.listViewEtiquetas.TabIndex = 14;
            this.listViewEtiquetas.UseCompatibleStateImageBehavior = false;
            // 
            // labelContenidoPregunta
            // 
            this.labelContenidoPregunta.AutoSize = true;
            this.labelContenidoPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContenidoPregunta.Location = new System.Drawing.Point(61, 67);
            this.labelContenidoPregunta.Name = "labelContenidoPregunta";
            this.labelContenidoPregunta.Size = new System.Drawing.Size(45, 16);
            this.labelContenidoPregunta.TabIndex = 15;
            this.labelContenidoPregunta.Text = "label3";
            // 
            // ColumnContenido
            // 
            this.ColumnContenido.HeaderText = "Contenido";
            this.ColumnContenido.Name = "ColumnContenido";
            this.ColumnContenido.ReadOnly = true;
            this.ColumnContenido.Width = 250;
            // 
            // ColumnAutor
            // 
            this.ColumnAutor.HeaderText = "Autor";
            this.ColumnAutor.Name = "ColumnAutor";
            this.ColumnAutor.ReadOnly = true;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.ReadOnly = true;
            // 
            // Respuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 485);
            this.Controls.Add(this.labelContenidoPregunta);
            this.Controls.Add(this.listViewEtiquetas);
            this.Controls.Add(this.labelCantidadDislike);
            this.Controls.Add(this.labelCantidadLikes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelTituloPregunta);
            this.Controls.Add(this.labelCantidadRecompensa);
            this.Controls.Add(this.labelTituloRecompensa);
            this.Controls.Add(this.textBoxRecompensa);
            this.Controls.Add(this.buttonAgregarRecompensa);
            this.Controls.Add(this.textBoxContenidoRespuesta);
            this.Controls.Add(this.buttonAgregarRespuesta);
            this.Controls.Add(this.dataGridViewRespuestas);
            this.Name = "Respuestas";
            this.Text = "Respuestas";
            this.Load += new System.EventHandler(this.Respuestas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRespuestas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRespuestas;
        private System.Windows.Forms.Button buttonAgregarRespuesta;
        private System.Windows.Forms.TextBox textBoxContenidoRespuesta;
        private System.Windows.Forms.Button buttonAgregarRecompensa;
        private System.Windows.Forms.TextBox textBoxRecompensa;
        private System.Windows.Forms.Label labelTituloRecompensa;
        private System.Windows.Forms.Label labelCantidadRecompensa;
        private System.Windows.Forms.Label labelTituloPregunta;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCantidadLikes;
        private System.Windows.Forms.Label labelCantidadDislike;
        private System.Windows.Forms.ListView listViewEtiquetas;
        private System.Windows.Forms.Label labelContenidoPregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
    }
}