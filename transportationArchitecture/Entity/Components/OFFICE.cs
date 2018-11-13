using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class OFFICE : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _oFFICECODE;
		private string _oFFICENAME;
		private string _wARDNO;
		private string _sTREET;
		private string _vDCMUNICIPALITY;
		private string _oFFICETYPEID;
		private string _wORKSASDEPOT;
		private string _rEGIONID;
		private string _cONTACT_PERSON;
		private string _pHONE_NO;
		private string _mOBILE_NO;
		private string _eMAIL;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string OFFICECODE
		{
			get { return _oFFICECODE; }
			set { _oFFICECODE = value; }
		}
	
		public string OFFICENAME
		{
			get { return _oFFICENAME; }
			set { _oFFICENAME = value; }
		}
	
		public string WARDNO
		{
			get { return _wARDNO; }
			set { _wARDNO = value; }
		}
	
		public string STREET
		{
			get { return _sTREET; }
			set { _sTREET = value; }
		}
	
		public string VDCMUNICIPALITY
		{
			get { return _vDCMUNICIPALITY; }
			set { _vDCMUNICIPALITY = value; }
		}
	
		public string OFFICETYPEID
		{
			get { return _oFFICETYPEID; }
			set { _oFFICETYPEID = value; }
		}
	
		public string WORKSASDEPOT
		{
			get { return _wORKSASDEPOT; }
			set { _wORKSASDEPOT = value; }
		}
	
		public string REGIONID
		{
			get { return _rEGIONID; }
			set { _rEGIONID = value; }
		}
	
		public string CONTACT_PERSON
		{
			get { return _cONTACT_PERSON; }
			set { _cONTACT_PERSON = value; }
		}
	
		public string PHONE_NO
		{
			get { return _pHONE_NO; }
			set { _pHONE_NO = value; }
		}
	
		public string MOBILE_NO
		{
			get { return _mOBILE_NO; }
			set { _mOBILE_NO = value; }
		}
	
		public string EMAIL
		{
			get { return _eMAIL; }
			set { _eMAIL = value; }
		}
		
		#region Methods

        public OFFICE()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	