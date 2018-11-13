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
    public class PRODUCT_TYPEDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public PRODUCT_TYPEDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTPRODUCT_TYPE";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_TYPE";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_TYPE";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_TYPE";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			PRODUCT_TYPE theEntity = new PRODUCT_TYPE();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.PRODUCT_CATEGORY_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.PRODUCTTYPE = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.REMARKS = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;

            theEntity.PRODUCT_TYPE_CODE = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            PRODUCT_TYPE theEntity = (PRODUCT_TYPE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_CATEGORY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CATEGORY_ID",theEntity.PRODUCT_CATEGORY_ID));

            if (!string.IsNullOrEmpty(theEntity.PRODUCTTYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_TYPE", theEntity.PRODUCTTYPE));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.PRODUCT_TYPE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_TYPE_CODE", theEntity.PRODUCT_TYPE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            PRODUCT_TYPE theEntity = (PRODUCT_TYPE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_CATEGORY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CATEGORY_ID",theEntity.PRODUCT_CATEGORY_ID));

            if (!string.IsNullOrEmpty(theEntity.PRODUCTTYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_TYPE", theEntity.PRODUCTTYPE));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.PRODUCT_TYPE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_TYPE_CODE", theEntity.PRODUCT_TYPE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            PRODUCT_TYPE theEntity = (PRODUCT_TYPE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_CATEGORY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CATEGORY_ID",theEntity.PRODUCT_CATEGORY_ID));

            if (!string.IsNullOrEmpty(theEntity.PRODUCTTYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_TYPE", theEntity.PRODUCTTYPE));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.PRODUCT_TYPE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_TYPE_CODE", theEntity.PRODUCT_TYPE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            PRODUCT_TYPE theEntity = (PRODUCT_TYPE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_CATEGORY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CATEGORY_ID",theEntity.PRODUCT_CATEGORY_ID));

            if (!string.IsNullOrEmpty(theEntity.PRODUCTTYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_TYPE", theEntity.PRODUCTTYPE));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.PRODUCT_TYPE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_TYPE_CODE", theEntity.PRODUCT_TYPE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	