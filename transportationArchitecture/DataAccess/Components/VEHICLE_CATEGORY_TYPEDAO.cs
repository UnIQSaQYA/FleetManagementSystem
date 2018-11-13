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
    public class VEHICLE_CATEGORY_TYPEDAO : DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public VEHICLE_CATEGORY_TYPEDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTVEHICLE_CATEGORY_TYPE";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_CATEGORY_TYPE";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_CATEGORY_TYPE";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_CATEGORY_TYPE";
            }
        }
        #endregion

        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
            VEHICLE_CATEGORY_TYPE theEntity = new VEHICLE_CATEGORY_TYPE();

            theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;

            theEntity.VEHICLE_CAT_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;

            theEntity.VEHICLE_TYPE_ID = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;

            return theEntity;
        }

        protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            VEHICLE_CATEGORY_TYPE theEntity = (VEHICLE_CATEGORY_TYPE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_CAT_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_CAT_ID", theEntity.VEHICLE_CAT_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE_ID", theEntity.VEHICLE_TYPE_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));

            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            VEHICLE_CATEGORY_TYPE theEntity = (VEHICLE_CATEGORY_TYPE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", "i"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_CAT_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_CAT_ID", theEntity.VEHICLE_CAT_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE_ID", theEntity.VEHICLE_TYPE_ID));
            
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));

            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            VEHICLE_CATEGORY_TYPE theEntity = (VEHICLE_CATEGORY_TYPE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", "u"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_CAT_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_CAT_ID", theEntity.VEHICLE_CAT_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE_ID", theEntity.VEHICLE_TYPE_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));

            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            VEHICLE_CATEGORY_TYPE theEntity = (VEHICLE_CATEGORY_TYPE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", "d"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_CAT_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_CAT_ID", theEntity.VEHICLE_CAT_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE_ID", theEntity.VEHICLE_TYPE_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));

            return cmdParams.ToArray();
        }
    }
}
