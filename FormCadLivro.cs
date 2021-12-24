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
    public partial class FormCadLivro : Form
    {
        public FormCadLivro()
        {
            InitializeComponent();
        }

        private void FormCadLivro_Load(object sender, EventArgs e)
        {
            foreach (Autor a in FormPrincipal.Autores)
            {
                cbxNomedoAutor.Items.Add(a.Nome);
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Livro lv = new Livro();
            lv.Id = int.Parse(txtId.Text);
            lv.Editora = txtEditora.Text;
            lv.Paginas = int.Parse(txtPaginas.Text);
            lv.Titulo = txtTitulo.Text;


            //int valorGeneroLivro = cbxGenero.SelectedIndex;
            //lv.GeneroLivro = (Genero)valorGeneroLivro;
            string valorGeneroLivro =
                cbxGenero.SelectedItem.ToString();
            switch (valorGeneroLivro)
            {
                case "Aventura":
                    lv.GeneroLivro = Genero.Aventura;
                    break;
                case "Comedia":
                    lv.GeneroLivro = Genero.Comedia;
                    break;
                case "Drama":
                    lv.GeneroLivro = Genero.Drama;
                    break;
                case "FicCientifica":
                    lv.GeneroLivro = Genero.FicCientifica;
                    break;
                case "Romance":
                    lv.GeneroLivro = Genero.Romance;
                    break;
                case "Suspense":
                    lv.GeneroLivro = Genero.Suspense;
                    break;
                case "Terror":
                    lv.GeneroLivro = Genero.Terror;
                    break;
                default:
                    lv.GeneroLivro = Genero.Aventura;
                    break;
            }

            lv.Ano = dtpAno.Value.Year;

            string autorselecionado = cbxNomedoAutor.SelectedItem.ToString();
            lv.NomeAutor = lv.ProcurarAutor(autorselecionado);
            
            if(lv.NomeAutor == null)
            {
                MessageBox.Show("Autor não encontrado na base!");
                return;
            }

            bool cadastrou = lv.Cadastrar(ref FormPrincipal.Livros);

            if(cadastrou == true)
            {
                lv.NomeAutor.Livros.Add(lv);
                MessageBox.Show("Cadastro Efetuado com sucesso",
                    "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Dispose();
            }
            else
            {
                MessageBox.Show("Cadastro Não Efetuado",
                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
