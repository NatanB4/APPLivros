using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBook
{
    public enum Genero
    {
        Comedia = 1,
        Romance,
        Drama,
        Terror,
        Suspense,
        Aventura,
        FicCientifica

    }
    public class Livro
    {
        public int Id; //Textbox
        public Autor NomeAutor; //Combobox
        public int Paginas;//Textbox
        public string Editora;//Textbox
        public string Titulo;//Textbox
        public Genero GeneroLivro; //Combobox
        public int Ano;//DateTimePicker

        public Autor ProcurarAutor(string nome)
        {
            foreach (Autor a in FormPrincipal.Autores)
            {
                if (a.Nome.Contains(nome) == true)
                    return a;
            }
            return null;
        }

        public bool Cadastrar(ref List<Livro> livros)
        {
            livros.Add(this);
            return true;
        }
    }
}
