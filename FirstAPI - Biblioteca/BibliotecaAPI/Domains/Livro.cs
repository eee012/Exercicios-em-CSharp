namespace BibliotecaAPI.Domains
{
    // DOMAIN -> representa um livro (cada linha vira um objeto Livro)
    // ENTIDADE Livro
    // Representação de uma tabela no banco de dados
    public class Livro
    {
        public int IdLivro { get; set; } // 0
        public string Titulo { get; set; } = string.Empty; //1
        public string Autor { get; set; } = string.Empty; //2
        public int AnoPublicacao {  get; set; } //3
        public bool LivroAlugado { get; set; } //4
    }
}
