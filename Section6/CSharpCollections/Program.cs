List<string> colors = new List<string>();

colors.Add("blue");
colors.Add("red");
colors.Add("green");

Console.WriteLine("Current colors in the list:");
foreach (string color in colors)
{
	Console.Write(color + ", ");
}

//como remover elementos de uma lista:
bool teste = colors.Remove("red");

Console.WriteLine("Current colors in the list after removal:");
foreach (string color in colors)
{
	Console.WriteLine(color);
}

//em vez de adicionarmos items como temos para o colors, podemos fazer da seguinte forma:
//podemos usar o [] para inicializar a collection ou da maneira convencional
List<string> colors2 = [
	"red",
	"green",
	"blue",
	"yellow"
];

//podemos ordenar uma lista desta forma:
List<int> numbers = new List<int> { 10, 4, 2, 5, 9, 7, 1 };

Console.WriteLine("numbers before sorted:");
numbers.ForEach(x => Console.WriteLine(x));

numbers.Sort();

Console.WriteLine("numbers after being sorted:");
foreach (int number in numbers)
{
	Console.WriteLine(number);
}

//encontrar elementos que satisfaçam uma condição a usar o FindAll():
var biggerThan5 = numbers.FindAll(x => x > 5);

Console.WriteLine("Numbers in the list bigger than 5:");
foreach (int number in biggerThan5)
{
	Console.WriteLine(number);
}

//predicates e expressões lambda
Predicate<int> predicate = x => x > 7;
var biggerThan7 = numbers.FindAll(predicate);

Console.WriteLine("Numbers in the list bigger than 7:");
foreach (int number in biggerThan7)
{
	Console.WriteLine(number);
}

Console.ReadKey();