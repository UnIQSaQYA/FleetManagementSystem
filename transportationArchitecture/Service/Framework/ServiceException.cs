using System;

namespace Service.Framework
{
	/// <summary>
	/// Summary description for ServiceException.
	/// </summary>
	public class ServiceException : ApplicationException
	{
		public ServiceException()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public ServiceException(string message) : base(message) {}
	}
}
