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
    public class M_LABOR_TYPEDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public M_LABOR_TYPEDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTM_LABOR_TYPE";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_LABOR_TYPE";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_LABOR_TYPE";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYM_LABOR_TYPE";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			M_LABOR_TYPE theEntity = new M_LABOR_TYPE();
	
			theEntity.PK_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.LABOUR_MASTER = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.PARENT = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            M_LABOR_TYPE theEntity = (M_LABOR_TYPE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.LABOUR_MASTER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LABOUR_MASTER",theEntity.LABOUR_MASTER));
	
			if(!string.IsNullOrEmpty(theEntity.PARENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARENT",theEntity.PARENT));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            M_LABOR_TYPE theEntity = (M_LABOR_TYPE)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.LABOUR_MASTER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LABOUR_MASTER",theEntity.LABOUR_MASTER));
	
			if(!string.IsNullOrEmpty(theEntity.PARENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARENT",theEntity.PARENT));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            M_LABOR_TYPE theEntity = (M_LABOR_TYPE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.LABOUR_MASTER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LABOUR_MASTER",theEntity.LABOUR_MASTER));
	
			if(!string.IsNullOrEmpty(theEntity.PARENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARENT",theEntity.PARENT));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            M_LABOR_TYPE theEntity = (M_LABOR_TYPE)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));
	
			if(!string.IsNullOrEmpty(theEntity.PK_ID))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PK_ID",theEntity.PK_ID));
	
			if(!string.IsNullOrEmpty(theEntity.LABOUR_MASTER))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_LABOUR_MASTER",theEntity.LABOUR_MASTER));
	
			if(!string.IsNullOrEmpty(theEntity.PARENT))
				cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_PARENT",theEntity.PARENT));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	