using BibliotecaAPI.Domains;
using BibliotecaAPI.Interfaces;

namespace BibliotecaAPI.Services
{
    public class LivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public List<Livro> Listar()
        {
            return _livroRepository.ListarTodosLivros();
        }

        public Livro Adicionar(Livro livro)
        {
            return _livroRepository.AdicionarLivro(livro);
        }

        public bool Atualizar(int id, Livro livro)
        {
            return _livroRepository.AtualizarLivro(id, livro);
        }
    }
}
