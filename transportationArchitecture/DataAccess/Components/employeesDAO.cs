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
    public class employeesDAO : DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public employeesDAO()
        {

        }
        #endregion

        #region Override Properties
        protected override string SelectCommand
        {
            get
            {
                return "PKJ_SELECT.selectemployees";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "PKJ_MODIFY.modifyemployees";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "PKJ_MODIFY.modifyemployees";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "PKJ_MODIFY.modifyemployees";
            }
        }
        #endregion

        #region Overridden Methods

        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
            employees theEntity = new employees();

            theEntity.EMPLOYEE_ID = !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;
            theEntity.FIRST_NAME = !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;
            theEntity.LAST_NAME = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;
            theEntity.DESIGNATION_ID = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;
            theEntity.DEPARTMENT_ID = !dr.IsDBNull(4) ? dr.GetValue(4).ToString() : string.Empty;
            theEntity.Office_code = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;
            theEntity.BIRTH_DATE = !dr.IsDBNull(6) ? dr.GetValue(6).ToString() : string.Empty;

            theEntity.EMAIL_EMP = !dr.IsDBNull(7) ? dr.GetValue(7).ToString() : string.Empty;
            theEntity.PHONE_EMP = !dr.IsDBNull(8) ? dr.GetValue(8).ToString() : string.Empty;
            theEntity.MOBILE_EMP = !dr.IsDBNull(9) ? dr.GetValue(9).ToString() : string.Empty;

            theEntity.MARITAL_STATUS = !dr.IsDBNull(10) ? dr.GetValue(10).ToString() : string.Empty;

            theEntity.Gen_der = !dr.IsDBNull(11) ? dr.GetValue(11).ToString() : string.Empty;


            return theEntity;
        }

        protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            employees theEntity = (employees)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();

            if (!string.IsNullOrEmpty(theEntity.EMPLOYEE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("EMPLOYEE_ID", theEntity.EMPLOYEE_ID));

            if (!string.IsNullOrEmpty(theEntity.FIRST_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("FIRST_NAME", theEntity.FIRST_NAME));

            if (!string.IsNullOrEmpty(theEntity.LAST_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("LAST_NAME", theEntity.LAST_NAME));

            if (!string.IsNullOrEmpty(theEntity.DESIGNATION_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("DESIGNATION_ID", theEntity.DESIGNATION_ID));

            if (!string.IsNullOrEmpty(theEntity.DEPARTMENT_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("DEPARTMENT_ID", theEntity.DEPARTMENT_ID));

            if (!string.IsNullOrEmpty(theEntity.Office_code))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("Office_code", theEntity.Office_code));

            if (!string.IsNullOrEmpty(theEntity.BIRTH_DATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("BIRTH_DATE", theEntity.BIRTH_DATE));



            if (!string.IsNullOrEmpty(theEntity.EMAIL_EMP))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("EMAIL_EMP", theEntity.EMAIL_EMP));

            if (!string.IsNullOrEmpty(theEntity.PHONE_EMP))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PHONE_EMP", theEntity.PHONE_EMP));

            if (!string.IsNullOrEmpty(theEntity.MOBILE_EMP))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("MOBILE_EMP", theEntity.MOBILE_EMP));


            if (!string.IsNullOrEmpty(theEntity.MARITAL_STATUS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("MARITAL_STATUS", theEntity.MARITAL_STATUS));


            if (!string.IsNullOrEmpty(theEntity.Gen_der))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("gen_der", theEntity.Gen_der));




            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));

            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            employees theEntity = (employees)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", "i"));

            if (!string.IsNullOrEmpty(theEntity.EMPLOYEE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("EMPLOYEE_ID", theEntity.EMPLOYEE_ID));

            if (!string.IsNullOrEmpty(theEntity.FIRST_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("FIRST_NAME", theEntity.FIRST_NAME));

            if (!string.IsNullOrEmpty(theEntity.LAST_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("LAST_NAME", theEntity.LAST_NAME));

            if (!string.IsNullOrEmpty(theEntity.DESIGNATION_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("DESIGNATION_ID", theEntity.DESIGNATION_ID));

            if (!string.IsNullOrEmpty(theEntity.DEPARTMENT_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("DEPARTMENT_ID", theEntity.DEPARTMENT_ID));

            if (!string.IsNullOrEmpty(theEntity.Office_code))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("Office_code", theEntity.Office_code));

            if (!string.IsNullOrEmpty(theEntity.BIRTH_DATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("BIRTH_DATE", theEntity.BIRTH_DATE));



            if (!string.IsNullOrEmpty(theEntity.EMAIL_EMP))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("EMAIL_EMP", theEntity.EMAIL_EMP));

            if (!string.IsNullOrEmpty(theEntity.PHONE_EMP))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PHONE_EMP", theEntity.PHONE_EMP));

            if (!string.IsNullOrEmpty(theEntity.MOBILE_EMP))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("MOBILE_EMP", theEntity.MOBILE_EMP));


            if (!string.IsNullOrEmpty(theEntity.MARITAL_STATUS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("MARITAL_STATUS", theEntity.MARITAL_STATUS));


            if (!string.IsNullOrEmpty(theEntity.Gen_der))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("gen_der", theEntity.Gen_der));


            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            employees theEntity = (employees)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", "u"));

            if (!string.IsNullOrEmpty(theEntity.EMPLOYEE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("EMPLOYEE_ID", theEntity.EMPLOYEE_ID));

            if (!string.IsNullOrEmpty(theEntity.FIRST_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("FIRST_NAME", theEntity.FIRST_NAME));

            if (!string.IsNullOrEmpty(theEntity.LAST_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("LAST_NAME", theEntity.LAST_NAME));

            if (!string.IsNullOrEmpty(theEntity.DESIGNATION_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("DESIGNATION_ID", theEntity.DESIGNATION_ID));

            if (!string.IsNullOrEmpty(theEntity.DEPARTMENT_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("DEPARTMENT_ID", theEntity.DEPARTMENT_ID));

            if (!string.IsNullOrEmpty(theEntity.Office_code))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("Office_code", theEntity.Office_code));

            if (!string.IsNullOrEmpty(theEntity.BIRTH_DATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("BIRTH_DATE", theEntity.BIRTH_DATE));



            if (!string.IsNullOrEmpty(theEntity.EMAIL_EMP))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("EMAIL_EMP", theEntity.EMAIL_EMP));

            if (!string.IsNullOrEmpty(theEntity.PHONE_EMP))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PHONE_EMP", theEntity.PHONE_EMP));

            if (!string.IsNullOrEmpty(theEntity.MOBILE_EMP))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("MOBILE_EMP", theEntity.MOBILE_EMP));


            if (!string.IsNullOrEmpty(theEntity.MARITAL_STATUS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("MARITAL_STATUS", theEntity.MARITAL_STATUS));


            if (!string.IsNullOrEmpty(theEntity.Gen_der))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("gen_der", theEntity.Gen_der));


            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            employees theEntity = (employees)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();
            cmdParams.Add(DataAccessFactory.CreateDataParameter("transmode", "d"));

            if (!string.IsNullOrEmpty(theEntity.EMPLOYEE_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("EMPLOYEE_ID", theEntity.EMPLOYEE_ID));

            if (!string.IsNullOrEmpty(theEntity.FIRST_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("FIRST_NAME", theEntity.FIRST_NAME));

            if (!string.IsNullOrEmpty(theEntity.LAST_NAME))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("LAST_NAME", theEntity.LAST_NAME));

            if (!string.IsNullOrEmpty(theEntity.DESIGNATION_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("DESIGNATION_ID", theEntity.DESIGNATION_ID));

            if (!string.IsNullOrEmpty(theEntity.DEPARTMENT_ID))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("DEPARTMENT_ID", theEntity.DEPARTMENT_ID));

            if (!string.IsNullOrEmpty(theEntity.Office_code))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("Office_code", theEntity.Office_code));

            if (!string.IsNullOrEmpty(theEntity.BIRTH_DATE))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("BIRTH_DATE", theEntity.BIRTH_DATE));

            if (!string.IsNullOrEmpty(theEntity.EMAIL_EMP))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("EMAIL_EMP", theEntity.EMAIL_EMP));

            if (!string.IsNullOrEmpty(theEntity.PHONE_EMP))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("PHONE_EMP", theEntity.PHONE_EMP));

            if (!string.IsNullOrEmpty(theEntity.MOBILE_EMP))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("MOBILE_EMP", theEntity.MOBILE_EMP));


            if (!string.IsNullOrEmpty(theEntity.MARITAL_STATUS))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("MARITAL_STATUS", theEntity.MARITAL_STATUS));


            if (!string.IsNullOrEmpty(theEntity.Gen_der))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("gen_der", theEntity.Gen_der));


            cmdParams.Add(DataAccessFactory.CreateDataParameter("errmsg", ""));
            return cmdParams.ToArray();
        }

        #endregion
    }
}
