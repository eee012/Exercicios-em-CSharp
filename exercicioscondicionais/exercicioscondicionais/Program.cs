using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Exercicios Faceis

// 1. Temperatura
// Leia uma temperatura em graus Celsius.
// Informe se está frio (abaixo de 15) ou agradável/quente.

Console.Write("Exercicio Facil - 1 \n");

Console.WriteLine("Informe a temperatura: ");
    int temperatura = int.Parse(Console.ReadLine());

if (temperatura < 15)
{
    Console.WriteLine("Esta frio.");
}
else
{
    Console.WriteLine("Esta quente.");
}

// 2. Número válido
//Leia um número.
//Informe se ele é maior que 100.

Console.WriteLine("\n Exercicio 2 \n");
Console.WriteLine("Informe um numero: ");
int numeroleitura =  int.Parse(Console.ReadLine());

if (numeroleitura > 100)
{
    Console.WriteLine("O numero e maior que 100.");
}
if (numeroleitura < 100)
{
    Console.WriteLine("O numero e menor que 100.");
}

//3. Senha simples
//Leia uma senha (string).
//Verifique se ela é igual a "123".

Console.WriteLine("\n Exercicio 3 \n");
Console.WriteLine("Digite sua senha: ");
int senhaleitura = int.Parse(Console.ReadLine());

if (senhaleitura == 123)
{
    Console.WriteLine("Senha correta! Abrindo sistema...");
}
else
{
    Console.WriteLine("Senha incorreta. Voltando...");
}

//4. Número negativo
//Leia um número.
//Se for negativo, mostre "Número inválido".

Console.WriteLine("\n Exercicio 4 \n");
Console.WriteLine("Digite um numero: ");
int num_detector = int.Parse(Console.ReadLine());

if (num_detector < 0)
{
    Console.WriteLine("Numero invalido!");
}
else
{
    Console.WriteLine("Numero aceito.");
}

//5. * *Ternário – positivo ou negativo * *
//Leia a idade de uma pessoa e use operador ternário para mostrar:
//    - `"Cadastro permitido"` se tiver 16 anos ou mais
//    - `"Cadastro não permitido"` se tiver menos de 16 anos

Console.WriteLine("\n Exercicio 5 \n");
Console.WriteLine("Digite sua idade: ");
int idadedetector = int.Parse(Console.ReadLine());

Console.WriteLine(idadedetector >= 16 ? "Cadastro permitido" : "Cadastro negado");

//6. * *Turno do dia(switch)**

//    Leia um número:

//    -1 → Manhã
//    - 2 → Tarde
//    - 3 → Noite
//    Qualquer outro → Inválido

Console.WriteLine("\n Exercicio 6 \n");
Console.WriteLine("Digite sua opcao: ");
Console.WriteLine("1 - Manhã");
Console.WriteLine("2 - Tarde");
Console.WriteLine("3 - Noite");
Console.WriteLine("Qualquer outro - Inválido");
int opcao_turno = int.Parse(Console.ReadLine());

switch (opcao_turno)
{
    case 1:
        Console.WriteLine("Turno da Manha!");
        break;
    case 2:
        Console.WriteLine("Turno da Tarde!");
        break;
    case 3:
        Console.WriteLine("Turno da Noite!");
        break;
}

// 7. **Menu simples (switch)**

// Leia uma opção:
    
//    -1 → "Novo jogo"
//    - 2 → "Carregar jogo"
//    - 3 → "Sair"

Console.WriteLine("\n Exercicio 7 \n");
Console.WriteLine("Bem vindo ao menu do jogo! Escolha sua opcao: \n 1 - Novo jogo \n 2 - Carregar jogo \n 3 - Sair");
int opcao_menu = int.Parse(Console.ReadLine());

switch (opcao_menu)
{
    case 1:
        Console.WriteLine("Comecando sua jornada...");
        break;
    case 2:
        Console.WriteLine("Carregando os estados salvos..");
        break;
    case 3:
        Console.WriteLine("Fechando jogo...");
        break;
    default:
        Console.WriteLine("Opcao invalida!");
        break;
}

Console.WriteLine("\n Exercicios Medios - 1 \n");
// 1. **Classificação de idade**
// Leia a idade e classifique:
//    -Criança(até 12)
//    - Adolescente(13 a 17)
//    - Adulto(18 ou mais)

Console.WriteLine("Digite sua idade: ");
int classificador = int.Parse(Console.ReadLine());

if (classificador <= 12)
{
    Console.WriteLine("Criança");
}
else if (classificador <= 17)
{
    Console.WriteLine("Adolescente");
}
else if (classificador >= 18)
{
    Console.WriteLine("Adulto");
}
Console.WriteLine("\n Exercicio 2 \n");

// 2. Maior entre dois (ternário)
// Leia dois números e use operador ternário para mostrar o maior.

Console.WriteLine("Digite o primeiro numero: "); 
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(num1 > num2 ? $"O maior numero é {num1}" : $"O maior numero é {num2}");  

// 3. **Acesso com duas condições**
//Leia:
//    - idade
//  - possui ingresso (true/false)
//    Só pode entrar se tiver mais de 18 **ou** possuir ingresso.

Console.WriteLine("\n Exercicio 3 \n");

Console.WriteLine("Digite sua idade: ");
int idade_access  = int.Parse(Console.ReadLine());

Console.WriteLine("Voce tem um ingresso? (S/N)");
var invite_check = Console.ReadLine();

if (idade_access >= 18 || invite_check == "S")
{
    Console.WriteLine("Acesso Permitido!");
}

// 4. Número dentro de faixa inválida
// Leia um número.
// Se estiver fora do intervalo de 0 a 10, mostrar "Valor inválido".

Console.WriteLine("\n Exercicio 4 \n");

Console.WriteLine("Digite um numero: ");
int num_invalid = int.Parse(Console.ReadLine());

if (num_invalid > 10 || num_invalid < 0)
{
    Console.WriteLine("Valor invalido.");
}

// 5. * *Desconto por idade**
// Leia a idade:
//    -Menor de 18 → sem desconto
//    - 18 a 59 → 10%
//    - 60 ou mais → 20%

Console.WriteLine("\n Exercicio 5 \n");

Console.WriteLine("Digite sua idade: ");
int idade_discount = int.Parse(Console.ReadLine());

if (idade_discount < 18)
{
    Console.WriteLine("Sem desconto.");
}
else if (idade_discount >= 18 && idade_discount <= 59) 
{
    Console.WriteLine("10% de Desconto");
}
else if (idade_discount >= 60)
{
    Console.WriteLine("20% de Desconto");
}

// 6. * *Desconto com ternário**

//    Leia o valor de uma compra:

//    - >= 200 → 15 % desconto
//    - < 200 → 5 % desconto

Console.WriteLine("\n Exercicio 6 \n");
Console.WriteLine("Digite o valor da sua compra: ");
int valor_discount = int.Parse(Console.ReadLine());

Console.WriteLine(valor_discount >= 200 ? "15% de Desconto!" : "5% de Desconto!");

Console.WriteLine("\n Exercicio 7 \n");
//7. * *Calculadora com switch**

//    Leia dois números e uma operação (+, -, *, /).
Console.WriteLine("Digite seu primeiro numero: ");
int num1_calc = int.Parse(Console.ReadLine());
Console.WriteLine("Digite seu segundo numero: ");
int num2_calc = int.Parse(Console.ReadLine());

//CONTINUAR DEPOIS!
//SWITCH EXPRESSION ESTA NO DESAFIOCONDICIONAL!



//exemplo de switch:
//int errorCode = 404;

//string message = errorCode switch
//{
//    200 => "Success",
//    400 => "Bad Request",
//    404 => "Not Found",
//    _ => "Unknown Error" // The underscore (_) acts as the default case
//};

//Console.WriteLine(message);
