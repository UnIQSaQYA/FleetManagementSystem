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
    public class VEHICLE_AT_OFFICEDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public VEHICLE_AT_OFFICEDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTVEHICLE_AT_OFFICE";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_AT_OFFICE";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_AT_OFFICE";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICLE_AT_OFFICE";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			VEHICLE_AT_OFFICE theEntity = new VEHICLE_AT_OFFICE();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VEHICLE_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.OFFICE_ID = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.VAO_DATE = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.VAO_DAY = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.VAO_MONTH = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.VAO_YEAR = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.TRANSFER_PURCHASE_ID = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.TRANSFER_PURCHASE = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;

            theEntity.STATUS = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;

            theEntity.PERSON_ID = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            VEHICLE_AT_OFFICE theEntity = (VEHICLE_AT_OFFICE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_ID",theEntity.OFFICE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_DATE",theEntity.VAO_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_DAY",theEntity.VAO_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_MONTH",theEntity.VAO_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_YEAR",theEntity.VAO_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.TRANSFER_PURCHASE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRANSFER_PURCHASE_ID",theEntity.TRANSFER_PURCHASE_ID));

            if (!string.IsNullOrEmpty(theEntity.TRANSFER_PURCHASE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRANSFER_PURCHASE", theEntity.TRANSFER_PURCHASE));
	
			if(!string.IsNullOrEmpty(theEntity.STATUS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS",theEntity.STATUS));

            if (!string.IsNullOrEmpty(theEntity.PERSON_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PERSON_ID", theEntity.PERSON_ID));


            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            VEHICLE_AT_OFFICE theEntity = (VEHICLE_AT_OFFICE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_ID",theEntity.OFFICE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_DATE",theEntity.VAO_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_DAY",theEntity.VAO_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_MONTH",theEntity.VAO_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_YEAR",theEntity.VAO_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.TRANSFER_PURCHASE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRANSFER_PURCHASE_ID",theEntity.TRANSFER_PURCHASE_ID));

            if (!string.IsNullOrEmpty(theEntity.TRANSFER_PURCHASE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRANSFER_PURCHASE", theEntity.TRANSFER_PURCHASE));

            if (!string.IsNullOrEmpty(theEntity.STATUS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS", theEntity.STATUS));

            if (!string.IsNullOrEmpty(theEntity.PERSON_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PERSON_ID", theEntity.PERSON_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));


	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            VEHICLE_AT_OFFICE theEntity = (VEHICLE_AT_OFFICE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_ID",theEntity.OFFICE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_DATE",theEntity.VAO_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_DAY",theEntity.VAO_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_MONTH",theEntity.VAO_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_YEAR",theEntity.VAO_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.TRANSFER_PURCHASE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRANSFER_PURCHASE_ID",theEntity.TRANSFER_PURCHASE_ID));

            if (!string.IsNullOrEmpty(theEntity.TRANSFER_PURCHASE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRANSFER_PURCHASE", theEntity.TRANSFER_PURCHASE));

            if (!string.IsNullOrEmpty(theEntity.STATUS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS", theEntity.STATUS));

            if (!string.IsNullOrEmpty(theEntity.PERSON_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PERSON_ID", theEntity.PERSON_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            VEHICLE_AT_OFFICE theEntity = (VEHICLE_AT_OFFICE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.OFFICE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_ID",theEntity.OFFICE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_DATE",theEntity.VAO_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_DAY",theEntity.VAO_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_MONTH",theEntity.VAO_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.VAO_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAO_YEAR",theEntity.VAO_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.TRANSFER_PURCHASE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRANSFER_PURCHASE_ID",theEntity.TRANSFER_PURCHASE_ID));

            if (!string.IsNullOrEmpty(theEntity.TRANSFER_PURCHASE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TRANSFER_PURCHASE", theEntity.TRANSFER_PURCHASE));

            if (!string.IsNullOrEmpty(theEntity.STATUS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_STATUS", theEntity.STATUS));

            if (!string.IsNullOrEmpty(theEntity.PERSON_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PERSON_ID", theEntity.PERSON_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));


	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	