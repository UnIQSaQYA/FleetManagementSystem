using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class VEHICLE_DAKHILA : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _dAKHILA_NO;
		private string _pURCHASE_ORDER_ID;
		private string _dAKHILA_DAY;
		private string _dAKHILA_MONTH;
		private string _dAKHILA_YEAR;
		private string _dAKHILA_DATE;
		private string _dAKHILA_FISCALYEAR;
		private string _bILL_NO;
		private string _bILL_DAY;
		private string _bILL_MONTH;
		private string _bILL_YEAR;
		private string _sUPPLIER_ID;
		private string _vAT_PERCENT;
		private string _vAT;
		private string _tOTAL;
		private string _gRAND_TOTAL;
		private string _pREPARE_BY;
		private string _cHECK_BY;
		private string _aPPROVE_BY;
		private string _pREPARE_DATE;
		private string _cHECK_DATE;
		private string _aPPROVE_DATE;
        private string _oFFICE_CODE;

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
	
		public string DAKHILA_NO
		{
			get { return _dAKHILA_NO; }
			set { _dAKHILA_NO = value; }
		}
	
		public string PURCHASE_ORDER_ID
		{
			get { return _pURCHASE_ORDER_ID; }
			set { _pURCHASE_ORDER_ID = value; }
		}
	
		public string DAKHILA_DAY
		{
			get { return _dAKHILA_DAY; }
			set { _dAKHILA_DAY = value; }
		}
	
		public string DAKHILA_MONTH
		{
			get { return _dAKHILA_MONTH; }
			set { _dAKHILA_MONTH = value; }
		}
	
		public string DAKHILA_YEAR
		{
			get { return _dAKHILA_YEAR; }
			set { _dAKHILA_YEAR = value; }
		}
	
		public string DAKHILA_DATE
		{
			get { return _dAKHILA_DATE; }
			set { _dAKHILA_DATE = value; }
		}
	
		public string DAKHILA_FISCALYEAR
		{
			get { return _dAKHILA_FISCALYEAR; }
			set { _dAKHILA_FISCALYEAR = value; }
		}
	
		public string BILL_NO
		{
			get { return _bILL_NO; }
			set { _bILL_NO = value; }
		}
	
		public string BILL_DAY
		{
			get { return _bILL_DAY; }
			set { _bILL_DAY = value; }
		}
	
		public string BILL_MONTH
		{
			get { return _bILL_MONTH; }
			set { _bILL_MONTH = value; }
		}
	
		public string BILL_YEAR
		{
			get { return _bILL_YEAR; }
			set { _bILL_YEAR = value; }
		}
	
		public string SUPPLIER_ID
		{
			get { return _sUPPLIER_ID; }
			set { _sUPPLIER_ID = value; }
		}
	
		public string VAT_PERCENT
		{
			get { return _vAT_PERCENT; }
			set { _vAT_PERCENT = value; }
		}
	
		public string VAT
		{
			get { return _vAT; }
			set { _vAT = value; }
		}
	
		public string TOTAL
		{
			get { return _tOTAL; }
			set { _tOTAL = value; }
		}
	
		public string GRAND_TOTAL
		{
			get { return _gRAND_TOTAL; }
			set { _gRAND_TOTAL = value; }
		}
	
		public string PREPARE_BY
		{
			get { return _pREPARE_BY; }
			set { _pREPARE_BY = value; }
		}
	
		public string CHECK_BY
		{
			get { return _cHECK_BY; }
			set { _cHECK_BY = value; }
		}
	
		public string APPROVE_BY
		{
			get { return _aPPROVE_BY; }
			set { _aPPROVE_BY = value; }
		}
	
		public string PREPARE_DATE
		{
			get { return _pREPARE_DATE; }
			set { _pREPARE_DATE = value; }
		}
	
		public string CHECK_DATE
		{
			get { return _cHECK_DATE; }
			set { _cHECK_DATE = value; }
		}
	
		public string APPROVE_DATE
		{
			get { return _aPPROVE_DATE; }
			set { _aPPROVE_DATE = value; }
		}
		
		#region Methods

        public VEHICLE_DAKHILA()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	