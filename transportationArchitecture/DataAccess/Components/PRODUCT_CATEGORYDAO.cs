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
    public class PRODUCT_CATEGORYDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public PRODUCT_CATEGORYDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTPRODUCT_CATEGORY";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_CATEGORY";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_CATEGORY";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_CATEGORY";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			PRODUCT_CATEGORY theEntity = new PRODUCT_CATEGORY();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.PRODUCTCATEGORY = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.REMARKS = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;

            theEntity.PRODUCT_CATEGORY_CODE = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;

			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            PRODUCT_CATEGORY theEntity = (PRODUCT_CATEGORY)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.PRODUCTCATEGORY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CATEGORY", theEntity.PRODUCTCATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));


            if (!string.IsNullOrEmpty(theEntity.PRODUCT_CATEGORY_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CATEGORY_CODE", theEntity.PRODUCT_CATEGORY_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            PRODUCT_CATEGORY theEntity = (PRODUCT_CATEGORY)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.PRODUCTCATEGORY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CATEGORY", theEntity.PRODUCTCATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.PRODUCT_CATEGORY_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CATEGORY_CODE", theEntity.PRODUCT_CATEGORY_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            PRODUCT_CATEGORY theEntity = (PRODUCT_CATEGORY)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.PRODUCTCATEGORY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CATEGORY", theEntity.PRODUCTCATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.PRODUCT_CATEGORY_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CATEGORY_CODE", theEntity.PRODUCT_CATEGORY_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            PRODUCT_CATEGORY theEntity = (PRODUCT_CATEGORY)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.PRODUCTCATEGORY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CATEGORY", theEntity.PRODUCTCATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.PRODUCT_CATEGORY_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_CATEGORY_CODE", theEntity.PRODUCT_CATEGORY_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	