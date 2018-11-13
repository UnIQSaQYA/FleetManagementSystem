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
    public class CAR_RADIO_HARDWAREDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public CAR_RADIO_HARDWAREDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTCAR_RADIO_HARDWARE";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYCAR_RADIO_HARDWARE";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYCAR_RADIO_HARDWARE";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYCAR_RADIO_HARDWARE";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			CAR_RADIO_HARDWARE theEntity = new CAR_RADIO_HARDWARE();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VEHICLE_ISSUE_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.UHF_VHF_SNO = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.VERIFIED_BY = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            CAR_RADIO_HARDWARE theEntity = (CAR_RADIO_HARDWARE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ISSUE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ISSUE_ID",theEntity.VEHICLE_ISSUE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.UHF_VHF_SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UHF_VHF_SNO",theEntity.UHF_VHF_SNO));
	
			if(!string.IsNullOrEmpty(theEntity.VERIFIED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VERIFIED_BY",theEntity.VERIFIED_BY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result",""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            CAR_RADIO_HARDWARE theEntity = (CAR_RADIO_HARDWARE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ISSUE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ISSUE_ID",theEntity.VEHICLE_ISSUE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.UHF_VHF_SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UHF_VHF_SNO",theEntity.UHF_VHF_SNO));
	
			if(!string.IsNullOrEmpty(theEntity.VERIFIED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VERIFIED_BY",theEntity.VERIFIED_BY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            CAR_RADIO_HARDWARE theEntity = (CAR_RADIO_HARDWARE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ISSUE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ISSUE_ID",theEntity.VEHICLE_ISSUE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.UHF_VHF_SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UHF_VHF_SNO",theEntity.UHF_VHF_SNO));
	
			if(!string.IsNullOrEmpty(theEntity.VERIFIED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VERIFIED_BY",theEntity.VERIFIED_BY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            CAR_RADIO_HARDWARE theEntity = (CAR_RADIO_HARDWARE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ISSUE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ISSUE_ID",theEntity.VEHICLE_ISSUE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.UHF_VHF_SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UHF_VHF_SNO",theEntity.UHF_VHF_SNO));
	
			if(!string.IsNullOrEmpty(theEntity.VERIFIED_BY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VERIFIED_BY",theEntity.VERIFIED_BY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	