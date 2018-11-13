using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class UserProfileEntity : EntityBase
    {
        #region Properties
        private string _userName;
        private string _password;
        private string _fiscalYear;
        private string _fullDetails;
        private string _employeeName;
        private string _employeeID;
        private int _userGroupID;
        private string _emailAddress;
        private Boolean _accessblocked;
        private Boolean _loginAccess;
        private string _locationID;
        private string _locationName;
        private int _locationTypeID;
        private string _locationTypeName;
        private DateTime _dateAD;
        private string _dateBS;
        private string _remarks;
        #endregion

        #region Methods

        public UserProfileEntity()
            : base(string.Empty)
        {
        }


        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string FiscalYear
        {
            get { return _fiscalYear; }
            set { _fiscalYear = value; }
        }


        public string FullDetails
        {
            get { return _fullDetails; }
            set { _fullDetails = value; }
        }
        public string EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }
        public int UserGroupID
        {
            get { return _userGroupID; }
            set { _userGroupID = value; }
        }
        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }
        public Boolean Accessblocked
        {
            get { return _accessblocked; }
            set { _accessblocked = value; }
        }
        public Boolean LoginAccess
        {
            get { return _loginAccess; }
            set { _loginAccess = value; }
        }
        public string LocationID
        {
            get { return _locationID; }
            set { _locationID = value; }
        }
        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }
        public int LocationTypeID
        {
            get { return _locationTypeID; }
            set { _locationTypeID = value; }
        }
        public string LocationTypeName
        {
            get { return _locationTypeName; }
            set { _locationTypeName = value; }
        }
        public DateTime DateAD
        {
            get { return _dateAD; }
            set { _dateAD = value; }
        }

        public string DateBS
        {
            get { return _dateBS; }
            set { _dateBS = value; }
        }

        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }
        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }


        #endregion

    }
}
