////Array - estrutura de dados unidimensional
//// aceita um unico tipo de dados (int, string, obj)
//// estrutura (colecao de tamanho fixo 
////definida no momento da criacao

////criacao 
//int[] valores = { 15, 20, 36 }; //cada valor chamado de INDEX. comeca pelo 0. 0, 1, 2.
//Console.WriteLine(0); //1, //2. //se o index for fora de alcance, da erro.

////anotando as nuances dos arrays no c# mesmo ja sabendo.

//valores[0] = 35;
//foreach (int val in valores)
//{
//    Console.WriteLine(val);
//}

//int[] valores2 = new int[5];//0, 1, 2, 3, 4. Significa: int valores2 array igual a novo array com 5 items

//for  (int i = 0; i < valores2.Length; i++) 
//{
//    Console.WriteLine($"Informe o {i+1} valor");
//    valores2[i] = int.Parse(Console.ReadLine()!);
//}

//int teste = 1;

//foreach (int v2 in valores2)
//{
//    Console.WriteLine($"\n Seu {teste++} valor foi: {v2}");
//}

////LISTAS!!!

//List<int> valorzoes = new List<int> { 1, 2, 3 };
//foreach  (var item in valorzoes)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine($"Comprimento atual da lista: {valorzoes.Count}");

//valorzoes[1] = 22;
////metodos de listas
////ADD VALORES:
//valorzoes.Add(30); //adiciona no final)
//valorzoes.Insert(1, 29); //posicao, valor

//REMOVER VALORES: remove, removeat, remove all, clear
//valoroes.Remove(valor); 
//ex: valorzoes.Remove(29); Remove pelo primeiro que achar.
//valorzoes.RemoveAt(1); Remove pelo Index/Posicao especificada (nesse caso, posicao 1)
//valorzoes.RemoveAll(x => x == 30); //neses caso, remove todas as instancias de 30. CHAMADO EXPRESSAO LAMBDA!
//Cria uma variavel (x =>) e atribui a variavel ao valor que procuramos. (x == 30)
//valorzoes.Clear(); //remove todos

//BUSCAR E CONSULTAR:
//contains, indexof, find, findindex, exists, find all

//(valorzoes.Contains(valor)); (Retorna True ou False)

//(valorzoes.IndexOf(posicao)) Retorna a primeira instancia

//(valorzoes.Find(x => x == 1)); Expressao Lambda! Explicacao no Remove All, mas Cria variavel, e atribui valor ao que procuramos.
//Retorna o primeiro elemento com base na condicao que acharmos (nesse caso, 1)
//valorzoes.FindIndex(x => x == 1); Mesma expressao lambda, mas nesse caso, mostra aonde esta a posicao em vez de achar o numero pra nos.
//valorzoes.FindAll(x=> x == 29); Retorna todas as instancias em lista tambem. 
// valorzoes.Exists(x => x == 1); Retora valor booleano (true ou false) pra confirmar se existe.

//METODOS DE ORDENACAO 
//Sort, Reverse
//ordem crescente (sort)
//ordem decrescente

//list.Count(); = valor inteiro do cumprimento da lista.

//foreach (var item in valorzoes)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine($"Comprimento atual da lista: {valorzoes.Count}");

//EXERCICIOS!

//Criar um programa para manipulacao de dados usando listas.
//1. Criar uma lista de frutas.
//2. Adicionar, remover
//3. Verficiar se um elemento esta na lista
//4. atualizar uma fruta existente
//Para isso, utilize as estruturas (se necessario)
//if-else-elseif, while, for, foreach, dowhile e os metodos de listas
//No fim, mostre para o professor.

using System.Threading.Channels;

bool confirmacao_fruitend = false;
string confirmacao_fruit;
string confirmacao_add;
bool confirmacao_addend;
List<string> frutas = new List<string>();

do
{
    Console.WriteLine("Digite as frutas guardadas:");
    string frutas_guard = Console.ReadLine()!;
    frutas.Add(frutas_guard);

    Console.WriteLine("Deseja continuar? (S/N)");
    confirmacao_fruit = Console.ReadLine()!.ToUpper();

    while (confirmacao_fruit != "S" && confirmacao_fruit != "N")
    {
        Console.WriteLine("Opção Inválida! Use S ou N");
        confirmacao_fruit = Console.ReadLine()!.ToUpper();
    }

    if (confirmacao_fruit == "S")
    {
        confirmacao_fruitend = false;
    }
    else if (confirmacao_fruit == "N")
    {
        confirmacao_fruitend = true;
    }

} while (confirmacao_fruitend == false);

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}
Console.WriteLine("Deseja adicionar mais uma fruta?");
string add_fruit = Console.ReadLine()!;

if  (add_fruit == "S")
{
    Console.WriteLine("Qual seria?");
    string frutas_guard = Console.ReadLine()!;
    frutas.Add(frutas_guard);
    Console.WriteLine("Mais alguma?");
    confirmacao_add = Console.ReadLine();
}
