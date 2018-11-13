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
    public class DISPATCH_ISSUE_ACCESSORIESDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public DISPATCH_ISSUE_ACCESSORIESDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTDISPATCH_ISSUE_ACCESS";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYDISPATCH_ISSUE_ACCESS";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYDISPATCH_ISSUE_ACCESS";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYDISPATCH_ISSUE_ACCESS";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			DISPATCH_ISSUE_ACCESSORIES theEntity = new DISPATCH_ISSUE_ACCESSORIES();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.DISPATCH_ISSUE = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.DISPATCH_ISSUE_ID = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.ACCESSORIES_ID = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            DISPATCH_ISSUE_ACCESSORIES theEntity = (DISPATCH_ISSUE_ACCESSORIES)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_ISSUE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_ISSUE",theEntity.DISPATCH_ISSUE));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_ISSUE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_ISSUE_ID",theEntity.DISPATCH_ISSUE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORIES_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES_ID",theEntity.ACCESSORIES_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            DISPATCH_ISSUE_ACCESSORIES theEntity = (DISPATCH_ISSUE_ACCESSORIES)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_ISSUE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_ISSUE",theEntity.DISPATCH_ISSUE));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_ISSUE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_ISSUE_ID",theEntity.DISPATCH_ISSUE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORIES_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES_ID",theEntity.ACCESSORIES_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            DISPATCH_ISSUE_ACCESSORIES theEntity = (DISPATCH_ISSUE_ACCESSORIES)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_ISSUE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_ISSUE",theEntity.DISPATCH_ISSUE));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_ISSUE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_ISSUE_ID",theEntity.DISPATCH_ISSUE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORIES_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES_ID",theEntity.ACCESSORIES_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            DISPATCH_ISSUE_ACCESSORIES theEntity = (DISPATCH_ISSUE_ACCESSORIES)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_ISSUE))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_ISSUE",theEntity.DISPATCH_ISSUE));
	
			if(!string.IsNullOrEmpty(theEntity.DISPATCH_ISSUE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_DISPATCH_ISSUE_ID",theEntity.DISPATCH_ISSUE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.ACCESSORIES_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_ACCESSORIES_ID",theEntity.ACCESSORIES_ID));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	