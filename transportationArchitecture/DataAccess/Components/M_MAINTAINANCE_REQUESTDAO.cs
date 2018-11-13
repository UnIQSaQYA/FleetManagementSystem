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
    public class M_MAINTAINANCE_REQUESTDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public M_MAINTAINANCE_REQUESTDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTM_MAINTAINANCE_REQUEST";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_MAINTAINANCE_REQUEST";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_MAINTAINANCE_REQUEST";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_MAINTAINANCE_REQUEST";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			M_MAINTAINANCE_REQUEST theEntity = new M_MAINTAINANCE_REQUEST();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.JOB_CARD_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.SNO = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.DESCRIPTION = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            M_MAINTAINANCE_REQUEST theEntity = (M_MAINTAINANCE_REQUEST)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_CARD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_CARD_ID",theEntity.JOB_CARD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESCRIPTION",theEntity.DESCRIPTION));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            M_MAINTAINANCE_REQUEST theEntity = (M_MAINTAINANCE_REQUEST)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_CARD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_CARD_ID",theEntity.JOB_CARD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESCRIPTION",theEntity.DESCRIPTION));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            M_MAINTAINANCE_REQUEST theEntity = (M_MAINTAINANCE_REQUEST)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_CARD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_CARD_ID",theEntity.JOB_CARD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESCRIPTION",theEntity.DESCRIPTION));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            M_MAINTAINANCE_REQUEST theEntity = (M_MAINTAINANCE_REQUEST)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.JOB_CARD_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_JOB_CARD_ID",theEntity.JOB_CARD_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SNO))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SNO",theEntity.SNO));
	
			if(!string.IsNullOrEmpty(theEntity.DESCRIPTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DESCRIPTION",theEntity.DESCRIPTION));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	