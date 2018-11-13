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
    public class VEHICLE_ISSUEDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public VEHICLE_ISSUEDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTVEHICLE_ISSUE";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_ISSUE";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_ISSUE";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_ISSUE";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			VEHICLE_ISSUE theEntity = new VEHICLE_ISSUE();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VEHICLE_ISSUE_CODE = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.ISSUE_DAY = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.ISSUE_MONTH = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.ISSUE_YEAR = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.ISSUE_DATE = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.ISSUE_FISCAL_YEAR = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.VEHICLE_ID = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.ODOMETER = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.DAMAGE_DESCRIPTION = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.ISSUER_ID = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.ENTRY_DAY = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.ENTRY_MONTH = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			theEntity.ENTRY_YEAR = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;
	
			theEntity.ENTRY_DATE = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;
	
			theEntity.RECEIVER_ID = !dr.IsDBNull(15) ? dr.GetValue(15).ToString() : string.Empty;
	
			theEntity.RECEIVE_DAY = !dr.IsDBNull(16) ? dr.GetValue(16).ToString() : string.Empty;
	
			theEntity.RECEIVE_MONTH = !dr.IsDBNull(17) ? dr.GetValue(17).ToString() : string.Empty;
	
			theEntity.RECEIVE_YEAR = !dr.IsDBNull(18) ? dr.GetValue(18).ToString() : string.Empty;
	
			theEntity.RECEIVER_DATE = !dr.IsDBNull(19) ? dr.GetValue(19).ToString() : string.Empty;
	
			theEntity.VEHICLE_CHECK_BY = !dr.IsDBNull(20) ? dr.GetValue(20).ToString() : string.Empty;
	
			theEntity.RECEIVER_ID_COPY = !dr.IsDBNull(21) ? dr.GetValue(21).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            VEHICLE_ISSUE theEntity = (VEHICLE_ISSUE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ISSUE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ISSUE_CODE",theEntity.VEHICLE_ISSUE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DAY",theEntity.ISSUE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_MONTH",theEntity.ISSUE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_YEAR",theEntity.ISSUE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DATE",theEntity.ISSUE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_FISCAL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_FISCAL_YEAR",theEntity.ISSUE_FISCAL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ODOMETER",theEntity.ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.DAMAGE_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAMAGE_DESCRIPTION",theEntity.DAMAGE_DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUER_ID",theEntity.ISSUER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_DAY",theEntity.ENTRY_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_MONTH",theEntity.ENTRY_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_YEAR",theEntity.ENTRY_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_DATE",theEntity.ENTRY_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_ID",theEntity.RECEIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_DAY",theEntity.RECEIVE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_MONTH",theEntity.RECEIVE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_YEAR",theEntity.RECEIVE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_DATE",theEntity.RECEIVER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_CHECK_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_CHECK_BY",theEntity.VEHICLE_CHECK_BY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_ID_COPY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_ID_COPY",theEntity.RECEIVER_ID_COPY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            VEHICLE_ISSUE theEntity = (VEHICLE_ISSUE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ISSUE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ISSUE_CODE",theEntity.VEHICLE_ISSUE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DAY",theEntity.ISSUE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_MONTH",theEntity.ISSUE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_YEAR",theEntity.ISSUE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DATE",theEntity.ISSUE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_FISCAL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_FISCAL_YEAR",theEntity.ISSUE_FISCAL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ODOMETER",theEntity.ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.DAMAGE_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAMAGE_DESCRIPTION",theEntity.DAMAGE_DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUER_ID",theEntity.ISSUER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_DAY",theEntity.ENTRY_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_MONTH",theEntity.ENTRY_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_YEAR",theEntity.ENTRY_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_DATE",theEntity.ENTRY_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_ID",theEntity.RECEIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_DAY",theEntity.RECEIVE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_MONTH",theEntity.RECEIVE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_YEAR",theEntity.RECEIVE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_DATE",theEntity.RECEIVER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_CHECK_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_CHECK_BY",theEntity.VEHICLE_CHECK_BY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_ID_COPY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_ID_COPY",theEntity.RECEIVER_ID_COPY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            VEHICLE_ISSUE theEntity = (VEHICLE_ISSUE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ISSUE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ISSUE_CODE",theEntity.VEHICLE_ISSUE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DAY",theEntity.ISSUE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_MONTH",theEntity.ISSUE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_YEAR",theEntity.ISSUE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DATE",theEntity.ISSUE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_FISCAL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_FISCAL_YEAR",theEntity.ISSUE_FISCAL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ODOMETER",theEntity.ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.DAMAGE_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAMAGE_DESCRIPTION",theEntity.DAMAGE_DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUER_ID",theEntity.ISSUER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_DAY",theEntity.ENTRY_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_MONTH",theEntity.ENTRY_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_YEAR",theEntity.ENTRY_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_DATE",theEntity.ENTRY_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_ID",theEntity.RECEIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_DAY",theEntity.RECEIVE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_MONTH",theEntity.RECEIVE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_YEAR",theEntity.RECEIVE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_DATE",theEntity.RECEIVER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_CHECK_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_CHECK_BY",theEntity.VEHICLE_CHECK_BY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_ID_COPY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_ID_COPY",theEntity.RECEIVER_ID_COPY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            VEHICLE_ISSUE theEntity = (VEHICLE_ISSUE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ISSUE_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ISSUE_CODE",theEntity.VEHICLE_ISSUE_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DAY",theEntity.ISSUE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_MONTH",theEntity.ISSUE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_YEAR",theEntity.ISSUE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_DATE",theEntity.ISSUE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUE_FISCAL_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUE_FISCAL_YEAR",theEntity.ISSUE_FISCAL_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ODOMETER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ODOMETER",theEntity.ODOMETER));
	
			if(!string.IsNullOrEmpty(theEntity.DAMAGE_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAMAGE_DESCRIPTION",theEntity.DAMAGE_DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.ISSUER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ISSUER_ID",theEntity.ISSUER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_DAY",theEntity.ENTRY_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_MONTH",theEntity.ENTRY_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_YEAR",theEntity.ENTRY_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ENTRY_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ENTRY_DATE",theEntity.ENTRY_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_ID",theEntity.RECEIVER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_DAY",theEntity.RECEIVE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_MONTH",theEntity.RECEIVE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVE_YEAR",theEntity.RECEIVE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_DATE",theEntity.RECEIVER_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_CHECK_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_CHECK_BY",theEntity.VEHICLE_CHECK_BY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_ID_COPY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_ID_COPY",theEntity.RECEIVER_ID_COPY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	