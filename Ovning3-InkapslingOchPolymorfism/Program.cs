using Ovning3_InkapslingOchPolymorfism;
using Ovning3_InkapslingOchPolymorfism.Animals;

Console.WriteLine("3.1) Inkapsling");
Console.WriteLine("=============");

try
{
	var personHandler = new PersonHandler();
	var pers1 = personHandler.CreatePerson(36, "Kalle", "Anka", 1.6, 67.6);
	var pers2 = personHandler.CreatePerson(42, "Musse", "Pigg", 1.4, 54.3);
	var pers3 = personHandler.CreatePerson(34, "Janne", "Långben", 2.1, 70.1);

	pers1.IncreaseAge();
	pers3.Rename("Jan", "Långben");

	Console.WriteLine(pers1);
	Console.WriteLine(pers2);
	Console.WriteLine(pers3);
}
catch (ArgumentException aex)
{
	Console.WriteLine(aex.Message);
}
catch (Exception)
{

}

Console.WriteLine();

Console.WriteLine("3.2) Polymorfism");
Console.WriteLine("================");

ICollection<UserError> errors = new List<UserError>();

errors.Add(new TextInputError());
errors.Add(new NumericInputError());
errors.Add(new ZeroDivisionError());
errors.Add(new TextInputError());
errors.Add(new TextInputError());
errors.Add(new NegativeInputError());
errors.Add(new NumericInputError());
errors.Add(new OutOfBoundsError());
errors.Add(new NumericInputError());

foreach (var error in errors)
{
	Console.WriteLine(error.UEMessage());
}

Console.WriteLine();

Console.WriteLine("3.3) Arv");
Console.WriteLine("=======");

ICollection<Animal> animals = new List<Animal>();

animals.Add(new Flamingo("Flamingo1", 3.5, 5, 2, 4.3, 2.0));
animals.Add(new Dog("Hund1", 5.2, 4, 4, 3.1));
animals.Add(new Hedgehog("Igelkott1", 1.2, 1, 4, 132));
animals.Add(new Horse("Häst1", 7.9, 8, 4, true));
animals.Add(new Pelican("Pelican1", 3.5, 5, 2, 4.3, 3));
animals.Add(new Dog("Hund2", 6.3, 3, 4, 2.2));
animals.Add(new Swan("Svan1", 2.3, 1, 2, 3.4, false));
animals.Add(new Wolf("Varg1", 7.5, 7, 4, true));
animals.Add(new Dog("Hund3", 3.7, 8, 4, 1.2));
animals.Add(new Worm("Mask1", 0.3, 1, 0, false));
animals.Add(new Wolfman("Wolfman1", 9.6, 16, 2, false));

foreach (var animal in animals)
{
	Console.WriteLine(animal.GetType().Name);
	Console.WriteLine(animal.DoSound());

	if (animal is IPerson pers)
	{
		Console.WriteLine(pers.Talk());
	}

	Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("3.4) Mer polymorfism");
Console.WriteLine("====================");

ICollection<Dog> dogs = new List<Dog>();

//dogs.Add(new Horse("Häst2", 7.9, 8, 4, true));

Console.WriteLine();

foreach (var animal in animals)
{
	Console.WriteLine(animal.Stats());
}

Console.WriteLine();

foreach (var animal in animals)
{
	if (animal is Dog dog)
	{
		Console.WriteLine(animal.Stats());
		//Console.WriteLine(animal.DogSpecificMethod());
		Console.WriteLine(dog.DogSpecificMethod());
	}
}