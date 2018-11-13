using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class SUPPLIER : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _sUPPLIER_ID;
		private string _sUPPLIER_NAME;
		private string _aDDRESS;
		private string _dISTRICT;
		private string _oFFICE_PHONE;
		private string _oFFICE_EMAIL;
		private string _oFFICE_WEBSITE;
		private string _oFFICE_FAX;
		private string _vAT_PAN;
		private string _vAT_PAN_NUMBER;
		private string _cONTACT_PERSON;
		private string _cONTACT_NO;
		private string _rEMARKS;
		private string _sTATUS;
		private string _dONOR;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string SUPPLIER_ID
		{
			get { return _sUPPLIER_ID; }
			set { _sUPPLIER_ID = value; }
		}
	
		public string SUPPLIER_NAME
		{
			get { return _sUPPLIER_NAME; }
			set { _sUPPLIER_NAME = value; }
		}
	
		public string ADDRESS
		{
			get { return _aDDRESS; }
			set { _aDDRESS = value; }
		}
	
		public string DISTRICT
		{
			get { return _dISTRICT; }
			set { _dISTRICT = value; }
		}
	
		public string OFFICE_PHONE
		{
			get { return _oFFICE_PHONE; }
			set { _oFFICE_PHONE = value; }
		}
	
		public string OFFICE_EMAIL
		{
			get { return _oFFICE_EMAIL; }
			set { _oFFICE_EMAIL = value; }
		}
	
		public string OFFICE_WEBSITE
		{
			get { return _oFFICE_WEBSITE; }
			set { _oFFICE_WEBSITE = value; }
		}
	
		public string OFFICE_FAX
		{
			get { return _oFFICE_FAX; }
			set { _oFFICE_FAX = value; }
		}
	
		public string VAT_PAN
		{
			get { return _vAT_PAN; }
			set { _vAT_PAN = value; }
		}
	
		public string VAT_PAN_NUMBER
		{
			get { return _vAT_PAN_NUMBER; }
			set { _vAT_PAN_NUMBER = value; }
		}
	
		public string CONTACT_PERSON
		{
			get { return _cONTACT_PERSON; }
			set { _cONTACT_PERSON = value; }
		}
	
		public string CONTACT_NO
		{
			get { return _cONTACT_NO; }
			set { _cONTACT_NO = value; }
		}
	
		public string REMARKS
		{
			get { return _rEMARKS; }
			set { _rEMARKS = value; }
		}
	
		public string STATUS
		{
			get { return _sTATUS; }
			set { _sTATUS = value; }
		}
	
		public string DONOR
		{
			get { return _dONOR; }
			set { _dONOR = value; }
		}
		
		#region Methods

        public SUPPLIER()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	