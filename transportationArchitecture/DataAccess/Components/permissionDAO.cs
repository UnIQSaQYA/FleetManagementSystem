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
    public class permissionDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public permissionDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.selectsubmodulespermission";
            }
        }
        
        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.modifysubmodulespermission";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.modifysubmodulespermission";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.modifysubmodulespermission";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			permission theEntity = new permission();
	
			theEntity.PERM_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.GROUP_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;

            theEntity.PERMISSION_SUB = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;

            theEntity.PageID = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            permission theEntity = (permission)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PERM_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("PERM_ID",theEntity.PERM_ID));
	
			if(!string.IsNullOrEmpty(theEntity.GROUP_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_ID",theEntity.GROUP_ID));

       
			if(!string.IsNullOrEmpty(theEntity.PERMISSION_SUB))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("PERMISSION_SUB",theEntity.PERMISSION_SUB));

            if (!string.IsNullOrEmpty(theEntity.PageID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("Page_ID", theEntity.PageID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            permission theEntity = (permission)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PERM_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("PERM_ID",theEntity.PERM_ID));
	
			if(!string.IsNullOrEmpty(theEntity.GROUP_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_ID",theEntity.GROUP_ID));
           

			if(!string.IsNullOrEmpty(theEntity.PERMISSION_SUB))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("PERMISSION_SUB",theEntity.PERMISSION_SUB));

            if (!string.IsNullOrEmpty(theEntity.PageID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("Page_ID", theEntity.PageID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            permission theEntity = (permission)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PERM_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("PERM_ID",theEntity.PERM_ID));
	
			if(!string.IsNullOrEmpty(theEntity.GROUP_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_ID",theEntity.GROUP_ID));
           


			if(!string.IsNullOrEmpty(theEntity.PERMISSION_SUB))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("PERMISSION_SUB",theEntity.PERMISSION_SUB));

            if (!string.IsNullOrEmpty(theEntity.PageID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("Page_ID", theEntity.PageID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            permission theEntity = (permission)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PERM_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("PERM_ID",theEntity.PERM_ID));
	
			if(!string.IsNullOrEmpty(theEntity.GROUP_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_ID",theEntity.GROUP_ID));
           


			if(!string.IsNullOrEmpty(theEntity.PERMISSION_SUB))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("PERMISSION_SUB",theEntity.PERMISSION_SUB));

            if (!string.IsNullOrEmpty(theEntity.PageID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("Page_ID", theEntity.PageID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
		}
	
		#endregion

        

    }
}

	