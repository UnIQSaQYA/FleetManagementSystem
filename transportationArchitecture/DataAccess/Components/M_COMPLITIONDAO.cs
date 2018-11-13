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
    public class M_COMPLITIONDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public M_COMPLITIONDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTM_COMPLITION";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_COMPLITION";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_COMPLITION";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_COMPLITION";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			M_COMPLITION theEntity = new M_COMPLITION();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.JOB_CARD_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.C_DATE = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.C_DAY = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.C_MONTH = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.C_YEAR = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.C_FY = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.SUPERVISOR_ID = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.DEPARTMENTHEAD_ID = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.D_DATE = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            M_COMPLITION theEntity = (M_COMPLITION)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_CARD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_CARD_ID",theEntity.JOB_CARD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.C_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_DATE",theEntity.C_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.C_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_DAY",theEntity.C_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.C_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_MONTH",theEntity.C_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.C_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_YEAR",theEntity.C_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.C_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_FY",theEntity.C_FY));
	
			if(!string.IsNullOrEmpty(theEntity.SUPERVISOR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPERVISOR_ID",theEntity.SUPERVISOR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DEPARTMENTHEAD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEPARTMENTHEAD_ID",theEntity.DEPARTMENTHEAD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.D_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_D_DATE",theEntity.D_DATE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            M_COMPLITION theEntity = (M_COMPLITION)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_CARD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_CARD_ID",theEntity.JOB_CARD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.C_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_DATE",theEntity.C_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.C_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_DAY",theEntity.C_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.C_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_MONTH",theEntity.C_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.C_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_YEAR",theEntity.C_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.C_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_FY",theEntity.C_FY));
	
			if(!string.IsNullOrEmpty(theEntity.SUPERVISOR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPERVISOR_ID",theEntity.SUPERVISOR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DEPARTMENTHEAD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEPARTMENTHEAD_ID",theEntity.DEPARTMENTHEAD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.D_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_D_DATE",theEntity.D_DATE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            M_COMPLITION theEntity = (M_COMPLITION)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_CARD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_CARD_ID",theEntity.JOB_CARD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.C_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_DATE",theEntity.C_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.C_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_DAY",theEntity.C_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.C_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_MONTH",theEntity.C_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.C_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_YEAR",theEntity.C_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.C_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_FY",theEntity.C_FY));
	
			if(!string.IsNullOrEmpty(theEntity.SUPERVISOR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPERVISOR_ID",theEntity.SUPERVISOR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DEPARTMENTHEAD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEPARTMENTHEAD_ID",theEntity.DEPARTMENTHEAD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.D_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_D_DATE",theEntity.D_DATE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            M_COMPLITION theEntity = (M_COMPLITION)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_CARD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_CARD_ID",theEntity.JOB_CARD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.C_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_DATE",theEntity.C_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.C_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_DAY",theEntity.C_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.C_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_MONTH",theEntity.C_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.C_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_YEAR",theEntity.C_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.C_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_C_FY",theEntity.C_FY));
	
			if(!string.IsNullOrEmpty(theEntity.SUPERVISOR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPERVISOR_ID",theEntity.SUPERVISOR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DEPARTMENTHEAD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEPARTMENTHEAD_ID",theEntity.DEPARTMENTHEAD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.D_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_D_DATE",theEntity.D_DATE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	