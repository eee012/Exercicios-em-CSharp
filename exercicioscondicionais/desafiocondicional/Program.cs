//Leia uma nota de 0 a 10 (aceita decimais) sem deixar o programa quebrar.
//Use double.TryParse no lugar de double.Parse.
//- Texto que não é numero - "Entrada inválida: Digite um numero."
//- Fora de 0 a 10 - "Nota fora da faixa (0 a 10)"
//- 9 ou mais = Conceito A
//- 7 ou mais = Conceito B 
//- 5 ou mais = Conceito C
//- Abaixo de 5 = Conceito D

//Console.WriteLine("Digite sua nota: ");
//string nota_testestring = Console.ReadLine();

//if (!double.TryParse(nota_testestring, out double nota_teste))
//{
//    Console.WriteLine("Entrada invalida!");
//}

//else if (nota_teste < 0 || nota_teste > 10)
//{
//    Console.WriteLine("Nota fora da faixa (0 a 10)");
//}

//else if (nota_teste >= 9)
//{
//    Console.WriteLine("Conceito A");
//}
//else if (nota_teste < 9 && nota_teste >= 7)
//{
//    Console.WriteLine("Conceito B");
//}
//else if (nota_teste < 7 && nota_teste >= 5)
//{
//    Console.WriteLine("Conceito C");
//}
//else if (nota_teste < 4)
//{
//    Console.WriteLine("Conceito D");
//}


//Leia a idade, se e estudante (S/N), o dia da semana (1 = domingo ... 7 = sabado) 
//e se a sessao e 3d (s/n). Calcule o preco:

//1.Preco base: RS 40,00
//2. Meia entrada (50%) se a idade for menor que 12, maior ou igual a 60, ou se for estudante 
//3. as tercas feiras (dia 3), mais 20 % de desconto sobre o valor ja calculado.
//4. Sessao 3D: soma R$8,00 depois dos descontos.
//Idade fora de 0 a 120 = "Idade invalida". Dia fora de 1 a 7 = "Dia invalido".

//Console.WriteLine("\n Exercicio 2 \n");


//Console.WriteLine("Bem vindo ao cinema! Porfavor, digite se e estudante: (S/N)");
//string estudante_check = Console.ReadLine();
//Console.WriteLine("Digite sua idade: ");
//int age_check = int.Parse(Console.ReadLine());
//Console.WriteLine("Digite o dia da semana: (1 a 7)");
//int day_check = int.Parse(Console.ReadLine());
//Console.WriteLine("Por fim, sua sessao e 3d? (S/N)");
//string dimension_check = Console.ReadLine();

//double base_price = 40.00;

//if (age_check < 0 || age_check > 120)
//{
//    Console.WriteLine("Idade invalida!");
//    return; //return retorna pra impedir de continuar
//}
//else if (day_check < 1 || day_check > 7)
//{
//    Console.WriteLine("Dia invalido!");
//    return;
//}
//else if (age_check < 12 || age_check >= 60 || estudante_check == "s")
//{
//    base_price = base_price * 0.50;
//}
//else if (day_check == 3)
//{
//    base_price = base_price * 0.80;
//}
//if (dimension_check == "s")
//{
//    base_price = base_price + 8.00;
//}

//Console.WriteLine($"O valor  de: R$ {base_price} reais");


//exercicio 3

//Leia o limite da via e a velocidade medida (km/h, inteiros)
//Calcule o percentual acima do limite com 
//(velocidade - limite) * 100.0 / limite e 
//classifique com uma switch expression.
//Regras simplificadas, inspiradas no Codigo de Transito:
//- 0% ou menos - "Dentro do limite"
//- ate 20% - "Infracao media"
//- acima de 20% ate 50% - "Infracao grave"
//- acima de 50% - "Infracao gravissima"
//Limite menor ou igual a 0, ou velocidade negativa - "Dados invalidos"


//TENTATIVA DE SWITCH EXPRESSION:
Console.WriteLine("Bem vindo ao calculador do limite! Digite a sua via: ");
int limite_via = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a velocidade medida: ");
int vel_medida = int.Parse(Console.ReadLine());

if (limite_via < 0 || vel_medida < 0)
{
    Console.WriteLine("Dados invalidos!");
    return;
}

double conta = (vel_medida - limite_via) * 100.0 / limite_via;

string classificacao = conta switch
{
    <= 0 => "Dentro do limite",
    <= 20 => "Infracao media",
    <= 50 => "Infracao grave",
    _ => "Infracao gravissima"
};

if (conta <= 0)
{
    Console.WriteLine(classificacao);
}
else
{
    Console.WriteLine($"{conta:f1}% acima : {classificacao}");
}
//f2 e forma decimal 
//math.round... (value, 2)
//nao usei nesse pois nao precisou, mas no anterior ate dava 

//exemplo de switch:
//int errorCode = 404;

//string message = errorCode switch
//{
//    200 => "Success",
//    400 => "Bad Request",
//    404 => "Not Found",
//    _ => "Unknown Error" // The underscore (_) acts as the default case
//};
