using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBook
{
    public enum Sexo
    {
        Masculino = 1,
        Feminino,
        Outro
    }
    public class Autor
    {
        public int Id;//Textobox
        public string Nome;//Textbox
        public Sexo SexoAutor;//Radiobutton
        public List<Livro> Livros = new List<Livro>();//Combobox

        public bool Cadastrar(ref List<Autor> lista)
        {
            lista.Add(this);
            return true;
        }
    }
}
