
namespace WFBook
{
    partial class FormCadLivro
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
            this.lblAno = new System.Windows.Forms.Label();
            this.dtpAno = new System.Windows.Forms.DateTimePicker();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.cbxNomedoAutor = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(271, 133);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(32, 15);
            this.lblAno.TabIndex = 27;
            this.lblAno.Text = "Ano:";
            // 
            // dtpAno
            // 
            this.dtpAno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAno.Location = new System.Drawing.Point(309, 125);
            this.dtpAno.Name = "dtpAno";
            this.dtpAno.Size = new System.Drawing.Size(121, 23);
            this.dtpAno.TabIndex = 26;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(255, 76);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(48, 15);
            this.lblGenero.TabIndex = 25;
            this.lblGenero.Text = "Gênero:";
            // 
            // cbxGenero
            // 
            this.cbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Comedia",
            "Romance",
            "Drama",
            "Terror",
            "Suspense",
            "Aventura",
            "FicCientifica"});
            this.cbxGenero.Location = new System.Drawing.Point(309, 68);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(121, 23);
            this.cbxGenero.TabIndex = 24;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(66, 128);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(100, 23);
            this.txtEditora.TabIndex = 23;
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(13, 136);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(47, 15);
            this.lblEditora.TabIndex = 22;
            this.lblEditora.Text = "Editora:";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(66, 190);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(100, 23);
            this.txtPaginas.TabIndex = 21;
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(9, 198);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(51, 15);
            this.lblPaginas.TabIndex = 20;
            this.lblPaginas.Text = "Páginas:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(66, 73);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 23);
            this.txtTitulo.TabIndex = 19;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 76);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 15);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Título:";
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.Location = new System.Drawing.Point(213, 32);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(90, 15);
            this.lblNomeAutor.TabIndex = 17;
            this.lblNomeAutor.Text = "Nome do Autor";
            // 
            // cbxNomedoAutor
            // 
            this.cbxNomedoAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNomedoAutor.FormattingEnabled = true;
            this.cbxNomedoAutor.Location = new System.Drawing.Point(309, 24);
            this.cbxNomedoAutor.Name = "cbxNomedoAutor";
            this.cbxNomedoAutor.Size = new System.Drawing.Size(121, 23);
            this.cbxNomedoAutor.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(66, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 15;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(40, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Id:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(355, 184);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 32);
            this.btnCadastrar.TabIndex = 28;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FormCadLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 251);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.dtpAno);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNomeAutor);
            this.Controls.Add(this.cbxNomedoAutor);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "FormCadLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadLivro";
            this.Load += new System.EventHandler(this.FormCadLivro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.DateTimePicker dtpAno;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomeAutor;
        private System.Windows.Forms.ComboBox cbxNomedoAutor;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnCadastrar;
    }
}