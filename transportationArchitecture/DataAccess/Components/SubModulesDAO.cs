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
    public class SubModulesDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public SubModulesDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.selectsubmodules";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.modifysubmodules";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.modifysubmodules";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.modifysubmodules";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			SubModules theEntity = new SubModules();
	
			theEntity.SUBMODULE_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.SUBMODULE_NAME = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.MODULE_ID = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            SubModules theEntity = (SubModules)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.SUBMODULE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("SUBMODULE_ID",theEntity.SUBMODULE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SUBMODULE_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("SUBMODULE_NAME",theEntity.SUBMODULE_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.MODULE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("MODULE_ID",theEntity.MODULE_ID));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            SubModules theEntity = (SubModules)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.SUBMODULE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("SUBMODULE_ID",theEntity.SUBMODULE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SUBMODULE_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("SUBMODULE_NAME",theEntity.SUBMODULE_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.MODULE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("MODULE_ID",theEntity.MODULE_ID));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            SubModules theEntity = (SubModules)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));

            if (!string.IsNullOrEmpty(theEntity.SUBMODULE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("SUBMODULE_ID", theEntity.SUBMODULE_ID));

            if (!string.IsNullOrEmpty(theEntity.SUBMODULE_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("SUBMODULE_NAME", theEntity.SUBMODULE_NAME));

            if (!string.IsNullOrEmpty(theEntity.MODULE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("MODULE_ID", theEntity.MODULE_ID));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            SubModules theEntity = (SubModules)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));

            if (!string.IsNullOrEmpty(theEntity.SUBMODULE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("SUBMODULE_ID", theEntity.SUBMODULE_ID));

            if (!string.IsNullOrEmpty(theEntity.SUBMODULE_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("SUBMODULE_NAME", theEntity.SUBMODULE_NAME));

            if (!string.IsNullOrEmpty(theEntity.MODULE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("MODULE_ID", theEntity.MODULE_ID));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
            return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	