
namespace FormaPrincipal
{
    partial class Votar
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
            this.dataGridViewVotar = new System.Windows.Forms.DataGridView();
            this.ColumnContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVotosPositivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVotosNegativos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnButtonPositivo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnButtonNegativo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVotar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVotar
            // 
            this.dataGridViewVotar.AllowUserToAddRows = false;
            this.dataGridViewVotar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVotar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnContenido,
            this.ColumnTipo,
            this.ColumnFecha,
            this.ColumnVotosPositivos,
            this.ColumnVotosNegativos,
            this.ColumnButtonPositivo,
            this.ColumnButtonNegativo,
            this.ColumnID});
            this.dataGridViewVotar.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewVotar.MultiSelect = false;
            this.dataGridViewVotar.Name = "dataGridViewVotar";
            this.dataGridViewVotar.ReadOnly = true;
            this.dataGridViewVotar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVotar.Size = new System.Drawing.Size(845, 150);
            this.dataGridViewVotar.TabIndex = 0;
            this.dataGridViewVotar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVotar_CellContentClick);
            // 
            // ColumnContenido
            // 
            this.ColumnContenido.HeaderText = "Contenido";
            this.ColumnContenido.Name = "ColumnContenido";
            this.ColumnContenido.ReadOnly = true;
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.HeaderText = "Tipo";
            this.ColumnTipo.Name = "ColumnTipo";
            this.ColumnTipo.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // ColumnVotosPositivos
            // 
            this.ColumnVotosPositivos.HeaderText = "Votos positivos";
            this.ColumnVotosPositivos.Name = "ColumnVotosPositivos";
            this.ColumnVotosPositivos.ReadOnly = true;
            // 
            // ColumnVotosNegativos
            // 
            this.ColumnVotosNegativos.HeaderText = "Negativos";
            this.ColumnVotosNegativos.Name = "ColumnVotosNegativos";
            this.ColumnVotosNegativos.ReadOnly = true;
            // 
            // ColumnButtonPositivo
            // 
            this.ColumnButtonPositivo.HeaderText = "Positivo";
            this.ColumnButtonPositivo.Name = "ColumnButtonPositivo";
            this.ColumnButtonPositivo.ReadOnly = true;
            // 
            // ColumnButtonNegativo
            // 
            this.ColumnButtonNegativo.HeaderText = "Negativo";
            this.ColumnButtonNegativo.Name = "ColumnButtonNegativo";
            this.ColumnButtonNegativo.ReadOnly = true;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(52, 37);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 1;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // Votar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.dataGridViewVotar);
            this.Name = "Votar";
            this.Text = "Votar";
            this.Load += new System.EventHandler(this.Votar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVotar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVotar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVotosPositivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVotosNegativos;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnButtonPositivo;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnButtonNegativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.Button buttonVolver;
    }
}