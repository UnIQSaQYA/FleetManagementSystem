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
    public class NAME_COMPANYDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public NAME_COMPANYDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTNAME_COMPANY";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYNAME_COMPANY";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYNAME_COMPANY";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYNAME_COMPANY";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			NAME_COMPANY theEntity = new NAME_COMPANY();
	
			theEntity.NAME = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.ADDRESS = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.MOBILE_NO = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.PHONE_NO1 = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.PHONE_NO2 = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.PHONE_NO3 = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.EMAIL = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.WEBSITE = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.FAX = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.PAN_NO = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.REG_NO = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            NAME_COMPANY theEntity = (NAME_COMPANY)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NAME",theEntity.NAME));
	
			if(!string.IsNullOrEmpty(theEntity.ADDRESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS",theEntity.ADDRESS));
	
			if(!string.IsNullOrEmpty(theEntity.MOBILE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOBILE_NO",theEntity.MOBILE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO1))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO1",theEntity.PHONE_NO1));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO2))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO2",theEntity.PHONE_NO2));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO3))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO3",theEntity.PHONE_NO3));
	
			if(!string.IsNullOrEmpty(theEntity.EMAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EMAIL",theEntity.EMAIL));
	
			if(!string.IsNullOrEmpty(theEntity.WEBSITE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WEBSITE",theEntity.WEBSITE));
	
			if(!string.IsNullOrEmpty(theEntity.FAX))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FAX",theEntity.FAX));
	
			if(!string.IsNullOrEmpty(theEntity.PAN_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PAN_NO",theEntity.PAN_NO));
	
			if(!string.IsNullOrEmpty(theEntity.REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REG_NO",theEntity.REG_NO));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            NAME_COMPANY theEntity = (NAME_COMPANY)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NAME",theEntity.NAME));
	
			if(!string.IsNullOrEmpty(theEntity.ADDRESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS",theEntity.ADDRESS));
	
			if(!string.IsNullOrEmpty(theEntity.MOBILE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOBILE_NO",theEntity.MOBILE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO1))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO1",theEntity.PHONE_NO1));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO2))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO2",theEntity.PHONE_NO2));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO3))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO3",theEntity.PHONE_NO3));
	
			if(!string.IsNullOrEmpty(theEntity.EMAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EMAIL",theEntity.EMAIL));
	
			if(!string.IsNullOrEmpty(theEntity.WEBSITE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WEBSITE",theEntity.WEBSITE));
	
			if(!string.IsNullOrEmpty(theEntity.FAX))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FAX",theEntity.FAX));
	
			if(!string.IsNullOrEmpty(theEntity.PAN_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PAN_NO",theEntity.PAN_NO));
	
			if(!string.IsNullOrEmpty(theEntity.REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REG_NO",theEntity.REG_NO));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            NAME_COMPANY theEntity = (NAME_COMPANY)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NAME",theEntity.NAME));
	
			if(!string.IsNullOrEmpty(theEntity.ADDRESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS",theEntity.ADDRESS));
	
			if(!string.IsNullOrEmpty(theEntity.MOBILE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOBILE_NO",theEntity.MOBILE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO1))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO1",theEntity.PHONE_NO1));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO2))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO2",theEntity.PHONE_NO2));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO3))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO3",theEntity.PHONE_NO3));
	
			if(!string.IsNullOrEmpty(theEntity.EMAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EMAIL",theEntity.EMAIL));
	
			if(!string.IsNullOrEmpty(theEntity.WEBSITE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WEBSITE",theEntity.WEBSITE));
	
			if(!string.IsNullOrEmpty(theEntity.FAX))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FAX",theEntity.FAX));
	
			if(!string.IsNullOrEmpty(theEntity.PAN_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PAN_NO",theEntity.PAN_NO));
	
			if(!string.IsNullOrEmpty(theEntity.REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REG_NO",theEntity.REG_NO));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            NAME_COMPANY theEntity = (NAME_COMPANY)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NAME",theEntity.NAME));
	
			if(!string.IsNullOrEmpty(theEntity.ADDRESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS",theEntity.ADDRESS));
	
			if(!string.IsNullOrEmpty(theEntity.MOBILE_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOBILE_NO",theEntity.MOBILE_NO));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO1))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO1",theEntity.PHONE_NO1));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO2))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO2",theEntity.PHONE_NO2));
	
			if(!string.IsNullOrEmpty(theEntity.PHONE_NO3))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PHONE_NO3",theEntity.PHONE_NO3));
	
			if(!string.IsNullOrEmpty(theEntity.EMAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EMAIL",theEntity.EMAIL));
	
			if(!string.IsNullOrEmpty(theEntity.WEBSITE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WEBSITE",theEntity.WEBSITE));
	
			if(!string.IsNullOrEmpty(theEntity.FAX))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FAX",theEntity.FAX));
	
			if(!string.IsNullOrEmpty(theEntity.PAN_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PAN_NO",theEntity.PAN_NO));
	
			if(!string.IsNullOrEmpty(theEntity.REG_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REG_NO",theEntity.REG_NO));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	