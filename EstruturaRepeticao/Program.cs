////COPIA DA AULA + ANOTACOES

////Sintaxe do for e diferente de Python. for (variavel; condicao; incremento)

////for (int j = 0; j < 12; j++)
////{
////    Console.WriteLine(j);
////}
////

////matriz sao escritos com {} dessa vez. ex:

//string[] nomes = { "Carlao", "Pedro", "Roberto", "Marcos", "Luiz" };
////precisa de uma chave ([])logo depois da variavel, entretanto!!!

////Console.WriteLine(nomes[1]);

////se colocar Console.WriteLine(nomes); assim, raw, vai vir System.String[]...
////voce deve colocar um valor! ex: nomes[0]...

//try
//{
//    //Console.WriteLine(nomes[5]); (da erro)
//    //foreach (var item in nomes)
//    //{
//    //    Console.WriteLine(item);
//    //}

//    for (int i = 0; i < nomes.Length; i++) //gambiarra. i = 0. lembre se que listas sao 01234. se i abaixo que o tamanho da lista do array (0 a 4), incrementa. printar o valor de i.
//    {
//        Console.WriteLine(nomes[i]);
//    }
//}
//catch (Exception) //ou catch(exception)!
//{
//    Console.WriteLine("test!");
//}

////try e meio fail safe. tem o catch tambem. 
////try, catch, except e finally.
////try e except ja sabia.
////aprendi o return com o c#, o break mais ou menos tambem
////e o continue ainda tenho que ver


//int[] numeros = { 2, 4, 6, 8 };
//var soma_num = numeros.Sum();

//foreach (int i in numeros)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine($"A soma dos numeros e: {soma_num} ");

//um jeito mais simplificado de fazer o seguinte:

//int[] numeros = { 2, 4, 6, 8 };
//var variavelCriada = 0;

//foreach (int numero in numeros)
//{
//    Console.WriteLine(numero);

//    variavelCriada += numero;
//}

//Console.WriteLine($"A soma dos numeros e de: {variavelCriada}");

////EXERCICIOS!

//crie um programa que vai pedir um numero para o usuario
//e o programa deve mostrar a tabuada desse numero da seguinte forma
//5x1 = 5
//5x2 = 10...
//5x10 = 50

//int[] lista_tabulagem = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Console.Write("Bem vindo a tabuada. Digite seu numero (1 a 10): ");
//int escolha = int.Parse(Console.ReadLine()!);

//if (escolha < 0 || escolha > 10)
//{
//    Console.WriteLine("Escolha alem da lista!");
//}

//foreach (int num in lista_tabulagem)
//{
//    Console.WriteLine($"{escolha} * {num} = {escolha * num}");
//}

//Fazendo isso de um jeito aonde, caso o usuario queira repetir..

Console.WriteLine("Exercicio 0 - Tabuda com Confirmacao! \n");

bool escolha_conf = false;

while (escolha_conf != true)
{
    int[] lista_tabulagem = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    Console.Write("Digite seu numero (1 a 10): ");
    int escolha = int.Parse(Console.ReadLine()!);

    while (escolha < 1 || escolha > 10)
    {
        Console.Write("Escolha alem da lista! Digite novamente: ");
        escolha = int.Parse(Console.ReadLine()!);
    }


    foreach (int num in lista_tabulagem)
    {
        Console.WriteLine($"{escolha} x {num} = {escolha * num}");
    }

    Console.Write("Deseja continuar? (S/N): ");
    string confirmacao = Console.ReadLine()!.ToUpper()!;

    if (confirmacao == "S")
    {
        escolha_conf = false;
    }
    if (confirmacao == "N")
    {
        escolha_conf = true;
        Console.WriteLine("Fechando programa...");
    }
}

////Comecando propriamente..
////1
////Media com Foreach
////Faca um programa que leia 5 numeros e informe a soma e a media dos numeros.

Console.WriteLine("\n Exercicio 1 - Media com Foreach  \n");

Console.WriteLine("Digite os numeros que voce quer usar: ");
double num1 = double.Parse(Console.ReadLine()!);
double num2 = double.Parse(Console.ReadLine()!);
double num3 = double.Parse(Console.ReadLine()!);
double num4 = double.Parse(Console.ReadLine()!);
double num5 = double.Parse(Console.ReadLine()!);
int cont_num = 0;


double[] listasomed = { num1, num2, num3, num4, num5 };

Console.WriteLine("SOMA DOS ITEMS DADOS: ");
foreach (int item in listasomed)
{
    cont_num += item;
    Console.WriteLine(cont_num);
}
Console.WriteLine("MEDIA DOS ITENS DADOS: ");

double media = cont_num / listasomed.Length;
Console.WriteLine(media);

//2.
//Faca um programa que, dado um conjunto de N numeros 
//determine o menor valor, o maior valor e a soma dos valores

Console.WriteLine("\n Exercicio 2 - Menor, Maior e Soma \n");

Console.WriteLine("Digite a quantidade de numeros que quer usar: ");
int quant_num = int.Parse(Console.ReadLine()!);

int[] numeros = new int[quant_num];

for (int i = 0; i < quant_num; i++)
{
    Console.WriteLine($"Diga seu numero: {i + 1}");
    numeros[i] = int.Parse(Console.ReadLine()!);
}
int menor_num = numeros.Min();
int maior_num = numeros.Max();
int num_soma = numeros.Sum();

Console.WriteLine($"O menor valor foi: {menor_num}, o maior valor foi {maior_num} e a soma foi {num_soma}");

//3.
//Numa eleicao existem tres candidatos. Faca um programa que peca o
//Numero total de eleitores. Peca para cada eleitor votar
//e ao final mostrar o numero de votos de cada candidato 

Console.Write("Digite o numero total de eleitores: ");
int quant_eleitor = int.Parse(Console.ReadLine()!);
int[] lista_eleitor = new int[quant_eleitor];

int joao_pimenta = 0;
int pedrao_espertao = 0;
int marcos_raposa = 0;

foreach (int i in lista_eleitor)
{
    Console.Write("Digite seu candidato (25 pra Joao, 11 pra Pedrao e 98 pra Marcos): ");
    int vota =  int.Parse(Console.ReadLine()!);
    if (vota == 25)
    {
        joao_pimenta++;
    }
    else if (vota == 98)
    {
        marcos_raposa++;
    }
    else if (vota == 11)
    {
        pedrao_espertao++;
    }
    else
    {
        Console.WriteLine("Opcao invalida!");
    }
}
Console.WriteLine($"{joao_pimenta} votos para Joao Pimenta!");
Console.WriteLine($"{marcos_raposa} votos para Marcos Raposa!");
Console.WriteLine($"{pedrao_espertao} votos para Pedrao Espertao!");

if (joao_pimenta > marcos_raposa || joao_pimenta > pedrao_espertao)
{
    Console.WriteLine("Joao Pimenta ganha a eleicao!");
    return;
}
else if (marcos_raposa > pedrao_espertao || marcos_raposa > joao_pimenta)
{
    Console.WriteLine("Marcos Raposa ganha a eleicao!");
    return;
}
else if (pedrao_espertao > marcos_raposa || pedrao_espertao > joao_pimenta)
{
    Console.WriteLine("Pedrao Espertao ganha a eleicao!");
    return;
}