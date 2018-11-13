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
    public class INSURANCE_CLAIMDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public INSURANCE_CLAIMDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTINSURANCE_CLAIM";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYINSURANCE_CLAIM";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYINSURANCE_CLAIM";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYINSURANCE_CLAIM";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			INSURANCE_CLAIM theEntity = new INSURANCE_CLAIM();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VEHICLE_ACCIDENT_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.REPORTING_DATE = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.REPORTING_DAY = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.REPORTING_MONTH = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.REPORTING_YEAR = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.INSURANCE_COMPANY_ID = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.REPAIRED_SHOP = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.REPAIRED_DETAIL = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.CLAIMED_COST = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.REIMBURSED_COST = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.REIMBURSED_REFERENCE = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            INSURANCE_CLAIM theEntity = (INSURANCE_CLAIM)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ACCIDENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ACCIDENT_ID",theEntity.VEHICLE_ACCIDENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_DATE",theEntity.REPORTING_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_DAY",theEntity.REPORTING_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_MONTH",theEntity.REPORTING_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_YEAR",theEntity.REPORTING_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.INSURANCE_COMPANY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_COMPANY_ID",theEntity.INSURANCE_COMPANY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIRED_SHOP))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIRED_SHOP",theEntity.REPAIRED_SHOP));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIRED_DETAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIRED_DETAIL",theEntity.REPAIRED_DETAIL));
	
			if(!string.IsNullOrEmpty(theEntity.CLAIMED_COST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CLAIMED_COST",theEntity.CLAIMED_COST));
	
			if(!string.IsNullOrEmpty(theEntity.REIMBURSED_COST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REIMBURSED_COST",theEntity.REIMBURSED_COST));
	
			if(!string.IsNullOrEmpty(theEntity.REIMBURSED_REFERENCE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REIMBURSED_REFERENCE",theEntity.REIMBURSED_REFERENCE));


            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            INSURANCE_CLAIM theEntity = (INSURANCE_CLAIM)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ACCIDENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ACCIDENT_ID",theEntity.VEHICLE_ACCIDENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_DATE",theEntity.REPORTING_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_DAY",theEntity.REPORTING_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_MONTH",theEntity.REPORTING_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_YEAR",theEntity.REPORTING_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.INSURANCE_COMPANY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_COMPANY_ID",theEntity.INSURANCE_COMPANY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIRED_SHOP))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIRED_SHOP",theEntity.REPAIRED_SHOP));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIRED_DETAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIRED_DETAIL",theEntity.REPAIRED_DETAIL));
	
			if(!string.IsNullOrEmpty(theEntity.CLAIMED_COST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CLAIMED_COST",theEntity.CLAIMED_COST));
	
			if(!string.IsNullOrEmpty(theEntity.REIMBURSED_COST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REIMBURSED_COST",theEntity.REIMBURSED_COST));
	
			if(!string.IsNullOrEmpty(theEntity.REIMBURSED_REFERENCE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REIMBURSED_REFERENCE",theEntity.REIMBURSED_REFERENCE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            INSURANCE_CLAIM theEntity = (INSURANCE_CLAIM)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ACCIDENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ACCIDENT_ID",theEntity.VEHICLE_ACCIDENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_DATE",theEntity.REPORTING_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_DAY",theEntity.REPORTING_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_MONTH",theEntity.REPORTING_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_YEAR",theEntity.REPORTING_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.INSURANCE_COMPANY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_COMPANY_ID",theEntity.INSURANCE_COMPANY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIRED_SHOP))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIRED_SHOP",theEntity.REPAIRED_SHOP));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIRED_DETAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIRED_DETAIL",theEntity.REPAIRED_DETAIL));
	
			if(!string.IsNullOrEmpty(theEntity.CLAIMED_COST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CLAIMED_COST",theEntity.CLAIMED_COST));
	
			if(!string.IsNullOrEmpty(theEntity.REIMBURSED_COST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REIMBURSED_COST",theEntity.REIMBURSED_COST));
	
			if(!string.IsNullOrEmpty(theEntity.REIMBURSED_REFERENCE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REIMBURSED_REFERENCE",theEntity.REIMBURSED_REFERENCE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            INSURANCE_CLAIM theEntity = (INSURANCE_CLAIM)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ACCIDENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ACCIDENT_ID",theEntity.VEHICLE_ACCIDENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_DATE",theEntity.REPORTING_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_DAY",theEntity.REPORTING_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_MONTH",theEntity.REPORTING_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.REPORTING_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPORTING_YEAR",theEntity.REPORTING_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.INSURANCE_COMPANY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_COMPANY_ID",theEntity.INSURANCE_COMPANY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIRED_SHOP))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIRED_SHOP",theEntity.REPAIRED_SHOP));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIRED_DETAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIRED_DETAIL",theEntity.REPAIRED_DETAIL));
	
			if(!string.IsNullOrEmpty(theEntity.CLAIMED_COST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CLAIMED_COST",theEntity.CLAIMED_COST));
	
			if(!string.IsNullOrEmpty(theEntity.REIMBURSED_COST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REIMBURSED_COST",theEntity.REIMBURSED_COST));
	
			if(!string.IsNullOrEmpty(theEntity.REIMBURSED_REFERENCE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REIMBURSED_REFERENCE",theEntity.REIMBURSED_REFERENCE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	