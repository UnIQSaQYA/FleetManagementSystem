using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class INSURANCE_MASTER : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _iNSURANCE_COMPANY;
		private string _aDDRESS;
		private string _cONTACT_NUMBER;
		private string _wEB_SITE;
		private string _eMAIL;
		private string _cONTACT_PERSON;
		private string _cONTACT_PERSON_MOBILE;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string INSURANCE_COMPANY
		{
			get { return _iNSURANCE_COMPANY; }
			set { _iNSURANCE_COMPANY = value; }
		}
	
		public string ADDRESS
		{
			get { return _aDDRESS; }
			set { _aDDRESS = value; }
		}
	
		public string CONTACT_NUMBER
		{
			get { return _cONTACT_NUMBER; }
			set { _cONTACT_NUMBER = value; }
		}
	
		public string WEB_SITE
		{
			get { return _wEB_SITE; }
			set { _wEB_SITE = value; }
		}
	
		public string EMAIL
		{
			get { return _eMAIL; }
			set { _eMAIL = value; }
		}
	
		public string CONTACT_PERSON
		{
			get { return _cONTACT_PERSON; }
			set { _cONTACT_PERSON = value; }
		}
	
		public string CONTACT_PERSON_MOBILE
		{
			get { return _cONTACT_PERSON_MOBILE; }
			set { _cONTACT_PERSON_MOBILE = value; }
		}
		
		#region Methods

        public INSURANCE_MASTER()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	