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
    public class M_NEXT_SERVICEDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public M_NEXT_SERVICEDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTM_NEXT_SERVICE";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_NEXT_SERVICE";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_NEXT_SERVICE";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_NEXT_SERVICE";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			M_NEXT_SERVICE theEntity = new M_NEXT_SERVICE();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VEHICLE_REG_NO = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.NEXT_SER_DAY = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.NEXT_SER_MONTH = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.NEXT_SER_YEAR = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.NEXT_SER_DATE = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.NEXT_SER_KM = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;

            theEntity.COMPLITION_ID = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            M_NEXT_SERVICE theEntity = (M_NEXT_SERVICE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_DAY",theEntity.NEXT_SER_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_MONTH",theEntity.NEXT_SER_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_YEAR",theEntity.NEXT_SER_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_DATE",theEntity.NEXT_SER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_KM))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_KM",theEntity.NEXT_SER_KM));

            if (!string.IsNullOrEmpty(theEntity.COMPLITION_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_COMPLITION_ID", theEntity.COMPLITION_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            M_NEXT_SERVICE theEntity = (M_NEXT_SERVICE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_DAY",theEntity.NEXT_SER_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_MONTH",theEntity.NEXT_SER_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_YEAR",theEntity.NEXT_SER_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_DATE",theEntity.NEXT_SER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_KM))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_KM",theEntity.NEXT_SER_KM));

            if (!string.IsNullOrEmpty(theEntity.COMPLITION_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_COMPLITION_ID", theEntity.COMPLITION_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            M_NEXT_SERVICE theEntity = (M_NEXT_SERVICE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_DAY",theEntity.NEXT_SER_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_MONTH",theEntity.NEXT_SER_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_YEAR",theEntity.NEXT_SER_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_DATE",theEntity.NEXT_SER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_KM))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_KM",theEntity.NEXT_SER_KM));

            if (!string.IsNullOrEmpty(theEntity.COMPLITION_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_COMPLITION_ID", theEntity.COMPLITION_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            M_NEXT_SERVICE theEntity = (M_NEXT_SERVICE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_DAY",theEntity.NEXT_SER_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_MONTH",theEntity.NEXT_SER_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_YEAR",theEntity.NEXT_SER_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_DATE",theEntity.NEXT_SER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SER_KM))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SER_KM",theEntity.NEXT_SER_KM));

            if (!string.IsNullOrEmpty(theEntity.COMPLITION_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_COMPLITION_ID", theEntity.COMPLITION_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	