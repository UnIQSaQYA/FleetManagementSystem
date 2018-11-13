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
    public class PURCHASE_ORDER_DETAILDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public PURCHASE_ORDER_DETAILDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTPURCHASE_ORDER_DETAIL";

               
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPURCHASE_ORDER_DETAIL";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPURCHASE_ORDER_DETAIL";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPURCHASE_ORDER_DETAIL";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			PURCHASE_ORDER_DETAIL theEntity = new PURCHASE_ORDER_DETAIL();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.PURCHASE_ORDER_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.SNO = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.PRODUCT_ID = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.QUANTITY = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.UNIT = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.RATE = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.TOTAL = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.REMARKS = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            PURCHASE_ORDER_DETAIL theEntity = (PURCHASE_ORDER_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_ORDER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_ORDER_ID",theEntity.PURCHASE_ORDER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.QUANTITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QUANTITY",theEntity.QUANTITY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL",theEntity.TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            PURCHASE_ORDER_DETAIL theEntity = (PURCHASE_ORDER_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_ORDER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_ORDER_ID",theEntity.PURCHASE_ORDER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.QUANTITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QUANTITY",theEntity.QUANTITY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL",theEntity.TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            PURCHASE_ORDER_DETAIL theEntity = (PURCHASE_ORDER_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_ORDER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_ORDER_ID",theEntity.PURCHASE_ORDER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.QUANTITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QUANTITY",theEntity.QUANTITY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL",theEntity.TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            PURCHASE_ORDER_DETAIL theEntity = (PURCHASE_ORDER_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PURCHASE_ORDER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PURCHASE_ORDER_ID",theEntity.PURCHASE_ORDER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.QUANTITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QUANTITY",theEntity.QUANTITY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL",theEntity.TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	