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
    public partial class FormCadAutor : Form
    {
        public FormCadAutor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Autor au = new Autor();
            au.Id = int.Parse(txtId.Text);

            if (txtNome.Text.Length > 4)
                au.Nome = txtNome.Text;
            else
            {
                MessageBox.Show("O nome do autor é inválido!");
                return;
            }

            if (rdbMasculino.Checked == true)
                au.SexoAutor = Sexo.Masculino;
            else if (rdbFeminino.Checked == true)
                au.SexoAutor = Sexo.Feminino;
            else if (rdbOutro.Checked == true)
                au.SexoAutor = Sexo.Outro;
            else
            {
                MessageBox.Show("Deve preencher o sexo do autor");
                return;
            }

            bool cadastrou = au.Cadastrar(ref FormPrincipal.Autores);

            if (cadastrou == true)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Cadastro não efetuado!");
                return;
            }








        }
    }
}
