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
    public class MOVEMENT_OF_VEHICLEDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public MOVEMENT_OF_VEHICLEDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTMOVEMENT_OF_VEHICLE";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYMOVEMENT_OF_VEHICLE";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYMOVEMENT_OF_VEHICLE";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYMOVEMENT_OF_VEHICLE";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			MOVEMENT_OF_VEHICLE theEntity = new MOVEMENT_OF_VEHICLE();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.TRAVEL_NUMBER = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.TRAVEL_DAY = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.TRAVEL_MONTH = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.TRAVEL_YEAR = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.TRAVEL_DATE = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.TRAVEL_FY = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.VEHICLE_REG_NO = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.DRIVER_ID = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.TVL_MAIN_PERSON = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.TVL_MAIN_CONTACTNO = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.TV_MAIN_MOBILENO = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.TVL_MAIN_CALLSIGN = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			theEntity.TVL_REASON = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;
	
			theEntity.TVL_TYPE = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;
	
			theEntity.TVL_REF_DEMAND_BY = !dr.IsDBNull(15) ? dr.GetValue(15).ToString() : string.Empty;
	
			theEntity.TVL_REF_DEMAND_OFFICE = !dr.IsDBNull(16) ? dr.GetValue(16).ToString() : string.Empty;
	
			theEntity.TVL_REF_DEMAND_DIS = !dr.IsDBNull(17) ? dr.GetValue(17).ToString() : string.Empty;
	
			theEntity.TVL_REF_APPROVE_BY = !dr.IsDBNull(18) ? dr.GetValue(18).ToString() : string.Empty;
	
			theEntity.TVL_REF_APPROVE_OFFICE = !dr.IsDBNull(19) ? dr.GetValue(19).ToString() : string.Empty;
	
			theEntity.TVL_REF_APPROVE_DIS = !dr.IsDBNull(20) ? dr.GetValue(20).ToString() : string.Empty;
	
			theEntity.TVL_APPROVE_BY = !dr.IsDBNull(21) ? dr.GetValue(21).ToString() : string.Empty;
	
			theEntity.TVL_APPROVE_OFFICE = !dr.IsDBNull(22) ? dr.GetValue(22).ToString() : string.Empty;
	
			theEntity.TVL_APPROVE_DIS = !dr.IsDBNull(23) ? dr.GetValue(23).ToString() : string.Empty;
	
			theEntity.TVL_COMPLITION_DETAIL = !dr.IsDBNull(24) ? dr.GetValue(24).ToString() : string.Empty;

            theEntity.FUEL_SOURCE = !dr.IsDBNull(25) ? dr.GetValue(25).ToString() : string.Empty;

            theEntity.FUEL_QUANTITY = !dr.IsDBNull(26) ? dr.GetValue(26).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            MOVEMENT_OF_VEHICLE theEntity = (MOVEMENT_OF_VEHICLE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_NUMBER",theEntity.TRAVEL_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_DAY",theEntity.TRAVEL_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_MONTH",theEntity.TRAVEL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_YEAR",theEntity.TRAVEL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_DATE",theEntity.TRAVEL_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_FY",theEntity.TRAVEL_FY));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID",theEntity.DRIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_MAIN_PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_MAIN_PERSON",theEntity.TVL_MAIN_PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_MAIN_CONTACTNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_MAIN_CONTACTNO",theEntity.TVL_MAIN_CONTACTNO));
	
			if(!string.IsNullOrEmpty(theEntity.TV_MAIN_MOBILENO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TV_MAIN_MOBILENO",theEntity.TV_MAIN_MOBILENO));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_MAIN_CALLSIGN))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_MAIN_CALLSIGN",theEntity.TVL_MAIN_CALLSIGN));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REASON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REASON",theEntity.TVL_REASON));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_TYPE",theEntity.TVL_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_DEMAND_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_DEMAND_BY",theEntity.TVL_REF_DEMAND_BY));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_DEMAND_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_DEMAND_OFFICE",theEntity.TVL_REF_DEMAND_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_DEMAND_DIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_DEMAND_DIS",theEntity.TVL_REF_DEMAND_DIS));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_APPROVE_BY",theEntity.TVL_REF_APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_APPROVE_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_APPROVE_OFFICE",theEntity.TVL_REF_APPROVE_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_APPROVE_DIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_APPROVE_DIS",theEntity.TVL_REF_APPROVE_DIS));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_APPROVE_BY",theEntity.TVL_APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_APPROVE_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_APPROVE_OFFICE",theEntity.TVL_APPROVE_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_APPROVE_DIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_APPROVE_DIS",theEntity.TVL_APPROVE_DIS));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_COMPLITION_DETAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_COMPLITION_DETAIL",theEntity.TVL_COMPLITION_DETAIL));

            if (!string.IsNullOrEmpty(theEntity.FUEL_SOURCE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_SOURCE", theEntity.FUEL_SOURCE));

            if (!string.IsNullOrEmpty(theEntity.FUEL_QUANTITY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_QUANTITY", theEntity.FUEL_QUANTITY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            MOVEMENT_OF_VEHICLE theEntity = (MOVEMENT_OF_VEHICLE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_NUMBER",theEntity.TRAVEL_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_DAY",theEntity.TRAVEL_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_MONTH",theEntity.TRAVEL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_YEAR",theEntity.TRAVEL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_DATE",theEntity.TRAVEL_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_FY",theEntity.TRAVEL_FY));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID",theEntity.DRIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_MAIN_PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_MAIN_PERSON",theEntity.TVL_MAIN_PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_MAIN_CONTACTNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_MAIN_CONTACTNO",theEntity.TVL_MAIN_CONTACTNO));
	
			if(!string.IsNullOrEmpty(theEntity.TV_MAIN_MOBILENO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TV_MAIN_MOBILENO",theEntity.TV_MAIN_MOBILENO));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_MAIN_CALLSIGN))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_MAIN_CALLSIGN",theEntity.TVL_MAIN_CALLSIGN));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REASON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REASON",theEntity.TVL_REASON));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_TYPE",theEntity.TVL_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_DEMAND_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_DEMAND_BY",theEntity.TVL_REF_DEMAND_BY));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_DEMAND_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_DEMAND_OFFICE",theEntity.TVL_REF_DEMAND_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_DEMAND_DIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_DEMAND_DIS",theEntity.TVL_REF_DEMAND_DIS));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_APPROVE_BY",theEntity.TVL_REF_APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_APPROVE_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_APPROVE_OFFICE",theEntity.TVL_REF_APPROVE_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_APPROVE_DIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_APPROVE_DIS",theEntity.TVL_REF_APPROVE_DIS));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_APPROVE_BY",theEntity.TVL_APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_APPROVE_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_APPROVE_OFFICE",theEntity.TVL_APPROVE_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_APPROVE_DIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_APPROVE_DIS",theEntity.TVL_APPROVE_DIS));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_COMPLITION_DETAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_COMPLITION_DETAIL",theEntity.TVL_COMPLITION_DETAIL));

            if (!string.IsNullOrEmpty(theEntity.FUEL_SOURCE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_SOURCE", theEntity.FUEL_SOURCE));

            if (!string.IsNullOrEmpty(theEntity.FUEL_QUANTITY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_QUANTITY", theEntity.FUEL_QUANTITY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            MOVEMENT_OF_VEHICLE theEntity = (MOVEMENT_OF_VEHICLE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_NUMBER",theEntity.TRAVEL_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_DAY",theEntity.TRAVEL_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_MONTH",theEntity.TRAVEL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_YEAR",theEntity.TRAVEL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_DATE",theEntity.TRAVEL_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_FY",theEntity.TRAVEL_FY));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID",theEntity.DRIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_MAIN_PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_MAIN_PERSON",theEntity.TVL_MAIN_PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_MAIN_CONTACTNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_MAIN_CONTACTNO",theEntity.TVL_MAIN_CONTACTNO));
	
			if(!string.IsNullOrEmpty(theEntity.TV_MAIN_MOBILENO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TV_MAIN_MOBILENO",theEntity.TV_MAIN_MOBILENO));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_MAIN_CALLSIGN))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_MAIN_CALLSIGN",theEntity.TVL_MAIN_CALLSIGN));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REASON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REASON",theEntity.TVL_REASON));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_TYPE",theEntity.TVL_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_DEMAND_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_DEMAND_BY",theEntity.TVL_REF_DEMAND_BY));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_DEMAND_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_DEMAND_OFFICE",theEntity.TVL_REF_DEMAND_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_DEMAND_DIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_DEMAND_DIS",theEntity.TVL_REF_DEMAND_DIS));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_APPROVE_BY",theEntity.TVL_REF_APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_APPROVE_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_APPROVE_OFFICE",theEntity.TVL_REF_APPROVE_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_APPROVE_DIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_APPROVE_DIS",theEntity.TVL_REF_APPROVE_DIS));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_APPROVE_BY",theEntity.TVL_APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_APPROVE_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_APPROVE_OFFICE",theEntity.TVL_APPROVE_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_APPROVE_DIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_APPROVE_DIS",theEntity.TVL_APPROVE_DIS));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_COMPLITION_DETAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_COMPLITION_DETAIL",theEntity.TVL_COMPLITION_DETAIL));

            if (!string.IsNullOrEmpty(theEntity.FUEL_SOURCE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_SOURCE", theEntity.FUEL_SOURCE));

            if (!string.IsNullOrEmpty(theEntity.FUEL_QUANTITY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_QUANTITY", theEntity.FUEL_QUANTITY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            MOVEMENT_OF_VEHICLE theEntity = (MOVEMENT_OF_VEHICLE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_NUMBER",theEntity.TRAVEL_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_DAY",theEntity.TRAVEL_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_MONTH",theEntity.TRAVEL_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_YEAR",theEntity.TRAVEL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_DATE",theEntity.TRAVEL_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.TRAVEL_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRAVEL_FY",theEntity.TRAVEL_FY));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO",theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID",theEntity.DRIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_MAIN_PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_MAIN_PERSON",theEntity.TVL_MAIN_PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_MAIN_CONTACTNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_MAIN_CONTACTNO",theEntity.TVL_MAIN_CONTACTNO));
	
			if(!string.IsNullOrEmpty(theEntity.TV_MAIN_MOBILENO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TV_MAIN_MOBILENO",theEntity.TV_MAIN_MOBILENO));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_MAIN_CALLSIGN))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_MAIN_CALLSIGN",theEntity.TVL_MAIN_CALLSIGN));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REASON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REASON",theEntity.TVL_REASON));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_TYPE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_TYPE",theEntity.TVL_TYPE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_DEMAND_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_DEMAND_BY",theEntity.TVL_REF_DEMAND_BY));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_DEMAND_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_DEMAND_OFFICE",theEntity.TVL_REF_DEMAND_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_DEMAND_DIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_DEMAND_DIS",theEntity.TVL_REF_DEMAND_DIS));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_APPROVE_BY",theEntity.TVL_REF_APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_APPROVE_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_APPROVE_OFFICE",theEntity.TVL_REF_APPROVE_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_REF_APPROVE_DIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_REF_APPROVE_DIS",theEntity.TVL_REF_APPROVE_DIS));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_APPROVE_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_APPROVE_BY",theEntity.TVL_APPROVE_BY));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_APPROVE_OFFICE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_APPROVE_OFFICE",theEntity.TVL_APPROVE_OFFICE));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_APPROVE_DIS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_APPROVE_DIS",theEntity.TVL_APPROVE_DIS));
	
			if(!string.IsNullOrEmpty(theEntity.TVL_COMPLITION_DETAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TVL_COMPLITION_DETAIL",theEntity.TVL_COMPLITION_DETAIL));

            if (!string.IsNullOrEmpty(theEntity.FUEL_SOURCE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_SOURCE", theEntity.FUEL_SOURCE));

            if (!string.IsNullOrEmpty(theEntity.FUEL_QUANTITY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FUEL_QUANTITY", theEntity.FUEL_QUANTITY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	