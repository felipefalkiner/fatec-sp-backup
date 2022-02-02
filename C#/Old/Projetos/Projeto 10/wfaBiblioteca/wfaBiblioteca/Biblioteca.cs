using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaBiblioteca
{
    class Publicacao
    {
        private string autor;
        private string titulo;
        private Boolean emprestado;

        public void setAutor(string autor)
        {
            this.autor = autor;
        }

        public string getAutor()
        {
            return (autor);
        }

        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string getTitulo()
        {
            return (titulo);
        }

        public Publicacao(string autor, string titulo)
        {
            setAutor(autor);
            setTitulo(titulo);
            emprestado = false;
        }

        public void emprestar()
        {
            if (emprestado == false)
            {
                emprestado = true;
                MessageBox.Show("Livro foi emprestado!");
            }
            else
            {
                MessageBox.Show("O Livro encontra-se emprestado atualmente!!");
            }
        }

        public void devolver()
        {
            if (emprestado == true)
            {
                emprestado = false;
                MessageBox.Show("O Livro foi Devolvido!");
            }
            else
            {
                MessageBox.Show("O Livro não encontra-se emprestado!");
            }
        }

        public void estaEmprestado()
        {
            if (emprestado == true)
                MessageBox.Show("O Livro encontra-se emprestado!");
            else
                MessageBox.Show("O Livro NÃO encontra-se emprestado!");
        }

        public virtual void imprime()
        {
            /* socorro */
        }

      

    }

    class Livro: Publicacao
    {
        private int edicao;
        private string isbn;

        public void setEdicao(int edicao)
        {
            this.edicao = edicao;
        }

        public void setISBN(string isbn)
        {
            this.isbn = isbn;
        }

        public int getEdicao()
        {
            return (edicao);
        }

        public int getISBN()
        {
          
            return Int32.Parse(isbn);
        }

        public override void imprime()
        {
            /* me ajuda */
        }

        public Livro(string autor, string titulo, int edicao, string isbn): base (autor, titulo)
        {
            setEdicao(edicao);
            setISBN(isbn);
        }
    }

}