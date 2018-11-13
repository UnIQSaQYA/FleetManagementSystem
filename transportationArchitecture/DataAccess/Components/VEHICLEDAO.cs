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
    public class VEHICLEDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public VEHICLEDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTVEHICLE";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			VEHICLE theEntity = new VEHICLE();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.CHASIS_NUMBER = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.REGISTRATION_NUMBER_ENG = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.REGISTRATION_NUMBER_NEP = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.ENGINE_NUMBER = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.REGISTRATION_DAY = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.REGISTRATION_MONTH = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.REGISTRATION_YEAR = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.REGISTRATION_DATE = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.MANUFACTURE = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.VECHICLE_MODEL = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.MODEL_YEAR = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.VEHICLE_CATEGORY = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			theEntity.VEHICLE_TYPE = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;
	
			theEntity.VEHICLE_TYPE_DESCRIPTION = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;
	
			theEntity.MAX_CARGO_CAPACITY = !dr.IsDBNull(15) ? dr.GetValue(15).ToString() : string.Empty;
	
			theEntity.MAX_PASSENGER_CAPACITY = !dr.IsDBNull(16) ? dr.GetValue(16).ToString() : string.Empty;
	
			theEntity.FUEL_TYPE = !dr.IsDBNull(17) ? dr.GetValue(17).ToString() : string.Empty;
	
			theEntity.MAINTENANCE_INTERVAL_MONTH = !dr.IsDBNull(18) ? dr.GetValue(18).ToString() : string.Empty;
	
			theEntity.MAINTENANCE_INTERVAL_KM = !dr.IsDBNull(19) ? dr.GetValue(19).ToString() : string.Empty;
	
			theEntity.VECHICLE_USER = !dr.IsDBNull(20) ? dr.GetValue(20).ToString() : string.Empty;
	
			theEntity.BASE_STATION = !dr.IsDBNull(21) ? dr.GetValue(21).ToString() : string.Empty;
	
			theEntity.VEHICLE_STATUS = !dr.IsDBNull(22) ? dr.GetValue(22).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            VEHICLE theEntity = (VEHICLE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.CHASIS_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHASIS_NUMBER",theEntity.CHASIS_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_NUMBER_ENG))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_NUMBER_ENG",theEntity.REGISTRATION_NUMBER_ENG));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_NUMBER_NEP))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_NUMBER_NEP",theEntity.REGISTRATION_NUMBER_NEP));
	
			if(!string.IsNullOrEmpty(theEntity.ENGINE_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENGINE_NUMBER",theEntity.ENGINE_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_DAY",theEntity.REGISTRATION_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_MONTH",theEntity.REGISTRATION_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_YEAR",theEntity.REGISTRATION_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_DATE",theEntity.REGISTRATION_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.MANUFACTURE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MANUFACTURE",theEntity.MANUFACTURE));
	
			if(!string.IsNullOrEmpty(theEntity.VECHICLE_MODEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_MODEL",theEntity.VECHICLE_MODEL));
	
			if(!string.IsNullOrEmpty(theEntity.MODEL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MODEL_YEAR",theEntity.MODEL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_CATEGORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_CATEGORY",theEntity.VEHICLE_CATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE",theEntity.VEHICLE_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE_DESCRIPTION",theEntity.VEHICLE_TYPE_DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.MAX_CARGO_CAPACITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAX_CARGO_CAPACITY",theEntity.MAX_CARGO_CAPACITY));
	
			if(!string.IsNullOrEmpty(theEntity.MAX_PASSENGER_CAPACITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAX_PASSENGER_CAPACITY",theEntity.MAX_PASSENGER_CAPACITY));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_TYPE",theEntity.FUEL_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTENANCE_INTERVAL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTENANCE_INTERVAL_MONTH",theEntity.MAINTENANCE_INTERVAL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTENANCE_INTERVAL_KM))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTENANCE_INTERVAL_KM",theEntity.MAINTENANCE_INTERVAL_KM));
	
			if(!string.IsNullOrEmpty(theEntity.VECHICLE_USER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_USER",theEntity.VECHICLE_USER));
	
			if(!string.IsNullOrEmpty(theEntity.BASE_STATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BASE_STATION",theEntity.BASE_STATION));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_STATUS",theEntity.VEHICLE_STATUS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            VEHICLE theEntity = (VEHICLE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.CHASIS_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHASIS_NUMBER",theEntity.CHASIS_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_NUMBER_ENG))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_NUMBER_ENG",theEntity.REGISTRATION_NUMBER_ENG));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_NUMBER_NEP))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_NUMBER_NEP",theEntity.REGISTRATION_NUMBER_NEP));
	
			if(!string.IsNullOrEmpty(theEntity.ENGINE_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENGINE_NUMBER",theEntity.ENGINE_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_DAY",theEntity.REGISTRATION_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_MONTH",theEntity.REGISTRATION_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_YEAR",theEntity.REGISTRATION_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_DATE",theEntity.REGISTRATION_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.MANUFACTURE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MANUFACTURE",theEntity.MANUFACTURE));
	
			if(!string.IsNullOrEmpty(theEntity.VECHICLE_MODEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_MODEL",theEntity.VECHICLE_MODEL));
	
			if(!string.IsNullOrEmpty(theEntity.MODEL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MODEL_YEAR",theEntity.MODEL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_CATEGORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_CATEGORY",theEntity.VEHICLE_CATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE",theEntity.VEHICLE_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE_DESCRIPTION",theEntity.VEHICLE_TYPE_DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.MAX_CARGO_CAPACITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAX_CARGO_CAPACITY",theEntity.MAX_CARGO_CAPACITY));
	
			if(!string.IsNullOrEmpty(theEntity.MAX_PASSENGER_CAPACITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAX_PASSENGER_CAPACITY",theEntity.MAX_PASSENGER_CAPACITY));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_TYPE",theEntity.FUEL_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTENANCE_INTERVAL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTENANCE_INTERVAL_MONTH",theEntity.MAINTENANCE_INTERVAL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTENANCE_INTERVAL_KM))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTENANCE_INTERVAL_KM",theEntity.MAINTENANCE_INTERVAL_KM));
	
			if(!string.IsNullOrEmpty(theEntity.VECHICLE_USER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_USER",theEntity.VECHICLE_USER));
	
			if(!string.IsNullOrEmpty(theEntity.BASE_STATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BASE_STATION",theEntity.BASE_STATION));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_STATUS",theEntity.VEHICLE_STATUS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            VEHICLE theEntity = (VEHICLE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.CHASIS_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHASIS_NUMBER",theEntity.CHASIS_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_NUMBER_ENG))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_NUMBER_ENG",theEntity.REGISTRATION_NUMBER_ENG));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_NUMBER_NEP))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_NUMBER_NEP",theEntity.REGISTRATION_NUMBER_NEP));
	
			if(!string.IsNullOrEmpty(theEntity.ENGINE_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENGINE_NUMBER",theEntity.ENGINE_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_DAY",theEntity.REGISTRATION_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_MONTH",theEntity.REGISTRATION_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_YEAR",theEntity.REGISTRATION_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_DATE",theEntity.REGISTRATION_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.MANUFACTURE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MANUFACTURE",theEntity.MANUFACTURE));
	
			if(!string.IsNullOrEmpty(theEntity.VECHICLE_MODEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_MODEL",theEntity.VECHICLE_MODEL));

            if (!string.IsNullOrEmpty(theEntity.MODEL_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MODEL_YEAR", theEntity.MODEL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_CATEGORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_CATEGORY",theEntity.VEHICLE_CATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE",theEntity.VEHICLE_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE_DESCRIPTION",theEntity.VEHICLE_TYPE_DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.MAX_CARGO_CAPACITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAX_CARGO_CAPACITY",theEntity.MAX_CARGO_CAPACITY));
	
			if(!string.IsNullOrEmpty(theEntity.MAX_PASSENGER_CAPACITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAX_PASSENGER_CAPACITY",theEntity.MAX_PASSENGER_CAPACITY));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_TYPE",theEntity.FUEL_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTENANCE_INTERVAL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTENANCE_INTERVAL_MONTH",theEntity.MAINTENANCE_INTERVAL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTENANCE_INTERVAL_KM))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTENANCE_INTERVAL_KM",theEntity.MAINTENANCE_INTERVAL_KM));
	
			if(!string.IsNullOrEmpty(theEntity.VECHICLE_USER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_USER",theEntity.VECHICLE_USER));
	
			if(!string.IsNullOrEmpty(theEntity.BASE_STATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BASE_STATION",theEntity.BASE_STATION));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_STATUS",theEntity.VEHICLE_STATUS));


            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            VEHICLE theEntity = (VEHICLE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.CHASIS_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CHASIS_NUMBER",theEntity.CHASIS_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_NUMBER_ENG))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_NUMBER_ENG",theEntity.REGISTRATION_NUMBER_ENG));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_NUMBER_NEP))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_NUMBER_NEP",theEntity.REGISTRATION_NUMBER_NEP));
	
			if(!string.IsNullOrEmpty(theEntity.ENGINE_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENGINE_NUMBER",theEntity.ENGINE_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_DAY",theEntity.REGISTRATION_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_MONTH",theEntity.REGISTRATION_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_YEAR",theEntity.REGISTRATION_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.REGISTRATION_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REGISTRATION_DATE",theEntity.REGISTRATION_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.MANUFACTURE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MANUFACTURE",theEntity.MANUFACTURE));
	
			if(!string.IsNullOrEmpty(theEntity.VECHICLE_MODEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_MODEL",theEntity.VECHICLE_MODEL));

            if (!string.IsNullOrEmpty(theEntity.MODEL_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MODEL_YEAR", theEntity.MODEL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_CATEGORY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_CATEGORY",theEntity.VEHICLE_CATEGORY));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE",theEntity.VEHICLE_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_TYPE_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_TYPE_DESCRIPTION",theEntity.VEHICLE_TYPE_DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.MAX_CARGO_CAPACITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAX_CARGO_CAPACITY",theEntity.MAX_CARGO_CAPACITY));
	
			if(!string.IsNullOrEmpty(theEntity.MAX_PASSENGER_CAPACITY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAX_PASSENGER_CAPACITY",theEntity.MAX_PASSENGER_CAPACITY));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_TYPE",theEntity.FUEL_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTENANCE_INTERVAL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTENANCE_INTERVAL_MONTH",theEntity.MAINTENANCE_INTERVAL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.MAINTENANCE_INTERVAL_KM))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MAINTENANCE_INTERVAL_KM",theEntity.MAINTENANCE_INTERVAL_KM));
	
			if(!string.IsNullOrEmpty(theEntity.VECHICLE_USER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_USER",theEntity.VECHICLE_USER));
	
			if(!string.IsNullOrEmpty(theEntity.BASE_STATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BASE_STATION",theEntity.BASE_STATION));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_STATUS",theEntity.VEHICLE_STATUS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	