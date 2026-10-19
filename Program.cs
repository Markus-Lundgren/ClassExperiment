namespace ClassExperiment;

enum Size { Small, Medium, Large }

interface ISized
{
	public abstract Size Size { get; protected set; }
}

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");
	}
}

public abstract class Product
{
	public abstract string Name { get; protected set; }
}

public abstract class Beverage : Product, ISized
{
	Size ISized.Size { get; set; }
	public enum Category { Soda, Milk, Milkshake, Water }
	public Category Type { get; protected set; }

	public Beverage(Category type) => Type = type;
}

public class Soda : Beverage
{
	public override string Name { get; protected set; }

	public Soda() : base(Category.Soda) { }
}


