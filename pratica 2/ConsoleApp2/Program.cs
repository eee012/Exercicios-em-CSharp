Console.WriteLine("Digite sua primeira nota:");
double nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite sua segunda nota:");
double nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite sua terceira nota:");
double nota3 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite sua quarta nota:");
double nota4 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite sua quinta nota:");
double nota5 = double.Parse(Console.ReadLine());


double calculacao = Math.Round((nota1 + nota2 + nota3 + nota4 + nota5) / 5);
Console.WriteLine($"Sua media e: {calculacao}");

