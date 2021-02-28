
namespace FormaPrincipal
{
    partial class Aceptar
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
            this.dataGridViewPreguntasAccept = new System.Windows.Forms.DataGridView();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.ColumnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreguntasAccept)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPreguntasAccept
            // 
            this.dataGridViewPreguntasAccept.AllowUserToAddRows = false;
            this.dataGridViewPreguntasAccept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreguntasAccept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitulo,
            this.ColumnContenido,
            this.ColumnID});
            this.dataGridViewPreguntasAccept.Location = new System.Drawing.Point(30, 77);
            this.dataGridViewPreguntasAccept.MultiSelect = false;
            this.dataGridViewPreguntasAccept.Name = "dataGridViewPreguntasAccept";
            this.dataGridViewPreguntasAccept.ReadOnly = true;
            this.dataGridViewPreguntasAccept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPreguntasAccept.Size = new System.Drawing.Size(346, 167);
            this.dataGridViewPreguntasAccept.TabIndex = 0;
            this.dataGridViewPreguntasAccept.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPreguntasAccept_CellDoubleClick);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(501, 27);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 1;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
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
            this.ColumnContenido.Width = 200;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            // 
            // Aceptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 319);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.dataGridViewPreguntasAccept);
            this.Name = "Aceptar";
            this.Text = "Aceptar";
            this.Load += new System.EventHandler(this.Aceptar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreguntasAccept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPreguntasAccept;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
    }
}