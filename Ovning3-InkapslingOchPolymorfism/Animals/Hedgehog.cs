
namespace Ovning3_InkapslingOchPolymorfism.Animals
{
	internal class Hedgehog : Animal
	{

		public int NrOfSpikes { get; }

		public Hedgehog(string name, double weight, int age, int numberOfLegs, int nrOfSpikes) : base(name, weight, age, numberOfLegs)
		{
			NrOfSpikes = nrOfSpikes;
		}

		public override string DoSound()
		{
			return "Susurrus";
		}

		public override string Stats()
		{
			return base.Stats() + $"\tNumber of spikes: {NrOfSpikes}";
		}
	}
}
