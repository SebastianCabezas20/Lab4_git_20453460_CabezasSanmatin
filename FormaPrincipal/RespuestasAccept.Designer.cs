
namespace FormaPrincipal
{
    partial class RespuestasAccept
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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.ColumnContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnButtonAceptar = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.ColumnButtonAceptar});
            this.dataGridViewRespuestas.Location = new System.Drawing.Point(42, 28);
            this.dataGridViewRespuestas.MultiSelect = false;
            this.dataGridViewRespuestas.Name = "dataGridViewRespuestas";
            this.dataGridViewRespuestas.ReadOnly = true;
            this.dataGridViewRespuestas.Size = new System.Drawing.Size(443, 150);
            this.dataGridViewRespuestas.TabIndex = 0;
            this.dataGridViewRespuestas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRespuestas_CellContentClick);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(614, 28);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 1;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // ColumnContenido
            // 
            this.ColumnContenido.HeaderText = "Contenido";
            this.ColumnContenido.Name = "ColumnContenido";
            this.ColumnContenido.ReadOnly = true;
            this.ColumnContenido.Width = 200;
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
            // ColumnButtonAceptar
            // 
            this.ColumnButtonAceptar.HeaderText = "Aceptar";
            this.ColumnButtonAceptar.Name = "ColumnButtonAceptar";
            this.ColumnButtonAceptar.ReadOnly = true;
            // 
            // RespuestasAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 251);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.dataGridViewRespuestas);
            this.Name = "RespuestasAccept";
            this.Text = "RespuestasAccept";
            this.Load += new System.EventHandler(this.RespuestasAccept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRespuestas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRespuestas;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnButtonAceptar;
    }
}