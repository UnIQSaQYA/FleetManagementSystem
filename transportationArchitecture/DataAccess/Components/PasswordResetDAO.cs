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
    public class PasswordResetDAO : DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public PasswordResetDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.SELECTPASSWORD_RESET";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPASSWORD_RESET";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPASSWORD_RESET";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.MODIFYPASSWORD_RESET";
            }
        }
        #endregion

        #region Overridden Methods

        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
            PasswordReset theEntity = new PasswordReset();

        
            theEntity.EMPLOYEE_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
            theEntity.CONFIRMATION_CODE = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
         
           
            
            return theEntity; 
        }

        protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            PasswordReset theEntity = (PasswordReset)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();

          
            if (!string.IsNullOrEmpty(theEntity.EMPLOYEE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("var_EMPLOYEE_ID", theEntity.EMPLOYEE_ID));

            if (!string.IsNullOrEmpty(theEntity.CONFIRMATION_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("var_CONFIRMATION_CODE", theEntity.CONFIRMATION_CODE));

           

             

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));

            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            PasswordReset theEntity = (PasswordReset)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", "i"));

            if (!string.IsNullOrEmpty(theEntity.EMPLOYEE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("var_EMPLOYEE_ID", theEntity.EMPLOYEE_ID));

            if (!string.IsNullOrEmpty(theEntity.CONFIRMATION_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("var_CONFIRMATION_CODE", theEntity.CONFIRMATION_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            PasswordReset theEntity = (PasswordReset)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", "u"));

            if (!string.IsNullOrEmpty(theEntity.EMPLOYEE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("var_EMPLOYEE_ID", theEntity.EMPLOYEE_ID));

            if (!string.IsNullOrEmpty(theEntity.CONFIRMATION_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("var_CONFIRMATION_CODE", theEntity.CONFIRMATION_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            PasswordReset theEntity = (PasswordReset)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", "d"));

            if (!string.IsNullOrEmpty(theEntity.EMPLOYEE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("var_EMPLOYEE_ID", theEntity.EMPLOYEE_ID));

            if (!string.IsNullOrEmpty(theEntity.CONFIRMATION_CODE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("var_CONFIRMATION_CODE", theEntity.CONFIRMATION_CODE));

            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
            return cmdParams.ToArray();
        }

 
        #endregion
    }
}
