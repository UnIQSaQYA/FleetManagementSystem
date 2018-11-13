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
    public class VEHICLE_LOGDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public VEHICLE_LOGDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTVEHICLE_LOG";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_LOG";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_LOG";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_LOG";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			VEHICLE_LOG theEntity = new VEHICLE_LOG();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VEHICLE_REG_NO = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.PREVIOUS_VEHICLE_REG_NO = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.LOG_DAY = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.LOG_MONTH = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.LOG_YEAR = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.LOG_DATE = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.DESTINATION_FROM = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;

            theEntity.DESTINATION_TO = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;

            theEntity.REASON_FOR_MOVEMENT = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;

            theEntity.ORDER_BY = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;

            theEntity.ISSUE_ODOMETER = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;

            theEntity.RECEIVE_ODOMETER = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;

            theEntity.RECEIVE_DAY = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;

            theEntity.RECEIVE_MONTH = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;

            theEntity.RECEIVE_YEAR = !dr.IsDBNull(15) ? dr.GetValue(15).ToString() : string.Empty;

            theEntity.RECEIVE_DATE = !dr.IsDBNull(16) ? dr.GetValue(16).ToString() : string.Empty;

            theEntity.DRIVER_ID = !dr.IsDBNull(17) ? dr.GetValue(17).ToString() : string.Empty;

            theEntity.DRIVER_MOBILE = !dr.IsDBNull(18) ? dr.GetValue(18).ToString() : string.Empty;

            theEntity.VEHICLE_USER_ID = !dr.IsDBNull(19) ? dr.GetValue(19).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            VEHICLE_LOG theEntity = (VEHICLE_LOG)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PREVIOUS_VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREVIOUS_VEHICLE_REG_NO",theEntity.PREVIOUS_VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_DAY",theEntity.LOG_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_MONTH",theEntity.LOG_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_YEAR",theEntity.LOG_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_DATE",theEntity.LOG_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DESTINATION_FROM))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESTINATION_FROM",theEntity.DESTINATION_FROM));

            if(!string.IsNullOrEmpty(theEntity.DESTINATION_TO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESTINATION_TO",theEntity.DESTINATION_TO));
	
			if(!string.IsNullOrEmpty(theEntity.REASON_FOR_MOVEMENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REASON_FOR_MOVEMENT",theEntity.REASON_FOR_MOVEMENT));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_BY",theEntity.ORDER_BY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_ODOMETER",theEntity.ISSUE_ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_ODOMETER",theEntity.RECEIVE_ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_DAY",theEntity.RECEIVE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_MONTH",theEntity.RECEIVE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_YEAR",theEntity.RECEIVE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_DATE",theEntity.RECEIVE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID",theEntity.DRIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_MOBILE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_MOBILE",theEntity.DRIVER_MOBILE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_USER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_USER_ID",theEntity.VEHICLE_USER_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            VEHICLE_LOG theEntity = (VEHICLE_LOG)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PREVIOUS_VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREVIOUS_VEHICLE_REG_NO",theEntity.PREVIOUS_VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_DAY",theEntity.LOG_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_MONTH",theEntity.LOG_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_YEAR",theEntity.LOG_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_DATE",theEntity.LOG_DATE));

            if (!string.IsNullOrEmpty(theEntity.DESTINATION_FROM))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESTINATION_FROM", theEntity.DESTINATION_FROM));

            if (!string.IsNullOrEmpty(theEntity.DESTINATION_TO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESTINATION_TO", theEntity.DESTINATION_TO));
	
			if(!string.IsNullOrEmpty(theEntity.REASON_FOR_MOVEMENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REASON_FOR_MOVEMENT",theEntity.REASON_FOR_MOVEMENT));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_BY",theEntity.ORDER_BY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_ODOMETER",theEntity.ISSUE_ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_ODOMETER",theEntity.RECEIVE_ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_DAY",theEntity.RECEIVE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_MONTH",theEntity.RECEIVE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_YEAR",theEntity.RECEIVE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_DATE",theEntity.RECEIVE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID",theEntity.DRIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_MOBILE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_MOBILE",theEntity.DRIVER_MOBILE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_USER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_USER_ID",theEntity.VEHICLE_USER_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            VEHICLE_LOG theEntity = (VEHICLE_LOG)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PREVIOUS_VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREVIOUS_VEHICLE_REG_NO",theEntity.PREVIOUS_VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_DAY",theEntity.LOG_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_MONTH",theEntity.LOG_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_YEAR",theEntity.LOG_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_DATE",theEntity.LOG_DATE));

            if (!string.IsNullOrEmpty(theEntity.DESTINATION_FROM))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESTINATION_FROM", theEntity.DESTINATION_FROM));

            if (!string.IsNullOrEmpty(theEntity.DESTINATION_TO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESTINATION_TO", theEntity.DESTINATION_TO));
	
			if(!string.IsNullOrEmpty(theEntity.REASON_FOR_MOVEMENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REASON_FOR_MOVEMENT",theEntity.REASON_FOR_MOVEMENT));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_BY",theEntity.ORDER_BY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_ODOMETER",theEntity.ISSUE_ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_ODOMETER",theEntity.RECEIVE_ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_DAY",theEntity.RECEIVE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_MONTH",theEntity.RECEIVE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_YEAR",theEntity.RECEIVE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_DATE",theEntity.RECEIVE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID",theEntity.DRIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_MOBILE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_MOBILE",theEntity.DRIVER_MOBILE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_USER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_USER_ID",theEntity.VEHICLE_USER_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            VEHICLE_LOG theEntity = (VEHICLE_LOG)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PREVIOUS_VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PREVIOUS_VEHICLE_REG_NO",theEntity.PREVIOUS_VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_DAY",theEntity.LOG_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_MONTH",theEntity.LOG_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_YEAR",theEntity.LOG_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.LOG_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LOG_DATE",theEntity.LOG_DATE));

            if (!string.IsNullOrEmpty(theEntity.DESTINATION_FROM))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESTINATION_FROM", theEntity.DESTINATION_FROM));

            if (!string.IsNullOrEmpty(theEntity.DESTINATION_TO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESTINATION_TO", theEntity.DESTINATION_TO));
	
			if(!string.IsNullOrEmpty(theEntity.REASON_FOR_MOVEMENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REASON_FOR_MOVEMENT",theEntity.REASON_FOR_MOVEMENT));
	
			if(!string.IsNullOrEmpty(theEntity.ORDER_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ORDER_BY",theEntity.ORDER_BY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_ODOMETER",theEntity.ISSUE_ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_ODOMETER",theEntity.RECEIVE_ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_DAY",theEntity.RECEIVE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_MONTH",theEntity.RECEIVE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_YEAR",theEntity.RECEIVE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_DATE",theEntity.RECEIVE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID",theEntity.DRIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_MOBILE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_MOBILE",theEntity.DRIVER_MOBILE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_USER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_USER_ID",theEntity.VEHICLE_USER_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	