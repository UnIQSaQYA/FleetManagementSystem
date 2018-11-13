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
    public class M_JOB_CARDDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public M_JOB_CARDDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTM_JOB_CARD";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_JOB_CARD";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_JOB_CARD";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_JOB_CARD";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			M_JOB_CARD theEntity = new M_JOB_CARD();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.JOB_NUMBER = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.JOB_DAY = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.JOB_MONTH = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.JOB_YEAR = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.JOB_DATE = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.JOB_FY = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.VECCHILE_REG_NO = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.PRIORITY = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.ODOMETER = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.DRIVER_ID = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.MECHANICS_ID = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.VECHICLE_USER = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			theEntity.MAINTAINANCE_SUPERVISOR_ID = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;
	
			theEntity.REFER_BY_ID = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;
	
			theEntity.APPROVE_BY_ID = !dr.IsDBNull(15) ? dr.GetValue(15).ToString() : string.Empty;
	
			theEntity.OFFICE = !dr.IsDBNull(16) ? dr.GetValue(16).ToString() : string.Empty;
	
			theEntity.BASE_SATATION = !dr.IsDBNull(17) ? dr.GetValue(17).ToString() : string.Empty;
	
			theEntity.MAINTAINANCE = !dr.IsDBNull(18) ? dr.GetValue(18).ToString() : string.Empty;
	
			theEntity.SERVICING = !dr.IsDBNull(19) ? dr.GetValue(19).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            M_JOB_CARD theEntity = (M_JOB_CARD)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_NUMBER",theEntity.JOB_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_DAY",theEntity.JOB_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_MONTH",theEntity.JOB_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_YEAR",theEntity.JOB_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_DATE",theEntity.JOB_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_FY",theEntity.JOB_FY));
	
			if(!string.IsNullOrEmpty(theEntity.VECCHILE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECCHILE_REG_NO",theEntity.VECCHILE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PRIORITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRIORITY",theEntity.PRIORITY));
	
			if(!string.IsNullOrEmpty(theEntity.ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ODOMETER",theEntity.ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID",theEntity.DRIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MECHANICS_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MECHANICS_ID",theEntity.MECHANICS_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VECHICLE_USER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_USER",theEntity.VECHICLE_USER));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTAINANCE_SUPERVISOR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTAINANCE_SUPERVISOR_ID",theEntity.MAINTAINANCE_SUPERVISOR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REFER_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REFER_BY_ID",theEntity.REFER_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_BY_ID",theEntity.APPROVE_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE",theEntity.OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.BASE_SATATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BASE_SATATION",theEntity.BASE_SATATION));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTAINANCE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTAINANCE",theEntity.MAINTAINANCE));
	
			if(!string.IsNullOrEmpty(theEntity.SERVICING))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SERVICING",theEntity.SERVICING));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            M_JOB_CARD theEntity = (M_JOB_CARD)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_NUMBER",theEntity.JOB_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_DAY",theEntity.JOB_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_MONTH",theEntity.JOB_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_YEAR",theEntity.JOB_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_DATE",theEntity.JOB_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_FY",theEntity.JOB_FY));
	
			if(!string.IsNullOrEmpty(theEntity.VECCHILE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECCHILE_REG_NO",theEntity.VECCHILE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PRIORITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRIORITY",theEntity.PRIORITY));
	
			if(!string.IsNullOrEmpty(theEntity.ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ODOMETER",theEntity.ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID",theEntity.DRIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MECHANICS_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MECHANICS_ID",theEntity.MECHANICS_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VECHICLE_USER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_USER",theEntity.VECHICLE_USER));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTAINANCE_SUPERVISOR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTAINANCE_SUPERVISOR_ID",theEntity.MAINTAINANCE_SUPERVISOR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REFER_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REFER_BY_ID",theEntity.REFER_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_BY_ID",theEntity.APPROVE_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE",theEntity.OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.BASE_SATATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BASE_SATATION",theEntity.BASE_SATATION));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTAINANCE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTAINANCE",theEntity.MAINTAINANCE));
	
			if(!string.IsNullOrEmpty(theEntity.SERVICING))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SERVICING",theEntity.SERVICING));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            M_JOB_CARD theEntity = (M_JOB_CARD)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_NUMBER",theEntity.JOB_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_DAY",theEntity.JOB_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_MONTH",theEntity.JOB_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_YEAR",theEntity.JOB_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_DATE",theEntity.JOB_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_FY",theEntity.JOB_FY));
	
			if(!string.IsNullOrEmpty(theEntity.VECCHILE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECCHILE_REG_NO",theEntity.VECCHILE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PRIORITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRIORITY",theEntity.PRIORITY));
	
			if(!string.IsNullOrEmpty(theEntity.ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ODOMETER",theEntity.ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID",theEntity.DRIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MECHANICS_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MECHANICS_ID",theEntity.MECHANICS_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VECHICLE_USER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_USER",theEntity.VECHICLE_USER));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTAINANCE_SUPERVISOR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTAINANCE_SUPERVISOR_ID",theEntity.MAINTAINANCE_SUPERVISOR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REFER_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REFER_BY_ID",theEntity.REFER_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_BY_ID",theEntity.APPROVE_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE",theEntity.OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.BASE_SATATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BASE_SATATION",theEntity.BASE_SATATION));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTAINANCE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTAINANCE",theEntity.MAINTAINANCE));
	
			if(!string.IsNullOrEmpty(theEntity.SERVICING))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SERVICING",theEntity.SERVICING));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            M_JOB_CARD theEntity = (M_JOB_CARD)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_NUMBER",theEntity.JOB_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_DAY",theEntity.JOB_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_MONTH",theEntity.JOB_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_YEAR",theEntity.JOB_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_DATE",theEntity.JOB_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_FY",theEntity.JOB_FY));
	
			if(!string.IsNullOrEmpty(theEntity.VECCHILE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECCHILE_REG_NO",theEntity.VECCHILE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PRIORITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRIORITY",theEntity.PRIORITY));
	
			if(!string.IsNullOrEmpty(theEntity.ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ODOMETER",theEntity.ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID",theEntity.DRIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MECHANICS_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MECHANICS_ID",theEntity.MECHANICS_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VECHICLE_USER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_USER",theEntity.VECHICLE_USER));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTAINANCE_SUPERVISOR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTAINANCE_SUPERVISOR_ID",theEntity.MAINTAINANCE_SUPERVISOR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REFER_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REFER_BY_ID",theEntity.REFER_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_BY_ID",theEntity.APPROVE_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE",theEntity.OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.BASE_SATATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BASE_SATATION",theEntity.BASE_SATATION));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTAINANCE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTAINANCE",theEntity.MAINTAINANCE));
	
			if(!string.IsNullOrEmpty(theEntity.SERVICING))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SERVICING",theEntity.SERVICING));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	