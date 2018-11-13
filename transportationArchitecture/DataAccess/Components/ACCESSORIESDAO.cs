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
    public class ACCESSORIESDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public ACCESSORIESDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTACCESSORIES";

              
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYACCESSORIES";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYACCESSORIES";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYACCESSORIES";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			ACCESSORIES theEntity = new ACCESSORIES();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VEHICLE_TYPE_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.ACCESSORIESS = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            ACCESSORIES theEntity = (ACCESSORIES)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE_ID", theEntity.VEHICLE_TYPE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORIESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES",theEntity.ACCESSORIESS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            ACCESSORIES theEntity = (ACCESSORIES)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE_ID", theEntity.VEHICLE_TYPE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORIESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES",theEntity.ACCESSORIESS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            ACCESSORIES theEntity = (ACCESSORIES)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE_ID", theEntity.VEHICLE_TYPE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORIESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES",theEntity.ACCESSORIESS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            ACCESSORIES theEntity = (ACCESSORIES)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE_ID", theEntity.VEHICLE_TYPE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORIESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES",theEntity.ACCESSORIESS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	