
namespace Ovning3_InkapslingOchPolymorfism.Animals
{
	internal class Pelican : Bird
	{
		public int NrOfFishesEatenToday { get; private set; }

		public Pelican(string name, double weight, int age, int numberOfLegs, double wingSpan, int nrOfFishesEatenToday) : base(name, weight, age, numberOfLegs, wingSpan)
		{
			NrOfFishesEatenToday = nrOfFishesEatenToday;
		}

		public void ResetNrOfFishesForToday()
		{
			NrOfFishesEatenToday = 0;
		}

		public void EatFish(int amount)
		{
			NrOfFishesEatenToday += amount;
		}

		public override string Stats()
		{
			return base.Stats() + $"\tNumber of fishes eaten today: {NrOfFishesEatenToday}";
		}
	}
}
