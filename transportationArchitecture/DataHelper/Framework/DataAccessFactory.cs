using System;
using System.Reflection;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;




namespace DataHelper.Framework
{
	/// <summary>
	/// Factory class whose methods return the approriate ADO.NET provider types.
	/// </summary>
	public class DataAccessFactory
	{
		#region Data Members
		// Each array contains types for OleDb and SqlClient
		private static Type[] _connectionTypes = new Type[] { typeof(OleDbConnection), typeof(SqlConnection),typeof(OracleConnection) };
		private static Type[] _commandTypes = new Type[] { typeof(OleDbCommand), typeof(SqlCommand),typeof(OracleCommand) };
		private static Type[] _dataAdapterTypes = new Type[] { typeof(OleDbDataAdapter), typeof(SqlDataAdapter),typeof(OracleDataAdapter) };
		private static Type[] _dataParameterTypes = new Type[] { typeof(OleDbParameter), typeof(SqlParameter),typeof(OracleParameter) };
		private static Type[] _dataReaderTypes = new Type[] { typeof(OleDbDataReader), typeof(SqlDataReader),typeof(OracleDataReader) };
		#endregion

		#region Private Constructor
		private DataAccessFactory()
		{
		}
		#endregion

		#region IDbConnection Methods
		/// <summary>
		/// Factory method returns appropriate DataProvider connection object.
		/// To create the appropriate instance for the connection the Activator class is used with the create instance method.
		/// This allows us to create a instance of a object dynmically with out the need for a multiple if statements.
		/// </summary>
		public static IDbConnection CreateConnection()
		{			
            
			IDbConnection conn = null;
			object[] args = {DataProvider.ConnectionString};
			try
			{
				conn = (IDbConnection) Activator.CreateInstance(_connectionTypes[(int) DataProvider.ProviderType], args);
			}
			catch (TargetInvocationException e)
			{
				throw new SystemException(e.InnerException.Message, e.InnerException);
			}
			return conn;
		}
		#endregion

		#region CreateCommand overloaded methods	
		/// <summary>
		/// Factory method returns appropriate data provider command object
		/// </summary>		
		public static IDbCommand CreateCommand()
		{
			return MakeCommand(null);
		}
		public static IDbCommand CreateCommand(string cmdText)
		{
			object[] args = {cmdText};
			return MakeCommand(args);
		}
		public static IDbCommand CreateCommand(string cmdText, IDbConnection connection)
		{
			object[] args = {cmdText, connection};
			return MakeCommand(args);
		}
		/// <summary>
		/// This overloaded method I read about but I am not sure of its use but it is here
		/// for future functionality..
		/// </summary>
		/// <param name="cmdText"></param>
		/// <param name="connection"></param>
		/// <param name="transaction"></param>
		/// <returns></returns>
		public static IDbCommand CreateCommand(string cmdText, IDbConnection connection, IDbTransaction transaction)
		{
			object[] args = {cmdText, connection, transaction};
			return MakeCommand(args);
		}

		#endregion	

        #region MakeCommand	
		/// <summary>
		/// Creates the underlying Command object with the supplied arguments
		/// </summary>
		/// <param name="args">The arguments to be specified while creating the Command object</param>
		/// <returns>The created Command object</returns>		
		private static IDbCommand MakeCommand(object[] args)
		{
			IDbCommand cmd = null;
			try
			{

				cmd = (IDbCommand) Activator.CreateInstance(_commandTypes[(int) DataProvider.ProviderType], args);
                
                OracleCommand OraCommand = new OracleCommand();
                if (cmd.GetType().Equals(OraCommand.GetType()))
                {
                    OraCommand = (OracleCommand)cmd;
                    OraCommand.BindByName = true;
                    cmd = OraCommand;
                }
                
			}
			catch (TargetInvocationException e)
			{
				throw new SystemException(e.InnerException.Message, e.InnerException);
			}
			return cmd;
		}
		#endregion
		
		#region IDataReader methods
		/// <summary>
		/// Factory method returns appropriate data provider data reader object
		/// </summary>		
		public static IDataReader CreateReader(IDbCommand cmd)
		{
			//return cmd.ExecuteReader(CommandBehavior.CloseConnection);
			if (DataProvider.ProviderType == DataAccessProviderType.SqlClient)
			{	
				SqlDataReader sdr = ((SqlCommand)cmd).ExecuteReader(CommandBehavior.CloseConnection);
				return sdr;
			}
            else if (DataProvider.ProviderType == DataAccessProviderType.OleDb)
            {
                OleDbDataReader odr = ((OleDbCommand)cmd).ExecuteReader(CommandBehavior.CloseConnection);
                return odr;
            }
            else
            {
                OracleDataReader odr = ((OracleCommand)cmd).ExecuteReader(CommandBehavior.CloseConnection);
                return odr;
            }
		}
		#endregion

		#region IDbDataAdapter methods
		/// <summary>
		/// Factory method returns appropriate data provider data adapter object
		/// </summary>	
		public static IDbDataAdapter CreateDataAdapter()
		{
			return MakeDataAdapter(null);
		}
		public static IDbDataAdapter CreateDataAdapter(IDbCommand selectCommand)
		{
			object[] args = {selectCommand};
			return MakeDataAdapter(args);
		}
		public static IDbDataAdapter CreateDataAdapter(string selectCommandText, IDbConnection selectConnection)
		{
			object[] args = {selectCommandText, selectConnection};
			return MakeDataAdapter(args);
		}
		public static IDbDataAdapter CreateDataAdapter(string selectCommandText, string selectConnectionString)
		{
			object[] args = {selectCommandText, selectConnectionString};
			return MakeDataAdapter(args);
		}	
		private static IDbDataAdapter MakeDataAdapter(object[] args)
		{
			IDbDataAdapter da = null;
			try
			{
				if (args == null)
					da = (IDbDataAdapter) Activator.CreateInstance(_dataAdapterTypes[(int) DataProvider.ProviderType]);
				else
					da = (IDbDataAdapter) Activator.CreateInstance(_dataAdapterTypes[(int) DataProvider.ProviderType], args);
			}
			catch (TargetInvocationException e)
			{
				throw new SystemException(e.InnerException.Message, e.InnerException);
			}

			return da;
		}
		#endregion

		#region IDbDataParameter methods
		public static IDbDataParameter CreateDataParameter(string parameterName, object theValue)
		{
			if (DataProvider.ProviderType == DataAccessProviderType.SqlClient)
			{	
				return new SqlParameter(parameterName, theValue);
			}
            else if (DataProvider.ProviderType == DataAccessProviderType.OleDb)
            {
                return new OleDbParameter(parameterName, theValue);
            }
            else
            {
                if (parameterName != "Result")
                {
                    if (parameterName != "errmsg")
                    {
                        OracleParameter OracleParam;
                        OracleParam = new OracleParameter(parameterName, theValue);
                        OracleParam.Direction = ParameterDirection.Input;
                        return OracleParam;
                    }
                    else
                    {
                        OracleParameter OracleParam;
                        OracleParam = new OracleParameter(parameterName, Oracle.DataAccess.Client.OracleDbType.Int32);
                        OracleParam.Direction = ParameterDirection.Output;
                        return OracleParam;
                    }
                }
                else
                {
                    OracleParameter OracleParamReturn;

                    OracleParamReturn = new OracleParameter(parameterName, Oracle.DataAccess.Client.OracleDbType.RefCursor);

                    OracleParamReturn.Direction = ParameterDirection.Output;
                    return OracleParamReturn;
                }
            }
		}
		#endregion		
	}
}
