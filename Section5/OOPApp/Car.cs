namespace OOPApp;

internal class Car
{
	private string _model = "";
	private string _brand = "";

	public string Model { get; set; }
	public string Brand { get; set; }

	public Car(string model, string brand)
	{
		_model = model;
		_brand = brand;

		Console.WriteLine($"An {_brand} of the model {_model} has been created!");
	}
}