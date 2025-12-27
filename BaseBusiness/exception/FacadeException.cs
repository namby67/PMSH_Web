using System;

namespace BaseBusiness.exception
{
	/// <summary>
	/// Summary description for FacadeException.
	/// </summary>
	public class FacadeException : Exception
	{
		public FacadeException(String message) : base(message)
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public FacadeException(Exception e)
		{
		}
	}
}