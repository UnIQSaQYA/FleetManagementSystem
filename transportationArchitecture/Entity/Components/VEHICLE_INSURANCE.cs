using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICLE_INSURANCE : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _vEHICLE_ID;
		private string _iNSURANCE_COMPANY_ID;
		private string _iNSURANCE_TYPE;
		private string _pOLICY_NUMBER;
		private string _iNSURANCE_DAY;
		private string _iNSURANCE_MONTH;
		private string _iNSURANCE_YEAR;
		private string _iNSURANCE_DATE;
		private string _aMOUNT;
        private string _iNSURANCE_FROM;

        public string INSURANCE_FROM
        {
            get { return _iNSURANCE_FROM; }
            set { _iNSURANCE_FROM = value; }
        }
        private string _oFFICE_CODE;
        private string _iNSURANCE_TO;

        public string INSURANCE_TO
        {
            get { return _iNSURANCE_TO; }
            set { _iNSURANCE_TO = value; }
        }

        private string _iNSURANCE_TO_ENG;

        public string INSURANCE_TO_ENG
        {
            get { return _iNSURANCE_TO_ENG; }
            set { _iNSURANCE_TO_ENG = value; }
        }
        private string _iNSURANCE_FROM_ENG;

        public string INSURANCE_FROM_ENG
        {
            get { return _iNSURANCE_FROM_ENG; }
            set { _iNSURANCE_FROM_ENG = value; }
        }

        public string OFFICE_CODE
        {
            get { return _oFFICE_CODE; }
            set { _oFFICE_CODE = value; }
        }
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string VEHICLE_ID
		{
			get { return _vEHICLE_ID; }
			set { _vEHICLE_ID = value; }
		}
	
		public string INSURANCE_COMPANY_ID
		{
			get { return _iNSURANCE_COMPANY_ID; }
			set { _iNSURANCE_COMPANY_ID = value; }
		}
	
		public string INSURANCE_TYPE
		{
			get { return _iNSURANCE_TYPE; }
			set { _iNSURANCE_TYPE = value; }
		}
	
		public string POLICY_NUMBER
		{
			get { return _pOLICY_NUMBER; }
			set { _pOLICY_NUMBER = value; }
		}
	
		public string INSURANCE_DAY
		{
			get { return _iNSURANCE_DAY; }
			set { _iNSURANCE_DAY = value; }
		}
	
		public string INSURANCE_MONTH
		{
			get { return _iNSURANCE_MONTH; }
			set { _iNSURANCE_MONTH = value; }
		}
	
		public string INSURANCE_YEAR
		{
			get { return _iNSURANCE_YEAR; }
			set { _iNSURANCE_YEAR = value; }
		}
	
		public string INSURANCE_DATE
		{
			get { return _iNSURANCE_DATE; }
			set { _iNSURANCE_DATE = value; }
		}
	
		public string AMOUNT
		{
			get { return _aMOUNT; }
			set { _aMOUNT = value; }
		}
		
		#region Methods

        public VEHICLE_INSURANCE()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	