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
    public class ACCESSORIES_GROUPDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public ACCESSORIES_GROUPDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTACCESSORIES_GROUP";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYACCESSORIES_GROUP";
              
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYACCESSORIES_GROUP";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYACCESSORIES_GROUP";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			ACCESSORIES_GROUP theEntity = new ACCESSORIES_GROUP();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.ACCESSORIESGROUP = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            ACCESSORIES_GROUP theEntity = (ACCESSORIES_GROUP)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.ACCESSORIESGROUP))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES_GROUP", theEntity.ACCESSORIESGROUP));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));

	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            ACCESSORIES_GROUP theEntity = (ACCESSORIES_GROUP)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORIESGROUP))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES_GROUP",theEntity.ACCESSORIESGROUP));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            ACCESSORIES_GROUP theEntity = (ACCESSORIES_GROUP)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORIESGROUP))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES_GROUP",theEntity.ACCESSORIESGROUP));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            ACCESSORIES_GROUP theEntity = (ACCESSORIES_GROUP)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORIESGROUP))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES_GROUP",theEntity.ACCESSORIESGROUP));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	