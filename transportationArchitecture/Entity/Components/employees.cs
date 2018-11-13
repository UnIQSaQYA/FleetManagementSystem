using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class employees : Entity.Framework.EntityBase
    {
		private string _eMPLOYEE_ID;
		private string _fIRST_NAME;
		private string _lAST_NAME;
		private string _dESIGNATION_ID;
		private string _dEPARTMENT_ID;
		private string _office_code;
		private string _bIRTH_DATE;
		
		private string _eMAIL_EMP;
		private string _pHONE_EMP;
		private string _mOBILE_EMP;
	
        private string _mARITAL_STATUS;
     
        private string _gen_der;
     

       



        public string EMPLOYEE_ID
        {
            get { return _eMPLOYEE_ID; }
            set { _eMPLOYEE_ID = value; }
        }

        public string FIRST_NAME
        {
            get { return _fIRST_NAME; }
            set { _fIRST_NAME = value; }
        }

        public string LAST_NAME
        {
            get { return _lAST_NAME; }
            set { _lAST_NAME = value; }
        }

        public string DESIGNATION_ID
        {
            get { return _dESIGNATION_ID; }
            set { _dESIGNATION_ID = value; }
        }

        public string DEPARTMENT_ID
        {
            get { return _dEPARTMENT_ID; }
            set { _dEPARTMENT_ID = value; }
        }

        public string Office_code
        {
            get { return _office_code; }
            set { _office_code = value; }
        }

        public string BIRTH_DATE
        {
            get { return _bIRTH_DATE; }
            set { _bIRTH_DATE = value; }
        }

      

        public string EMAIL_EMP
        {
            get { return _eMAIL_EMP; }
            set { _eMAIL_EMP = value; }
        }

        public string PHONE_EMP
        {
            get { return _pHONE_EMP; }
            set { _pHONE_EMP = value; }
        }

        public string MOBILE_EMP
        {
            get { return _mOBILE_EMP; }
            set { _mOBILE_EMP = value; }
        }

       

       

      
        public string MARITAL_STATUS
        {
            get { return _mARITAL_STATUS; }
            set { _mARITAL_STATUS = value; }
        }
        

      

        public string Gen_der
        {
            get { return _gen_der; }
            set { _gen_der = value; }
        }

      

       

       
      

       
        #region Methods

        public employees()
            : base(string.Empty)
        {
        }
        #endregion
    }
}