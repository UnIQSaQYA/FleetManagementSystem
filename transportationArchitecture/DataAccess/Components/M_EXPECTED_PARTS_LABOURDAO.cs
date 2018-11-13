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
    public class M_EXPECTED_PARTS_LABOURDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public M_EXPECTED_PARTS_LABOURDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTM_EXPECTED_PARTS_LABOUR";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_EXPECTED_PARTS_LABOUR";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_EXPECTED_PARTS_LABOUR";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_EXPECTED_PARTS_LABOUR";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			M_EXPECTED_PARTS_LABOUR theEntity = new M_EXPECTED_PARTS_LABOUR();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.JOB_CARD_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.SNO = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.PARTS_LABOUR = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.PARTS_LABOUR_ID = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.REQUIRED_QTY = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.ESTIMATED_RATE = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.REMARKS = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            M_EXPECTED_PARTS_LABOUR theEntity = (M_EXPECTED_PARTS_LABOUR)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_CARD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_CARD_ID",theEntity.JOB_CARD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR",theEntity.PARTS_LABOUR));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR_ID",theEntity.PARTS_LABOUR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REQUIRED_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REQUIRED_QTY",theEntity.REQUIRED_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.ESTIMATED_RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATED_RATE",theEntity.ESTIMATED_RATE));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            M_EXPECTED_PARTS_LABOUR theEntity = (M_EXPECTED_PARTS_LABOUR)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_CARD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_CARD_ID",theEntity.JOB_CARD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR",theEntity.PARTS_LABOUR));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR_ID",theEntity.PARTS_LABOUR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REQUIRED_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REQUIRED_QTY",theEntity.REQUIRED_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.ESTIMATED_RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATED_RATE",theEntity.ESTIMATED_RATE));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            M_EXPECTED_PARTS_LABOUR theEntity = (M_EXPECTED_PARTS_LABOUR)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_CARD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_CARD_ID",theEntity.JOB_CARD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR",theEntity.PARTS_LABOUR));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR_ID",theEntity.PARTS_LABOUR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REQUIRED_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REQUIRED_QTY",theEntity.REQUIRED_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.ESTIMATED_RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATED_RATE",theEntity.ESTIMATED_RATE));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            M_EXPECTED_PARTS_LABOUR theEntity = (M_EXPECTED_PARTS_LABOUR)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_CARD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_CARD_ID",theEntity.JOB_CARD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR",theEntity.PARTS_LABOUR));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR_ID",theEntity.PARTS_LABOUR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REQUIRED_QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REQUIRED_QTY",theEntity.REQUIRED_QTY));
	
			if(!string.IsNullOrEmpty(theEntity.ESTIMATED_RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATED_RATE",theEntity.ESTIMATED_RATE));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	