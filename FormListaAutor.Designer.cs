
namespace WFBook
{
    partial class FormListaAutor
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
            this.dgvListarAutor = new System.Windows.Forms.DataGridView();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLivros = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarAutor
            // 
            this.dgvListarAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarAutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnID,
            this.clnNome,
            this.clnSexo,
            this.clnLivros});
            this.dgvListarAutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListarAutor.Location = new System.Drawing.Point(0, 0);
            this.dgvListarAutor.Name = "dgvListarAutor";
            this.dgvListarAutor.RowTemplate.Height = 25;
            this.dgvListarAutor.Size = new System.Drawing.Size(595, 152);
            this.dgvListarAutor.TabIndex = 0;
            // 
            // clnID
            // 
            this.clnID.HeaderText = "ID";
            this.clnID.Name = "clnID";
            this.clnID.Width = 50;
            // 
            // clnNome
            // 
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.Width = 200;
            // 
            // clnSexo
            // 
            this.clnSexo.HeaderText = "Sexo";
            this.clnSexo.Name = "clnSexo";
            // 
            // clnLivros
            // 
            this.clnLivros.HeaderText = "Livros";
            this.clnLivros.Name = "clnLivros";
            this.clnLivros.Width = 200;
            // 
            // FormListaAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 152);
            this.Controls.Add(this.dgvListarAutor);
            this.Name = "FormListaAutor";
            this.Text = "FormListaAutor";
            this.Load += new System.EventHandler(this.FormListaAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarAutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSexo;
        private System.Windows.Forms.DataGridViewComboBoxColumn clnLivros;
    }
}