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
    public class GroupsDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public GroupsDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.selectgroup";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.modifygroup";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.modifygroup";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.modifygroup";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			Groups theEntity = new Groups();
	
			theEntity.GROUPID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.GROUPNAME = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.GROUPPRECEDENCE = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.GROUPDETAILS = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            Groups theEntity = (Groups)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.GROUPID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_ID",theEntity.GROUPID));
	
			if(!string.IsNullOrEmpty(theEntity.GROUPNAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_NAME",theEntity.GROUPNAME));
	
			if(!string.IsNullOrEmpty(theEntity.GROUPPRECEDENCE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_PRECEDENCE",theEntity.GROUPPRECEDENCE));
	
			if(!string.IsNullOrEmpty(theEntity.GROUPDETAILS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_DETAILS",theEntity.GROUPDETAILS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));

            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            Groups theEntity = (Groups)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();

            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", 'i'));
            if (!string.IsNullOrEmpty(theEntity.GROUPID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_ID", theEntity.GROUPID));

            if (!string.IsNullOrEmpty(theEntity.GROUPNAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_NAME", theEntity.GROUPNAME));

            if (!string.IsNullOrEmpty(theEntity.GROUPPRECEDENCE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_PRECEDENCE", theEntity.GROUPPRECEDENCE));

            if (!string.IsNullOrEmpty(theEntity.GROUPDETAILS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_DETAILS", theEntity.GROUPDETAILS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));

			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            Groups theEntity = (Groups)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", 'u'));
            if (!string.IsNullOrEmpty(theEntity.GROUPID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_ID", theEntity.GROUPID));

            if (!string.IsNullOrEmpty(theEntity.GROUPNAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_NAME", theEntity.GROUPNAME));

            if (!string.IsNullOrEmpty(theEntity.GROUPPRECEDENCE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_PRECEDENCE", theEntity.GROUPPRECEDENCE));

            if (!string.IsNullOrEmpty(theEntity.GROUPDETAILS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_DETAILS", theEntity.GROUPDETAILS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));

			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            Groups theEntity = (Groups)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", 'd'));
            if (!string.IsNullOrEmpty(theEntity.GROUPID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_ID", theEntity.GROUPID));

            if (!string.IsNullOrEmpty(theEntity.GROUPNAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_NAME", theEntity.GROUPNAME));

            if (!string.IsNullOrEmpty(theEntity.GROUPPRECEDENCE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_PRECEDENCE", theEntity.GROUPPRECEDENCE));

            if (!string.IsNullOrEmpty(theEntity.GROUPDETAILS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_DETAILS", theEntity.GROUPDETAILS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));

			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	