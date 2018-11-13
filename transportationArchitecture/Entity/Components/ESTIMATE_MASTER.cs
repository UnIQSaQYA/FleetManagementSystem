using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class ESTIMATE_MASTER : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _eSTIMATE_NUMBER;
		private string _eSTIMATE_DAY;
		private string _eSTIMATE_MONTH;
		private string _eSTIMATE_YEAR;
		private string _eSTIMATE_DATE;
		private string _eSTIMATE_FY;
        private string _pARTY_NAME;
        private string _vEHICLE_REG_NO;
		private string _tOTAL_PARTS;
		private string _tOTAL_LABOUR;
		private string _vAT_PARTS;
		private string _vAT_LABOUR;
		private string _gRAND_TOTAL;
		private string _cUSTOMER_NAME;
		private string _aUTHORISED_PERSON;
        private string _vEHICLE_MODEL;

       
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string ESTIMATE_NUMBER
		{
			get { return _eSTIMATE_NUMBER; }
			set { _eSTIMATE_NUMBER = value; }
		}
	
		public string ESTIMATE_DAY
		{
			get { return _eSTIMATE_DAY; }
			set { _eSTIMATE_DAY = value; }
		}
	
		public string ESTIMATE_MONTH
		{
			get { return _eSTIMATE_MONTH; }
			set { _eSTIMATE_MONTH = value; }
		}
	
		public string ESTIMATE_YEAR
		{
			get { return _eSTIMATE_YEAR; }
			set { _eSTIMATE_YEAR = value; }
		}
	
		public string ESTIMATE_DATE
		{
			get { return _eSTIMATE_DATE; }
			set { _eSTIMATE_DATE = value; }
		}
	
		public string ESTIMATE_FY
		{
			get { return _eSTIMATE_FY; }
			set { _eSTIMATE_FY = value; }
		}

        public string PARTY_NAME
        {
            get { return _pARTY_NAME; }
            set { _pARTY_NAME = value; }
        }
        public string VEHICLE_REG_NO
        {
            get { return _vEHICLE_REG_NO; }
            set { _vEHICLE_REG_NO = value; }
        }
	
		public string TOTAL_PARTS
		{
			get { return _tOTAL_PARTS; }
			set { _tOTAL_PARTS = value; }
		}
	
		public string TOTAL_LABOUR
		{
			get { return _tOTAL_LABOUR; }
			set { _tOTAL_LABOUR = value; }
		}
	
		public string VAT_PARTS
		{
			get { return _vAT_PARTS; }
			set { _vAT_PARTS = value; }
		}
	
		public string VAT_LABOUR
		{
			get { return _vAT_LABOUR; }
			set { _vAT_LABOUR = value; }
		}
	
		public string GRAND_TOTAL
		{
			get { return _gRAND_TOTAL; }
			set { _gRAND_TOTAL = value; }
		}
	
		public string CUSTOMER_NAME
		{
			get { return _cUSTOMER_NAME; }
			set { _cUSTOMER_NAME = value; }
		}
	
		public string AUTHORISED_PERSON
		{
			get { return _aUTHORISED_PERSON; }
			set { _aUTHORISED_PERSON = value; }
		}

        public string VEHICLE_MODEL
        {
            get { return _vEHICLE_MODEL; }
            set { _vEHICLE_MODEL = value; }
        }
		
		#region Methods

        public ESTIMATE_MASTER()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	