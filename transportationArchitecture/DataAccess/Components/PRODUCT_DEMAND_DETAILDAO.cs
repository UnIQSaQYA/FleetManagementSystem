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
    public class PRODUCT_DEMAND_DETAILDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public PRODUCT_DEMAND_DETAILDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTPRODUCT_DEMAND_DETAIL";

              
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_DEMAND_DETAIL";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_DEMAND_DETAIL";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_DEMAND_DETAIL";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			PRODUCT_DEMAND_DETAIL theEntity = new PRODUCT_DEMAND_DETAIL();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.PRODUCT_DEMAND_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.SNO = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.PRODUCT_ID = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.REQUEST_QTY = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.UNIT = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.ISSUE_QTY = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.LEDGER_PAGE_NO = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.REMARKS = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.APPROVE_QTY = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            PRODUCT_DEMAND_DETAIL theEntity = (PRODUCT_DEMAND_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_DEMAND_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_DEMAND_ID",theEntity.PRODUCT_DEMAND_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REQUEST_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REQUEST_QTY",theEntity.REQUEST_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_QTY",theEntity.ISSUE_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.LEDGER_PAGE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LEDGER_PAGE_NO",theEntity.LEDGER_PAGE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_QTY",theEntity.APPROVE_QTY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            PRODUCT_DEMAND_DETAIL theEntity = (PRODUCT_DEMAND_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_DEMAND_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_DEMAND_ID",theEntity.PRODUCT_DEMAND_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REQUEST_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REQUEST_QTY",theEntity.REQUEST_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_QTY",theEntity.ISSUE_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.LEDGER_PAGE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LEDGER_PAGE_NO",theEntity.LEDGER_PAGE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_QTY",theEntity.APPROVE_QTY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            PRODUCT_DEMAND_DETAIL theEntity = (PRODUCT_DEMAND_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_DEMAND_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_DEMAND_ID",theEntity.PRODUCT_DEMAND_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REQUEST_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REQUEST_QTY",theEntity.REQUEST_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_QTY",theEntity.ISSUE_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.LEDGER_PAGE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LEDGER_PAGE_NO",theEntity.LEDGER_PAGE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_QTY",theEntity.APPROVE_QTY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            PRODUCT_DEMAND_DETAIL theEntity = (PRODUCT_DEMAND_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_DEMAND_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_DEMAND_ID",theEntity.PRODUCT_DEMAND_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REQUEST_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REQUEST_QTY",theEntity.REQUEST_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_QTY",theEntity.ISSUE_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.LEDGER_PAGE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LEDGER_PAGE_NO",theEntity.LEDGER_PAGE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_QTY",theEntity.APPROVE_QTY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	