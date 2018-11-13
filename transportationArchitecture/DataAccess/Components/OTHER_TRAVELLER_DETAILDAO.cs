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
    public class OTHER_TRAVELLER_DETAILDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public OTHER_TRAVELLER_DETAILDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTOTHER_TRAVELLER_DETAIL";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYOTHER_TRAVELLER_DETAIL";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYOTHER_TRAVELLER_DETAIL";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYOTHER_TRAVELLER_DETAIL";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			OTHER_TRAVELLER_DETAIL theEntity = new OTHER_TRAVELLER_DETAIL();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.MOVEMENT_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.SNO = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.PERSON = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.RELATION = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.GOODS_CARRIED = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.QTY = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            OTHER_TRAVELLER_DETAIL theEntity = (OTHER_TRAVELLER_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MOVEMENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOVEMENT_ID",theEntity.MOVEMENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PERSON",theEntity.PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.RELATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RELATION",theEntity.RELATION));
	
			if(!string.IsNullOrEmpty(theEntity.GOODS_CARRIED))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GOODS_CARRIED",theEntity.GOODS_CARRIED));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            OTHER_TRAVELLER_DETAIL theEntity = (OTHER_TRAVELLER_DETAIL)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MOVEMENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOVEMENT_ID",theEntity.MOVEMENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PERSON",theEntity.PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.RELATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RELATION",theEntity.RELATION));
	
			if(!string.IsNullOrEmpty(theEntity.GOODS_CARRIED))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GOODS_CARRIED",theEntity.GOODS_CARRIED));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            OTHER_TRAVELLER_DETAIL theEntity = (OTHER_TRAVELLER_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MOVEMENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOVEMENT_ID",theEntity.MOVEMENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PERSON",theEntity.PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.RELATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RELATION",theEntity.RELATION));
	
			if(!string.IsNullOrEmpty(theEntity.GOODS_CARRIED))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GOODS_CARRIED",theEntity.GOODS_CARRIED));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            OTHER_TRAVELLER_DETAIL theEntity = (OTHER_TRAVELLER_DETAIL)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.MOVEMENT_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_MOVEMENT_ID",theEntity.MOVEMENT_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.PERSON))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PERSON",theEntity.PERSON));
	
			if(!string.IsNullOrEmpty(theEntity.RELATION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_RELATION",theEntity.RELATION));
	
			if(!string.IsNullOrEmpty(theEntity.GOODS_CARRIED))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_GOODS_CARRIED",theEntity.GOODS_CARRIED));
	
			if(!string.IsNullOrEmpty(theEntity.QTY))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_QTY",theEntity.QTY));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	