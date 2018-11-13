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
    public class NEXT_SERVICE_SUGGESTIONDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public NEXT_SERVICE_SUGGESTIONDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTNEXT_SERVICE_SUGGESTION";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYNEXT_SERVICE_SUGGESTION";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYNEXT_SERVICE_SUGGESTION";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYNEXT_SERVICE_SUGGESTION";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			NEXT_SERVICE_SUGGESTION theEntity = new NEXT_SERVICE_SUGGESTION();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.NEXT_SERVICE_ID = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.SERVICE_SUGGESTION = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            NEXT_SERVICE_SUGGESTION theEntity = (NEXT_SERVICE_SUGGESTION)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SERVICE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SERVICE_ID",theEntity.NEXT_SERVICE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SERVICE_SUGGESTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SERVICE_SUGGESTION",theEntity.SERVICE_SUGGESTION));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            NEXT_SERVICE_SUGGESTION theEntity = (NEXT_SERVICE_SUGGESTION)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SERVICE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SERVICE_ID",theEntity.NEXT_SERVICE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SERVICE_SUGGESTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SERVICE_SUGGESTION",theEntity.SERVICE_SUGGESTION));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            NEXT_SERVICE_SUGGESTION theEntity = (NEXT_SERVICE_SUGGESTION)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SERVICE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SERVICE_ID",theEntity.NEXT_SERVICE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SERVICE_SUGGESTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SERVICE_SUGGESTION",theEntity.SERVICE_SUGGESTION));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            NEXT_SERVICE_SUGGESTION theEntity = (NEXT_SERVICE_SUGGESTION)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.NEXT_SERVICE_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_NEXT_SERVICE_ID",theEntity.NEXT_SERVICE_ID));
	
			if(!string.IsNullOrEmpty(theEntity.SERVICE_SUGGESTION))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_SERVICE_SUGGESTION",theEntity.SERVICE_SUGGESTION));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	