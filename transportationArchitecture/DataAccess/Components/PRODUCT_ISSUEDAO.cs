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
    public class PRODUCT_ISSUEDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public PRODUCT_ISSUEDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTPRODUCT_ISSUE";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_ISSUE";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_ISSUE";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_ISSUE";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			PRODUCT_ISSUE theEntity = new PRODUCT_ISSUE();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.ISSUE_NO = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.ISSUE_DAY = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.ISSUE_MONTH = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.ISSUE_YEAR = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.ISSUE_DATE = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.ISSUE_FISCALYEAR = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.INTERNAL_EXTERNAL = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.ISSUE_TO_OFFICE_NAME = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.DECISION_DAY = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.DECISION_MONTH = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.DECISION_YEAR = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.DECISION_DATE = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			theEntity.DELIVERY_OFFICE = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;
	
			theEntity.DELIVERY_BY = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;
	
			theEntity.DELIVERY_DESIGNATION = !dr.IsDBNull(15) ? dr.GetValue(15).ToString() : string.Empty;
	
			theEntity.DELIVERY_REC_THROUGH = !dr.IsDBNull(16) ? dr.GetValue(16).ToString() : string.Empty;
	
			theEntity.RECEIVED_BY = !dr.IsDBNull(17) ? dr.GetValue(17).ToString() : string.Empty;
	
			theEntity.RECEIVED_BY_DESIGNATION = !dr.IsDBNull(18) ? dr.GetValue(18).ToString() : string.Empty;
	
			theEntity.RECEIVED_DATE = !dr.IsDBNull(19) ? dr.GetValue(19).ToString() : string.Empty;

            theEntity.PRODUCT_DEMAND_NO = !dr.IsDBNull(20) ? dr.GetValue(20).ToString() : string.Empty;

			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            PRODUCT_ISSUE theEntity = (PRODUCT_ISSUE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_NO",theEntity.ISSUE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DAY",theEntity.ISSUE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_MONTH",theEntity.ISSUE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_YEAR",theEntity.ISSUE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DATE",theEntity.ISSUE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_FISCALYEAR",theEntity.ISSUE_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.INTERNAL_EXTERNAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INTERNAL_EXTERNAL",theEntity.INTERNAL_EXTERNAL));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_TO_OFFICE_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_TO_OFFICE_NAME",theEntity.ISSUE_TO_OFFICE_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_DAY",theEntity.DECISION_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_MONTH",theEntity.DECISION_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_YEAR",theEntity.DECISION_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_DATE",theEntity.DECISION_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_OFFICE",theEntity.DELIVERY_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_BY",theEntity.DELIVERY_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_DESIGNATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_DESIGNATION",theEntity.DELIVERY_DESIGNATION));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_REC_THROUGH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_REC_THROUGH",theEntity.DELIVERY_REC_THROUGH));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVED_BY",theEntity.RECEIVED_BY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVED_BY_DESIGNATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVED_BY_DESIGNATION",theEntity.RECEIVED_BY_DESIGNATION));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVED_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVED_DATE",theEntity.RECEIVED_DATE));

            if (!string.IsNullOrEmpty(theEntity.PRODUCT_DEMAND_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_DEMAND_NO", theEntity.PRODUCT_DEMAND_NO));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            PRODUCT_ISSUE theEntity = (PRODUCT_ISSUE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_NO",theEntity.ISSUE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DAY",theEntity.ISSUE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_MONTH",theEntity.ISSUE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_YEAR",theEntity.ISSUE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DATE",theEntity.ISSUE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_FISCALYEAR",theEntity.ISSUE_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.INTERNAL_EXTERNAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INTERNAL_EXTERNAL",theEntity.INTERNAL_EXTERNAL));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_TO_OFFICE_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_TO_OFFICE_NAME",theEntity.ISSUE_TO_OFFICE_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_DAY",theEntity.DECISION_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_MONTH",theEntity.DECISION_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_YEAR",theEntity.DECISION_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_DATE",theEntity.DECISION_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_OFFICE",theEntity.DELIVERY_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_BY",theEntity.DELIVERY_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_DESIGNATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_DESIGNATION",theEntity.DELIVERY_DESIGNATION));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_REC_THROUGH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_REC_THROUGH",theEntity.DELIVERY_REC_THROUGH));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVED_BY",theEntity.RECEIVED_BY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVED_BY_DESIGNATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVED_BY_DESIGNATION",theEntity.RECEIVED_BY_DESIGNATION));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVED_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVED_DATE",theEntity.RECEIVED_DATE));

            if (!string.IsNullOrEmpty(theEntity.PRODUCT_DEMAND_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_DEMAND_NO", theEntity.PRODUCT_DEMAND_NO));
            
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            PRODUCT_ISSUE theEntity = (PRODUCT_ISSUE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_NO",theEntity.ISSUE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DAY",theEntity.ISSUE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_MONTH",theEntity.ISSUE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_YEAR",theEntity.ISSUE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DATE",theEntity.ISSUE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_FISCALYEAR",theEntity.ISSUE_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.INTERNAL_EXTERNAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INTERNAL_EXTERNAL",theEntity.INTERNAL_EXTERNAL));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_TO_OFFICE_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_TO_OFFICE_NAME",theEntity.ISSUE_TO_OFFICE_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_DAY",theEntity.DECISION_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_MONTH",theEntity.DECISION_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_YEAR",theEntity.DECISION_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_DATE",theEntity.DECISION_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_OFFICE",theEntity.DELIVERY_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_BY",theEntity.DELIVERY_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_DESIGNATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_DESIGNATION",theEntity.DELIVERY_DESIGNATION));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_REC_THROUGH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_REC_THROUGH",theEntity.DELIVERY_REC_THROUGH));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVED_BY",theEntity.RECEIVED_BY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVED_BY_DESIGNATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVED_BY_DESIGNATION",theEntity.RECEIVED_BY_DESIGNATION));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVED_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVED_DATE",theEntity.RECEIVED_DATE));

            if (!string.IsNullOrEmpty(theEntity.PRODUCT_DEMAND_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_DEMAND_NO", theEntity.PRODUCT_DEMAND_NO));
            
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            PRODUCT_ISSUE theEntity = (PRODUCT_ISSUE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_NO",theEntity.ISSUE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DAY",theEntity.ISSUE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_MONTH",theEntity.ISSUE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_YEAR",theEntity.ISSUE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DATE",theEntity.ISSUE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_FISCALYEAR",theEntity.ISSUE_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.INTERNAL_EXTERNAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INTERNAL_EXTERNAL",theEntity.INTERNAL_EXTERNAL));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_TO_OFFICE_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_TO_OFFICE_NAME",theEntity.ISSUE_TO_OFFICE_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_DAY",theEntity.DECISION_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_MONTH",theEntity.DECISION_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_YEAR",theEntity.DECISION_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DECISION_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DECISION_DATE",theEntity.DECISION_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_OFFICE",theEntity.DELIVERY_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_BY",theEntity.DELIVERY_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_DESIGNATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_DESIGNATION",theEntity.DELIVERY_DESIGNATION));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_REC_THROUGH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_REC_THROUGH",theEntity.DELIVERY_REC_THROUGH));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVED_BY",theEntity.RECEIVED_BY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVED_BY_DESIGNATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVED_BY_DESIGNATION",theEntity.RECEIVED_BY_DESIGNATION));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVED_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVED_DATE",theEntity.RECEIVED_DATE));

            if (!string.IsNullOrEmpty(theEntity.PRODUCT_DEMAND_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_DEMAND_NO", theEntity.PRODUCT_DEMAND_NO));
            
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	