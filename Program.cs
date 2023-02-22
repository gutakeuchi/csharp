using Course;
using Course.Class;
using System.Globalization;


/*

Triangulo x, y;

x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo X: ");
x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y: ");
y.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double areaX = x.Area();

double areaY = y.Area();

Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if(areaX > areaY)
{
    Console.WriteLine("Maior área: X");
}
else
{
    Console.WriteLine("Maior área: Y");
}


/* Exercício 1

Pessoa p1, p2;

p1 = new Pessoa();
p2 = new Pessoa();

Console.WriteLine("Primeira pessoa");
Console.WriteLine("Qual é o seu nome: ");
p1.nome = Console.ReadLine();
Console.WriteLine("Digite a sua idade: ");
p1.idade = int.Parse(Console.ReadLine());


Console.WriteLine("Segunda pessoa");
Console.WriteLine("Qual é o seu nome: ");
p2.nome = Console.ReadLine();
Console.WriteLine("Digite a sua idade: ");
p2.idade = int.Parse(Console.ReadLine());


Console.WriteLine("Dados da primeira pessoa: ");
Console.WriteLine($"Nome: {p1.nome}");
Console.WriteLine($"Idade: {p1.idade}");

Console.WriteLine("Dados da segunda pessoa: ");
Console.WriteLine($"Nome: {p2.nome}");
Console.WriteLine($"Idade: {p2.idade}");

if(p1.idade > p2.idade) Console.WriteLine($"Pessoa mais velha: {p1.nome}");
else Console.WriteLine($"Pessoa mais velha: {p2.nome}");

*/

/*

Funcionario f1, f2;

f1 = new Funcionario();
f2 = new Funcionario();

Console.WriteLine("Digite o seu nome: ");
f1.nome = Console.ReadLine();
Console.WriteLine("Digite o seu salário: ");
f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Digite o seu nome: ");
f2.nome = Console.ReadLine();
Console.WriteLine("Digite o seu salário: ");
f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine("Dados do primeiro funcionário: ");
Console.WriteLine($"Nome: {f1.nome}");
Console.WriteLine($"Nome: {f1.salario.ToString("F2", CultureInfo.InvariantCulture)}");

Console.WriteLine("Dados do segundo funcionário: ");
Console.WriteLine($"Nome: {f2.nome}");
Console.WriteLine($"Nome: {f2.salario.ToString("F2", CultureInfo.InvariantCulture)}");

*/

Produto p = new Produto("TV", 500.00, 10);

p.Nome = "T";



Console.WriteLine(p.Nome);
Console.WriteLine(p.Preco);
