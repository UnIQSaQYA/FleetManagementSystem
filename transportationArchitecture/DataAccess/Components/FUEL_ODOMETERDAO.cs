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
    public class FUEL_ODOMETERDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public FUEL_ODOMETERDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTFUEL_ODOMETER";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYFUEL_ODOMETER";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYFUEL_ODOMETER";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYFUEL_ODOMETER";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			FUEL_ODOMETER theEntity = new FUEL_ODOMETER();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VEHICLE_REG_NO = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.FUEL_DAY = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.FUEL_MONTH = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.FUEL_YEAR = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.FUEL_DATE = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.PETROL = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.DIESEL = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.MOBIL = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.DISTILLED_WATER = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.ODOMETER = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.FUEL_STATION_TYPE = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.FUEL_STATION = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			theEntity.REFUEL_BY = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;
	
			theEntity.RATE_PETROL = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;
	
			theEntity.RATE_DIESEL = !dr.IsDBNull(15) ? dr.GetValue(15).ToString() : string.Empty;
	
			theEntity.RATE_MOBIL = !dr.IsDBNull(16) ? dr.GetValue(16).ToString() : string.Empty;
	
			theEntity.RATE_DISTILLED_WATER = !dr.IsDBNull(17) ? dr.GetValue(17).ToString() : string.Empty;

            theEntity.FUEL_TYPE = !dr.IsDBNull(18) ? dr.GetValue(18).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            FUEL_ODOMETER theEntity = (FUEL_ODOMETER)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_DAY",theEntity.FUEL_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_MONTH",theEntity.FUEL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_YEAR",theEntity.FUEL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_DATE",theEntity.FUEL_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.PETROL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PETROL",theEntity.PETROL));
	
			if(!string.IsNullOrEmpty(theEntity.DIESEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DIESEL",theEntity.DIESEL));
	
			if(!string.IsNullOrEmpty(theEntity.MOBIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOBIL",theEntity.MOBIL));
	
			if(!string.IsNullOrEmpty(theEntity.DISTILLED_WATER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISTILLED_WATER",theEntity.DISTILLED_WATER));
	
			if(!string.IsNullOrEmpty(theEntity.ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ODOMETER",theEntity.ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_STATION_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_STATION_TYPE",theEntity.FUEL_STATION_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_STATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_STATION",theEntity.FUEL_STATION));
	
			if(!string.IsNullOrEmpty(theEntity.REFUEL_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REFUEL_BY",theEntity.REFUEL_BY));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_PETROL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_PETROL",theEntity.RATE_PETROL));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_DIESEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_DIESEL",theEntity.RATE_DIESEL));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_MOBIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_MOBIL",theEntity.RATE_MOBIL));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_DISTILLED_WATER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_DISTILLED_WATER",theEntity.RATE_DISTILLED_WATER));

            if (!string.IsNullOrEmpty(theEntity.FUEL_TYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_TYPE", theEntity.FUEL_TYPE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            FUEL_ODOMETER theEntity = (FUEL_ODOMETER)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_DAY",theEntity.FUEL_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_MONTH",theEntity.FUEL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_YEAR",theEntity.FUEL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_DATE",theEntity.FUEL_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.PETROL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PETROL",theEntity.PETROL));
	
			if(!string.IsNullOrEmpty(theEntity.DIESEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DIESEL",theEntity.DIESEL));
	
			if(!string.IsNullOrEmpty(theEntity.MOBIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOBIL",theEntity.MOBIL));
	
			if(!string.IsNullOrEmpty(theEntity.DISTILLED_WATER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISTILLED_WATER",theEntity.DISTILLED_WATER));
	
			if(!string.IsNullOrEmpty(theEntity.ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ODOMETER",theEntity.ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_STATION_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_STATION_TYPE",theEntity.FUEL_STATION_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_STATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_STATION",theEntity.FUEL_STATION));
	
			if(!string.IsNullOrEmpty(theEntity.REFUEL_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REFUEL_BY",theEntity.REFUEL_BY));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_PETROL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_PETROL",theEntity.RATE_PETROL));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_DIESEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_DIESEL",theEntity.RATE_DIESEL));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_MOBIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_MOBIL",theEntity.RATE_MOBIL));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_DISTILLED_WATER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_DISTILLED_WATER",theEntity.RATE_DISTILLED_WATER));

            if (!string.IsNullOrEmpty(theEntity.FUEL_TYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_TYPE", theEntity.FUEL_TYPE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            FUEL_ODOMETER theEntity = (FUEL_ODOMETER)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_DAY",theEntity.FUEL_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_MONTH",theEntity.FUEL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_YEAR",theEntity.FUEL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_DATE",theEntity.FUEL_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.PETROL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PETROL",theEntity.PETROL));
	
			if(!string.IsNullOrEmpty(theEntity.DIESEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DIESEL",theEntity.DIESEL));
	
			if(!string.IsNullOrEmpty(theEntity.MOBIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOBIL",theEntity.MOBIL));
	
			if(!string.IsNullOrEmpty(theEntity.DISTILLED_WATER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISTILLED_WATER",theEntity.DISTILLED_WATER));
	
			if(!string.IsNullOrEmpty(theEntity.ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ODOMETER",theEntity.ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_STATION_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_STATION_TYPE",theEntity.FUEL_STATION_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_STATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_STATION",theEntity.FUEL_STATION));
	
			if(!string.IsNullOrEmpty(theEntity.REFUEL_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REFUEL_BY",theEntity.REFUEL_BY));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_PETROL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_PETROL",theEntity.RATE_PETROL));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_DIESEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_DIESEL",theEntity.RATE_DIESEL));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_MOBIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_MOBIL",theEntity.RATE_MOBIL));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_DISTILLED_WATER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_DISTILLED_WATER",theEntity.RATE_DISTILLED_WATER));

            if (!string.IsNullOrEmpty(theEntity.FUEL_TYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_TYPE", theEntity.FUEL_TYPE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            FUEL_ODOMETER theEntity = (FUEL_ODOMETER)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_DAY",theEntity.FUEL_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_MONTH",theEntity.FUEL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_YEAR",theEntity.FUEL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_DATE",theEntity.FUEL_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.PETROL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PETROL",theEntity.PETROL));
	
			if(!string.IsNullOrEmpty(theEntity.DIESEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DIESEL",theEntity.DIESEL));
	
			if(!string.IsNullOrEmpty(theEntity.MOBIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOBIL",theEntity.MOBIL));
	
			if(!string.IsNullOrEmpty(theEntity.DISTILLED_WATER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISTILLED_WATER",theEntity.DISTILLED_WATER));
	
			if(!string.IsNullOrEmpty(theEntity.ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ODOMETER",theEntity.ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_STATION_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_STATION_TYPE",theEntity.FUEL_STATION_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.FUEL_STATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_STATION",theEntity.FUEL_STATION));
	
			if(!string.IsNullOrEmpty(theEntity.REFUEL_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REFUEL_BY",theEntity.REFUEL_BY));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_PETROL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_PETROL",theEntity.RATE_PETROL));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_DIESEL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_DIESEL",theEntity.RATE_DIESEL));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_MOBIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_MOBIL",theEntity.RATE_MOBIL));
	
			if(!string.IsNullOrEmpty(theEntity.RATE_DISTILLED_WATER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE_DISTILLED_WATER",theEntity.RATE_DISTILLED_WATER));

            if (!string.IsNullOrEmpty(theEntity.FUEL_TYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_TYPE", theEntity.FUEL_TYPE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	