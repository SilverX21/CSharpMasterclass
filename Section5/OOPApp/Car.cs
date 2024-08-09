namespace OOPApp;

internal class Car
{
	private string _model = "";
	private string _brand = "";

	public string Model { get => _model; set => _model = value; }
	public string Brand { get => _brand; set => _brand = value; }

	public Car(string model, string brand)
	{
		Model = model;
		Brand = brand;

		Console.WriteLine($"An {Brand} of the model {Model} has been created!");
	}
}