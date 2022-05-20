
namespace Ovning3_InkapslingOchPolymorfism
{
	internal class ZeroDivisionError : UserError
	{
		public override string UEMessage()
		{
			return "You tried to divide by zero. This fired an error!";
		}
	}
}
