namespace OOPApp;

internal class Program
{
	private static void Main(string[] args)
	{
		Car audi = new Car("A3", "Audi");
		Car bmw = new Car("i7", "BMW");
		Console.WriteLine("Hello, World!");

		//Customer
		Customer earl = new Customer("Earl");
		Customer frankTheTank = new Customer("FrankTheTank", "MAinstreet 1", "123");
		Console.WriteLine("Name of customer is: " + earl.Name);
		Customer.DoSomeCustomerStuff();
	}
}