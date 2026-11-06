using BibliotecaAPI.Domains;

namespace BibliotecaAPI.Interfaces
{
    // Interface: Listar as operações que qualquer repositório precisa ter
    // ILivroRepository diz o que fazer; A classe repository diz COMO fazer
    public interface ILivroRepository
    {
        //Listar todos os livros
        List<Livro> ListarTodosLivros();
        Livro AdicionarLivro(Livro livro);
        bool AtualizarLivro(int id, Livro livro);
        bool DeletarLivro(int id);

    }
}
