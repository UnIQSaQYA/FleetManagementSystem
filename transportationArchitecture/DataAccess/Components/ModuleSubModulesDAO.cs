using System;
using System.Collections.Generic;
using System.Data;


using System.Text;

using DataAccess.Framework;
using DataHelper.Framework;
using Entity.Components;
using Entity.Framework;
using System.Collections;

namespace DataAccess.Components
{
    public class ModuleSubModulesDAO : DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public ModuleSubModulesDAO()
        {

        }
        #endregion

        #region Override Properties

        protected string GetModuleSubModules
        {
            get
            {
                return "PKJ_UserAcces.getsubmodule";
            }
        }
        protected override string SelectCommand
        {
            get
            {
                return "";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "";
            }
        }
        #endregion

        #region Overridden Methods

        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
            ModuleSubmoduleEntity theEntity = new ModuleSubmoduleEntity();

            theEntity.Moduleid = !dr.IsDBNull(0) ? Int32.Parse(dr.GetValue(0).ToString()) : -1;

            theEntity.Modulename = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;

            theEntity.Leafnode = !dr.IsDBNull(2) ? Int32.Parse(dr.GetValue(2).ToString()) : -1;

            theEntity.Parentmodule = !dr.IsDBNull(3) ? Int32.Parse(dr.GetValue(3).ToString()) : -1;

            theEntity.Submoduleid = !dr.IsDBNull(4) ? Int32.Parse(dr.GetValue(4).ToString()) : -1;

            theEntity.Name = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;

            theEntity.Permission = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;

            return theEntity;
        }
        protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            UserProfileEntity theEntity = (UserProfileEntity)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();

            if (!string.IsNullOrEmpty(theEntity.UserGroupID.ToString()))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("group_id", theEntity.UserGroupID));

            // This is the output parameter that is required for Oracle Connection. 
            // This is required only when the database is oracle as it will return curson.

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));

            return cmdParams.ToArray();
        }

        protected IDbDataParameter[] CreateSelectModuleParameters(EntityBase anEntity,string CurrentM_ID)
        {
            UserProfileEntity theEntity = (UserProfileEntity)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();

            if (!string.IsNullOrEmpty(theEntity.UserGroupID.ToString()))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("group_id", theEntity.UserGroupID));

            if (!string.IsNullOrEmpty(theEntity.UserGroupID.ToString()))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("Module_ID", CurrentM_ID));

            // This is the output parameter that is required for Oracle Connection. 
            // This is required only when the database is oracle as it will return curson.

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));

            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            return null;
        }

        protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            return null;
        }

        protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            return null;
        }

        #endregion
            

        public EntityList GetModuleSubModule(EntityBase anEntity)
        {
            IDbDataParameter[] cmdParams = this.CreateSelectParameters(anEntity);
            return GetList(GetModuleSubModules, this.CommandTypeUsed, cmdParams);
        }

        public EntityList GetModuleSubModule(EntityBase anEntity,string CurrentM_ID)
        {
            IDbDataParameter[] cmdParams = this.CreateSelectModuleParameters(anEntity, CurrentM_ID);
            return GetList(GetModuleSubModules, this.CommandTypeUsed, cmdParams);
        }
    }
}
