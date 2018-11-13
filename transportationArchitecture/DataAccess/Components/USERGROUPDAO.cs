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
    public class USERGROUPDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public USERGROUPDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.selectusergroup";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.modifyusergroup";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.modifyusergroup";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.modifyusergroup";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			USERGROUP theEntity = new USERGROUP();
	
			theEntity.USERGROUPID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
            theEntity.GROUPID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
			theEntity.USERID = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            USERGROUP theEntity = (USERGROUP)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.USERGROUPID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("userGROUP_ID", theEntity.USERGROUPID));

            if (!string.IsNullOrEmpty(theEntity.USERID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("user_id", theEntity.USERID));

            if (!string.IsNullOrEmpty(theEntity.GROUPID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("group_ID", theEntity.GROUPID));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            USERGROUP theEntity = (USERGROUP)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));

            if (!string.IsNullOrEmpty(theEntity.USERGROUPID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("userGROUP_ID", theEntity.USERGROUPID));

            if (!string.IsNullOrEmpty(theEntity.USERID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("user_id", theEntity.USERID));

            if (!string.IsNullOrEmpty(theEntity.GROUPID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("group_ID", theEntity.GROUPID));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            USERGROUP theEntity = (USERGROUP)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));

            if (!string.IsNullOrEmpty(theEntity.USERGROUPID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("userGROUP_ID", theEntity.USERGROUPID));

            if (!string.IsNullOrEmpty(theEntity.USERID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("user_id", theEntity.USERID));

            if (!string.IsNullOrEmpty(theEntity.GROUPID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("group_ID", theEntity.GROUPID));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            USERGROUP theEntity = (USERGROUP)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));

            if (!string.IsNullOrEmpty(theEntity.USERGROUPID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("userGROUP_ID", theEntity.USERGROUPID));

            if (!string.IsNullOrEmpty(theEntity.USERID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("user_id", theEntity.USERID));

            if (!string.IsNullOrEmpty(theEntity.GROUPID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("group_ID", theEntity.GROUPID));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	