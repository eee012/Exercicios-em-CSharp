// (FGV/TCE-SE) Duas tartarugas estavam juntas e começaram a caminhar em linha reta em direção a um lago distante.
// A primeira tartaruga percorreu 30 metros por dia e demorou 16 dias para chegar ao lago.
// A segunda tartaruga só conseguiu percorrer 20 metros por dia e, portanto, chegou ao lago alguns dias depois da primeira.
// Quando a primeira tartaruga chegou ao lago, o número de dias que ela teve que esperar para a segunda tartaruga chegar foi:

Console.WriteLine("Exercicio 1");
Console.WriteLine();

int turtle01metros = 30;
int turtle01dias = 16;
int turtle02metros = 20;

int turtlewait = (turtle01dias * turtle02metros) / turtle01metros;
Console.WriteLine($"O numero de tempo que a primeira tartaruga esperou foi {turtlewait} dias");

//(Enem)Jogar baralho é uma atividade que estimula o raciocínio. 
//Um jogo tradicional é a Paciência, que utiliza 52 cartas. Inicialmente são formadas sete colunas com as cartas. 
//A primeira coluna tem uma carta, a segunda tem duas cartas, a terceira tem três cartas, a quarta tem quatro cartas, 
//e assim sucessivamente até a sétima coluna, a qual tem sete cartas, e o que sobra forma o monte, que são as cartas não utilizadas 
//nas colunas. A quantidade de cartas que forma o monte é:

Console.WriteLine();
Console.WriteLine("Exercicio 2");
Console.WriteLine();

int card_total = 52;
int card_coluna = 7;

int soma_card7 = (card_coluna * (card_coluna + 1)) / 2;
int card_monte = (card_total - soma_card7);
Console.WriteLine($"O numero de cartas que forma o monte é {card_monte} cartas");

// (CESGRANRIO) Uma pizzaria vende pizzas nos sabores calabresa, frango e quatro queijos.
// A borda pode ser tradicional ou recheada, e o tamanho pode ser médio ou grande.
// Quantas combinações diferentes de pizza o cliente pode pedir, considerando apenas um sabor por vez?

Console.WriteLine();
Console.WriteLine("Exercicio 3");
Console.WriteLine();

int pizza_sabores = 3;
int pizza_bordas = 2;
int pizza_tamanhos = 2;

int pizza_combinacoes = pizza_sabores * pizza_bordas * pizza_tamanhos;
Console.WriteLine($"A quantidade de combinacoes diferentes de pizza são {pizza_combinacoes}");

// Descubra a lógica por trás de cada sequência e assinale a alternativa que
// apresenta corretamente o próximo elemento de cada uma delas:
//I) 1, 3, 5, 7, ?
//II) 2, 4, 8, 16, 32, 64, ?
//III) 0, 1, 4, 9, 16, 25, 36, ?
//IV) 4, 16, 36, 64, ?
//V) 1, 1, 2, 3, 5, 8, ?
//VI) 2, 10, 12, 16, 17, 18, 19, ?

int sequencia1 = 1 + (2 * 4);
Console.WriteLine($"A ordem na primeira sequencia e seguindo o proximo impar, entao, o proximo numero sera {sequencia1}");

double sequencia2num, sequencia2num2;

sequencia2num = 2;
sequencia2num2 = 7;

double sequencia2 = Math.Pow(sequencia2num, sequencia2num2);
Console.WriteLine($"A ordem da segunda sequencia e 2 exponenciado, entao o ultimo numero sera {sequencia2}");

double sequencia3num = 7;
double sequencia3num2 = 2;

double sequencia3 = Math.Pow(sequencia3num, sequencia3num2);
Console.WriteLine($"A ordem da terceira sequencia e numeros exponenciados por 2, entao o ultimo numero sera {sequencia3}");


double sequencia4num = 10;
double sequencia4num2 = 2;

double sequencia4 = Math.Pow(sequencia4num, sequencia4num2);
Console.WriteLine($"A ordem da terceira sequencia e numeros pares exponenciados por 2, entao o ultimo numero sera {sequencia4}");

//Nao consegui fazer um codigo pra quinta e sexta sequencias. Entao, so deixei escrito: 

Console.WriteLine("A ordem da quinta sequencia e fibonacci, entao o ultimo numero sera 13");
Console.WriteLine("A ordem da sexta sequencia e uma sequencia logica baseada na lingua portuguesa, entao sera 200.");
