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
    public class GOOD_TRANSPORTATIONDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public GOOD_TRANSPORTATIONDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTGOOD_TRANSPORTATION";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYGOOD_TRANSPORTATION";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYGOOD_TRANSPORTATION";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYGOOD_TRANSPORTATION";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			GOOD_TRANSPORTATION theEntity = new GOOD_TRANSPORTATION();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.MOVEMENT_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.ORDER_OFFICE = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.ORDER_BY_HEAD = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.ORDER_BY = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            GOOD_TRANSPORTATION theEntity = (GOOD_TRANSPORTATION)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MOVEMENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOVEMENT_ID",theEntity.MOVEMENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_OFFICE",theEntity.ORDER_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_BY_HEAD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_BY_HEAD",theEntity.ORDER_BY_HEAD));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_BY",theEntity.ORDER_BY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            GOOD_TRANSPORTATION theEntity = (GOOD_TRANSPORTATION)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MOVEMENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOVEMENT_ID",theEntity.MOVEMENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_OFFICE",theEntity.ORDER_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_BY_HEAD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_BY_HEAD",theEntity.ORDER_BY_HEAD));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_BY",theEntity.ORDER_BY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            GOOD_TRANSPORTATION theEntity = (GOOD_TRANSPORTATION)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MOVEMENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOVEMENT_ID",theEntity.MOVEMENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_OFFICE",theEntity.ORDER_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_BY_HEAD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_BY_HEAD",theEntity.ORDER_BY_HEAD));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_BY",theEntity.ORDER_BY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            GOOD_TRANSPORTATION theEntity = (GOOD_TRANSPORTATION)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MOVEMENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOVEMENT_ID",theEntity.MOVEMENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_OFFICE",theEntity.ORDER_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_BY_HEAD))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_BY_HEAD",theEntity.ORDER_BY_HEAD));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_BY",theEntity.ORDER_BY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	