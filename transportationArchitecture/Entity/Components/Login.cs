using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class Login : Entity.Framework.EntityBase
    {
		private string _lOGINID;
		private string _fULLDETAILS;
		private string _eMPLOYEEID;
		private string _gROUPID;
		private string _lDOLOGIN;
		private string _pASSWORD;
		private string _eMAIL;
		private string _pASSWORDQUESTION;
		private string _pASSWORDANSWER;
		private string _aCCESSBLOCKED;
		private string _dEFAULTMODULEID;
	
		public string LOGINID
		{
			get { return _lOGINID; }
			set { _lOGINID = value; }
		}
	
		public string FULLDETAILS
		{
			get { return _fULLDETAILS; }
			set { _fULLDETAILS = value; }
		}
	
		public string EMPLOYEEID
		{
			get { return _eMPLOYEEID; }
			set { _eMPLOYEEID = value; }
		}
	
		public string GROUPID
		{
			get { return _gROUPID; }
			set { _gROUPID = value; }
		}
	
		public string LDOLOGIN
		{
			get { return _lDOLOGIN; }
			set { _lDOLOGIN = value; }
		}
	
		public string PASSWORD
		{
			get { return _pASSWORD; }
			set { _pASSWORD = value; }
		}
	
		public string EMAIL
		{
			get { return _eMAIL; }
			set { _eMAIL = value; }
		}
	
		public string PASSWORDQUESTION
		{
			get { return _pASSWORDQUESTION; }
			set { _pASSWORDQUESTION = value; }
		}
	
		public string PASSWORDANSWER
		{
			get { return _pASSWORDANSWER; }
			set { _pASSWORDANSWER = value; }
		}
	
		public string ACCESSBLOCKED
		{
			get { return _aCCESSBLOCKED; }
			set { _aCCESSBLOCKED = value; }
		}
	
		public string DEFAULTMODULEID
		{
			get { return _dEFAULTMODULEID; }
			set { _dEFAULTMODULEID = value; }
		}
		
		#region Methods

        public Login()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	