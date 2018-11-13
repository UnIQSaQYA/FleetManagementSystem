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
    public class OPENING_CLOSINGDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public OPENING_CLOSINGDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTOPENING_CLOSING";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYOPENING_CLOSING";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYOPENING_CLOSING";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYOPENING_CLOSING";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			OPENING_CLOSING theEntity = new OPENING_CLOSING();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.FISCAL_YEAR = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.PRODUCT_ID = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.OPENING_QTY = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.PURCHASE_QTY = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.RETURN_QTY = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.ADJUSTED_QTY = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.ISSUE_QTY = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.CLOSING_QTY = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.UNIT = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;

            theEntity.BATCH = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;

            theEntity.EXPIRY_DATE = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;

            theEntity.RATE = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            OPENING_CLOSING theEntity = (OPENING_CLOSING)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.FISCAL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FISCAL_YEAR",theEntity.FISCAL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OPENING_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OPENING_QTY",theEntity.OPENING_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_QTY",theEntity.PURCHASE_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_QTY",theEntity.RETURN_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.ADJUSTED_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADJUSTED_QTY",theEntity.ADJUSTED_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_QTY",theEntity.ISSUE_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.CLOSING_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CLOSING_QTY",theEntity.CLOSING_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));

            if (!string.IsNullOrEmpty(theEntity.BATCH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BATCH", theEntity.BATCH));

            if (!string.IsNullOrEmpty(theEntity.EXPIRY_DATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EXPIRY_DATE", theEntity.EXPIRY_DATE));

            if (!string.IsNullOrEmpty(theEntity.RATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE", theEntity.RATE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            OPENING_CLOSING theEntity = (OPENING_CLOSING)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.FISCAL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FISCAL_YEAR",theEntity.FISCAL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OPENING_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OPENING_QTY",theEntity.OPENING_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_QTY",theEntity.PURCHASE_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_QTY",theEntity.RETURN_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.ADJUSTED_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADJUSTED_QTY",theEntity.ADJUSTED_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_QTY",theEntity.ISSUE_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.CLOSING_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CLOSING_QTY",theEntity.CLOSING_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));

            if (!string.IsNullOrEmpty(theEntity.BATCH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BATCH", theEntity.BATCH));

            if (!string.IsNullOrEmpty(theEntity.EXPIRY_DATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EXPIRY_DATE", theEntity.EXPIRY_DATE));

            if (!string.IsNullOrEmpty(theEntity.RATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE", theEntity.RATE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            OPENING_CLOSING theEntity = (OPENING_CLOSING)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.FISCAL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FISCAL_YEAR",theEntity.FISCAL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OPENING_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OPENING_QTY",theEntity.OPENING_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_QTY",theEntity.PURCHASE_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_QTY",theEntity.RETURN_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.ADJUSTED_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADJUSTED_QTY",theEntity.ADJUSTED_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_QTY",theEntity.ISSUE_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.CLOSING_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CLOSING_QTY",theEntity.CLOSING_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));

            if (!string.IsNullOrEmpty(theEntity.BATCH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BATCH", theEntity.BATCH));

            if (!string.IsNullOrEmpty(theEntity.EXPIRY_DATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EXPIRY_DATE", theEntity.EXPIRY_DATE));

            if (!string.IsNullOrEmpty(theEntity.RATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE", theEntity.RATE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            OPENING_CLOSING theEntity = (OPENING_CLOSING)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.FISCAL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FISCAL_YEAR",theEntity.FISCAL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OPENING_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OPENING_QTY",theEntity.OPENING_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_QTY",theEntity.PURCHASE_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_QTY",theEntity.RETURN_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.ADJUSTED_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADJUSTED_QTY",theEntity.ADJUSTED_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_QTY",theEntity.ISSUE_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.CLOSING_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CLOSING_QTY",theEntity.CLOSING_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));

            if (!string.IsNullOrEmpty(theEntity.BATCH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BATCH", theEntity.BATCH));

            if (!string.IsNullOrEmpty(theEntity.EXPIRY_DATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EXPIRY_DATE", theEntity.EXPIRY_DATE));

            if (!string.IsNullOrEmpty(theEntity.RATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE", theEntity.RATE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	