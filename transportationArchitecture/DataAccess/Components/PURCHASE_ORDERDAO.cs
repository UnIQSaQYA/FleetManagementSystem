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
    public class PURCHASE_ORDERDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public PURCHASE_ORDERDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTPURCHASE_ORDER";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPURCHASE_ORDER";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPURCHASE_ORDER";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPURCHASE_ORDER";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			PURCHASE_ORDER theEntity = new PURCHASE_ORDER();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.PURCHASE_ORDER_NUMBER = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.ORDER_DAY = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.ORDER_MONTH = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.ORDER_YEAR = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.ORDER_DATE = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.ORDER_FISCALYEAR = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.SUPPLIER_ID = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.DELIVERY_DATE = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.DELIVERY_PLACE = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.ISSUE_BY = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.DEPARTMENT_HEAD = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.GRAND_TOTAL = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			theEntity.SUPPLIER_REPRESENTATIVE = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;
	
			theEntity.SUPPLY_RECEIVE_DATE = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;

            theEntity.OFFICE_CODE = !dr.IsDBNull(15) ? dr.GetValue(15).ToString() : string.Empty;

			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            PURCHASE_ORDER theEntity = (PURCHASE_ORDER)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_ORDER_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_ORDER_NUMBER",theEntity.PURCHASE_ORDER_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DAY",theEntity.ORDER_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_MONTH",theEntity.ORDER_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_YEAR",theEntity.ORDER_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DATE",theEntity.ORDER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_FISCALYEAR",theEntity.ORDER_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.SUPPLIER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLIER_ID",theEntity.SUPPLIER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_DATE",theEntity.DELIVERY_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_PLACE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_PLACE",theEntity.DELIVERY_PLACE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_BY",theEntity.ISSUE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DEPARTMENT_HEAD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEPARTMENT_HEAD",theEntity.DEPARTMENT_HEAD));
	
			if(!string.IsNullOrEmpty(theEntity.GRAND_TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_TOTAL",theEntity.GRAND_TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.SUPPLIER_REPRESENTATIVE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLIER_REPRESENTATIVE",theEntity.SUPPLIER_REPRESENTATIVE));
	
			if(!string.IsNullOrEmpty(theEntity.SUPPLY_RECEIVE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLY_RECEIVE_DATE",theEntity.SUPPLY_RECEIVE_DATE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            PURCHASE_ORDER theEntity = (PURCHASE_ORDER)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_ORDER_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_ORDER_NUMBER",theEntity.PURCHASE_ORDER_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DAY",theEntity.ORDER_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_MONTH",theEntity.ORDER_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_YEAR",theEntity.ORDER_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DATE",theEntity.ORDER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_FISCALYEAR",theEntity.ORDER_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.SUPPLIER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLIER_ID",theEntity.SUPPLIER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_DATE",theEntity.DELIVERY_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_PLACE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_PLACE",theEntity.DELIVERY_PLACE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_BY",theEntity.ISSUE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DEPARTMENT_HEAD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEPARTMENT_HEAD",theEntity.DEPARTMENT_HEAD));
	
			if(!string.IsNullOrEmpty(theEntity.GRAND_TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_TOTAL",theEntity.GRAND_TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.SUPPLIER_REPRESENTATIVE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLIER_REPRESENTATIVE",theEntity.SUPPLIER_REPRESENTATIVE));
	
			if(!string.IsNullOrEmpty(theEntity.SUPPLY_RECEIVE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLY_RECEIVE_DATE",theEntity.SUPPLY_RECEIVE_DATE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            PURCHASE_ORDER theEntity = (PURCHASE_ORDER)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_ORDER_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_ORDER_NUMBER",theEntity.PURCHASE_ORDER_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DAY",theEntity.ORDER_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_MONTH",theEntity.ORDER_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_YEAR",theEntity.ORDER_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DATE",theEntity.ORDER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_FISCALYEAR",theEntity.ORDER_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.SUPPLIER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLIER_ID",theEntity.SUPPLIER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_DATE",theEntity.DELIVERY_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_PLACE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_PLACE",theEntity.DELIVERY_PLACE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_BY",theEntity.ISSUE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DEPARTMENT_HEAD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEPARTMENT_HEAD",theEntity.DEPARTMENT_HEAD));
	
			if(!string.IsNullOrEmpty(theEntity.GRAND_TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_TOTAL",theEntity.GRAND_TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.SUPPLIER_REPRESENTATIVE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLIER_REPRESENTATIVE",theEntity.SUPPLIER_REPRESENTATIVE));
	
			if(!string.IsNullOrEmpty(theEntity.SUPPLY_RECEIVE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLY_RECEIVE_DATE",theEntity.SUPPLY_RECEIVE_DATE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            PURCHASE_ORDER theEntity = (PURCHASE_ORDER)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_ORDER_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_ORDER_NUMBER",theEntity.PURCHASE_ORDER_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DAY",theEntity.ORDER_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_MONTH",theEntity.ORDER_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_YEAR",theEntity.ORDER_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_DATE",theEntity.ORDER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_FISCALYEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_FISCALYEAR",theEntity.ORDER_FISCALYEAR));
	
			if(!string.IsNullOrEmpty(theEntity.SUPPLIER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLIER_ID",theEntity.SUPPLIER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_DATE",theEntity.DELIVERY_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DELIVERY_PLACE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DELIVERY_PLACE",theEntity.DELIVERY_PLACE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_BY",theEntity.ISSUE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.DEPARTMENT_HEAD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DEPARTMENT_HEAD",theEntity.DEPARTMENT_HEAD));
	
			if(!string.IsNullOrEmpty(theEntity.GRAND_TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_TOTAL",theEntity.GRAND_TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.SUPPLIER_REPRESENTATIVE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLIER_REPRESENTATIVE",theEntity.SUPPLIER_REPRESENTATIVE));

            if (!string.IsNullOrEmpty(theEntity.SUPPLY_RECEIVE_DATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SUPPLY_RECEIVE_DATE", theEntity.SUPPLY_RECEIVE_DATE));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));

	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	