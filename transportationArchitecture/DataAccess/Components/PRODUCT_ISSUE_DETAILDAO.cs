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
    public class PRODUCT_ISSUE_DETAILDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public PRODUCT_ISSUE_DETAILDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTPRODUCT_ISSUE_DETAIL";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_ISSUE_DETAIL";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_ISSUE_DETAIL";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPRODUCT_ISSUE_DETAIL";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			PRODUCT_ISSUE_DETAIL theEntity = new PRODUCT_ISSUE_DETAIL();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.PRODUCT_ISSUE_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.SNO = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.LFONO = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.PRODUCT_ID = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.QTY = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.UNIT = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.INITIAL_RECEIVED_DATE = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.REMARKS = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;

            theEntity.BATCH_NO = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;

            theEntity.OFFICE_CODE = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;

			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            PRODUCT_ISSUE_DETAIL theEntity = (PRODUCT_ISSUE_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ISSUE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ISSUE_ID",theEntity.PRODUCT_ISSUE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.LFONO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LFONO",theEntity.LFONO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.INITIAL_RECEIVED_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INITIAL_RECEIVED_DATE",theEntity.INITIAL_RECEIVED_DATE));

            if (!string.IsNullOrEmpty(theEntity.REMARKS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS", theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.BATCH_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BATCH_NO", theEntity.BATCH_NO));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            PRODUCT_ISSUE_DETAIL theEntity = (PRODUCT_ISSUE_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ISSUE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ISSUE_ID",theEntity.PRODUCT_ISSUE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.LFONO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LFONO",theEntity.LFONO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.INITIAL_RECEIVED_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INITIAL_RECEIVED_DATE",theEntity.INITIAL_RECEIVED_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.BATCH_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BATCH_NO", theEntity.BATCH_NO));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            PRODUCT_ISSUE_DETAIL theEntity = (PRODUCT_ISSUE_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ISSUE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ISSUE_ID",theEntity.PRODUCT_ISSUE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.LFONO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LFONO",theEntity.LFONO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.INITIAL_RECEIVED_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INITIAL_RECEIVED_DATE",theEntity.INITIAL_RECEIVED_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.BATCH_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BATCH_NO", theEntity.BATCH_NO));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            PRODUCT_ISSUE_DETAIL theEntity = (PRODUCT_ISSUE_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ISSUE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ISSUE_ID",theEntity.PRODUCT_ISSUE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.LFONO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LFONO",theEntity.LFONO));
	
			if(!string.IsNullOrEmpty(theEntity.PRODUCT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PRODUCT_ID",theEntity.PRODUCT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.INITIAL_RECEIVED_DATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_INITIAL_RECEIVED_DATE",theEntity.INITIAL_RECEIVED_DATE));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.BATCH_NO))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_BATCH_NO", theEntity.BATCH_NO));

            if (!string.IsNullOrEmpty(theEntity.OFFICE_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_OFFICE_CODE", theEntity.OFFICE_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	