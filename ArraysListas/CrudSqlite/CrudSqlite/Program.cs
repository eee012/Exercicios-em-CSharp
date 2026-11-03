using Microsoft.Data.Sqlite;
using System.Runtime.CompilerServices;
//Verificando conexao com banco de dados:
//Criar a tabela para trabalhar com persistencia de dados

var conn = new SqliteConnection("Data Source = frutas.db");
conn.Open();
var criarTabela = conn.CreateCommand();
criarTabela.CommandText = @"CREATE TABLE IF NOT EXISTS frutas (
                              idFruta INTEGER PRIMARY KEY AUTOINCREMENT,
                              nomeFruta TEXT NOT NULL UNIQUE)";
criarTabela.ExecuteNonQuery();

Console.WriteLine($"Banco frutas criado em: {Path.GetFullPath("frutas.db")}");

// -------------MENU----------------


List<string> listaFrutas = new List<string>();
int opcao;
do
{
    MostrarMenu();
    String entrada = Perguntar("Opcao: ");

    if (!int.TryParse(entrada, out opcao))
    {
    opcao = -1;
    }
    switch (opcao)
{
        case 1:
            ListarFrutas();
            break;
        case 2:
            AdicionarFrutas();
            break;
        case 3:
            AtualizarFrutas();
            break;
        case 4:
            DeletarFrutas();
            break;
        case 5:
            VerificarExiste();
            break;
        case 6:
            OrdenarLista();
            break;
    case 0:
        Console.WriteLine("Ate Mais!");
        break;
    default:
        Console.WriteLine("Opcao Invalida!");
        break;
}
}while (opcao != 0) ;

void ListarFrutas()
{
    listaFrutas = new List<string>();

    //Monto o comando para executar a query apartir da conexao 
    var selecionarFrutas = conn.CreateCommand();
    selecionarFrutas.CommandText = "" +
        "SELECT nomeFruta FROM frutas ORDER BY nomeFruta asc";

    //executar a query
    var leitor = selecionarFrutas.ExecuteReader();
    while (leitor.Read())
    {
        listaFrutas.Add(leitor.GetString(0));
    }
    leitor.Close();

    foreach (var f in listaFrutas)
    {
        Console.WriteLine(f);
    }
}


string Perguntar(string mensagem)
{
    Console.WriteLine(mensagem);
    return (Console.ReadLine()!.Trim()!);
}

void MostrarMenu()
{
    Console.WriteLine();
    Console.WriteLine("===== FRUTAS =====");
    Console.WriteLine("[1] - Listar Frutas");
    Console.WriteLine("[2] - Adicionar Frutas");
    Console.WriteLine("[3] - Atualizar Frutas");
    Console.WriteLine("[4] - Remover Frutas");
    Console.WriteLine("[5] - Verificar se Existe");
    Console.WriteLine("[6] - Ordenar Lista");
    Console.WriteLine("[0] - Sair");
}

void AdicionarFrutas()
{
    Console.WriteLine("Informe o nome da fruta nova: ");
    string frutanova = Console.ReadLine()!;
    if (listaFrutas.Contains(frutanova))
    {
        Console.WriteLine("A lista ja possui essa fruta");
    }
    else if (frutanova == "")
    {
        Console.WriteLine("O nome nao pode ficar vazio.");
    }
    else
    {
        //1. banco
        var inserir = conn.CreateCommand();
        inserir.CommandText = "INSERT INTO frutas(nomeFruta) VALUES ($nomeFruta)";
        inserir.Parameters.AddWithValue("$nomeFruta", frutanova);
        inserir.ExecuteNonQuery();

        //2. Adiciona na lista
        listaFrutas.Add(frutanova);
        Console.WriteLine($"{frutanova} adicionada com sucesso!");
    }
}

void AtualizarFrutas()
{
    Console.WriteLine("====Lista de Frutas====");
    ListarFrutas();

    Console.WriteLine("Digite a fruta que quer alterar: ");
    string frutausuario = Console.ReadLine()!;

    Console.WriteLine($"Que fruta deseja colocar no lugar de {frutausuario}?");
    string frutanovauser = Console.ReadLine()!;

    int indice = listaFrutas.IndexOf(frutausuario);

    if (indice == -1)
    {
        Console.WriteLine("A fruta nao existe ou nao foi encontrada!");
    }
    else if (frutanovauser == "" || listaFrutas.Contains(frutanovauser))
    {
        Console.WriteLine("Nome da fruta vazio ou ja existe.");
    }
    else
    {
        var atualizar = conn.CreateCommand();
        atualizar.CommandText = "UPDATE frutas SET nomeFruta = $novoNome WHERE nomeFruta = $antigoNome";
        atualizar.Parameters.AddWithValue("$novoNome", frutanovauser);
        atualizar.Parameters.AddWithValue("$antigoNome", frutausuario);
        atualizar.ExecuteNonQuery();

        listaFrutas[indice] = frutanovauser;
        Console.WriteLine($"A fruta {frutausuario} foi atualizada para {frutanovauser}");
    }
}
void DeletarFrutas()
{
    ListarFrutas();
    Console.WriteLine("Informe o nome da fruta a deletar: ");
    string frutatodelete = Console.ReadLine()!;
    if (!listaFrutas.Contains(frutatodelete))
    {
        Console.WriteLine("Fruta nao encontrada.");
    }
    else
    {
        var deletar = conn.CreateCommand();
        deletar.CommandText = "DELETE FROM frutas WHERE nomeFruta = $frutaDelete";
        deletar.Parameters.AddWithValue("$frutaDelete", frutatodelete);
        deletar.ExecuteNonQuery();

        listaFrutas.Remove(frutatodelete);
        Console.WriteLine("Fruta deletada com sucesso!");
    }
}

void VerificarExiste()
{
    Console.WriteLine("Informe a fruta a verificar: ");
    string verificacao = Console.ReadLine()!;

    var buscar = conn.CreateCommand();
    buscar.CommandText = "SELECT COUNT(1) FROM frutas WHERE nomeFruta = $verificacaoFruta";
    buscar.Parameters.AddWithValue("$verificacaoFruta", verificacao); 
    buscar.ExecuteNonQuery();

    int quantidade = Convert.ToInt32(buscar.ExecuteScalar());

    if (listaFrutas.Contains(verificacao) && quantidade > 0)
    {
        Console.WriteLine($"A fruta {verificacao} esta na lista!");
    }
    else
    {
        Console.WriteLine("Fruta nao encontrada!");
    }
}

void OrdenarLista()
{

}
