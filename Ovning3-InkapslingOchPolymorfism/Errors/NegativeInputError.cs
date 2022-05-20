
namespace Ovning3_InkapslingOchPolymorfism
{
	internal class NegativeInputError : UserError
	{
		public override string UEMessage()
		{
			return "You tried to use a negative input in a positive only field. This fired an error!";
		}
	}
}
