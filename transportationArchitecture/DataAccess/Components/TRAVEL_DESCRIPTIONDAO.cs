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
    public class TRAVEL_DESCRIPTIONDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public TRAVEL_DESCRIPTIONDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTTRAVEL_DESCRIPTION";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYTRAVEL_DESCRIPTION";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYTRAVEL_DESCRIPTION";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYTRAVEL_DESCRIPTION";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			TRAVEL_DESCRIPTION theEntity = new TRAVEL_DESCRIPTION();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.MOVEMENT_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.TRAVEL_DATE = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.TRAVEL_TIME = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.PLACE_FROM = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.PLACE_TO = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            TRAVEL_DESCRIPTION theEntity = (TRAVEL_DESCRIPTION)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MOVEMENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOVEMENT_ID",theEntity.MOVEMENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_DATE",theEntity.TRAVEL_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_TIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_TIME",theEntity.TRAVEL_TIME));
	
			if(!string.IsNullOrEmpty(theEntity.PLACE_FROM))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PLACE_FROM",theEntity.PLACE_FROM));
	
			if(!string.IsNullOrEmpty(theEntity.PLACE_TO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PLACE_TO",theEntity.PLACE_TO));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            TRAVEL_DESCRIPTION theEntity = (TRAVEL_DESCRIPTION)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MOVEMENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOVEMENT_ID",theEntity.MOVEMENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_DATE",theEntity.TRAVEL_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_TIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_TIME",theEntity.TRAVEL_TIME));
	
			if(!string.IsNullOrEmpty(theEntity.PLACE_FROM))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PLACE_FROM",theEntity.PLACE_FROM));
	
			if(!string.IsNullOrEmpty(theEntity.PLACE_TO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PLACE_TO",theEntity.PLACE_TO));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            TRAVEL_DESCRIPTION theEntity = (TRAVEL_DESCRIPTION)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MOVEMENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOVEMENT_ID",theEntity.MOVEMENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_DATE",theEntity.TRAVEL_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_TIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_TIME",theEntity.TRAVEL_TIME));
	
			if(!string.IsNullOrEmpty(theEntity.PLACE_FROM))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PLACE_FROM",theEntity.PLACE_FROM));
	
			if(!string.IsNullOrEmpty(theEntity.PLACE_TO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PLACE_TO",theEntity.PLACE_TO));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            TRAVEL_DESCRIPTION theEntity = (TRAVEL_DESCRIPTION)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MOVEMENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOVEMENT_ID",theEntity.MOVEMENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_DATE",theEntity.TRAVEL_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_TIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_TIME",theEntity.TRAVEL_TIME));
	
			if(!string.IsNullOrEmpty(theEntity.PLACE_FROM))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PLACE_FROM",theEntity.PLACE_FROM));
	
			if(!string.IsNullOrEmpty(theEntity.PLACE_TO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PLACE_TO",theEntity.PLACE_TO));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	