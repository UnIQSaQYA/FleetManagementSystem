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
    public class VECHICLE_ACCIDENTDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public VECHICLE_ACCIDENTDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTVECHICLE_ACCIDENT";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVECHICLE_ACCIDENT";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVECHICLE_ACCIDENT";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVECHICLE_ACCIDENT";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			VECHICLE_ACCIDENT theEntity = new VECHICLE_ACCIDENT();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VEHICLE_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.ACCIDENT_TYPE_ID = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.ACCIDENT_DAY = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.ACCIDENT_MONTH = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.ACCIDENT_YEAR = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.ACCIDENT_PLACE = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.ACCIDENT_DETAIL = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.DRIVER_ID = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;

            theEntity.OFFICE_CODE = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;

            theEntity.ACCIDENT_NO = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;

            theEntity.ACCIDENT_FISCAL_YEAR = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;

			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            VECHICLE_ACCIDENT theEntity = (VECHICLE_ACCIDENT)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID",theEntity.VEHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCIDENT_TYPE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_TYPE_ID",theEntity.ACCIDENT_TYPE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCIDENT_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_DAY",theEntity.ACCIDENT_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ACCIDENT_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_MONTH",theEntity.ACCIDENT_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ACCIDENT_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_YEAR",theEntity.ACCIDENT_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ACCIDENT_PLACE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_PLACE",theEntity.ACCIDENT_PLACE));
	
			if(!string.IsNullOrEmpty(theEntity.ACCIDENT_DETAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_DETAIL",theEntity.ACCIDENT_DETAIL));
	
			if(!string.IsNullOrEmpty(theEntity.DRIVER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID",theEntity.DRIVER_ID));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_NO", theEntity.ACCIDENT_NO));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_FISCAL_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_FISCAL_YEAR", theEntity.ACCIDENT_FISCAL_YEAR));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            VECHICLE_ACCIDENT theEntity = (VECHICLE_ACCIDENT)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID", theEntity.VEHICLE_ID));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_TYPE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_TYPE_ID", theEntity.ACCIDENT_TYPE_ID));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_DAY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_DAY", theEntity.ACCIDENT_DAY));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_MONTH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_MONTH", theEntity.ACCIDENT_MONTH));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_YEAR", theEntity.ACCIDENT_YEAR));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_PLACE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_PLACE", theEntity.ACCIDENT_PLACE));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_DETAIL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_DETAIL", theEntity.ACCIDENT_DETAIL));

            if (!string.IsNullOrEmpty(theEntity.DRIVER_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID", theEntity.DRIVER_ID));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_NO", theEntity.ACCIDENT_NO));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_FISCAL_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_FISCAL_YEAR", theEntity.ACCIDENT_FISCAL_YEAR));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            VECHICLE_ACCIDENT theEntity = (VECHICLE_ACCIDENT)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID", theEntity.VEHICLE_ID));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_TYPE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_TYPE_ID", theEntity.ACCIDENT_TYPE_ID));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_DAY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_DAY", theEntity.ACCIDENT_DAY));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_MONTH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_MONTH", theEntity.ACCIDENT_MONTH));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_YEAR", theEntity.ACCIDENT_YEAR));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_PLACE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_PLACE", theEntity.ACCIDENT_PLACE));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_DETAIL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_DETAIL", theEntity.ACCIDENT_DETAIL));

            if (!string.IsNullOrEmpty(theEntity.DRIVER_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID", theEntity.DRIVER_ID));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_NO", theEntity.ACCIDENT_NO));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_FISCAL_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_FISCAL_YEAR", theEntity.ACCIDENT_FISCAL_YEAR));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            VECHICLE_ACCIDENT theEntity = (VECHICLE_ACCIDENT)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_ID", theEntity.VEHICLE_ID));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_TYPE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_TYPE_ID", theEntity.ACCIDENT_TYPE_ID));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_DAY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_DAY", theEntity.ACCIDENT_DAY));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_MONTH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_MONTH", theEntity.ACCIDENT_MONTH));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_YEAR", theEntity.ACCIDENT_YEAR));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_PLACE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_PLACE", theEntity.ACCIDENT_PLACE));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_DETAIL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_DETAIL", theEntity.ACCIDENT_DETAIL));

            if (!string.IsNullOrEmpty(theEntity.DRIVER_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DRIVER_ID", theEntity.DRIVER_ID));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_NO", theEntity.ACCIDENT_NO));

            if (!string.IsNullOrEmpty(theEntity.ACCIDENT_FISCAL_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCIDENT_FISCAL_YEAR", theEntity.ACCIDENT_FISCAL_YEAR));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	