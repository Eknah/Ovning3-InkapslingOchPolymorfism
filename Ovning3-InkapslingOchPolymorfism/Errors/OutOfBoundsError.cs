
namespace Ovning3_InkapslingOchPolymorfism
{
	internal class OutOfBoundsError : UserError
	{
		public override string UEMessage()
		{
			return "You tried to access an element with an index outside of the collection range. This fired an error!";
		}
	}
}
