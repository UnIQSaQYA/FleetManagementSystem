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
    public class ModulesDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public ModulesDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.selectmodules";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.modifymodules";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.modifymodules";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.modifymodules";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			Modules theEntity = new Modules();
	
			theEntity.MODULE_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.MODULE_NAME = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.LEAF_NODE = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.PARENT_MODULE = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            Modules theEntity = (Modules)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.MODULE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("MODULE_ID",theEntity.MODULE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MODULE_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("MODULE_NAME",theEntity.MODULE_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.LEAF_NODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("LEAF_NODE",theEntity.LEAF_NODE));
	
			if(!string.IsNullOrEmpty(theEntity.PARENT_MODULE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("PARENT_MODULE",theEntity.PARENT_MODULE));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            Modules theEntity = (Modules)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.MODULE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("MODULE_ID",theEntity.MODULE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MODULE_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("MODULE_NAME",theEntity.MODULE_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.LEAF_NODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("LEAF_NODE",theEntity.LEAF_NODE));
	
			if(!string.IsNullOrEmpty(theEntity.PARENT_MODULE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("PARENT_MODULE",theEntity.PARENT_MODULE));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            Modules theEntity = (Modules)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));

            if (!string.IsNullOrEmpty(theEntity.MODULE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("MODULE_ID", theEntity.MODULE_ID));

            if (!string.IsNullOrEmpty(theEntity.MODULE_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("MODULE_NAME", theEntity.MODULE_NAME));

            if (!string.IsNullOrEmpty(theEntity.LEAF_NODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("LEAF_NODE", theEntity.LEAF_NODE));

            if (!string.IsNullOrEmpty(theEntity.PARENT_MODULE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PARENT_MODULE", theEntity.PARENT_MODULE));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            Modules theEntity = (Modules)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));

            if (!string.IsNullOrEmpty(theEntity.MODULE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("MODULE_ID", theEntity.MODULE_ID));

            if (!string.IsNullOrEmpty(theEntity.MODULE_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("MODULE_NAME", theEntity.MODULE_NAME));

            if (!string.IsNullOrEmpty(theEntity.LEAF_NODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("LEAF_NODE", theEntity.LEAF_NODE));

            if (!string.IsNullOrEmpty(theEntity.PARENT_MODULE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PARENT_MODULE", theEntity.PARENT_MODULE));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
            return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	