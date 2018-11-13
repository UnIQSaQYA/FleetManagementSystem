using System;
using System.Configuration;
using System.Web.Configuration;

namespace DataHelper.Framework
{
	/// <summary>
	/// This class determines the DataAccessProvider and ConnectionString from the Web.config file
	/// </summary>
	public class DataProvider
	{
		#region Private Contructor
		/// <summary>
		/// Private Constructor to disable instantiation of this class
		/// All methods are static
		/// </summary>
		private DataProvider()
		{			
		}
		#endregion

		#region Properties
		
		/// <summary>
		/// Returns the ConnectionString stored in the Web.config file
		/// </summary>
		public static string ConnectionString 	
		{ 
			get 
			{
                return ConfigurationManager.ConnectionStrings["cnMIS"].ConnectionString;
                
			}		
		}
		
		/// <summary>
		/// Returns the DataAccessProviderType
		/// DataAccessProviderType is a Enum and will reutrn an instance of 
		/// this enum of SqlClient or OleDb
		/// </summary>
		public static DataAccessProviderType ProviderType 
		{ 
			get 
			{ 
				string dtype =  ConfigurationSettings.AppSettings[ ("DatabaseType" ).ToLower()];

                if (dtype == "sql")
                    return DataAccessProviderType.SqlClient;
                else if (dtype == "oracle")
                    return DataAccessProviderType.OracelClient;
                else
                    return DataAccessProviderType.OleDb;				 
			} 
		}
		#endregion
	}

	
	/// <summary>
	/// Represents the collection of ADO.NET data providers that are 
	/// supported by our DataAccessLayer: OleDb and SqlClient
	/// </summary>
	public enum DataAccessProviderType
	{
		OleDb = 0,
		SqlClient = 1,
        OracelClient=2
	}
}