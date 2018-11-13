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
    public class LoginDAO :DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public LoginDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.selectlogin";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.modifylogin";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.modifylogin";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.modifylogin";
            }
        }
        #endregion
	
		#region Overridden Methods
		
        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
			Login theEntity = new Login();
	
			theEntity.LOGINID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
	
			theEntity.FULLDETAILS = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
	
			theEntity.EMPLOYEEID = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
	
			theEntity.GROUPID = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
	
			theEntity.LDOLOGIN = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
	
			theEntity.PASSWORD = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
	
			theEntity.EMAIL = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;
	
			theEntity.PASSWORDQUESTION = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
	
			theEntity.PASSWORDANSWER = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
	
			theEntity.ACCESSBLOCKED = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;

            theEntity.DEFAULTMODULEID = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;
	
			return  theEntity;
		}
	
		protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            Login theEntity = (Login)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();

            if (!string.IsNullOrEmpty(theEntity.LOGINID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("LOGIN_ID", theEntity.LOGINID));

            if (!string.IsNullOrEmpty(theEntity.FULLDETAILS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("FULL_DETAILS", theEntity.FULLDETAILS));

            if (!string.IsNullOrEmpty(theEntity.EMPLOYEEID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("EMPLOYEE_ID", theEntity.EMPLOYEEID));

            if (!string.IsNullOrEmpty(theEntity.GROUPID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_ID", theEntity.GROUPID));

            if (!string.IsNullOrEmpty(theEntity.LDOLOGIN))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("LDO_LOGIN", theEntity.LDOLOGIN));

            if (!string.IsNullOrEmpty(theEntity.PASSWORD))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PASS_WORD", theEntity.PASSWORD));

            if (!string.IsNullOrEmpty(theEntity.EMAIL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("E_MAIL", theEntity.EMAIL));

            if (!string.IsNullOrEmpty(theEntity.PASSWORDQUESTION))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PASSWORD_QUESTION", theEntity.PASSWORDQUESTION));

            if (!string.IsNullOrEmpty(theEntity.PASSWORDANSWER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PASSWORD_ANSWER", theEntity.PASSWORDANSWER));

            if (!string.IsNullOrEmpty(theEntity.ACCESSBLOCKED))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("ACCESS_BLOCKED", theEntity.ACCESSBLOCKED));

            if (!string.IsNullOrEmpty(theEntity.DEFAULTMODULEID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("DEFAULT_MODULEID", theEntity.DEFAULTMODULEID));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));
            return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            Login theEntity = (Login)anEntity;
			List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","i"));

            if (!string.IsNullOrEmpty(theEntity.LOGINID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("LOGIN_ID", theEntity.LOGINID));

            if (!string.IsNullOrEmpty(theEntity.FULLDETAILS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("FULL_DETAILS", theEntity.FULLDETAILS));

            if (!string.IsNullOrEmpty(theEntity.EMPLOYEEID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("EMPLOYEE_ID", theEntity.EMPLOYEEID));

            if (!string.IsNullOrEmpty(theEntity.GROUPID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_ID", theEntity.GROUPID));

            if (!string.IsNullOrEmpty(theEntity.LDOLOGIN))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("LDO_LOGIN", theEntity.LDOLOGIN));

            if (!string.IsNullOrEmpty(theEntity.PASSWORD))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PASS_WORD", theEntity.PASSWORD));

            if (!string.IsNullOrEmpty(theEntity.EMAIL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("E_MAIL", theEntity.EMAIL));

            if (!string.IsNullOrEmpty(theEntity.PASSWORDQUESTION))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PASSWORD_QUESTION", theEntity.PASSWORDQUESTION));

            if (!string.IsNullOrEmpty(theEntity.PASSWORDANSWER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PASSWORD_ANSWER", theEntity.PASSWORDANSWER));

            if (!string.IsNullOrEmpty(theEntity.ACCESSBLOCKED))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("ACCESS_BLOCKED", theEntity.ACCESSBLOCKED));

            if (!string.IsNullOrEmpty(theEntity.DEFAULTMODULEID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("DEFAULT_MODULEID", theEntity.DEFAULTMODULEID));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            Login theEntity = (Login)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","u"));

            if (!string.IsNullOrEmpty(theEntity.LOGINID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("LOGIN_ID", theEntity.LOGINID));

            if (!string.IsNullOrEmpty(theEntity.FULLDETAILS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("FULL_DETAILS", theEntity.FULLDETAILS));

            if (!string.IsNullOrEmpty(theEntity.EMPLOYEEID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("EMPLOYEE_ID", theEntity.EMPLOYEEID));

            if (!string.IsNullOrEmpty(theEntity.GROUPID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_ID", theEntity.GROUPID));

            if (!string.IsNullOrEmpty(theEntity.LDOLOGIN))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("LDO_LOGIN", theEntity.LDOLOGIN));

            if (!string.IsNullOrEmpty(theEntity.PASSWORD))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PASS_WORD", theEntity.PASSWORD));

            if (!string.IsNullOrEmpty(theEntity.EMAIL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("E_MAIL", theEntity.EMAIL));

            if (!string.IsNullOrEmpty(theEntity.PASSWORDQUESTION))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PASSWORD_QUESTION", theEntity.PASSWORDQUESTION));

            if (!string.IsNullOrEmpty(theEntity.PASSWORDANSWER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PASSWORD_ANSWER", theEntity.PASSWORDANSWER));

            if (!string.IsNullOrEmpty(theEntity.ACCESSBLOCKED))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("ACCESS_BLOCKED", theEntity.ACCESSBLOCKED));

            if (!string.IsNullOrEmpty(theEntity.DEFAULTMODULEID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("DEFAULT_MODULEID", theEntity.DEFAULTMODULEID));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
        }
	
		protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            Login theEntity = (Login)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode","d"));

            if (!string.IsNullOrEmpty(theEntity.LOGINID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("LOGIN_ID", theEntity.LOGINID));

            if (!string.IsNullOrEmpty(theEntity.FULLDETAILS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("FULL_DETAILS", theEntity.FULLDETAILS));

            if (!string.IsNullOrEmpty(theEntity.EMPLOYEEID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("EMPLOYEE_ID", theEntity.EMPLOYEEID));

            if (!string.IsNullOrEmpty(theEntity.GROUPID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("GROUP_ID", theEntity.GROUPID));

            if (!string.IsNullOrEmpty(theEntity.LDOLOGIN))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("LDO_LOGIN", theEntity.LDOLOGIN));

            if (!string.IsNullOrEmpty(theEntity.PASSWORD))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PASS_WORD", theEntity.PASSWORD));

            if (!string.IsNullOrEmpty(theEntity.EMAIL))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("E_MAIL", theEntity.EMAIL));

            if (!string.IsNullOrEmpty(theEntity.PASSWORDQUESTION))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PASSWORD_QUESTION", theEntity.PASSWORDQUESTION));

            if (!string.IsNullOrEmpty(theEntity.PASSWORDANSWER))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PASSWORD_ANSWER", theEntity.PASSWORDANSWER));

            if (!string.IsNullOrEmpty(theEntity.ACCESSBLOCKED))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("ACCESS_BLOCKED", theEntity.ACCESSBLOCKED));

            if (!string.IsNullOrEmpty(theEntity.DEFAULTMODULEID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("DEFAULT_MODULEID", theEntity.DEFAULTMODULEID));
            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
	
			return cmdParams.ToArray();
		}
	
		#endregion
    }
}

	