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
    public class ESTIMATE_DETAILDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public ESTIMATE_DETAILDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTESTIMATE_DETAIL";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYESTIMATE_DETAIL";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYESTIMATE_DETAIL";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYESTIMATE_DETAIL";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			ESTIMATE_DETAIL theEntity = new ESTIMATE_DETAIL();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.ESTIMATE_MASTER_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.SNO = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.PARTS_LABOUR = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.PARTS_LABOUR_ID = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.QTY = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.RATE = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.TOTAL_COST = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            ESTIMATE_DETAIL theEntity = (ESTIMATE_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ESTIMATE_MASTER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_MASTER_ID",theEntity.ESTIMATE_MASTER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR",theEntity.PARTS_LABOUR));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR_ID",theEntity.PARTS_LABOUR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL_COST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL_COST",theEntity.TOTAL_COST));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            ESTIMATE_DETAIL theEntity = (ESTIMATE_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ESTIMATE_MASTER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_MASTER_ID",theEntity.ESTIMATE_MASTER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR",theEntity.PARTS_LABOUR));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR_ID",theEntity.PARTS_LABOUR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL_COST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL_COST",theEntity.TOTAL_COST));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            ESTIMATE_DETAIL theEntity = (ESTIMATE_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ESTIMATE_MASTER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_MASTER_ID",theEntity.ESTIMATE_MASTER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR",theEntity.PARTS_LABOUR));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR_ID",theEntity.PARTS_LABOUR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL_COST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL_COST",theEntity.TOTAL_COST));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            ESTIMATE_DETAIL theEntity = (ESTIMATE_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ESTIMATE_MASTER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ESTIMATE_MASTER_ID",theEntity.ESTIMATE_MASTER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR",theEntity.PARTS_LABOUR));
	
			if(!string.IsNullOrEmpty(theEntity.PARTS_LABOUR_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTS_LABOUR_ID",theEntity.PARTS_LABOUR_ID));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.TOTAL_COST))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_TOTAL_COST",theEntity.TOTAL_COST));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	