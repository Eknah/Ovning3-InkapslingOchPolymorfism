
namespace Ovning3_InkapslingOchPolymorfism.Animals
{
	internal class Wolf : Animal
	{

		public bool LookingForFood { get; }

		public Wolf(string name, double weight, int age, int numberOfLegs, bool lookingForFood) : base(name, weight, age, numberOfLegs)
		{
			LookingForFood = lookingForFood;
		}

		public override string DoSound()
		{
			return "Grr";
		}

		public override string Stats()
		{
			return base.Stats() + $"\tLooking for food: {(LookingForFood ? "Yes" : "No")}";
		}
	}
}
