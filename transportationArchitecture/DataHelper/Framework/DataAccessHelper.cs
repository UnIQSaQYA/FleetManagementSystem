using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;


namespace DataHelper.Framework
{
	/// <summary>
	/// This class is a general purpose helper class for our data access layer. 
	/// It encapsulates the ADO.NET functionality so that the rest of our 
	/// data layer does not have any coupling to database implementation details.
	/// </summary>
	public class DataAccessHelper
	{
		#region Private Constructor
		private DataAccessHelper()
		{			
		}
		#endregion

        #region ExecuteNonQuery Transaction Methods
        public static int ExecuteNonQueryTransaction(string cmdText, CommandType cmdType, IDbDataParameter[] cmdParms, DistributedTransaction DTrans)
        {
            int val = 0;

            // Create Instance of Command object via data access factory
            IDbCommand cmd = DataAccessFactory.CreateCommand(cmdText, DTrans.Connection());
            cmd.CommandType = cmdType;
            if (cmdParms != null)
            {
                foreach (IDbDataParameter param in cmdParms)
                    cmd.Parameters.Add(param);
            }

            try
            {
                val = cmd.ExecuteNonQuery();
                OracleConnection Orconn = new OracleConnection();
                if (DTrans.Connection().GetType() == Orconn.GetType())
                {
                    OracleParameter oracleoutParam = (OracleParameter)cmd.Parameters["errmsg"];
                    if (oracleoutParam != null)
                    {
                        oracleoutParam.Direction = ParameterDirection.Input;
                        val = Int32.Parse(oracleoutParam.Value.ToString());
                    }
                }
                cmd.Parameters.Clear();
            }
            catch
            {
                DTrans.HAPPY=false;
            }

            //Modified By: Adam Alinauskas
            //Date Modified: June 30, 2004
            //Description: changed the return value to return the identity that was just used.
            //cmdText = "SELECT @@IDENTITY";
            //cmd = DataAccessFactory.CreateCommand(cmdText, conn);
            //string ID = cmd.ExecuteScalar().ToString();

            //if (ID != null && !ID.Equals(""))
            //{
            //    val = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            //}

            return val;
        }
        #endregion

        #region ExecuteNonQuery Method
        /// <summary>
		/// Execute a Command (that returns no resultset) against a database
		/// </summary>
		/// <param name="cmdText">the stored procedure name or SQL statement</param>
		/// <param name="cmdType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="cmdParms">an array of SqlParamters used to execute the command</param>
		/// <returns>an int representing the number of rows affected by the command</returns>
		public static int ExecuteNonQuery(string cmdText, CommandType cmdType, IDbDataParameter[] cmdParms)
		{
			// Create Instance of Connection object via data access factory            
			IDbConnection conn = DataAccessFactory.CreateConnection();
			
			// Create Instance of Command object via data access factory
			IDbCommand cmd = DataAccessFactory.CreateCommand(cmdText, conn);
			cmd.CommandType = cmdType;
			if (cmdParms != null)
			{
				foreach (IDbDataParameter param in cmdParms)
					cmd.Parameters.Add(param);
			}


			conn.Open();
			int val = cmd.ExecuteNonQuery();
            OracleConnection Orconn=new OracleConnection();
            if (conn.GetType() == Orconn.GetType())
            {
                OracleParameter oracleoutParam = (OracleParameter)cmd.Parameters["errmsg"];
                if (oracleoutParam != null)
                {
                    oracleoutParam.Direction = ParameterDirection.Input;
                    val = Int32.Parse(oracleoutParam.Value.ToString());
                }
            }
			cmd.Parameters.Clear();
			
			
			//Modified By: Adam Alinauskas
			//Date Modified: June 30, 2004
			//Description: changed the return value to return the identity that was just used.
            //cmdText = "SELECT @@IDENTITY";
            //cmd = DataAccessFactory.CreateCommand(cmdText, conn);
            //string ID = cmd.ExecuteScalar().ToString();

            //if (ID != null && !ID.Equals(""))
            //{
            //    val = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            //}
			
			conn.Close();
			
			return val;
		}
		#endregion

		#region ExecuteReader Method
		/// <summary>
		/// Execute a SqlCommand that returns a resultset against the database specified in the connection string 
		/// using the provided parameters.
		/// </summary>
		/// <param name="commandText">the stored procedure name or SQL command</param>/// 
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandParameters">an array of SqlParamters used to execute the command</param>
		/// <returns>A IDbDataReader containing the results</returns>
		public static IDataReader ExecuteReader(string cmdText, CommandType cmdType, IDbDataParameter[] cmdParms) 
		{
			// Create Instance of Connection object via data access factory
			IDbConnection conn = DataAccessFactory.CreateConnection();
			
			// Create Instance of Command object via data access factory
			IDbCommand cmd = DataAccessFactory.CreateCommand(cmdText, conn);
			cmd.CommandType = cmdType;
            cmd.CommandTimeout = 1800000;
			if (cmdParms != null)
			{
				foreach (IDbDataParameter param in cmdParms)
					cmd.Parameters.Add(param);
			}
			conn.Open();

			// we use a try/catch here because if the method throws an exception we want to 
			// close the connection throw code, because no datareader will exist, hence the 
			// commandBehaviour.CloseConnection will not work
            try
            {
                IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
               
                cmd.Parameters.Clear();
                return reader;
            }
            catch
            {
                conn.Close();
                throw;
               

            }
            finally
            {
               // conn.Close();

            }


		}

        /// Execute Reader in Transaction
        /// 
        public static IDataReader ExecuteReader(string cmdText, CommandType cmdType, IDbDataParameter[] cmdParms,DistributedTransaction DT)
        {
            // Create Instance of Connection object via data access factory

            // Create Instance of Command object via data access factory
            IDbCommand cmd = DataAccessFactory.CreateCommand(cmdText, DT.Connection());
            cmd.CommandType = cmdType;
            cmd.CommandTimeout = 1800000;
            if (cmdParms != null)
            {
                foreach (IDbDataParameter param in cmdParms)
                    cmd.Parameters.Add(param);
            }
            // we use a try/catch here because if the method throws an exception we want to 
            // close the connection throw code, because no datareader will exist, hence the 
            // commandBehaviour.CloseConnection will not work
            try
            {
                IDataReader reader = cmd.ExecuteReader();
                cmd.Parameters.Clear();
                return reader;
            }
            catch
            {
                cmd.Connection.Close();
                DT.HAPPY = false;
                return null;
            }
        }
		#endregion
		
		#region ExecuteScalar Method
		/// <summary>
		/// Execute a SqlCommand that returns the first column of the first record against the database specified in the connection string 
		/// using the provided parameters.
		/// </summary>
		/// <param name="connectionString">a valid connection string for a SqlConnection</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or SQL command</param>
		/// <param name="commandParameters">an array of SqlParamters used to execute the command</param>
		/// <returns>An object that should be converted to the expected type using Convert.To{Type}</returns>
		public static object ExecuteScalar(string cmdText, CommandType cmdType, IDbDataParameter[] cmdParms) 
		{
			// Create Instance of Connection object via data access factory
			IDbConnection conn = DataAccessFactory.CreateConnection();
			
			// Create Instance of Command object via data access factory
			IDbCommand cmd = DataAccessFactory.CreateCommand(cmdText, conn);
			cmd.CommandType = cmdType;
			if (cmdParms != null)
			{
				foreach (IDbDataParameter param in cmdParms)
					cmd.Parameters.Add(param);
			}
			conn.Open();
            object val = null;
            try
            {
                val = cmd.ExecuteScalar().ToString(); 
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }
            OracleConnection Orconn = new OracleConnection();
            if (conn.GetType() == Orconn.GetType())
            {
                OracleParameter oracleoutParam = (OracleParameter)cmd.Parameters["errmsg"];
                if (oracleoutParam != null)
                {
                    oracleoutParam.Direction = ParameterDirection.Input;
                    val = Int32.Parse(oracleoutParam.Value.ToString());
                }
            }
			cmd.Parameters.Clear();
			return val;
		}
		#endregion
    }

}

