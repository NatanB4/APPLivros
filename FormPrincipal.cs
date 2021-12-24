using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBook
{
    public partial class FormPrincipal : Form
    {
        public static List<Autor> Autores = new List<Autor>();
        public static List<Livro> Livros = new List<Livro>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void subItemCadLivro_Click(object sender, EventArgs e)
        {
            FormCadLivro form = new FormCadLivro();
            form.ShowDialog();
        }

        private void subItemCadAutor_Click(object sender, EventArgs e)
        {
            FormCadAutor form = new FormCadAutor();
            form.ShowDialog();
        }

        private void subItemListLivro_Click(object sender, EventArgs e)
        {
            FormListaLivro form = new FormListaLivro();
            form.ShowDialog();
        }

        private void subItemListAutor_Click(object sender, EventArgs e)
        {
            FormListaAutor form = new FormListaAutor();
            form.ShowDialog();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Voce deseja sair?", "Info", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }

        }
    }
}
