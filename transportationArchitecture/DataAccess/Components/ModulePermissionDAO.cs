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
    public class ModulePermissionDAO : DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public ModulePermissionDAO()
        {

        }
        #endregion

        #region Override Properties

        protected override string SelectCommand
        {
            get
            {
                return "PKJ_USERACCES.getmodule";
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
            ModulePermissionEntity theEntity = new ModulePermissionEntity();

            theEntity.Moduleid= !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;

            theEntity.Modulename= !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;

            theEntity.Picturename = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;

            theEntity.Remarks = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;

            return theEntity;
        }

        protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            UserProfileEntity theEntity = (UserProfileEntity)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();

            if (!string.IsNullOrEmpty(theEntity.UserName))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("group_id", theEntity.UserGroupID));

            // This is the output parameter that is required for Oracle Connection. 
            // This is required only when the database is oracle as it will return cursor.

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
    }
}
