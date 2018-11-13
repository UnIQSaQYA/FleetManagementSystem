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
    public class PRODUCT_DEMANDDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public PRODUCT_DEMANDDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTPRODUCT_DEMAND";

             
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_DEMAND";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_DEMAND";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_DEMAND";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			PRODUCT_DEMAND theEntity = new PRODUCT_DEMAND();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.DEMAND_NO = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.DEMAND_DAY = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.DEMAND_MONTH = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.DEMAND_YEAR = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.DEMAND_DATE = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.DEMAND_FISCALYEAR = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.INTERNAL_EXTERNAL = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.DEMAND_OFFICE = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.DEMAND_BY = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.PURPOSE = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.APPROVE_BY = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.APPROVE_DAY = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			theEntity.APPROVE_MONTH = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;
	
			theEntity.APPROVE_YEAR = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;
	
			theEntity.APPROVE_DATE = !dr.IsDBNull(15) ? dr.GetValue(15).ToString() : string.Empty;
	
			theEntity.ENTER_BY = !dr.IsDBNull(16) ? dr.GetValue(16).ToString() : string.Empty;
	
			theEntity.DEMAND_FULFILL_TYPE = !dr.IsDBNull(17) ? dr.GetValue(17).ToString() : string.Empty;
	
			theEntity.STATUS = !dr.IsDBNull(18) ? dr.GetValue(18).ToString() : string.Empty;

            theEntity.OFFICE_CODE = !dr.IsDBNull(19) ? dr.GetValue(19).ToString() : string.Empty;

			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            PRODUCT_DEMAND theEntity = (PRODUCT_DEMAND)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_NO",theEntity.DEMAND_NO));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_DAY",theEntity.DEMAND_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_MONTH",theEntity.DEMAND_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_YEAR",theEntity.DEMAND_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_DATE",theEntity.DEMAND_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_FISCALYEAR",theEntity.DEMAND_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.INTERNAL_EXTERNAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INTERNAL_EXTERNAL",theEntity.INTERNAL_EXTERNAL));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_OFFICE",theEntity.DEMAND_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_BY",theEntity.DEMAND_BY));
	
			if(!string.IsNullOrEmpty(theEntity.PURPOSE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURPOSE",theEntity.PURPOSE));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_BY",theEntity.APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_DAY",theEntity.APPROVE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_MONTH",theEntity.APPROVE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_YEAR",theEntity.APPROVE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_DATE",theEntity.APPROVE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ENTER_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTER_BY",theEntity.ENTER_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_FULFILL_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_FULFILL_TYPE",theEntity.DEMAND_FULFILL_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS",theEntity.STATUS));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            PRODUCT_DEMAND theEntity = (PRODUCT_DEMAND)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_NO",theEntity.DEMAND_NO));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_DAY",theEntity.DEMAND_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_MONTH",theEntity.DEMAND_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_YEAR",theEntity.DEMAND_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_DATE",theEntity.DEMAND_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_FISCALYEAR",theEntity.DEMAND_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.INTERNAL_EXTERNAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INTERNAL_EXTERNAL",theEntity.INTERNAL_EXTERNAL));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_OFFICE",theEntity.DEMAND_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_BY",theEntity.DEMAND_BY));
	
			if(!string.IsNullOrEmpty(theEntity.PURPOSE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURPOSE",theEntity.PURPOSE));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_BY",theEntity.APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_DAY",theEntity.APPROVE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_MONTH",theEntity.APPROVE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_YEAR",theEntity.APPROVE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_DATE",theEntity.APPROVE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ENTER_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTER_BY",theEntity.ENTER_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_FULFILL_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_FULFILL_TYPE",theEntity.DEMAND_FULFILL_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS",theEntity.STATUS));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            PRODUCT_DEMAND theEntity = (PRODUCT_DEMAND)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_NO",theEntity.DEMAND_NO));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_DAY",theEntity.DEMAND_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_MONTH",theEntity.DEMAND_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_YEAR",theEntity.DEMAND_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_DATE",theEntity.DEMAND_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_FISCALYEAR",theEntity.DEMAND_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.INTERNAL_EXTERNAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INTERNAL_EXTERNAL",theEntity.INTERNAL_EXTERNAL));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_OFFICE",theEntity.DEMAND_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_BY",theEntity.DEMAND_BY));
	
			if(!string.IsNullOrEmpty(theEntity.PURPOSE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURPOSE",theEntity.PURPOSE));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_BY",theEntity.APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_DAY",theEntity.APPROVE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_MONTH",theEntity.APPROVE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_YEAR",theEntity.APPROVE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_DATE",theEntity.APPROVE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ENTER_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTER_BY",theEntity.ENTER_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_FULFILL_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_FULFILL_TYPE",theEntity.DEMAND_FULFILL_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS",theEntity.STATUS));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            PRODUCT_DEMAND theEntity = (PRODUCT_DEMAND)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_NO",theEntity.DEMAND_NO));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_DAY",theEntity.DEMAND_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_MONTH",theEntity.DEMAND_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_YEAR",theEntity.DEMAND_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_DATE",theEntity.DEMAND_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_FISCALYEAR",theEntity.DEMAND_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.INTERNAL_EXTERNAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INTERNAL_EXTERNAL",theEntity.INTERNAL_EXTERNAL));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_OFFICE",theEntity.DEMAND_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_BY",theEntity.DEMAND_BY));
	
			if(!string.IsNullOrEmpty(theEntity.PURPOSE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURPOSE",theEntity.PURPOSE));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_BY",theEntity.APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_DAY",theEntity.APPROVE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_MONTH",theEntity.APPROVE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_YEAR",theEntity.APPROVE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_DATE",theEntity.APPROVE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ENTER_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTER_BY",theEntity.ENTER_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DEMAND_FULFILL_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEMAND_FULFILL_TYPE",theEntity.DEMAND_FULFILL_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS",theEntity.STATUS));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	