
namespace WFBook
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnsCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.subItemCadLivro = new System.Windows.Forms.ToolStripMenuItem();
            this.subItemCadAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsListar = new System.Windows.Forms.ToolStripMenuItem();
            this.subItemListLivro = new System.Windows.Forms.ToolStripMenuItem();
            this.subItemListAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPrincipal.BackgroundImage")));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCadastrar,
            this.mnsListar,
            this.mnsSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mnsCadastrar
            // 
            this.mnsCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subItemCadLivro,
            this.subItemCadAutor});
            this.mnsCadastrar.Name = "mnsCadastrar";
            this.mnsCadastrar.Size = new System.Drawing.Size(69, 20);
            this.mnsCadastrar.Text = "Cadastrar";
            // 
            // subItemCadLivro
            // 
            this.subItemCadLivro.Name = "subItemCadLivro";
            this.subItemCadLivro.Size = new System.Drawing.Size(180, 22);
            this.subItemCadLivro.Text = "Cadastrar Livro";
            this.subItemCadLivro.Click += new System.EventHandler(this.subItemCadLivro_Click);
            // 
            // subItemCadAutor
            // 
            this.subItemCadAutor.Name = "subItemCadAutor";
            this.subItemCadAutor.Size = new System.Drawing.Size(180, 22);
            this.subItemCadAutor.Text = "Cadastrar Autor";
            this.subItemCadAutor.Click += new System.EventHandler(this.subItemCadAutor_Click);
            // 
            // mnsListar
            // 
            this.mnsListar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subItemListLivro,
            this.subItemListAutor});
            this.mnsListar.Name = "mnsListar";
            this.mnsListar.Size = new System.Drawing.Size(47, 20);
            this.mnsListar.Text = "Listar";
            // 
            // subItemListLivro
            // 
            this.subItemListLivro.Name = "subItemListLivro";
            this.subItemListLivro.Size = new System.Drawing.Size(135, 22);
            this.subItemListLivro.Text = "Listar Livro";
            this.subItemListLivro.Click += new System.EventHandler(this.subItemListLivro_Click);
            // 
            // subItemListAutor
            // 
            this.subItemListAutor.Name = "subItemListAutor";
            this.subItemListAutor.Size = new System.Drawing.Size(135, 22);
            this.subItemListAutor.Text = "Listar Autor";
            this.subItemListAutor.Click += new System.EventHandler(this.subItemListAutor_Click);
            // 
            // mnsSair
            // 
            this.mnsSair.Name = "mnsSair";
            this.mnsSair.Size = new System.Drawing.Size(38, 20);
            this.mnsSair.Text = "Sair";
            this.mnsSair.Click += new System.EventHandler(this.mnsSair_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFBook.Properties.Resources.telaaaa;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnsCadastrar;
        private System.Windows.Forms.ToolStripMenuItem subItemCadLivro;
        private System.Windows.Forms.ToolStripMenuItem subItemCadAutor;
        private System.Windows.Forms.ToolStripMenuItem mnsListar;
        private System.Windows.Forms.ToolStripMenuItem subItemListLivro;
        private System.Windows.Forms.ToolStripMenuItem subItemListAutor;
        private System.Windows.Forms.ToolStripMenuItem mnsSair;
    }
}

