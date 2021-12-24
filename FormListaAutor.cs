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
    public partial class FormListaAutor : Form
    {
        public FormListaAutor()
        {
            InitializeComponent();
        }

        private void FormListaAutor_Load(object sender, EventArgs e)
        {
            foreach (Autor au in FormPrincipal.Autores)
            {
                string[] dados = new string[4];
                dados[0] = au.Id.ToString();
                dados[1] = au.Nome;
                dados[2] = au.SexoAutor.ToString();
                
                foreach (Livro lv in au.Livros)
                    clnLivros.Items.Add(lv.Titulo);

                dgvListarAutor.Rows.Add(dados);

            }
            
            
        }
    }
}
