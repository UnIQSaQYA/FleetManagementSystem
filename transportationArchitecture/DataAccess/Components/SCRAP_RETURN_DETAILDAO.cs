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
    public class SCRAP_RETURN_DETAILDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public SCRAP_RETURN_DETAILDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTSCRAP_RETURN_DETAIL";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYSCRAP_RETURN_DETAIL";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYSCRAP_RETURN_DETAIL";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYSCRAP_RETURN_DETAIL";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			SCRAP_RETURN_DETAIL theEntity = new SCRAP_RETURN_DETAIL();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.SCRAP_RETURN_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.PRODUCT_ID = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.STORE_AT = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.REMARKS = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            SCRAP_RETURN_DETAIL theEntity = (SCRAP_RETURN_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SCRAP_RETURN_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCRAP_RETURN_ID",theEntity.SCRAP_RETURN_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.STORE_AT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STORE_AT",theEntity.STORE_AT));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            SCRAP_RETURN_DETAIL theEntity = (SCRAP_RETURN_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SCRAP_RETURN_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCRAP_RETURN_ID",theEntity.SCRAP_RETURN_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.STORE_AT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STORE_AT",theEntity.STORE_AT));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            SCRAP_RETURN_DETAIL theEntity = (SCRAP_RETURN_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SCRAP_RETURN_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCRAP_RETURN_ID",theEntity.SCRAP_RETURN_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.STORE_AT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STORE_AT",theEntity.STORE_AT));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            SCRAP_RETURN_DETAIL theEntity = (SCRAP_RETURN_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SCRAP_RETURN_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCRAP_RETURN_ID",theEntity.SCRAP_RETURN_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.STORE_AT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STORE_AT",theEntity.STORE_AT));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	