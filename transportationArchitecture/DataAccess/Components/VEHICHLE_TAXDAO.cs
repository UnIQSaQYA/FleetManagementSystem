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
    public class VEHICHLE_TAXDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public VEHICHLE_TAXDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTVEHICHLE_TAX";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICHLE_TAX";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICHLE_TAX";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYVEHICHLE_TAX";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			VEHICHLE_TAX theEntity = new VEHICHLE_TAX();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.VECHICLE_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.RECEIPT_NO = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.RECEIPT_DAY = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.RECEIPT_MONTH = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.RECEIPT_YEAR = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.AMOUNT = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            VEHICHLE_TAX theEntity = (VEHICHLE_TAX)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.VECHICLE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_ID",theEntity.VECHICLE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIPT_NO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_NO",theEntity.RECEIPT_NO));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIPT_DAY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_DAY",theEntity.RECEIPT_DAY));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIPT_MONTH))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_MONTH",theEntity.RECEIPT_MONTH));
	
			if(!string.IsNullOrEmpty(theEntity.RECEIPT_YEAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_YEAR",theEntity.RECEIPT_YEAR));
	
			if(!string.IsNullOrEmpty(theEntity.AMOUNT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AMOUNT",theEntity.AMOUNT));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            VEHICHLE_TAX theEntity = (VEHICHLE_TAX)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VECHICLE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_ID", theEntity.VECHICLE_ID));

            if (!string.IsNullOrEmpty(theEntity.RECEIPT_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_NO", theEntity.RECEIPT_NO));

            if (!string.IsNullOrEmpty(theEntity.RECEIPT_DAY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_DAY", theEntity.RECEIPT_DAY));

            if (!string.IsNullOrEmpty(theEntity.RECEIPT_MONTH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_MONTH", theEntity.RECEIPT_MONTH));

            if (!string.IsNullOrEmpty(theEntity.RECEIPT_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_YEAR", theEntity.RECEIPT_YEAR));

            if (!string.IsNullOrEmpty(theEntity.AMOUNT))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AMOUNT", theEntity.AMOUNT));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            VEHICHLE_TAX theEntity = (VEHICHLE_TAX)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VECHICLE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_ID", theEntity.VECHICLE_ID));

            if (!string.IsNullOrEmpty(theEntity.RECEIPT_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_NO", theEntity.RECEIPT_NO));

            if (!string.IsNullOrEmpty(theEntity.RECEIPT_DAY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_DAY", theEntity.RECEIPT_DAY));

            if (!string.IsNullOrEmpty(theEntity.RECEIPT_MONTH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_MONTH", theEntity.RECEIPT_MONTH));

            if (!string.IsNullOrEmpty(theEntity.RECEIPT_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_YEAR", theEntity.RECEIPT_YEAR));

            if (!string.IsNullOrEmpty(theEntity.AMOUNT))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AMOUNT", theEntity.AMOUNT));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            VEHICHLE_TAX theEntity = (VEHICHLE_TAX)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));

            if (!string.IsNullOrEmpty(theEntity.PK_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID", theEntity.PK_ID));

            if (!string.IsNullOrEmpty(theEntity.VECHICLE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_VECHICLE_ID", theEntity.VECHICLE_ID));

            if (!string.IsNullOrEmpty(theEntity.RECEIPT_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_NO", theEntity.RECEIPT_NO));

            if (!string.IsNullOrEmpty(theEntity.RECEIPT_DAY))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_DAY", theEntity.RECEIPT_DAY));

            if (!string.IsNullOrEmpty(theEntity.RECEIPT_MONTH))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_MONTH", theEntity.RECEIPT_MONTH));

            if (!string.IsNullOrEmpty(theEntity.RECEIPT_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RECEIPT_YEAR", theEntity.RECEIPT_YEAR));

            if (!string.IsNullOrEmpty(theEntity.AMOUNT))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AMOUNT", theEntity.AMOUNT));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	