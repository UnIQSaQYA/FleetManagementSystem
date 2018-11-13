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
    public class REPAIR_ORDER_MASTERDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public REPAIR_ORDER_MASTERDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTREPAIR_ORDER_MASTER";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYREPAIR_ORDER_MASTER";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYREPAIR_ORDER_MASTER";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYREPAIR_ORDER_MASTER";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			REPAIR_ORDER_MASTER theEntity = new REPAIR_ORDER_MASTER();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.OFFICE_CODE = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.REPAIR_ORDER_NUMBER = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.REPAIR_ORDER_DAY = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.REPAIR_ORDER_MONTH = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.REPAIR_ORDER_YEAR = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.REPAIR_ORDER_DATE = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.REPAIR_ORDER_FY = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.EXTERNAL_WORKSHOP_ID = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.VEHICLE_REG_NO = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.CHECK_BY_ID = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.ACCOUNTANT_ID = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.DEPARTMENTHEAD_ID = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            REPAIR_ORDER_MASTER theEntity = (REPAIR_ORDER_MASTER)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE",theEntity.OFFICE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_NUMBER",theEntity.REPAIR_ORDER_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_DAY",theEntity.REPAIR_ORDER_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_MONTH",theEntity.REPAIR_ORDER_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_YEAR",theEntity.REPAIR_ORDER_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_DATE",theEntity.REPAIR_ORDER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_FY",theEntity.REPAIR_ORDER_FY));
	
			if(!string.IsNullOrEmpty(theEntity.EXTERNAL_WORKSHOP_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EXTERNAL_WORKSHOP_ID",theEntity.EXTERNAL_WORKSHOP_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.CHECK_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHECK_BY_ID",theEntity.CHECK_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCOUNTANT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCOUNTANT_ID",theEntity.ACCOUNTANT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DEPARTMENTHEAD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEPARTMENTHEAD_ID",theEntity.DEPARTMENTHEAD_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            REPAIR_ORDER_MASTER theEntity = (REPAIR_ORDER_MASTER)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE",theEntity.OFFICE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_NUMBER",theEntity.REPAIR_ORDER_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_DAY",theEntity.REPAIR_ORDER_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_MONTH",theEntity.REPAIR_ORDER_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_YEAR",theEntity.REPAIR_ORDER_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_DATE",theEntity.REPAIR_ORDER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_FY",theEntity.REPAIR_ORDER_FY));
	
			if(!string.IsNullOrEmpty(theEntity.EXTERNAL_WORKSHOP_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EXTERNAL_WORKSHOP_ID",theEntity.EXTERNAL_WORKSHOP_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.CHECK_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHECK_BY_ID",theEntity.CHECK_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCOUNTANT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCOUNTANT_ID",theEntity.ACCOUNTANT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DEPARTMENTHEAD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEPARTMENTHEAD_ID",theEntity.DEPARTMENTHEAD_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            REPAIR_ORDER_MASTER theEntity = (REPAIR_ORDER_MASTER)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE",theEntity.OFFICE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_NUMBER",theEntity.REPAIR_ORDER_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_DAY",theEntity.REPAIR_ORDER_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_MONTH",theEntity.REPAIR_ORDER_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_YEAR",theEntity.REPAIR_ORDER_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_DATE",theEntity.REPAIR_ORDER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_FY",theEntity.REPAIR_ORDER_FY));
	
			if(!string.IsNullOrEmpty(theEntity.EXTERNAL_WORKSHOP_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EXTERNAL_WORKSHOP_ID",theEntity.EXTERNAL_WORKSHOP_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.CHECK_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHECK_BY_ID",theEntity.CHECK_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCOUNTANT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCOUNTANT_ID",theEntity.ACCOUNTANT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DEPARTMENTHEAD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEPARTMENTHEAD_ID",theEntity.DEPARTMENTHEAD_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            REPAIR_ORDER_MASTER theEntity = (REPAIR_ORDER_MASTER)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE",theEntity.OFFICE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_NUMBER",theEntity.REPAIR_ORDER_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_DAY",theEntity.REPAIR_ORDER_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_MONTH",theEntity.REPAIR_ORDER_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_YEAR",theEntity.REPAIR_ORDER_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_DATE",theEntity.REPAIR_ORDER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_FY",theEntity.REPAIR_ORDER_FY));
	
			if(!string.IsNullOrEmpty(theEntity.EXTERNAL_WORKSHOP_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EXTERNAL_WORKSHOP_ID",theEntity.EXTERNAL_WORKSHOP_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.CHECK_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHECK_BY_ID",theEntity.CHECK_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCOUNTANT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCOUNTANT_ID",theEntity.ACCOUNTANT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DEPARTMENTHEAD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEPARTMENTHEAD_ID",theEntity.DEPARTMENTHEAD_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	