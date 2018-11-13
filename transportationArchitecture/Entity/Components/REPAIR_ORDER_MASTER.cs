using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class REPAIR_ORDER_MASTER : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _oFFICE_CODE;
		private string _rEPAIR_ORDER_NUMBER;
		private string _rEPAIR_ORDER_DAY;
		private string _rEPAIR_ORDER_MONTH;
		private string _rEPAIR_ORDER_YEAR;
		private string _rEPAIR_ORDER_DATE;
		private string _rEPAIR_ORDER_FY;
		private string _eXTERNAL_WORKSHOP_ID;
		private string _vEHICLE_REG_NO;
		private string _cHECK_BY_ID;
		private string _aCCOUNTANT_ID;
		private string _dEPARTMENTHEAD_ID;
	
		public string PK_ID
		{
			get { return _pK_ID; }
			set { _pK_ID = value; }
		}
	
		public string OFFICE_CODE
		{
			get { return _oFFICE_CODE; }
			set { _oFFICE_CODE = value; }
		}
	
		public string REPAIR_ORDER_NUMBER
		{
			get { return _rEPAIR_ORDER_NUMBER; }
			set { _rEPAIR_ORDER_NUMBER = value; }
		}
	
		public string REPAIR_ORDER_DAY
		{
			get { return _rEPAIR_ORDER_DAY; }
			set { _rEPAIR_ORDER_DAY = value; }
		}
	
		public string REPAIR_ORDER_MONTH
		{
			get { return _rEPAIR_ORDER_MONTH; }
			set { _rEPAIR_ORDER_MONTH = value; }
		}
	
		public string REPAIR_ORDER_YEAR
		{
			get { return _rEPAIR_ORDER_YEAR; }
			set { _rEPAIR_ORDER_YEAR = value; }
		}
	
		public string REPAIR_ORDER_DATE
		{
			get { return _rEPAIR_ORDER_DATE; }
			set { _rEPAIR_ORDER_DATE = value; }
		}
	
		public string REPAIR_ORDER_FY
		{
			get { return _rEPAIR_ORDER_FY; }
			set { _rEPAIR_ORDER_FY = value; }
		}
	
		public string EXTERNAL_WORKSHOP_ID
		{
			get { return _eXTERNAL_WORKSHOP_ID; }
			set { _eXTERNAL_WORKSHOP_ID = value; }
		}
	
		public string VEHICLE_REG_NO
		{
			get { return _vEHICLE_REG_NO; }
			set { _vEHICLE_REG_NO = value; }
		}
	
		public string CHECK_BY_ID
		{
			get { return _cHECK_BY_ID; }
			set { _cHECK_BY_ID = value; }
		}
	
		public string ACCOUNTANT_ID
		{
			get { return _aCCOUNTANT_ID; }
			set { _aCCOUNTANT_ID = value; }
		}
	
		public string DEPARTMENTHEAD_ID
		{
			get { return _dEPARTMENTHEAD_ID; }
			set { _dEPARTMENTHEAD_ID = value; }
		}
		
		#region Methods

        public REPAIR_ORDER_MASTER()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	