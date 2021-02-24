
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnButtonAceptar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnContenido,
            this.ColumnAutor,
            this.ColumnID,
            this.ColumnButtonAceptar});
            this.dataGridView1.Location = new System.Drawing.Point(42, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnContenido
            // 
            this.ColumnContenido.HeaderText = "Contenido";
            this.ColumnContenido.Name = "ColumnContenido";
            // 
            // ColumnAutor
            // 
            this.ColumnAutor.HeaderText = "Autor";
            this.ColumnAutor.Name = "ColumnAutor";
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnButtonAceptar
            // 
            this.ColumnButtonAceptar.HeaderText = "Aceptar";
            this.ColumnButtonAceptar.Name = "ColumnButtonAceptar";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(588, 28);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 1;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            // 
            // RespuestasAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RespuestasAccept";
            this.Text = "RespuestasAccept";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnButtonAceptar;
        private System.Windows.Forms.Button buttonVolver;
    }
}