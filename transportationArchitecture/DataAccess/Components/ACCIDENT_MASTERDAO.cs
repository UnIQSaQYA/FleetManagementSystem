using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using DataAccess.Framework;
using DataHelper.Framework;
using Entity.Components;
using Entity.Framework;

namespace DataAccess.Components
{
    public class ACCIDENT_MASTERDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public ACCIDENT_MASTERDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTACCIDENT_MASTER";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYACCIDENT_MASTER";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYACCIDENT_MASTER";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYACCIDENT_MASTER";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			ACCIDENT_MASTER theEntity = new ACCIDENT_MASTER();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.ACCIDENT_TYPE = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.REMARKS = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;

            theEntity.PARENT_ID = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            ACCIDENT_MASTER theEntity = (ACCIDENT_MASTER)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCIDENT_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_TYPE",theEntity.ACCIDENT_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.PARENT_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARENT_ID", theEntity.PARENT_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            ACCIDENT_MASTER theEntity = (ACCIDENT_MASTER)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_TYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_TYPE", theEntity.ACCIDENT_TYPE));

            if (!string.IsNullOrEmpty(theEntity.REMARKS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS", theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.PARENT_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARENT_ID", theEntity.PARENT_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            ACCIDENT_MASTER theEntity = (ACCIDENT_MASTER)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", "u"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_TYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_TYPE", theEntity.ACCIDENT_TYPE));

            if (!string.IsNullOrEmpty(theEntity.REMARKS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS", theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.PARENT_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARENT_ID", theEntity.PARENT_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            ACCIDENT_MASTER theEntity = (ACCIDENT_MASTER)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", "d"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_TYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_TYPE", theEntity.ACCIDENT_TYPE));

            if (!string.IsNullOrEmpty(theEntity.REMARKS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS", theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.PARENT_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARENT_ID", theEntity.PARENT_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	