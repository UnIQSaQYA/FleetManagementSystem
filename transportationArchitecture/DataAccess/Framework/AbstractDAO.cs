using System;
using System.Data;
using DataHelper.Framework;
using Entity.Framework;

namespace DataAccess.Framework
{
    /// <summary>
    /// Data Access Object (DAO) abstracts the underlying data access implementation
    /// for our various entities
    /// 
    /// DAOs implement create, find, update, and delete operations
    /// All DAOs use our DataAccessHelper classes as the interface to the data source itself
    /// </summary>
    public abstract class AbstractDAO
    {
        #region Constructor
        public AbstractDAO()
        {
        }
        #endregion

        #region Abstract Properties
        /// <summary>
        /// Abstract property to contain name of stored procedure or sql statement for inserting data
        /// </summary>
        protected abstract string SelectCommand
        {
            get;
        }

        /// <summary>
        /// Abstract property to contain name of stored procedure or sql statement for inserting data
        /// </summary>
        protected abstract string InsertCommand
        {
            get;
        }
        /// <summary>
        /// Abstract property to contain name of stored procedure or sql statement for deleting data
        /// </summary>
        protected abstract string DeleteCommand
        {
            get;
        }
        /// <summary>
        /// Abstract property to contain name of stored procedure or sql statement for updating data
        /// </summary>
        protected abstract string UpdateCommand
        {
            get;
        }
        /// <summary>
        /// Abstract property that specifies whether to use stored procedure or sql statement
        /// </summary>
        public CommandType CommandTypeUsed
        {
            get 
            { 
                return System.Data.CommandType.StoredProcedure;
            }
        }


        #endregion

        #region Abstract Protected Methods
        /// <summary>
        /// Abstract template method for filling an entity object from a data record
        /// </summary>
        /// <param name="dr">Data reader containing data</param>
        /// <returns></returns>
        protected abstract EntityBase CreateAndBuildEntity(SafeDataReader dr);

        /// <summary>
        /// Abstract template method for filling data parameter array with appropriate
        /// data parameters for performing an SQL Select.
        /// </summary>
        /// <param name="returnParam"></param>
        /// <returns></returns>
        protected abstract IDbDataParameter[] CreateSelectParameters(EntityBase anEntity);


        /// <summary>
        /// Abstract template method for filling data parameter array with appropriate
        /// data parameters for performing an SQL insert.
        /// </summary>
        /// <param name="returnParam"></param>
        /// <returns></returns>
        protected abstract IDbDataParameter[] CreateInsertParameters(EntityBase anEntity);

        /// <summary>
        /// Abstract template method for filling data parameter array with appropriate
        /// data parameters for performing an SQL delete.
        /// </summary>
        /// <param name="returnParam"></param>
        /// <returns></returns>
        protected abstract IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity);

        /// <summary>
        /// Abstract template method for filling data parameter array with appropriate
        /// data parameters for performing an SQL update.
        /// </summary>
        /// <param name="returnParam"></param>
        /// <returns></returns>
        protected abstract IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity);

        #endregion

        #region Public Methods
        public virtual EntityList GetAll()
        {            
            return GetList(this.SelectCommand, this.CommandTypeUsed, null);
        }

        public IDataReader GetAllDataReader(string CommandName, CommandType cmdType, IDbDataParameter[] cmdParams)
        {
            return GetDataReader(CommandName, cmdType, cmdParams);
        }

        public IDataReader GetAllDataReader(string CommandName, CommandType cmdType, IDbDataParameter[] cmdParams,DistributedTransaction DT)
        {
            return GetDataReader(CommandName, cmdType, cmdParams,DT);
        }
        /// <summary>
        /// Performs the Selection of a new entity into the appropriate table. It uses the subclass's
        /// CreateSelectParameters method and SelectCommand property
        /// </summary>
        /// <param name="anEntity"></param>
        /// <returns></returns>
        public EntityList GetAll(string Procedure, IDbDataParameter[] cmdParams)
        {
            return GetList(Procedure, this.CommandTypeUsed, cmdParams);
        }

        public EntityList GetAll(string Procedure, IDbDataParameter[] cmdParams, DistributedTransaction DT)
        {
            return GetList(Procedure, this.CommandTypeUsed, cmdParams,DT);
        }

        public virtual EntityList GetAll(EntityBase anEntity)
        {
            IDbDataParameter[] cmdParams = this.CreateSelectParameters(anEntity);
            return GetList(this.SelectCommand, this.CommandTypeUsed, cmdParams);
        }

        public virtual EntityList GetAll(EntityBase anEntity,DistributedTransaction DT)
        {
            IDbDataParameter[] cmdParams = this.CreateSelectParameters(anEntity);
            return GetList(this.SelectCommand, this.CommandTypeUsed, cmdParams,DT);
        }

        public virtual EntityBase GetSingle(EntityBase anEntity)
        {
            IDbDataParameter[] cmdParams = this.CreateSelectParameters(anEntity);
            return GetSingle(this.SelectCommand, this.CommandTypeUsed, cmdParams);
        }

        /// <summary>
        /// Performs the insertion of a new entity into the appropriate table. It uses the subclass's
        /// CreateInsertParameters method and InsertCommand property
        /// </summary>
        /// <param name="anEntity"></param>
        /// <returns></returns>
        public virtual int Insert(EntityBase anEntity)
        {            
            IDbDataParameter[] cmdParams = this.CreateInsertParameters(anEntity);
            return DataAccessHelper.ExecuteNonQuery(this.InsertCommand, this.CommandTypeUsed, cmdParams);
        }

        
        /// <summary>
        /// Performs the update of an existing entity into the appropriate table. It uses the subclass's
        /// CreateUpdateParameters method and UpdateCommand property
        /// </summary>
        /// <param name="anEntity"></param>
        /// <returns></returns>
        public virtual int Update(EntityBase anEntity)
        {
            IDbDataParameter[] cmdParams = CreateUpdateParameters(anEntity);
            return DataAccessHelper.ExecuteNonQuery(this.UpdateCommand, this.CommandTypeUsed, cmdParams);
        }

        /// <summary>
        /// Performs the deletion of an existing entity (identified by an id) into the appropriate table. 
        /// It uses the subclass's CreateDeleteParameters method and DeleteCommand property		
        /// </summary>
        /// <param name="anEntity"></param>
        /// <returns></returns>
        public virtual int Delete(EntityBase anEntity)
        {
            IDbDataParameter[] cmdParams = this.CreateDeleteParameters(anEntity);
            return DataAccessHelper.ExecuteNonQuery(DeleteCommand, CommandTypeUsed, cmdParams);
        }
        #region These Methods are for the Distributed Transaction
        /// <summary>
        /// Performs the insertion of a new entity into the appropriate table. It uses the subclass's
        /// CreateInsertParameters method and InsertCommand property
        /// </summary>
        /// <param name="anEntity"></param>
        /// <returns></returns>
        /// 
        public virtual EntityBase GetSingle(EntityBase anEntity, DistributedTransaction DT)
        {
            IDbDataParameter[] cmdParams = this.CreateSelectParameters(anEntity);
            return GetSingle(this.SelectCommand, this.CommandTypeUsed, cmdParams,DT);
        }
        public virtual int Insert(EntityBase anEntity, DistributedTransaction DT)
        {
            IDbDataParameter[] cmdParams = this.CreateInsertParameters(anEntity);
            return DataAccessHelper.ExecuteNonQueryTransaction(this.InsertCommand, this.CommandTypeUsed, cmdParams, DT);
        }

        /// <summary>
        /// Performs the update of an existing entity into the appropriate table. It uses the subclass's
        /// CreateUpdateParameters method and UpdateCommand property
        /// </summary>
        /// <param name="anEntity"></param>
        /// <returns></returns>
        public virtual int Update(EntityBase anEntity, DistributedTransaction DT)
        {
            IDbDataParameter[] cmdParams = CreateUpdateParameters(anEntity);
            return DataAccessHelper.ExecuteNonQueryTransaction(this.UpdateCommand, this.CommandTypeUsed, cmdParams, DT);
        }

        /// <summary>
        /// Performs the deletion of an existing entity (identified by an id) into the appropriate table. 
        /// It uses the subclass's CreateDeleteParameters method and DeleteCommand property		
        /// </summary>
        /// <param name="anEntity"></param>
        /// <returns></returns>
        public virtual int Delete(EntityBase anEntity, DistributedTransaction DT)
        {
            IDbDataParameter[] cmdParams = this.CreateDeleteParameters(anEntity);
            return DataAccessHelper.ExecuteNonQueryTransaction(DeleteCommand, CommandTypeUsed, cmdParams,DT);
        }

        #endregion

        #endregion

        #region Protected Methods
        protected EntityList GetList(string cmdText, CommandType cmdType, IDbDataParameter[] cmdParams)
        {
            EntityList theList = new EntityList();
            EntityBase result = null;

            IDataReader reader = DataAccessHelper.ExecuteReader(cmdText, cmdType, cmdParams);
            SafeDataReader safeReader = new SafeDataReader(reader);
                while (safeReader.Read())
                {
                    result = this.CreateAndBuildEntity(safeReader);
                    theList.Add(result);
                }
                safeReader.Close();
            return theList;
        }

        protected EntityList GetList(string cmdText, CommandType cmdType, IDbDataParameter[] cmdParams,DistributedTransaction DT)
        {
            EntityList theList = new EntityList();
            EntityBase result = null;

            IDataReader reader = DataAccessHelper.ExecuteReader(cmdText, cmdType, cmdParams,DT);
            SafeDataReader safeReader = new SafeDataReader(reader);
            while (safeReader.Read())
            {
                result = this.CreateAndBuildEntity(safeReader);
                theList.Add(result);
            }
            safeReader.Close();
            return theList;
        }

        public virtual DataSet GetDataSet(EntityBase anEntity)
        {
            DataTable dt = new DataTable();
            DataColumn dc;
            DataSet ds = new DataSet();
            anEntity.GetType();
            IDbDataParameter[] cmdParams = this.CreateSelectParameters(anEntity);
            EntityList entList= GetList(this.SelectCommand, this.CommandTypeUsed, cmdParams);
            if (entList.Count > 0)
            {
                System.Reflection.PropertyInfo[] propInfo = entList[0].GetType().GetProperties();
                System.Reflection.MethodInfo[] memInfo = entList[0].GetType().GetMethods();
                foreach (System.Reflection.PropertyInfo proinf in propInfo)
                {
                    dc = new DataColumn(proinf.Name, System.Type.GetType("System.String"));
                    dt.Columns.Add(dc);
                }


                string[] userParameters = null;
                foreach (EntityBase ent in entList)
                {
                    DataRow dr = dt.NewRow();
                    int i = 0;
                    foreach (System.Reflection.MethodInfo memInf in memInfo)
                    {
                        if (memInf.Name.Substring(0, 3).ToLower() == "get")
                        {
                            if (memInf.Name.ToLower() != "gettype" && memInf.Name.ToLower() != "gethashcode")
                            {

                                dr[i] = memInf.Invoke(ent, userParameters);
                                i++;
                            }
                        }
                    }
                    dt.Rows.Add(dr);
                }
                ds.Tables.Add(dt);
            }
            return ds;

        }
        protected EntityBase GetSingle(string cmdText, CommandType cmdType, IDbDataParameter[] cmdParams)
        {
            EntityBase result = null;
            IDataReader reader = DataAccessHelper.ExecuteReader(cmdText, cmdType, cmdParams);
            SafeDataReader safeReader = new SafeDataReader(reader);
                if (reader.Read())
                    result = this.CreateAndBuildEntity(safeReader);
                reader.Close();
            return result;
        }

        protected EntityBase GetSingle(string cmdText, CommandType cmdType, IDbDataParameter[] cmdParams, DistributedTransaction DT)
        {
            EntityBase result = null;
            IDataReader reader = DataAccessHelper.ExecuteReader(cmdText, cmdType, cmdParams,DT);
            SafeDataReader safeReader = new SafeDataReader(reader);
                if (reader.Read())
                    result = this.CreateAndBuildEntity(safeReader);
                reader.Close();
            return result;
        }

        public string GetSingleValue(string cmdText, CommandType cmdType, IDbDataParameter[] cmdParams)
        {
            string result = "";
            IDataReader reader = DataAccessHelper.ExecuteReader(cmdText, cmdType, cmdParams);
            SafeDataReader safeReader = new SafeDataReader(reader);
                if (reader.Read())
                {
                    try
                    {
                        result = safeReader[0].ToString();
                    }
                    catch
                    {
                        result = "";
                    }
                }
            return result;
        }


        public string GetSingleValue(string cmdText, CommandType cmdType, IDbDataParameter[] cmdParams,DistributedTransaction DT)
        {
            string result = "";
            IDataReader reader = DataAccessHelper.ExecuteReader(cmdText, cmdType, cmdParams,DT);
            SafeDataReader safeReader = new SafeDataReader(reader);
                if (reader.Read())
                {
                        result = safeReader[0].ToString();
                }
            return result;
        }

        protected IDataReader GetDataReader(string cmdText, CommandType cmdType, IDbDataParameter[] cmdParams)
        {
            IDataReader reader = DataAccessHelper.ExecuteReader(cmdText, cmdType, cmdParams);
            IDataReader currentDataReader;
            currentDataReader=reader;
            //reader.Close();
            return currentDataReader;
        }

        protected IDataReader GetDataReader(string cmdText, CommandType cmdType, IDbDataParameter[] cmdParams,DistributedTransaction DT)
        {
            IDataReader reader = DataAccessHelper.ExecuteReader(cmdText, cmdType, cmdParams,DT);
            IDataReader currentDataReader;
            currentDataReader = reader;
            //reader.Close();
            return currentDataReader;
        }

        #endregion
    }
}