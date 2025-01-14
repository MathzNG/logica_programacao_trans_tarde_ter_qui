// Escreva um programa que pergunte o nome de usuário e apresente nome + boas vindas

Console.WriteLine("Qual é o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual é o seu sobrenome?");
string sobrenome = Console.ReadLine();

Console.WriteLine("Qual é o seu último sobrenome?");
string ultimosobrenome = Console.ReadLine();

//Console.WriteLine("Seja bem-vindo(a)" + nome + sobrenome + ulitmosobrenome);
Console.WriteLine($"Seja bem-vindo(a) {nome} {sobrenome} {ultimosobrenome} ");