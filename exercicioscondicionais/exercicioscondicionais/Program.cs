//Exercicios Faceis

// 1. Temperatura
// Leia uma temperatura em graus Celsius.
// Informe se está frio (abaixo de 15) ou agradável/quente.

Console.Write("Exercicio 1 \n");

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
Console.WriteLine("-1 → Manhã");
Console.WriteLine("-2 → Tarde");
Console.WriteLine("-3 → Noite");
Console.WriteLine("Qualquer outro → Inválido");
int opcao_turno = int.Parse(Console.ReadLine());

switch (opcao_turno)
{
    case 1:
        Console.WriteLine("Turno da Manha!");
        break;
    case 2:
        Console.WriteLine("Turno da Tarde");
        break;
    case 3:
        Console.WriteLine("Turno da Noite!");
        break;
}

