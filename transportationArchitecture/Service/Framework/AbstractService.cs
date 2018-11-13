using System;
using Entity.Framework;
using DataAccess.Framework;
using System.Data;
using DataHelper.Framework;

namespace Service.Framework
{
    /// <summary>
    /// All service objects based on this AbstractService class. 
    /// 
    /// A service layer defines an application's boundary with a layer of services that
    /// establishes a set of available operations and coordinates the application's
    /// response in each operation.
    /// 
    /// The service layer thus encapsulates the application's business logic, controls
    /// any database transactions, and coordinates any responses needed in the implementation 
    /// of the operations. Each service object is thus a facade of sorts for each of the
    /// major domain objects
    /// </summary>
    public abstract class AbstractService
    {
        public enum SortDirection
        {
            Ascending,
            Descending
        }

        #region Constructor
        public AbstractService()
        {
        }
        #endregion

        #region Properties
        public abstract AbstractDAO dao
        {
            get;
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Inserts a entity into a table. The DAO object knows which table and field the
        /// entity is for. The DAO Object is initialized in the subclass
        /// </summary>
        /// <param name="anEntity"></param>
        /// <returns></returns>
        public virtual int Insert(EntityBase anEntity)
        {
            return dao.Insert(anEntity);
        }

        /// <summary>
        /// Updates a entity in a table. The DAO object knows which table and field the
        /// entity is for. The DAO Object is initialized in the subclass
        /// </summary>
        /// <param name="anEntity"></param>
        public virtual int Update(EntityBase anEntity)
        {
            return dao.Update(anEntity);
        }

        /// <summary>
        /// Deletes the spefied ID from a table in the database. The DAO object knows which table and field the
        /// ID is for. The DAO Object is initialized in the subclass. The ID field must be valid
        /// </summary>
        /// <param name="anEntity"></param>
        public virtual int Delete(EntityBase anEntity)
        {
            return dao.Delete(anEntity);
        }

        #region These Methods are For Distributed Transaction
        /// <summary>
        /// Inserts a entity into a table. The DAO object knows which table and field the
        /// entity is for. The DAO Object is initialized in the subclass
        /// </summary>
        /// <param name="anEntity"></param>
        /// <returns></returns>
        public virtual int Insert(EntityBase anEntity, DistributedTransaction DT)
        {
            return dao.Insert(anEntity, DT);
        }

        /// <summary>
        /// Updates a entity in a table. The DAO object knows which table and field the
        /// entity is for. The DAO Object is initialized in the subclass
        /// </summary>
        /// <param name="anEntity"></param>
        public virtual int Update(EntityBase anEntity, DistributedTransaction DT)
        {
            return dao.Update(anEntity,DT);
        }

        /// <summary>
        /// Deletes the spefied ID from a table in the database. The DAO object knows which table and field the
        /// ID is for. The DAO Object is initialized in the subclass. The ID field must be valid
        /// </summary>
        /// <param name="anEntity"></param>
        public virtual int Delete(EntityBase anEntity, DistributedTransaction DT)
        {
            return dao.Delete(anEntity, DT);
        }

        public virtual EntityBase GetSingle(EntityBase anEntity, DistributedTransaction DT)
        {
            return dao.GetSingle(anEntity,DT);
        }

        public virtual EntityList GetAll()
        {
            return dao.GetAll();
        }

        public virtual EntityList GetAll(EntityBase anEntity)
        {
            return dao.GetAll(anEntity);
        }

        public virtual EntityList GetAll(EntityBase anEntity,DistributedTransaction DT)
        {
            return dao.GetAll(anEntity,DT);
        }

        public virtual EntityBase GetSingle(EntityBase anEntity)
        {
            return dao.GetSingle(anEntity);
        }

        public virtual DataSet GetDataSet(EntityBase anEntity)
        {
            return dao.GetDataSet(anEntity);
        }

        public virtual IDataReader GetAllDataReader(string CommandName, CommandType cmdType, IDbDataParameter[] cmdParams)
        {
            return dao.GetAllDataReader(CommandName, cmdType, cmdParams);
        }

        public virtual string GetSingleValue(string CommandName, CommandType cmdType, IDbDataParameter[] ParamList)
        {
            string ReturnValue="";
            ReturnValue = dao.GetSingleValue(CommandName, cmdType, ParamList);
            return ReturnValue;
            
        }

        public virtual string GetSingleValue(string CommandName, CommandType cmdType, IDbDataParameter[] ParamList,DistributedTransaction DT)
        {
            string ReturnValue = "";
            ReturnValue = dao.GetSingleValue(CommandName, cmdType, ParamList,DT);
            return ReturnValue;

        }

        public DataTable ReaderToTable(string cmdText, CommandType cmdType, IDbDataParameter[] cmdParams)
        {
            IDataReader reader;
            DataTable DT = new DataTable();
            reader = dao.GetAllDataReader(cmdText, cmdType, cmdParams);
            if (reader != null)
            {
                if (reader.FieldCount > 0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        DataColumn DC = new DataColumn();
                        DC.ColumnName = reader.GetName(i).ToString();
                        DC.DataType = reader.GetFieldType(i);
                        DT.Columns.Add(DC);
                    }
                }
                while (reader.Read())
                {
                    DataRow DR = DT.NewRow();
                    for (int j = 0; j < reader.FieldCount; j++)
                    {
                        DR[j] = reader[j];
                    }
                    DT.Rows.Add(DR);
                }
                return DT;
            }
            return null;
        }

        public DataTable ReaderToTable(string cmdText, CommandType cmdType, IDbDataParameter[] cmdParams,DistributedTransaction DisTran)
        {
            IDataReader reader;
            DataTable DT = new DataTable();
            reader = dao.GetAllDataReader(cmdText, cmdType, cmdParams, DisTran);
            if (reader != null)
            {
                if (reader.FieldCount > 0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        DataColumn DC = new DataColumn();
                        DC.ColumnName = reader.GetName(i).ToString();
                        DC.DataType = reader.GetFieldType(i);
                        DT.Columns.Add(DC);
                    }
                }
                while (reader.Read())
                {
                    DataRow DR = DT.NewRow();
                    for (int j = 0; j < reader.FieldCount; j++)
                    {
                        DR[j] = reader[j];
                    }
                    DT.Rows.Add(DR);
                }
                return DT;
            }
            return null;
        }

        #endregion

        #endregion

        #region	Protected Methods
        protected virtual EntityList GetAllFromDAO()
        {
            return dao.GetAll();
        }

        #endregion
    }
}
