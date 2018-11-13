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
    public class DISPATCH_ACCESSORY_LISTDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public DISPATCH_ACCESSORY_LISTDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTDISPATCH_ACCESSORY_LIST";

            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYDISPATCH_ACCESSORY_LIST";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYDISPATCH_ACCESSORY_LIST";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYDISPATCH_ACCESSORY_LIST";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			DISPATCH_ACCESSORY_LIST theEntity = new DISPATCH_ACCESSORY_LIST();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VEHICLE_DISPATCH_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.ACCESSORY = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            DISPATCH_ACCESSORY_LIST theEntity = (DISPATCH_ACCESSORY_LIST)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_DISPATCH_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_DISPATCH_ID",theEntity.VEHICLE_DISPATCH_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORY",theEntity.ACCESSORY));

              cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
            
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            DISPATCH_ACCESSORY_LIST theEntity = (DISPATCH_ACCESSORY_LIST)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_DISPATCH_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_DISPATCH_ID",theEntity.VEHICLE_DISPATCH_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORY",theEntity.ACCESSORY));

      cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
            
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            DISPATCH_ACCESSORY_LIST theEntity = (DISPATCH_ACCESSORY_LIST)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_DISPATCH_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_DISPATCH_ID",theEntity.VEHICLE_DISPATCH_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORY",theEntity.ACCESSORY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            DISPATCH_ACCESSORY_LIST theEntity = (DISPATCH_ACCESSORY_LIST)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_DISPATCH_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_DISPATCH_ID",theEntity.VEHICLE_DISPATCH_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORY",theEntity.ACCESSORY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	