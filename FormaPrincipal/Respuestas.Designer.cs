
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
            this.dataGridViewRespuestas = new System.Windows.Forms.DataGridView();
            this.ColumnContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAgregarRespuesta = new System.Windows.Forms.Button();
            this.textBoxContenidoRespuesta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRespuestas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRespuestas
            // 
            this.dataGridViewRespuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRespuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnContenido,
            this.ColumnAutor,
            this.ColumnID,
            this.ColumnFecha,
            this.ColumnEstado});
            this.dataGridViewRespuestas.Location = new System.Drawing.Point(155, 118);
            this.dataGridViewRespuestas.Name = "dataGridViewRespuestas";
            this.dataGridViewRespuestas.ReadOnly = true;
            this.dataGridViewRespuestas.Size = new System.Drawing.Size(543, 150);
            this.dataGridViewRespuestas.TabIndex = 0;
            // 
            // ColumnContenido
            // 
            this.ColumnContenido.HeaderText = "Contenido";
            this.ColumnContenido.Name = "ColumnContenido";
            this.ColumnContenido.ReadOnly = true;
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
            // buttonAgregarRespuesta
            // 
            this.buttonAgregarRespuesta.Location = new System.Drawing.Point(64, 294);
            this.buttonAgregarRespuesta.Name = "buttonAgregarRespuesta";
            this.buttonAgregarRespuesta.Size = new System.Drawing.Size(135, 23);
            this.buttonAgregarRespuesta.TabIndex = 1;
            this.buttonAgregarRespuesta.Text = "Agregar respuesta";
            this.buttonAgregarRespuesta.UseVisualStyleBackColor = true;
            this.buttonAgregarRespuesta.Click += new System.EventHandler(this.buttonAgregarRespuesta_Click);
            // 
            // textBoxContenidoRespuesta
            // 
            this.textBoxContenidoRespuesta.Location = new System.Drawing.Point(64, 323);
            this.textBoxContenidoRespuesta.Name = "textBoxContenidoRespuesta";
            this.textBoxContenidoRespuesta.Size = new System.Drawing.Size(251, 20);
            this.textBoxContenidoRespuesta.TabIndex = 2;
            // 
            // Respuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 375);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.Button buttonAgregarRespuesta;
        private System.Windows.Forms.TextBox textBoxContenidoRespuesta;
    }
}