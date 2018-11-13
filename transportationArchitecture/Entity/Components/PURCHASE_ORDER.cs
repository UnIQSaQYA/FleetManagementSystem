using System;
using System.Collections.Generic;
using System.Text;
using Entity.Framework;

namespace Entity.Components
{
    public class PURCHASE_ORDER : Entity.Framework.EntityBase
    {
		private string _pK_ID;
		private string _pURCHASE_ORDER_NUMBER;
		private string _oRDER_DAY;
		private string _oRDER_MONTH;
		private string _oRDER_YEAR;
		private string _oRDER_DATE;
		private string _oRDER_FISCALYEAR;
		private string _sUPPLIER_ID;
		private string _dELIVERY_DATE;
		private string _dELIVERY_PLACE;
		private string _iSSUE_BY;
		private string _dEPARTMENT_HEAD;
		private string _gRAND_TOTAL;
		private string _sUPPLIER_REPRESENTATIVE;
		private string _sUPPLY_RECEIVE_DATE;
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
	
		public string PURCHASE_ORDER_NUMBER
		{
			get { return _pURCHASE_ORDER_NUMBER; }
			set { _pURCHASE_ORDER_NUMBER = value; }
		}
	
		public string ORDER_DAY
		{
			get { return _oRDER_DAY; }
			set { _oRDER_DAY = value; }
		}
	
		public string ORDER_MONTH
		{
			get { return _oRDER_MONTH; }
			set { _oRDER_MONTH = value; }
		}
	
		public string ORDER_YEAR
		{
			get { return _oRDER_YEAR; }
			set { _oRDER_YEAR = value; }
		}
	
		public string ORDER_DATE
		{
			get { return _oRDER_DATE; }
			set { _oRDER_DATE = value; }
		}
	
		public string ORDER_FISCALYEAR
		{
			get { return _oRDER_FISCALYEAR; }
			set { _oRDER_FISCALYEAR = value; }
		}
	
		public string SUPPLIER_ID
		{
			get { return _sUPPLIER_ID; }
			set { _sUPPLIER_ID = value; }
		}
	
		public string DELIVERY_DATE
		{
			get { return _dELIVERY_DATE; }
			set { _dELIVERY_DATE = value; }
		}
	
		public string DELIVERY_PLACE
		{
			get { return _dELIVERY_PLACE; }
			set { _dELIVERY_PLACE = value; }
		}
	
		public string ISSUE_BY
		{
			get { return _iSSUE_BY; }
			set { _iSSUE_BY = value; }
		}
	
		public string DEPARTMENT_HEAD
		{
			get { return _dEPARTMENT_HEAD; }
			set { _dEPARTMENT_HEAD = value; }
		}
	
		public string GRAND_TOTAL
		{
			get { return _gRAND_TOTAL; }
			set { _gRAND_TOTAL = value; }
		}
	
		public string SUPPLIER_REPRESENTATIVE
		{
			get { return _sUPPLIER_REPRESENTATIVE; }
			set { _sUPPLIER_REPRESENTATIVE = value; }
		}
	
		public string SUPPLY_RECEIVE_DATE
		{
			get { return _sUPPLY_RECEIVE_DATE; }
			set { _sUPPLY_RECEIVE_DATE = value; }
		}
		
		#region Methods

        public PURCHASE_ORDER()
            : base(string.Empty)
        {
        }
        #endregion
    }
}
	