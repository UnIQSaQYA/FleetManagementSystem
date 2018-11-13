using System;
using System.Collections.Generic;
using System.Data;


using System.Text;

using DataAccess.Framework;
using DataHelper.Framework;
using Entity.Components;
using Entity.Framework;
using System.Collections;

namespace DataAccess.Components
{
    public class LogDAO : DataAccess.Framework.AbstractDAO
    {
        #region Constructor
        public LogDAO()
        {

        }
        #endregion

        #region Override Properties

        protected string ValidateCommand
        {
            get
            {
                return "PKJ_USERACCES.GetUserProfile";
            }
        }
        protected override string SelectCommand
        {
            get
            {
                return "";
            }
        }

        protected override string InsertCommand
        {
            get
            {
                return "";
            }
        }

        protected override string UpdateCommand
        {
            get
            {
                return "";
            }
        }

        protected override string DeleteCommand
        {
            get
            {
                return "";
            }
        }
        #endregion

        #region Overridden Methods

        protected override EntityBase CreateAndBuildEntity(DataHelper.Framework.SafeDataReader dr)
        {
            UserProfileEntity theEntity = new UserProfileEntity();

            theEntity.UserName= !dr.IsDBNull(0) ? dr.GetValue(0).ToString() : string.Empty;

            theEntity.FullDetails= !dr.IsDBNull(1) ? dr.GetValue(1).ToString() : string.Empty;

            theEntity.Password = !dr.IsDBNull(5) ? dr.GetValue(5).ToString() : string.Empty;

            theEntity.FiscalYear = !dr.IsDBNull(2) ? dr.GetValue(2).ToString() : string.Empty;

            theEntity.EmployeeName = !dr.IsDBNull(3) ? dr.GetValue(3).ToString() : string.Empty;

            theEntity.UserGroupID = !dr.IsDBNull(4) ? Int32.Parse(dr.GetValue(4).ToString()) : 0;
            theEntity.EmployeeID = !dr.IsDBNull(12) ? dr.GetValue(12).ToString() : string.Empty;
            if (!dr.IsDBNull(7))
            {
                if (Int32.Parse(dr.GetValue(7).ToString()) == 1)
                {
                    theEntity.Accessblocked = true;
                }
                else
                {
                    theEntity.Accessblocked = false;
                }
            }
            else
            {
                theEntity.Accessblocked = false;
            }

            return theEntity;
        }

        protected override IDbDataParameter[] CreateSelectParameters(EntityBase anEntity)
        {
            UserProfileEntity theEntity = (UserProfileEntity)anEntity;
            List<IDbDataParameter> cmdParams = new List<IDbDataParameter>();

            if (!string.IsNullOrEmpty(theEntity.UserName))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("id", theEntity.UserName));

            if (!string.IsNullOrEmpty(theEntity.Password))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("pwd", theEntity.Password));

            if (!string.IsNullOrEmpty(theEntity.FiscalYear))
                cmdParams.Add(DataAccessFactory.CreateDataParameter("fcl_yr", theEntity.FiscalYear));

            // This is the output parameter that is required for Oracle Connection. 
            // This is required only when the database is oracle as it will return cursor.

            cmdParams.Add(DataAccessFactory.CreateDataParameter("Result", ""));

            return cmdParams.ToArray();
        }

        protected override IDbDataParameter[] CreateInsertParameters(EntityBase anEntity)
        {
            return null;
        }

        protected override IDbDataParameter[] CreateUpdateParameters(EntityBase anEntity)
        {
            return null;
        }

        protected override IDbDataParameter[] CreateDeleteParameters(EntityBase anEntity)
        {
            return null;
        }

        #endregion
            

        private EntityBase GetUserId(UserProfileEntity userProfile)
        {
            IDbDataParameter[] param = CreateSelectParameters(userProfile);
            DataHelper.Framework.SafeDataReader reader = new DataHelper.Framework.SafeDataReader(DataAccessHelper.ExecuteReader(ValidateCommand, System.Data.CommandType.StoredProcedure, param));
            if (reader.Read())
            {
                return CreateAndBuildEntity(reader);
            }
            return userProfile;
        }


        public EntityBase GetValidUser(EntityBase anEntity)
        {
            IDbDataParameter[] cmdParams = this.CreateSelectParameters(anEntity);
            return GetSingle(this.ValidateCommand, this.CommandTypeUsed, cmdParams);
        }
    }
}

