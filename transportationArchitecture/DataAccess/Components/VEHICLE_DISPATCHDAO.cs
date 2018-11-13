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
    public class VEHICLE_DISPATCHDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public VEHICLE_DISPATCHDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTVEHICLE_DISPATCH";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_DISPATCH";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_DISPATCH";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_DISPATCH";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			VEHICLE_DISPATCH theEntity = new VEHICLE_DISPATCH();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.DISPATCH_NUMBER = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.VEHICLE_ID = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.DRIVERS_ID = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.DISPATCH_DAY = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.DISPATCH_MONTH = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.DISPATCH_YEAR = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.DISPATCH_DATE = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.DISPATCH_TIME = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.DISPATCH_ODOMETER = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.RETURN_DAY = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.RETURN_MONTH = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.RETURN_YEAR = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			theEntity.RETURN_DATE = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;
	
			theEntity.RETURN_TIME = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;
	
			theEntity.DESTINATION = !dr.IsDBNull(15) ? dr.GetValue(15).ToString() : string.Empty;
	
			theEntity.PARKING_PLACE = !dr.IsDBNull(16) ? dr.GetValue(16).ToString() : string.Empty;
	
			theEntity.SCHEDULED_MAINTAIN_DATE = !dr.IsDBNull(17) ? dr.GetValue(17).ToString() : string.Empty;
	
			theEntity.SCHEDULED_MAINTAIN_MILAGE = !dr.IsDBNull(18) ? dr.GetValue(18).ToString() : string.Empty;
	
			theEntity.OUTSTANDING_REPAIR = !dr.IsDBNull(19) ? dr.GetValue(19).ToString() : string.Empty;
	
			theEntity.UNIT_PERSON_STATUS = !dr.IsDBNull(20) ? dr.GetValue(20).ToString() : string.Empty;
	
			theEntity.UNIT_PERSON = !dr.IsDBNull(21) ? dr.GetValue(21).ToString() : string.Empty;
	
			theEntity.TEMPORARY_PERMANENT = !dr.IsDBNull(22) ? dr.GetValue(22).ToString() : string.Empty;
	
			theEntity.OFFICE_CODE = !dr.IsDBNull(23) ? dr.GetValue(23).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            VEHICLE_DISPATCH theEntity = (VEHICLE_DISPATCH)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_NUMBER",theEntity.DISPATCH_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVERS_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVERS_ID",theEntity.DRIVERS_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_DAY",theEntity.DISPATCH_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_MONTH",theEntity.DISPATCH_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_YEAR",theEntity.DISPATCH_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_DATE",theEntity.DISPATCH_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_TIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_TIME",theEntity.DISPATCH_TIME));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_ODOMETER",theEntity.DISPATCH_ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DAY",theEntity.RETURN_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_MONTH",theEntity.RETURN_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_YEAR",theEntity.RETURN_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DATE",theEntity.RETURN_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_TIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_TIME",theEntity.RETURN_TIME));
	
			if(!string.IsNullOrEmpty(theEntity.DESTINATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESTINATION",theEntity.DESTINATION));
	
			if(!string.IsNullOrEmpty(theEntity.PARKING_PLACE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARKING_PLACE",theEntity.PARKING_PLACE));
	
			if(!string.IsNullOrEmpty(theEntity.SCHEDULED_MAINTAIN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCHEDULED_MAINTAIN_DATE",theEntity.SCHEDULED_MAINTAIN_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.SCHEDULED_MAINTAIN_MILAGE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCHEDULED_MAINTAIN_MILAGE",theEntity.SCHEDULED_MAINTAIN_MILAGE));
	
			if(!string.IsNullOrEmpty(theEntity.OUTSTANDING_REPAIR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OUTSTANDING_REPAIR",theEntity.OUTSTANDING_REPAIR));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT_PERSON_STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT_PERSON_STATUS",theEntity.UNIT_PERSON_STATUS));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT_PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT_PERSON",theEntity.UNIT_PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.TEMPORARY_PERMANENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TEMPORARY_PERMANENT",theEntity.TEMPORARY_PERMANENT));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE",theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            VEHICLE_DISPATCH theEntity = (VEHICLE_DISPATCH)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_NUMBER",theEntity.DISPATCH_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVERS_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVERS_ID",theEntity.DRIVERS_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_DAY",theEntity.DISPATCH_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_MONTH",theEntity.DISPATCH_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_YEAR",theEntity.DISPATCH_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_DATE",theEntity.DISPATCH_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_TIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_TIME",theEntity.DISPATCH_TIME));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_ODOMETER",theEntity.DISPATCH_ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DAY",theEntity.RETURN_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_MONTH",theEntity.RETURN_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_YEAR",theEntity.RETURN_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DATE",theEntity.RETURN_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_TIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_TIME",theEntity.RETURN_TIME));
	
			if(!string.IsNullOrEmpty(theEntity.DESTINATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESTINATION",theEntity.DESTINATION));
	
			if(!string.IsNullOrEmpty(theEntity.PARKING_PLACE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARKING_PLACE",theEntity.PARKING_PLACE));
	
			if(!string.IsNullOrEmpty(theEntity.SCHEDULED_MAINTAIN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCHEDULED_MAINTAIN_DATE",theEntity.SCHEDULED_MAINTAIN_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.SCHEDULED_MAINTAIN_MILAGE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCHEDULED_MAINTAIN_MILAGE",theEntity.SCHEDULED_MAINTAIN_MILAGE));
	
			if(!string.IsNullOrEmpty(theEntity.OUTSTANDING_REPAIR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OUTSTANDING_REPAIR",theEntity.OUTSTANDING_REPAIR));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT_PERSON_STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT_PERSON_STATUS",theEntity.UNIT_PERSON_STATUS));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT_PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT_PERSON",theEntity.UNIT_PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.TEMPORARY_PERMANENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TEMPORARY_PERMANENT",theEntity.TEMPORARY_PERMANENT));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE",theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            VEHICLE_DISPATCH theEntity = (VEHICLE_DISPATCH)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_NUMBER",theEntity.DISPATCH_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVERS_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVERS_ID",theEntity.DRIVERS_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_DAY",theEntity.DISPATCH_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_MONTH",theEntity.DISPATCH_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_YEAR",theEntity.DISPATCH_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_DATE",theEntity.DISPATCH_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_TIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_TIME",theEntity.DISPATCH_TIME));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_ODOMETER",theEntity.DISPATCH_ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DAY",theEntity.RETURN_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_MONTH",theEntity.RETURN_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_YEAR",theEntity.RETURN_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DATE",theEntity.RETURN_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_TIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_TIME",theEntity.RETURN_TIME));
	
			if(!string.IsNullOrEmpty(theEntity.DESTINATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESTINATION",theEntity.DESTINATION));
	
			if(!string.IsNullOrEmpty(theEntity.PARKING_PLACE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARKING_PLACE",theEntity.PARKING_PLACE));
	
			if(!string.IsNullOrEmpty(theEntity.SCHEDULED_MAINTAIN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCHEDULED_MAINTAIN_DATE",theEntity.SCHEDULED_MAINTAIN_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.SCHEDULED_MAINTAIN_MILAGE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCHEDULED_MAINTAIN_MILAGE",theEntity.SCHEDULED_MAINTAIN_MILAGE));
	
			if(!string.IsNullOrEmpty(theEntity.OUTSTANDING_REPAIR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OUTSTANDING_REPAIR",theEntity.OUTSTANDING_REPAIR));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT_PERSON_STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT_PERSON_STATUS",theEntity.UNIT_PERSON_STATUS));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT_PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT_PERSON",theEntity.UNIT_PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.TEMPORARY_PERMANENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TEMPORARY_PERMANENT",theEntity.TEMPORARY_PERMANENT));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE",theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            VEHICLE_DISPATCH theEntity = (VEHICLE_DISPATCH)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_NUMBER",theEntity.DISPATCH_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVERS_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVERS_ID",theEntity.DRIVERS_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_DAY",theEntity.DISPATCH_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_MONTH",theEntity.DISPATCH_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_YEAR",theEntity.DISPATCH_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_DATE",theEntity.DISPATCH_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_TIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_TIME",theEntity.DISPATCH_TIME));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_ODOMETER",theEntity.DISPATCH_ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DAY",theEntity.RETURN_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_MONTH",theEntity.RETURN_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_YEAR",theEntity.RETURN_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DATE",theEntity.RETURN_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_TIME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_TIME",theEntity.RETURN_TIME));
	
			if(!string.IsNullOrEmpty(theEntity.DESTINATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESTINATION",theEntity.DESTINATION));
	
			if(!string.IsNullOrEmpty(theEntity.PARKING_PLACE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARKING_PLACE",theEntity.PARKING_PLACE));
	
			if(!string.IsNullOrEmpty(theEntity.SCHEDULED_MAINTAIN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCHEDULED_MAINTAIN_DATE",theEntity.SCHEDULED_MAINTAIN_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.SCHEDULED_MAINTAIN_MILAGE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SCHEDULED_MAINTAIN_MILAGE",theEntity.SCHEDULED_MAINTAIN_MILAGE));
	
			if(!string.IsNullOrEmpty(theEntity.OUTSTANDING_REPAIR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OUTSTANDING_REPAIR",theEntity.OUTSTANDING_REPAIR));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT_PERSON_STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT_PERSON_STATUS",theEntity.UNIT_PERSON_STATUS));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT_PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT_PERSON",theEntity.UNIT_PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.TEMPORARY_PERMANENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TEMPORARY_PERMANENT",theEntity.TEMPORARY_PERMANENT));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE",theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	