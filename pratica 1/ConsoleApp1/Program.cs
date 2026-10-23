Console.Write("Bem vindo! Porfavor, digite seu nome: ");
string nome = Console.ReadLine();

Console.Write("Excelente, digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.Write("Por fim, digite sua cidade: ");
string cidade = Console.ReadLine();

Console.WriteLine($"Excelente, entao seu nome e {nome}, sua idade e {idade} e mora em {cidade}");
