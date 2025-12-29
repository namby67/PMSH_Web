using System;

namespace BaseBusiness.exception
{
	/// <summary>
	/// Summary description for BOException.
	/// </summary>
	public class BOException : Exception
	{
		public BOException(String message) : base(message)
		{
		}

		public BOException(String message, Exception e, string className)
		{
		}
	}
}