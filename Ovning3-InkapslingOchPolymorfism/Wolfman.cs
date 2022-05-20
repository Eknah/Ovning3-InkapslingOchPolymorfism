using Ovning3_InkapslingOchPolymorfism.Animals;

namespace Ovning3_InkapslingOchPolymorfism
{
	internal class Wolfman : Wolf, IPerson
	{
		public Wolfman(string name, double weight, int age, int numberOfLegs, bool lookingForFood) : base(name, weight, age, numberOfLegs, lookingForFood)
		{
		}

		public string Talk()
		{
			return "\"I like full moons.\"";
		}
	}
}
