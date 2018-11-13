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
    public class ACCESSORIES_DAKHILADAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public ACCESSORIES_DAKHILADAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTACCESSORIES_DAKHILA";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYACCESSORIES_DAKHILA";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYACCESSORIES_DAKHILA";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYACCESSORIES_DAKHILA";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			ACCESSORIES_DAKHILA theEntity = new ACCESSORIES_DAKHILA();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.DAKHILA_NO = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.PURCHASE_ORDER_ID = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.DAKHILA_DAY = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.DAKHILA_MONTH = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.DAKHILA_YEAR = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.DAKHILA_DATE = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.DAKHILA_FISCALYEAR = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.BILL_NO = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.BILL_DAY = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.BILL_MONTH = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.BILL_YEAR = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.SUPPLIER_ID = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			theEntity.VAT_PERCENT = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;
	
			theEntity.VAT = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;
	
			theEntity.TOTAL = !dr.IsDBNull(15) ? dr.GetValue(15).ToString() : string.Empty;
	
			theEntity.GRAND_TOTAL = !dr.IsDBNull(16) ? dr.GetValue(16).ToString() : string.Empty;
	
			theEntity.PREPARE_BY = !dr.IsDBNull(17) ? dr.GetValue(17).ToString() : string.Empty;
	
			theEntity.CHECK_BY = !dr.IsDBNull(18) ? dr.GetValue(18).ToString() : string.Empty;
	
			theEntity.APPROVE_BY = !dr.IsDBNull(19) ? dr.GetValue(19).ToString() : string.Empty;
	
			theEntity.PREPARE_DATE = !dr.IsDBNull(20) ? dr.GetValue(20).ToString() : string.Empty;
	
			theEntity.CHECK_DATE = !dr.IsDBNull(21) ? dr.GetValue(21).ToString() : string.Empty;
	
			theEntity.APPROVE_DATE = !dr.IsDBNull(22) ? dr.GetValue(22).ToString() : string.Empty;

            theEntity.OFFICE_CODE = !dr.IsDBNull(23) ? dr.GetValue(23).ToString() : string.Empty;

			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            ACCESSORIES_DAKHILA theEntity = (ACCESSORIES_DAKHILA)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_NO",theEntity.DAKHILA_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_ORDER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_ORDER_ID",theEntity.PURCHASE_ORDER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_DAY",theEntity.DAKHILA_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_MONTH",theEntity.DAKHILA_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_YEAR",theEntity.DAKHILA_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_DATE",theEntity.DAKHILA_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_FISCALYEAR",theEntity.DAKHILA_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_NO",theEntity.BILL_NO));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_DAY",theEntity.BILL_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_MONTH",theEntity.BILL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_YEAR",theEntity.BILL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.SUPPLIER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLIER_ID",theEntity.SUPPLIER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VAT_PERCENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PERCENT",theEntity.VAT_PERCENT));
	
			if(!string.IsNullOrEmpty(theEntity.VAT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT",theEntity.VAT));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL",theEntity.TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.GRAND_TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_TOTAL",theEntity.GRAND_TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARE_BY",theEntity.PREPARE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.CHECK_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHECK_BY",theEntity.CHECK_BY));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_BY",theEntity.APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARE_DATE",theEntity.PREPARE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.CHECK_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHECK_DATE",theEntity.CHECK_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_DATE",theEntity.APPROVE_DATE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            ACCESSORIES_DAKHILA theEntity = (ACCESSORIES_DAKHILA)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_NO",theEntity.DAKHILA_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_ORDER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_ORDER_ID",theEntity.PURCHASE_ORDER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_DAY",theEntity.DAKHILA_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_MONTH",theEntity.DAKHILA_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_YEAR",theEntity.DAKHILA_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_DATE",theEntity.DAKHILA_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_FISCALYEAR",theEntity.DAKHILA_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_NO",theEntity.BILL_NO));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_DAY",theEntity.BILL_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_MONTH",theEntity.BILL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_YEAR",theEntity.BILL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.SUPPLIER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLIER_ID",theEntity.SUPPLIER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VAT_PERCENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PERCENT",theEntity.VAT_PERCENT));
	
			if(!string.IsNullOrEmpty(theEntity.VAT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT",theEntity.VAT));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL",theEntity.TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.GRAND_TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_TOTAL",theEntity.GRAND_TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARE_BY",theEntity.PREPARE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.CHECK_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHECK_BY",theEntity.CHECK_BY));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_BY",theEntity.APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARE_DATE",theEntity.PREPARE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.CHECK_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHECK_DATE",theEntity.CHECK_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_DATE",theEntity.APPROVE_DATE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            ACCESSORIES_DAKHILA theEntity = (ACCESSORIES_DAKHILA)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_NO",theEntity.DAKHILA_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_ORDER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_ORDER_ID",theEntity.PURCHASE_ORDER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_DAY",theEntity.DAKHILA_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_MONTH",theEntity.DAKHILA_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_YEAR",theEntity.DAKHILA_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_DATE",theEntity.DAKHILA_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_FISCALYEAR",theEntity.DAKHILA_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_NO",theEntity.BILL_NO));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_DAY",theEntity.BILL_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_MONTH",theEntity.BILL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_YEAR",theEntity.BILL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.SUPPLIER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLIER_ID",theEntity.SUPPLIER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VAT_PERCENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PERCENT",theEntity.VAT_PERCENT));
	
			if(!string.IsNullOrEmpty(theEntity.VAT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT",theEntity.VAT));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL",theEntity.TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.GRAND_TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_TOTAL",theEntity.GRAND_TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARE_BY",theEntity.PREPARE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.CHECK_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHECK_BY",theEntity.CHECK_BY));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_BY",theEntity.APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARE_DATE",theEntity.PREPARE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.CHECK_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHECK_DATE",theEntity.CHECK_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_DATE",theEntity.APPROVE_DATE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            ACCESSORIES_DAKHILA theEntity = (ACCESSORIES_DAKHILA)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_NO",theEntity.DAKHILA_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_ORDER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_ORDER_ID",theEntity.PURCHASE_ORDER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_DAY",theEntity.DAKHILA_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_MONTH",theEntity.DAKHILA_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_YEAR",theEntity.DAKHILA_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_DATE",theEntity.DAKHILA_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DAKHILA_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAKHILA_FISCALYEAR",theEntity.DAKHILA_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_NO",theEntity.BILL_NO));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_DAY",theEntity.BILL_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_MONTH",theEntity.BILL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.BILL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BILL_YEAR",theEntity.BILL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.SUPPLIER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLIER_ID",theEntity.SUPPLIER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VAT_PERCENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PERCENT",theEntity.VAT_PERCENT));
	
			if(!string.IsNullOrEmpty(theEntity.VAT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT",theEntity.VAT));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL",theEntity.TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.GRAND_TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_TOTAL",theEntity.GRAND_TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARE_BY",theEntity.PREPARE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.CHECK_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHECK_BY",theEntity.CHECK_BY));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_BY",theEntity.APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.PREPARE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREPARE_DATE",theEntity.PREPARE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.CHECK_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHECK_DATE",theEntity.CHECK_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.APPROVE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_APPROVE_DATE",theEntity.APPROVE_DATE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	