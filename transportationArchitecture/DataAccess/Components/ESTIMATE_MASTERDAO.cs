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
    public class ESTIMATE_MASTERDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public ESTIMATE_MASTERDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTESTIMATE_MASTER";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYESTIMATE_MASTER";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYESTIMATE_MASTER";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYESTIMATE_MASTER";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			ESTIMATE_MASTER theEntity = new ESTIMATE_MASTER();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.ESTIMATE_NUMBER = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.ESTIMATE_DAY = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.ESTIMATE_MONTH = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.ESTIMATE_YEAR = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.ESTIMATE_DATE = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.ESTIMATE_FY = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.PARTY_NAME = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.VEHICLE_REG_NO = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.TOTAL_PARTS = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			theEntity.TOTAL_LABOUR = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			theEntity.VAT_PARTS = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;
	
			theEntity.VAT_LABOUR = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
	
			theEntity.GRAND_TOTAL = !dr.IsDBNull(13) ? dr.GetValue(13).ToString() : string.Empty;
	
			theEntity.CUSTOMER_NAME = !dr.IsDBNull(14) ? dr.GetValue(14).ToString() : string.Empty;
	
			theEntity.AUTHORISED_PERSON = !dr.IsDBNull(15) ? dr.GetValue(15).ToString() : string.Empty;

            theEntity.VEHICLE_MODEL = !dr.IsDBNull(16) ? dr.GetValue(16).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            ESTIMATE_MASTER theEntity = (ESTIMATE_MASTER)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ESTIMATE_NUMBER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_NUMBER",theEntity.ESTIMATE_NUMBER));
	
			if(!string.IsNullOrEmpty(theEntity.ESTIMATE_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_DAY",theEntity.ESTIMATE_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.ESTIMATE_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_MONTH",theEntity.ESTIMATE_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.ESTIMATE_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_YEAR",theEntity.ESTIMATE_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.ESTIMATE_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_DATE",theEntity.ESTIMATE_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.ESTIMATE_FY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_FY",theEntity.ESTIMATE_FY));
	
			if(!string.IsNullOrEmpty(theEntity.PARTY_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTY_NAME", theEntity.PARTY_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO", theEntity.VEHICLE_REG_NO));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL_PARTS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL_PARTS",theEntity.TOTAL_PARTS));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL_LABOUR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL_LABOUR",theEntity.TOTAL_LABOUR));
	
			if(!string.IsNullOrEmpty(theEntity.VAT_PARTS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PARTS",theEntity.VAT_PARTS));
	
			if(!string.IsNullOrEmpty(theEntity.VAT_LABOUR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_LABOUR",theEntity.VAT_LABOUR));
	
			if(!string.IsNullOrEmpty(theEntity.GRAND_TOTAL))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_TOTAL",theEntity.GRAND_TOTAL));
	
			if(!string.IsNullOrEmpty(theEntity.CUSTOMER_NAME))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CUSTOMER_NAME",theEntity.CUSTOMER_NAME));
	
			if(!string.IsNullOrEmpty(theEntity.AUTHORISED_PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_PERSON",theEntity.AUTHORISED_PERSON));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_MODEL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_MODEL", theEntity.VEHICLE_MODEL));



            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            ESTIMATE_MASTER theEntity = (ESTIMATE_MASTER)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_NUMBER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_NUMBER", theEntity.ESTIMATE_NUMBER));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_DAY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_DAY", theEntity.ESTIMATE_DAY));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_MONTH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_MONTH", theEntity.ESTIMATE_MONTH));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_YEAR", theEntity.ESTIMATE_YEAR));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_DATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_DATE", theEntity.ESTIMATE_DATE));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_FY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_FY", theEntity.ESTIMATE_FY));

            if (!string.IsNullOrEmpty(theEntity.PARTY_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTY_NAME", theEntity.PARTY_NAME));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO", theEntity.VEHICLE_REG_NO));

            if (!string.IsNullOrEmpty(theEntity.TOTAL_PARTS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL_PARTS", theEntity.TOTAL_PARTS));

            if (!string.IsNullOrEmpty(theEntity.TOTAL_LABOUR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL_LABOUR", theEntity.TOTAL_LABOUR));

            if (!string.IsNullOrEmpty(theEntity.VAT_PARTS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PARTS", theEntity.VAT_PARTS));

            if (!string.IsNullOrEmpty(theEntity.VAT_LABOUR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_LABOUR", theEntity.VAT_LABOUR));

            if (!string.IsNullOrEmpty(theEntity.GRAND_TOTAL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_TOTAL", theEntity.GRAND_TOTAL));

            if (!string.IsNullOrEmpty(theEntity.CUSTOMER_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CUSTOMER_NAME", theEntity.CUSTOMER_NAME));

            if (!string.IsNullOrEmpty(theEntity.AUTHORISED_PERSON))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_PERSON", theEntity.AUTHORISED_PERSON));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_MODEL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_MODEL", theEntity.VEHICLE_MODEL));


            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            ESTIMATE_MASTER theEntity = (ESTIMATE_MASTER)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_NUMBER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_NUMBER", theEntity.ESTIMATE_NUMBER));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_DAY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_DAY", theEntity.ESTIMATE_DAY));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_MONTH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_MONTH", theEntity.ESTIMATE_MONTH));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_YEAR", theEntity.ESTIMATE_YEAR));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_DATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_DATE", theEntity.ESTIMATE_DATE));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_FY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_FY", theEntity.ESTIMATE_FY));

            if (!string.IsNullOrEmpty(theEntity.PARTY_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTY_NAME", theEntity.PARTY_NAME));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO", theEntity.VEHICLE_REG_NO));

            if (!string.IsNullOrEmpty(theEntity.TOTAL_PARTS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL_PARTS", theEntity.TOTAL_PARTS));

            if (!string.IsNullOrEmpty(theEntity.TOTAL_LABOUR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL_LABOUR", theEntity.TOTAL_LABOUR));

            if (!string.IsNullOrEmpty(theEntity.VAT_PARTS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PARTS", theEntity.VAT_PARTS));

            if (!string.IsNullOrEmpty(theEntity.VAT_LABOUR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_LABOUR", theEntity.VAT_LABOUR));

            if (!string.IsNullOrEmpty(theEntity.GRAND_TOTAL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_TOTAL", theEntity.GRAND_TOTAL));

            if (!string.IsNullOrEmpty(theEntity.CUSTOMER_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CUSTOMER_NAME", theEntity.CUSTOMER_NAME));

            if (!string.IsNullOrEmpty(theEntity.AUTHORISED_PERSON))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_PERSON", theEntity.AUTHORISED_PERSON));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_MODEL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_MODEL", theEntity.VEHICLE_MODEL));


            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            ESTIMATE_MASTER theEntity = (ESTIMATE_MASTER)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_NUMBER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_NUMBER", theEntity.ESTIMATE_NUMBER));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_DAY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_DAY", theEntity.ESTIMATE_DAY));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_MONTH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_MONTH", theEntity.ESTIMATE_MONTH));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_YEAR", theEntity.ESTIMATE_YEAR));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_DATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_DATE", theEntity.ESTIMATE_DATE));

            if (!string.IsNullOrEmpty(theEntity.ESTIMATE_FY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_FY", theEntity.ESTIMATE_FY));

            if (!string.IsNullOrEmpty(theEntity.PARTY_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTY_NAME", theEntity.PARTY_NAME));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_REG_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_REG_NO", theEntity.VEHICLE_REG_NO));

            if (!string.IsNullOrEmpty(theEntity.TOTAL_PARTS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL_PARTS", theEntity.TOTAL_PARTS));

            if (!string.IsNullOrEmpty(theEntity.TOTAL_LABOUR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL_LABOUR", theEntity.TOTAL_LABOUR));

            if (!string.IsNullOrEmpty(theEntity.VAT_PARTS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_PARTS", theEntity.VAT_PARTS));

            if (!string.IsNullOrEmpty(theEntity.VAT_LABOUR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VAT_LABOUR", theEntity.VAT_LABOUR));

            if (!string.IsNullOrEmpty(theEntity.GRAND_TOTAL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GRAND_TOTAL", theEntity.GRAND_TOTAL));

            if (!string.IsNullOrEmpty(theEntity.CUSTOMER_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_CUSTOMER_NAME", theEntity.CUSTOMER_NAME));

            if (!string.IsNullOrEmpty(theEntity.AUTHORISED_PERSON))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AUTHORISED_PERSON", theEntity.AUTHORISED_PERSON));

            if (!string.IsNullOrEmpty(theEntity.VEHICLE_MODEL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VEHICLE_MODEL", theEntity.VEHICLE_MODEL));


            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	