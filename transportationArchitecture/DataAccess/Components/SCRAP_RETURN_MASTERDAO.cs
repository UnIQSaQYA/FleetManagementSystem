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
    public class SCRAP_RETURN_MASTERDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public SCRAP_RETURN_MASTERDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTSCRAP_RETURN_MASTER";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYSCRAP_RETURN_MASTER";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYSCRAP_RETURN_MASTER";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYSCRAP_RETURN_MASTER";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			SCRAP_RETURN_MASTER theEntity = new SCRAP_RETURN_MASTER();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.RETURN_DAY = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.RETURN_MONTH = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.RETURN_YEAR = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.RETURN_DATE = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.RETURN_BY = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.VEHICLE_REG_NO = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            SCRAP_RETURN_MASTER theEntity = (SCRAP_RETURN_MASTER)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DAY",theEntity.RETURN_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_MONTH",theEntity.RETURN_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_YEAR",theEntity.RETURN_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DATE",theEntity.RETURN_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_BY",theEntity.RETURN_BY));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            SCRAP_RETURN_MASTER theEntity = (SCRAP_RETURN_MASTER)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DAY",theEntity.RETURN_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_MONTH",theEntity.RETURN_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_YEAR",theEntity.RETURN_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DATE",theEntity.RETURN_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_BY",theEntity.RETURN_BY));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            SCRAP_RETURN_MASTER theEntity = (SCRAP_RETURN_MASTER)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DAY",theEntity.RETURN_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_MONTH",theEntity.RETURN_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_YEAR",theEntity.RETURN_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DATE",theEntity.RETURN_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_BY",theEntity.RETURN_BY));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            SCRAP_RETURN_MASTER theEntity = (SCRAP_RETURN_MASTER)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DAY",theEntity.RETURN_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_MONTH",theEntity.RETURN_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_YEAR",theEntity.RETURN_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DATE",theEntity.RETURN_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_BY",theEntity.RETURN_BY));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	