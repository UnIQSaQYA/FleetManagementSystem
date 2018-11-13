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
    public class REPAIR_ORDER_DETAILDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public REPAIR_ORDER_DETAILDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTREPAIR_ORDER_DETAIL";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYREPAIR_ORDER_DETAIL";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYREPAIR_ORDER_DETAIL";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYREPAIR_ORDER_DETAIL";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			REPAIR_ORDER_DETAIL theEntity = new REPAIR_ORDER_DETAIL();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.REPAIR_ORDER_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.SNO = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.PARTICULAR = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.QTY = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.UNIT = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.RATE = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.AMOUNT = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.REMARKS = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;

            theEntity.PARTICULAR_TYPE = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            REPAIR_ORDER_DETAIL theEntity = (REPAIR_ORDER_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_ID",theEntity.REPAIR_ORDER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PARTICULAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTICULAR",theEntity.PARTICULAR));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.AMOUNT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AMOUNT",theEntity.AMOUNT));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.PARTICULAR_TYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTICULAR_TYPE", theEntity.PARTICULAR_TYPE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            REPAIR_ORDER_DETAIL theEntity = (REPAIR_ORDER_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_ID",theEntity.REPAIR_ORDER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PARTICULAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTICULAR",theEntity.PARTICULAR));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.AMOUNT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AMOUNT",theEntity.AMOUNT));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.PARTICULAR_TYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTICULAR_TYPE", theEntity.PARTICULAR_TYPE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            REPAIR_ORDER_DETAIL theEntity = (REPAIR_ORDER_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_ID",theEntity.REPAIR_ORDER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PARTICULAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTICULAR",theEntity.PARTICULAR));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.AMOUNT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AMOUNT",theEntity.AMOUNT));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.PARTICULAR_TYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTICULAR_TYPE", theEntity.PARTICULAR_TYPE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            REPAIR_ORDER_DETAIL theEntity = (REPAIR_ORDER_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.REPAIR_ORDER_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REPAIR_ORDER_ID",theEntity.REPAIR_ORDER_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PARTICULAR))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTICULAR",theEntity.PARTICULAR));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));
	
			if(!string.IsNullOrEmpty(theEntity.UNIT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_UNIT",theEntity.UNIT));
	
			if(!string.IsNullOrEmpty(theEntity.RATE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RATE",theEntity.RATE));
	
			if(!string.IsNullOrEmpty(theEntity.AMOUNT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_AMOUNT",theEntity.AMOUNT));
	
			if(!string.IsNullOrEmpty(theEntity.REMARKS))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_REMARKS",theEntity.REMARKS));

            if (!string.IsNullOrEmpty(theEntity.PARTICULAR_TYPE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARTICULAR_TYPE", theEntity.PARTICULAR_TYPE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	