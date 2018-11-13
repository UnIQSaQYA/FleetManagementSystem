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
    public class VEHICLE_INSURANCEDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public VEHICLE_INSURANCEDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTVEHICLE_INSURANCE";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_INSURANCE";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_INSURANCE";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_INSURANCE";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			VEHICLE_INSURANCE theEntity = new VEHICLE_INSURANCE();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VEHICLE_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.INSURANCE_COMPANY_ID = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.INSURANCE_TYPE = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.POLICY_NUMBER = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.INSURANCE_DAY = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.INSURANCE_MONTH = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.INSURANCE_YEAR = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.INSURANCE_DATE = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.AMOUNT = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;

            theEntity.OFFICE_CODE = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;

            theEntity.INSURANCE_FROM = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;

            theEntity.INSURANCE_TO = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;

            theEntity.INSURANCE_FROM_ENG = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;

            theEntity.INSURANCE_TO_ENG = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            VEHICLE_INSURANCE theEntity = (VEHICLE_INSURANCE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.INSURANCE_COMPANY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_COMPANY_ID",theEntity.INSURANCE_COMPANY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.INSURANCE_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_TYPE",theEntity.INSURANCE_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.POLICY_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_POLICY_NUMBER",theEntity.POLICY_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.INSURANCE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_DAY",theEntity.INSURANCE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.INSURANCE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_MONTH",theEntity.INSURANCE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.INSURANCE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_YEAR",theEntity.INSURANCE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.INSURANCE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_DATE",theEntity.INSURANCE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.AMOUNT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AMOUNT",theEntity.AMOUNT));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_FROM))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_FROM", theEntity.INSURANCE_FROM));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_TO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_TO", theEntity.INSURANCE_TO));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_FROM_ENG))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_FROM_ENG", theEntity.INSURANCE_FROM_ENG));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_TO_ENG))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_TO_ENG", theEntity.INSURANCE_TO_ENG));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            VEHICLE_INSURANCE theEntity = (VEHICLE_INSURANCE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID", theEntity.VEHICLE_ID));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_COMPANY_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_COMPANY_ID", theEntity.INSURANCE_COMPANY_ID));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_TYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_TYPE", theEntity.INSURANCE_TYPE));

            if (!string.IsNullOrEmpty(theEntity.POLICY_NUMBER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_POLICY_NUMBER", theEntity.POLICY_NUMBER));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_DAY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_DAY", theEntity.INSURANCE_DAY));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_MONTH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_MONTH", theEntity.INSURANCE_MONTH));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_YEAR", theEntity.INSURANCE_YEAR));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_DATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_DATE", theEntity.INSURANCE_DATE));

            if (!string.IsNullOrEmpty(theEntity.AMOUNT))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AMOUNT", theEntity.AMOUNT));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_FROM))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_FROM", theEntity.INSURANCE_FROM));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_TO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_TO", theEntity.INSURANCE_TO));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_FROM_ENG))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_FROM_ENG", theEntity.INSURANCE_FROM_ENG));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_TO_ENG))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_TO_ENG", theEntity.INSURANCE_TO_ENG));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            VEHICLE_INSURANCE theEntity = (VEHICLE_INSURANCE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID", theEntity.VEHICLE_ID));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_COMPANY_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_COMPANY_ID", theEntity.INSURANCE_COMPANY_ID));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_TYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_TYPE", theEntity.INSURANCE_TYPE));

            if (!string.IsNullOrEmpty(theEntity.POLICY_NUMBER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_POLICY_NUMBER", theEntity.POLICY_NUMBER));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_DAY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_DAY", theEntity.INSURANCE_DAY));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_MONTH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_MONTH", theEntity.INSURANCE_MONTH));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_YEAR", theEntity.INSURANCE_YEAR));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_DATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_DATE", theEntity.INSURANCE_DATE));

            if (!string.IsNullOrEmpty(theEntity.AMOUNT))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AMOUNT", theEntity.AMOUNT));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_FROM))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_FROM", theEntity.INSURANCE_FROM));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_TO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_TO", theEntity.INSURANCE_TO));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_FROM_ENG))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_FROM_ENG", theEntity.INSURANCE_FROM_ENG));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_TO_ENG))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_TO_ENG", theEntity.INSURANCE_TO_ENG));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            VEHICLE_INSURANCE theEntity = (VEHICLE_INSURANCE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID", theEntity.VEHICLE_ID));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_COMPANY_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_COMPANY_ID", theEntity.INSURANCE_COMPANY_ID));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_TYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_TYPE", theEntity.INSURANCE_TYPE));

            if (!string.IsNullOrEmpty(theEntity.POLICY_NUMBER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_POLICY_NUMBER", theEntity.POLICY_NUMBER));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_DAY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_DAY", theEntity.INSURANCE_DAY));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_MONTH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_MONTH", theEntity.INSURANCE_MONTH));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_YEAR", theEntity.INSURANCE_YEAR));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_DATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_DATE", theEntity.INSURANCE_DATE));

            if (!string.IsNullOrEmpty(theEntity.AMOUNT))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AMOUNT", theEntity.AMOUNT));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_FROM))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_FROM", theEntity.INSURANCE_FROM));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_TO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_TO", theEntity.INSURANCE_TO));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_FROM_ENG))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_FROM_ENG", theEntity.INSURANCE_FROM_ENG));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_TO_ENG))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_TO_ENG", theEntity.INSURANCE_TO_ENG));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	