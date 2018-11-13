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
    public class fiscalyearDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public fiscalyearDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.selectfiscalyear";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.modifyfiscalyear";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.modifyfiscalyear";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.modifyfiscalyear";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			fiscalyear theEntity = new fiscalyear();
	
			theEntity.FISCAL_YEAR = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.START_DATE = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.END_DATE = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            fiscalyear theEntity = (fiscalyear)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.FISCAL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("FISCAL_YEAR",theEntity.FISCAL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.START_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("START_DATE",theEntity.START_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.END_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("END_DATE",theEntity.END_DATE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            fiscalyear theEntity = (fiscalyear)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.FISCAL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("FISCAL_YEAR",theEntity.FISCAL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.START_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("START_DATE",theEntity.START_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.END_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("END_DATE",theEntity.END_DATE));
            
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            fiscalyear theEntity = (fiscalyear)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.FISCAL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("FISCAL_YEAR",theEntity.FISCAL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.START_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("START_DATE",theEntity.START_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.END_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("END_DATE",theEntity.END_DATE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            fiscalyear theEntity = (fiscalyear)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.FISCAL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("FISCAL_YEAR",theEntity.FISCAL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.START_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("START_DATE",theEntity.START_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.END_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("END_DATE",theEntity.END_DATE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	