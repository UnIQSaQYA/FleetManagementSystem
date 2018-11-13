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
    public class ACCESSORIES_DAKHILA_DETAILDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public ACCESSORIES_DAKHILA_DETAILDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTACCESSDAKHILADETAIL";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYACCESSDAKHILADETAIL";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYACCESSDAKHILADETAIL";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYACCESSDAKHILADETAIL";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			ACCESSORIES_DAKHILA_DETAIL theEntity = new ACCESSORIES_DAKHILA_DETAIL();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.ACCESSORIES_DAKHILA_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.SNO = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.LFONO = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.PRODUCT_ID = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.CATEGORIZATION_NO = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.QUANTITY = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.RATE = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.VAT = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.OTHER_EXPENSE = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.TOTAL = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.BATCH = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.MANUFACTURER = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			theEntity.PRODUCT_SIZE = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;
	
			theEntity.LIFETIME = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;
	
			theEntity.REMARKS = !dr.IsDBNull(15) ? dr.GetValue(15).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            ACCESSORIES_DAKHILA_DETAIL theEntity = (ACCESSORIES_DAKHILA_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORIES_DAKHILA_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES_DAKHILA_ID",theEntity.ACCESSORIES_DAKHILA_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.LFONO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LFONO",theEntity.LFONO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.CATEGORIZATION_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CATEGORIZATION_NO",theEntity.CATEGORIZATION_NO));
	
			if(!string.IsNullOrEmpty(theEntity.QUANTITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QUANTITY",theEntity.QUANTITY));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.VAT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT",theEntity.VAT));
	
			if(!string.IsNullOrEmpty(theEntity.OTHER_EXPENSE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OTHER_EXPENSE",theEntity.OTHER_EXPENSE));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL",theEntity.TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.BATCH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BATCH",theEntity.BATCH));
	
			if(!string.IsNullOrEmpty(theEntity.MANUFACTURER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MANUFACTURER",theEntity.MANUFACTURER));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_SIZE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_SIZE",theEntity.PRODUCT_SIZE));
	
			if(!string.IsNullOrEmpty(theEntity.LIFETIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LIFETIME",theEntity.LIFETIME));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            ACCESSORIES_DAKHILA_DETAIL theEntity = (ACCESSORIES_DAKHILA_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORIES_DAKHILA_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES_DAKHILA_ID",theEntity.ACCESSORIES_DAKHILA_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.LFONO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LFONO",theEntity.LFONO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.CATEGORIZATION_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CATEGORIZATION_NO",theEntity.CATEGORIZATION_NO));
	
			if(!string.IsNullOrEmpty(theEntity.QUANTITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QUANTITY",theEntity.QUANTITY));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.VAT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT",theEntity.VAT));
	
			if(!string.IsNullOrEmpty(theEntity.OTHER_EXPENSE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OTHER_EXPENSE",theEntity.OTHER_EXPENSE));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL",theEntity.TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.BATCH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BATCH",theEntity.BATCH));
	
			if(!string.IsNullOrEmpty(theEntity.MANUFACTURER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MANUFACTURER",theEntity.MANUFACTURER));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_SIZE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_SIZE",theEntity.PRODUCT_SIZE));
	
			if(!string.IsNullOrEmpty(theEntity.LIFETIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LIFETIME",theEntity.LIFETIME));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            ACCESSORIES_DAKHILA_DETAIL theEntity = (ACCESSORIES_DAKHILA_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORIES_DAKHILA_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES_DAKHILA_ID",theEntity.ACCESSORIES_DAKHILA_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.LFONO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LFONO",theEntity.LFONO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.CATEGORIZATION_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CATEGORIZATION_NO",theEntity.CATEGORIZATION_NO));
	
			if(!string.IsNullOrEmpty(theEntity.QUANTITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QUANTITY",theEntity.QUANTITY));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.VAT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT",theEntity.VAT));
	
			if(!string.IsNullOrEmpty(theEntity.OTHER_EXPENSE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OTHER_EXPENSE",theEntity.OTHER_EXPENSE));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL",theEntity.TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.BATCH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BATCH",theEntity.BATCH));
	
			if(!string.IsNullOrEmpty(theEntity.MANUFACTURER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MANUFACTURER",theEntity.MANUFACTURER));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_SIZE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_SIZE",theEntity.PRODUCT_SIZE));
	
			if(!string.IsNullOrEmpty(theEntity.LIFETIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LIFETIME",theEntity.LIFETIME));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            ACCESSORIES_DAKHILA_DETAIL theEntity = (ACCESSORIES_DAKHILA_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORIES_DAKHILA_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES_DAKHILA_ID",theEntity.ACCESSORIES_DAKHILA_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.LFONO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LFONO",theEntity.LFONO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.CATEGORIZATION_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CATEGORIZATION_NO",theEntity.CATEGORIZATION_NO));
	
			if(!string.IsNullOrEmpty(theEntity.QUANTITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QUANTITY",theEntity.QUANTITY));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.VAT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT",theEntity.VAT));
	
			if(!string.IsNullOrEmpty(theEntity.OTHER_EXPENSE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OTHER_EXPENSE",theEntity.OTHER_EXPENSE));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL",theEntity.TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.BATCH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BATCH",theEntity.BATCH));
	
			if(!string.IsNullOrEmpty(theEntity.MANUFACTURER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MANUFACTURER",theEntity.MANUFACTURER));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_SIZE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_SIZE",theEntity.PRODUCT_SIZE));
	
			if(!string.IsNullOrEmpty(theEntity.LIFETIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LIFETIME",theEntity.LIFETIME));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	