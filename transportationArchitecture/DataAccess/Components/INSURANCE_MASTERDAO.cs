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
    public class INSURANCE_MASTERDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public INSURANCE_MASTERDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTINSURANCE_MASTER";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYINSURANCE_MASTER";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYINSURANCE_MASTER";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYINSURANCE_MASTER";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			INSURANCE_MASTER theEntity = new INSURANCE_MASTER();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.INSURANCE_COMPANY = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.ADDRESS = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.CONTACT_NUMBER = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.WEB_SITE = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.EMAIL = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.CONTACT_PERSON = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.CONTACT_PERSON_MOBILE = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            INSURANCE_MASTER theEntity = (INSURANCE_MASTER)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.INSURANCE_COMPANY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_COMPANY",theEntity.INSURANCE_COMPANY));
	
			if(!string.IsNullOrEmpty(theEntity.ADDRESS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS",theEntity.ADDRESS));
	
			if(!string.IsNullOrEmpty(theEntity.CONTACT_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_NUMBER",theEntity.CONTACT_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.WEB_SITE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WEB_SITE",theEntity.WEB_SITE));
	
			if(!string.IsNullOrEmpty(theEntity.EMAIL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EMAIL",theEntity.EMAIL));
	
			if(!string.IsNullOrEmpty(theEntity.CONTACT_PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON",theEntity.CONTACT_PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.CONTACT_PERSON_MOBILE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON_MOBILE",theEntity.CONTACT_PERSON_MOBILE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            INSURANCE_MASTER theEntity = (INSURANCE_MASTER)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_COMPANY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_COMPANY", theEntity.INSURANCE_COMPANY));

            if (!string.IsNullOrEmpty(theEntity.ADDRESS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS", theEntity.ADDRESS));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_NUMBER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_NUMBER", theEntity.CONTACT_NUMBER));

            if (!string.IsNullOrEmpty(theEntity.WEB_SITE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WEB_SITE", theEntity.WEB_SITE));

            if (!string.IsNullOrEmpty(theEntity.EMAIL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EMAIL", theEntity.EMAIL));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_PERSON))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON", theEntity.CONTACT_PERSON));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_PERSON_MOBILE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON_MOBILE", theEntity.CONTACT_PERSON_MOBILE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            INSURANCE_MASTER theEntity = (INSURANCE_MASTER)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_COMPANY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_COMPANY", theEntity.INSURANCE_COMPANY));

            if (!string.IsNullOrEmpty(theEntity.ADDRESS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS", theEntity.ADDRESS));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_NUMBER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_NUMBER", theEntity.CONTACT_NUMBER));

            if (!string.IsNullOrEmpty(theEntity.WEB_SITE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WEB_SITE", theEntity.WEB_SITE));

            if (!string.IsNullOrEmpty(theEntity.EMAIL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EMAIL", theEntity.EMAIL));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_PERSON))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON", theEntity.CONTACT_PERSON));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_PERSON_MOBILE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON_MOBILE", theEntity.CONTACT_PERSON_MOBILE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            INSURANCE_MASTER theEntity = (INSURANCE_MASTER)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.INSURANCE_COMPANY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INSURANCE_COMPANY", theEntity.INSURANCE_COMPANY));

            if (!string.IsNullOrEmpty(theEntity.ADDRESS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ADDRESS", theEntity.ADDRESS));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_NUMBER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_NUMBER", theEntity.CONTACT_NUMBER));

            if (!string.IsNullOrEmpty(theEntity.WEB_SITE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_WEB_SITE", theEntity.WEB_SITE));

            if (!string.IsNullOrEmpty(theEntity.EMAIL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_EMAIL", theEntity.EMAIL));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_PERSON))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON", theEntity.CONTACT_PERSON));

            if (!string.IsNullOrEmpty(theEntity.CONTACT_PERSON_MOBILE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CONTACT_PERSON_MOBILE", theEntity.CONTACT_PERSON_MOBILE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
            return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	