using Microsoft.Data.Sqlite;
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