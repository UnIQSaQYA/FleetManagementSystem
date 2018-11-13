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
    public class POST_OPERATION_LISTDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public POST_OPERATION_LISTDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTPOST_OPERATION_LIST";

               
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPOST_OPERATION_LIST";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPOST_OPERATION_LIST";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPOST_OPERATION_LIST";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			POST_OPERATION_LIST theEntity = new POST_OPERATION_LIST();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VEHICLE_DISPATCH_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.POST_OPERATIONLIST = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            POST_OPERATION_LIST theEntity = (POST_OPERATION_LIST)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_DISPATCH_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_DISPATCH_ID",theEntity.VEHICLE_DISPATCH_ID));
	
			if(!string.IsNullOrEmpty(theEntity.POST_OPERATIONLIST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_POST_OPERATION_LIST",theEntity.POST_OPERATIONLIST));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            POST_OPERATION_LIST theEntity = (POST_OPERATION_LIST)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_DISPATCH_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_DISPATCH_ID",theEntity.VEHICLE_DISPATCH_ID));
	
			if(!string.IsNullOrEmpty(theEntity.POST_OPERATIONLIST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_POST_OPERATION_LIST",theEntity.POST_OPERATIONLIST));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            POST_OPERATION_LIST theEntity = (POST_OPERATION_LIST)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_DISPATCH_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_DISPATCH_ID",theEntity.VEHICLE_DISPATCH_ID));
	
			if(!string.IsNullOrEmpty(theEntity.POST_OPERATIONLIST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_POST_OPERATION_LIST",theEntity.POST_OPERATIONLIST));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            POST_OPERATION_LIST theEntity = (POST_OPERATION_LIST)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_DISPATCH_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_DISPATCH_ID",theEntity.VEHICLE_DISPATCH_ID));
	
			if(!string.IsNullOrEmpty(theEntity.POST_OPERATIONLIST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_POST_OPERATION_LIST",theEntity.POST_OPERATIONLIST));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	