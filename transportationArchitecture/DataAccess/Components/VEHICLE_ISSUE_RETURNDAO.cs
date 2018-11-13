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
    public class VEHICLE_ISSUE_RETURNDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public VEHICLE_ISSUE_RETURNDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTVEHICLE_ISSUE_RETURN";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_ISSUE_RETURN";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_ISSUE_RETURN";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_ISSUE_RETURN";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			VEHICLE_ISSUE_RETURN theEntity = new VEHICLE_ISSUE_RETURN();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VEHICLE_ISSUE_RETURN_CODE = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.VEHICLE_ID = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.DAMAGE_DESCRIPTION = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.RETURN_BY_ID = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.RETURN_DAY = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.RETURN_MONTH = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.RETURN_YEAR = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.RETURN_DATE = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.RECEIVER_ID = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.RECEIVE_DAY = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.RECEIVE_MONTH = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.RECEIVE_YEAR = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			theEntity.RECEIVER_DATE = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;
	
			theEntity.RECEIVER_ID_COPY = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            VEHICLE_ISSUE_RETURN theEntity = (VEHICLE_ISSUE_RETURN)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ISSUE_RETURN_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ISSUE_RETURN_CODE",theEntity.VEHICLE_ISSUE_RETURN_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DAMAGE_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAMAGE_DESCRIPTION",theEntity.DAMAGE_DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_BY_ID",theEntity.RETURN_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DAY",theEntity.RETURN_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_MONTH",theEntity.RETURN_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_YEAR",theEntity.RETURN_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DATE",theEntity.RETURN_DATE));
	
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
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_ID_COPY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_ID_COPY",theEntity.RECEIVER_ID_COPY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            VEHICLE_ISSUE_RETURN theEntity = (VEHICLE_ISSUE_RETURN)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ISSUE_RETURN_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ISSUE_RETURN_CODE",theEntity.VEHICLE_ISSUE_RETURN_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DAMAGE_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAMAGE_DESCRIPTION",theEntity.DAMAGE_DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_BY_ID",theEntity.RETURN_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DAY",theEntity.RETURN_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_MONTH",theEntity.RETURN_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_YEAR",theEntity.RETURN_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DATE",theEntity.RETURN_DATE));
	
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
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_ID_COPY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_ID_COPY",theEntity.RECEIVER_ID_COPY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            VEHICLE_ISSUE_RETURN theEntity = (VEHICLE_ISSUE_RETURN)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ISSUE_RETURN_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ISSUE_RETURN_CODE",theEntity.VEHICLE_ISSUE_RETURN_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DAMAGE_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAMAGE_DESCRIPTION",theEntity.DAMAGE_DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_BY_ID",theEntity.RETURN_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DAY",theEntity.RETURN_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_MONTH",theEntity.RETURN_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_YEAR",theEntity.RETURN_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DATE",theEntity.RETURN_DATE));
	
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
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_ID_COPY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_ID_COPY",theEntity.RECEIVER_ID_COPY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            VEHICLE_ISSUE_RETURN theEntity = (VEHICLE_ISSUE_RETURN)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ISSUE_RETURN_CODE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ISSUE_RETURN_CODE",theEntity.VEHICLE_ISSUE_RETURN_CODE));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DAMAGE_DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DAMAGE_DESCRIPTION",theEntity.DAMAGE_DESCRIPTION));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_BY_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_BY_ID",theEntity.RETURN_BY_ID));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DAY",theEntity.RETURN_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_MONTH",theEntity.RETURN_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_YEAR",theEntity.RETURN_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.RETURN_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RETURN_DATE",theEntity.RETURN_DATE));
	
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
	
			if(!string.IsNullOrEmpty(theEntity.RECEIVER_ID_COPY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIVER_ID_COPY",theEntity.RECEIVER_ID_COPY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	