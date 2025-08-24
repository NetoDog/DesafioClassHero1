// See https://aka.ms/new-console-template for more information
string? nome;
string? sobrenome;
string? nomesobrenome;

nome = Console.ReadLine();
sobrenome = Console.ReadLine();

Console.WriteLine(nome + " " +sobrenome);

nomesobrenome = $"{nome} {sobrenome}";
Console.WriteLine(nomesobrenome);