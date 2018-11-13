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
    public class VEHICLE_MODELDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public VEHICLE_MODELDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTVEHICLE_MODEL";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_MODEL";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_MODEL";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_MODEL";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			VEHICLE_MODEL theEntity = new VEHICLE_MODEL();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VEHICLE_TYPE_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.MODEL = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.MANUFACTURE_ID = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            VEHICLE_MODEL theEntity = (VEHICLE_MODEL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE_ID", theEntity.VEHICLE_TYPE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MODEL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MODEL", theEntity.MODEL));
	
			if(!string.IsNullOrEmpty(theEntity.MANUFACTURE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MANUFACTURE_ID",theEntity.MANUFACTURE_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            VEHICLE_MODEL theEntity = (VEHICLE_MODEL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));


            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE_ID", theEntity.VEHICLE_TYPE_ID));

            if (!string.IsNullOrEmpty(theEntity.MODEL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MODEL", theEntity.MODEL));

            if (!string.IsNullOrEmpty(theEntity.MANUFACTURE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MANUFACTURE_ID", theEntity.MANUFACTURE_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            VEHICLE_MODEL theEntity = (VEHICLE_MODEL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));


            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE_ID", theEntity.VEHICLE_TYPE_ID));

            if (!string.IsNullOrEmpty(theEntity.MODEL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MODEL", theEntity.MODEL));

            if (!string.IsNullOrEmpty(theEntity.MANUFACTURE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MANUFACTURE_ID", theEntity.MANUFACTURE_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            VEHICLE_MODEL theEntity = (VEHICLE_MODEL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));


            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MODEL_NO", theEntity.VEHICLE_TYPE_ID));

            if (!string.IsNullOrEmpty(theEntity.MODEL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MODEL", theEntity.MODEL));

            if (!string.IsNullOrEmpty(theEntity.MANUFACTURE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MANUFACTURE_ID", theEntity.MANUFACTURE_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	