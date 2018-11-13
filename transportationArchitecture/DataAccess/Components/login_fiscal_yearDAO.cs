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
    public class login_fiscal_yearDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public login_fiscal_yearDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTLOGIN_FISCAL_YEAR";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYLOGIN_FISCAL_YEAR";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYLOGIN_FISCAL_YEAR";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYLOGIN_FISCAL_YEAR";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
            login_fiscal_year theEntity = new login_fiscal_year();
	
			theEntity.FISCAL_YEAR = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            login_fiscal_year theEntity = (login_fiscal_year)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
	
			if(!string.IsNullOrEmpty(theEntity.FISCAL_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FISCAL_YEAR", theEntity.FISCAL_YEAR));
	

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
	
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            login_fiscal_year theEntity = (login_fiscal_year)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));

            if (!string.IsNullOrEmpty(theEntity.FISCAL_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FISCAL_YEAR", theEntity.FISCAL_YEAR));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            login_fiscal_year theEntity = (login_fiscal_year)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));
            if (!string.IsNullOrEmpty(theEntity.FISCAL_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FISCAL_YEAR", theEntity.FISCAL_YEAR));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            login_fiscal_year theEntity = (login_fiscal_year)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));

            if (!string.IsNullOrEmpty(theEntity.FISCAL_YEAR))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("VAR_FISCAL_YEAR", theEntity.FISCAL_YEAR));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	