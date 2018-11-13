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
    public class PRODUCTDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public PRODUCTDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTPRODUCT";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			PRODUCT theEntity = new PRODUCT();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.PRODUCT_TYPE_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.PRODUCT_CODE = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.PRODUCT_NAME = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.NATURE_CATEGORY = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.PRICE_CATEGORY = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.UNIT = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.REORDER_LEVEL = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.MAXIMUM_QTY = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.STORAGE_DETAIL = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.FORMAT = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.SPECIFICATION = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.STATUS = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;

            theEntity.BUDGET_CODE = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;

            theEntity.CLASSIFICATION_CODE = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;

			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            PRODUCT theEntity = (PRODUCT)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_TYPE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_TYPE_ID",theEntity.PRODUCT_TYPE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CODE",theEntity.PRODUCT_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_NAME",theEntity.PRODUCT_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.NATURE_CATEGORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NATURE_CATEGORY",theEntity.NATURE_CATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.PRICE_CATEGORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRICE_CATEGORY",theEntity.PRICE_CATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.REORDER_LEVEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REORDER_LEVEL",theEntity.REORDER_LEVEL));
	
			if(!string.IsNullOrEmpty(theEntity.MAXIMUM_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAXIMUM_QTY",theEntity.MAXIMUM_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.STORAGE_DETAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STORAGE_DETAIL",theEntity.STORAGE_DETAIL));
	
			if(!string.IsNullOrEmpty(theEntity.FORMAT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FORMAT",theEntity.FORMAT));
	
			if(!string.IsNullOrEmpty(theEntity.SPECIFICATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SPECIFICATION",theEntity.SPECIFICATION));
	
			if(!string.IsNullOrEmpty(theEntity.STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS",theEntity.STATUS));

            if (!string.IsNullOrEmpty(theEntity.BUDGET_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BUDGET_CODE", theEntity.BUDGET_CODE));

            if (!string.IsNullOrEmpty(theEntity.CLASSIFICATION_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CLASSIFICATION_CODE", theEntity.CLASSIFICATION_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            PRODUCT theEntity = (PRODUCT)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_TYPE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_TYPE_ID",theEntity.PRODUCT_TYPE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CODE",theEntity.PRODUCT_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_NAME",theEntity.PRODUCT_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.NATURE_CATEGORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NATURE_CATEGORY",theEntity.NATURE_CATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.PRICE_CATEGORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRICE_CATEGORY",theEntity.PRICE_CATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.REORDER_LEVEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REORDER_LEVEL",theEntity.REORDER_LEVEL));
	
			if(!string.IsNullOrEmpty(theEntity.MAXIMUM_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAXIMUM_QTY",theEntity.MAXIMUM_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.STORAGE_DETAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STORAGE_DETAIL",theEntity.STORAGE_DETAIL));
	
			if(!string.IsNullOrEmpty(theEntity.FORMAT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FORMAT",theEntity.FORMAT));
	
			if(!string.IsNullOrEmpty(theEntity.SPECIFICATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SPECIFICATION",theEntity.SPECIFICATION));
	
			if(!string.IsNullOrEmpty(theEntity.STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS",theEntity.STATUS));

            if (!string.IsNullOrEmpty(theEntity.BUDGET_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BUDGET_CODE", theEntity.BUDGET_CODE));

            if (!string.IsNullOrEmpty(theEntity.CLASSIFICATION_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CLASSIFICATION_CODE", theEntity.CLASSIFICATION_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            PRODUCT theEntity = (PRODUCT)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_TYPE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_TYPE_ID",theEntity.PRODUCT_TYPE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CODE",theEntity.PRODUCT_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_NAME",theEntity.PRODUCT_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.NATURE_CATEGORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NATURE_CATEGORY",theEntity.NATURE_CATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.PRICE_CATEGORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRICE_CATEGORY",theEntity.PRICE_CATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.REORDER_LEVEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REORDER_LEVEL",theEntity.REORDER_LEVEL));
	
			if(!string.IsNullOrEmpty(theEntity.MAXIMUM_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAXIMUM_QTY",theEntity.MAXIMUM_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.STORAGE_DETAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STORAGE_DETAIL",theEntity.STORAGE_DETAIL));
	
			if(!string.IsNullOrEmpty(theEntity.FORMAT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FORMAT",theEntity.FORMAT));
	
			if(!string.IsNullOrEmpty(theEntity.SPECIFICATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SPECIFICATION",theEntity.SPECIFICATION));
	
			if(!string.IsNullOrEmpty(theEntity.STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS",theEntity.STATUS));

            if (!string.IsNullOrEmpty(theEntity.BUDGET_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BUDGET_CODE", theEntity.BUDGET_CODE));

            if (!string.IsNullOrEmpty(theEntity.CLASSIFICATION_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CLASSIFICATION_CODE", theEntity.CLASSIFICATION_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            PRODUCT theEntity = (PRODUCT)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_TYPE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_TYPE_ID",theEntity.PRODUCT_TYPE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CODE",theEntity.PRODUCT_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_NAME",theEntity.PRODUCT_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.NATURE_CATEGORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NATURE_CATEGORY",theEntity.NATURE_CATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.PRICE_CATEGORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRICE_CATEGORY",theEntity.PRICE_CATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.REORDER_LEVEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REORDER_LEVEL",theEntity.REORDER_LEVEL));
	
			if(!string.IsNullOrEmpty(theEntity.MAXIMUM_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAXIMUM_QTY",theEntity.MAXIMUM_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.STORAGE_DETAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STORAGE_DETAIL",theEntity.STORAGE_DETAIL));
	
			if(!string.IsNullOrEmpty(theEntity.FORMAT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FORMAT",theEntity.FORMAT));
	
			if(!string.IsNullOrEmpty(theEntity.SPECIFICATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SPECIFICATION",theEntity.SPECIFICATION));
	
			if(!string.IsNullOrEmpty(theEntity.STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS",theEntity.STATUS));

            if (!string.IsNullOrEmpty(theEntity.BUDGET_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BUDGET_CODE", theEntity.BUDGET_CODE));

            if (!string.IsNullOrEmpty(theEntity.CLASSIFICATION_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CLASSIFICATION_CODE", theEntity.CLASSIFICATION_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	