using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class NAME_COMPANY : Entity.Framework.EntityBase
    {
		private string _nAME;
		private string _aDDRESS;
		private string _mOBILE_NO;
		private string _pHONE_NO1;
		private string _pHONE_NO2;
		private string _pHONE_NO3;
		private string _eMAIL;
		private string _wEBSITE;
		private string _fAX;
		private string _pAN_NO;
		private string _rEG_NO;
	
		public string NAME
		{
			get { return _nAME; }
			set { _nAME = value; }
		}
	
		public string ADDRESS
		{
			get { return _aDDRESS; }
			set { _aDDRESS = value; }
		}
	
		public string MOBILE_NO
		{
			get { return _mOBILE_NO; }
			set { _mOBILE_NO = value; }
		}
	
		public string PHONE_NO1
		{
			get { return _pHONE_NO1; }
			set { _pHONE_NO1 = value; }
		}
	
		public string PHONE_NO2
		{
			get { return _pHONE_NO2; }
			set { _pHONE_NO2 = value; }
		}
	
		public string PHONE_NO3
		{
			get { return _pHONE_NO3; }
			set { _pHONE_NO3 = value; }
		}
	
		public string EMAIL
		{
			get { return _eMAIL; }
			set { _eMAIL = value; }
		}
	
		public string WEBSITE
		{
			get { return _wEBSITE; }
			set { _wEBSITE = value; }
		}
	
		public string FAX
		{
			get { return _fAX; }
			set { _fAX = value; }
		}
	
		public string PAN_NO
		{
			get { return _pAN_NO; }
			set { _pAN_NO = value; }
		}
	
		public string REG_NO
		{
			get { return _rEG_NO; }
			set { _rEG_NO = value; }
		}
		
		#region Methods

        public NAME_COMPANY()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	